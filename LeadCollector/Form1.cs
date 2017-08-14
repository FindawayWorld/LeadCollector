using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//•	First Name:
//•	Last Name:
//•	Organization Name:
//•	Organization Type:  check boxes: Library, School, Military, Government, Medical, Other
//•	Title:
//•	City:
//•	State:
//•	Email:
//•	Phone:
//•	Products Used: Check boxes: Playaway, Playaway View, Playaway Bookpacks, Playaway Launchpad, Playaway Lock
//•	More Information:


namespace LeadCollector
{
    public partial class Form1 : Form
    {
        public static Lead lead = new Lead();

        public static int currentPage = 0;
        public static string[] questions = { "What is your first name?", "What is your last name?", "What is your organization's\nname?", "What is your organization\ntype?", "What is your title?", "What is your city?", "What is your state?", "What is your email?", "What is your phone number?", "What products do you use?", "Anything else you'd like to\ntell us?", "Thank you!" };

        public Form1()
        {
            InitializeComponent();
            label1.Text = questions[currentPage].ToUpper();
            panelCheckBoxes.Visible = false;
        }

        private void readTextBox()
        {
            string input = textBox1.Text.ToString();
            switch (currentPage)
            {
                case 0:
                    lead.firstName = input;
                    break;
                case 1:
                    lead.lastName = input;
                    break;
                case 2:
                    lead.organizationName = input;
                    break;
                case 3:
                    lead.organizationType = input;
                    break;
                case 4:
                    lead.title = input;
                    break;
                case 5:
                    lead.city = input;
                    break;
                case 6:
                    lead.state = input;
                    break;
                case 7:
                    lead.email = input;
                    break;
                case 8:
                    lead.phone = input;
                    break;
                case 10:
                    lead.productsUsed = input;
                    break;
                case 11:
                    lead.moreInfo = input;
                    break;

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextQuestion();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextQuestion();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void nextQuestion()
        {
            readTextBox();
            if (currentPage <= 10)
            {
                currentPage++;
                try { label1.Text = questions[currentPage].ToUpper(); }
                catch (Exception ex) { }
                updateTextBox();
                if (currentPage == 10)
                {
                    btnNext.Text = "SUBMIT";
                }
            }
            if (currentPage > 10)
            {
                btnBack.Visible = false;
                btnNext.Visible = false;
                textBox1.Visible = false;
                WriteLeadToCSV(lead);
            }
            
        }


        public class Lead 
        {
            public string firstName;
            public string lastName;
            public string organizationName;
            public string organizationType;
            public string title;
            public string city;
            public string state;
            public string email;
            public string phone;
            public string productsUsed;
            public string moreInfo;

            public Lead()
            {
                this.firstName = "";
                this.lastName = "";
                this.organizationName = "";
                this.organizationType = "";
                this.title = "";
                this.city = "";
                this.state = "";
                this.email = "";
                this.phone = "";
                this.productsUsed = "";
                this.moreInfo = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                label1.Text = questions[currentPage].ToUpper();
                updateTextBox();
            }
            if (currentPage <= 10)
            {
                btnBack.Visible = true;
                btnNext.Visible = true;
                textBox1.Visible = true;
            }

        }

        private void updateTextBox()
        {
            switch (currentPage)
            {
                case 0:
                    textBox1.Text = lead.firstName;
                    break;
                case 1:
                    textBox1.Text = lead.lastName;
                    break;
                case 2:
                    textBox1.Text = lead.organizationName;
                    break;
                case 3:
                    textBox1.Text = lead.organizationType;
                    break;
                case 4:
                    textBox1.Text = lead.title;
                    break;
                case 5:
                    textBox1.Text = lead.city;
                    break;
                case 6:
                    textBox1.Text = lead.state;
                    break;
                case 7:
                    textBox1.Text = lead.email;
                    break;
                case 8:
                    panelCheckBoxes.Visible = false;
                    textBox1.Visible = true;
                    textBox1.Text = lead.phone;
                    break;
                case 9:
                    textBox1.Visible = false;
                    panelCheckBoxes.Visible = true;
                    break;
                case 10:
                    panelCheckBoxes.Visible = false;
                    textBox1.Visible = true;
                    textBox1.Text = lead.moreInfo;
                    break;
            }
        }

        private void GetCheckBoxValues()
        {
            List<string> productsUsed = new List<string>();
            if (cbPlayaway.Checked)
            {
                productsUsed.Add("Playaway");
            }
            if (cbView.Checked)
            {
                productsUsed.Add("View");
            }
            if (cbBookpacks.Checked)
            {
                productsUsed.Add("Bookpacks");
            }
            if (cbLaunchpad.Checked)
            {
                productsUsed.Add("Launchpad");
            }
            if (cbLock.Checked)
            {
                productsUsed.Add("Lock");
            }
            string csvString = "";
            int length = productsUsed.Count();
            int counter = 1;
            foreach (string product in productsUsed)
            {
                csvString = csvString + product;
                if (counter > length)
                {
                    csvString = csvString + " & ";
                }
            }
            lead.productsUsed = csvString;
        }

        private void WriteLeadToCSV(Lead lead)
        {
            GetCheckBoxValues();
            lead.moreInfo = lead.moreInfo.Replace(",", " [comma] ");
            string csvString = lead.firstName + "," + lead.lastName + "," + lead.organizationName + "," + lead.organizationType + "," + lead.title + "," + lead.city + "," + lead.state + "," + lead.email + "," + lead.phone + "," + lead.productsUsed + "," + lead.moreInfo + ",";
            
        }
    }

    
}
