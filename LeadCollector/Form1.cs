﻿using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LeadCollector
{
    public partial class Form1 : Form
    {
        public static Lead lead = new Lead();

        //public static int currentPage = 0;
        //public static string[] questions = { "What is your first name?", "What is your last name?", "What is your organization's\nname?", "What is your organization\ntype?", "What is your title?", "What is your city?", "What is your state?", "What is your email?", "What is your phone number?", "What products do you use?", "Anything else you'd like to\ntell us?", "Thank you!" };
        public static string csvColumnNames = "First Name,Last Name,Organizaiton Name,Organization Type,Title,City,State,Email,Phone,Playaway,View,Bookpacks,Launchpad Apps,Launchpad Comics,Launchpad Video,Lock,More Info\r\n";
        public static string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static DirectoryInfo di = new DirectoryInfo(Path.Combine(myDocumentsPath, "Lead Collector Leads"));
        public static string csvPath;


        public Form1()
        {
            
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            if (!di.Exists)
            {
                di.Create();
            }
        }



        //private void readTextBox()
        //{
        //    string input = tbFirstName.Text.ToString();
        //    switch (currentPage)
        //    {
        //        case 0:
        //            lead.firstName = input;
        //            break;
        //        case 1:
        //            lead.lastName = input;
        //            break;
        //        case 2:
        //            lead.organizationName = input;
        //            break;
        //        case 3:
        //            lead.organizationType = input;
        //            break;
        //        case 4:
        //            lead.title = input;
        //            break;
        //        case 5:
        //            lead.city = input;
        //            break;
        //        case 6:
        //            lead.state = input;
        //            break;
        //        case 7:
        //            lead.email = input;
        //            break;
        //        case 8:
        //            lead.phone = input;
        //            break;
        //        case 10:
        //            lead.productsUsed = input;
        //            break;
        //        case 11:
        //            lead.moreInfo = input;
        //            break;

        //    }
        //}

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    nextQuestion();
        //}

        //private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        nextQuestion();
        //        e.Handled = true;
        //        e.SuppressKeyPress = true;
        //    }
        //}

        //private void nextQuestion()
        //{
        //    readTextBox();
        //    if (currentPage <= 10)
        //    {
        //        currentPage++;
        //        try { lblFirstName.Text = questions[currentPage].ToUpper(); }
        //        catch (Exception ex) { }
        //        updateTextBox();
        //        if (currentPage == 10)
        //        {
        //            btnNext.Text = "SUBMIT";
        //        }
        //    }
        //    if (currentPage > 10)
        //    {
        //        btnBack.Visible = false;
        //        btnNext.Visible = false;
        //        tbFirstName.Visible = false;
        //        WriteLeadToCSV(lead);
        //    }

        //}


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
            public string playaway;
            public string view;
            public string bookpacks;
            public string launchpadApps;
            public string launchpadComics;
            public string launchpadVideo;
            public string playawayLock;
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
                this.playaway = "";
                this.view = "";
                this.bookpacks = "";
                this.launchpadApps = "";
                this.launchpadComics = "";
                this.launchpadVideo = "";
                this.playawayLock = "";
                this.moreInfo = "";
            }
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    if (currentPage > 0)
        //    {
        //        currentPage--;
        //        lblFirstName.Text = questions[currentPage].ToUpper();
        //        updateTextBox();
        //    }
        //    if (currentPage <= 10)
        //    {
        //        btnBack.Visible = true;
        //        btnNext.Visible = true;
        //        tbFirstName.Visible = true;
        //    }

        //}

        //private void updateTextBox()
        //{
        //    switch (currentPage)
        //    {
        //        case 0:
        //            tbFirstName.Text = lead.firstName;
        //            break;
        //        case 1:
        //            tbFirstName.Text = lead.lastName;
        //            break;
        //        case 2:
        //            tbFirstName.Text = lead.organizationName;
        //            break;
        //        case 3:
        //            tbFirstName.Text = lead.organizationType;
        //            break;
        //        case 4:
        //            tbFirstName.Text = lead.title;
        //            break;
        //        case 5:
        //            tbFirstName.Text = lead.city;
        //            break;
        //        case 6:
        //            tbFirstName.Text = lead.state;
        //            break;
        //        case 7:
        //            tbFirstName.Text = lead.email;
        //            break;
        //        case 8:
        //            panelCheckBoxes.Visible = false;
        //            tbFirstName.Visible = true;
        //            tbFirstName.Text = lead.phone;
        //            break;
        //        case 9:
        //            tbFirstName.Visible = false;
        //            panelCheckBoxes.Visible = true;
        //            break;
        //        case 10:
        //            panelCheckBoxes.Visible = false;
        //            tbFirstName.Visible = true;
        //            tbFirstName.Text = lead.moreInfo;
        //            break;
        //    }
        //}

        private void GetCheckBoxValues()
        {
            List<string> productsUsed = new List<string>();
            if (cbPlayaway.Checked)
            {
                lead.playaway = "X";
            }
            if (cbView.Checked)
            {
                lead.view = "X";
            }
            if (cbBookpacks.Checked)
            {
                lead.bookpacks = "X";
            }
            if (cbLaunchpad.Checked)
            {
                lead.launchpadApps = "X";
            }
            if (cbComics.Checked)
            {
                lead.launchpadComics = "X";
            }
            if (cbVideo.Checked)
            {
                lead.launchpadVideo = "X";
            }
            if (cbLock.Checked)
            {
                lead.playawayLock = "X";
            }
        }

        private void WriteLeadToCSV(Lead lead)
        {
            FileInfo fi;

            string errors = "";
            bool pass;

            if (tbFirstName.Text != "")
            {
                tbFirstName.Text = ScrubCommas(tbFirstName.Text);
            }
            else
            {
                pass = false;
                errors = errors + "First Name";
            }
            if (tbLastName.Text != "")
            {
                tbLastName.Text = ScrubCommas(tbLastName.Text);
            }
            else
            {
                pass = false;
                errors = errors + "Last Name";
            }
                tbOrganizationName.Text = ScrubCommas(tbOrganizationName.Text);
                tbTitle.Text = ScrubCommas(tbTitle.Text);
                tbCity.Text = ScrubCommas(tbCity.Text);
                comboBoxState.Text = ScrubCommas(comboBoxState.Text);
                tbEmail.Text = ScrubCommas(tbEmail.Text);
                tbPhone.Text = ScrubCommas(tbPhone.Text);
                tbMoreInfo.Text = ScrubCommas(tbMoreInfo.Text);

            if (csvPath == null)
            {
                fi = new FileInfo(Path.Combine(di.FullName, "Lead Collector - " + DateTime.Now.ToString("yyyyMMdd") + ".csv"));
                csvPath = fi.FullName;
                if (!fi.Exists)
                {
                    File.WriteAllText(csvPath, csvColumnNames);
                }
            }
            GetCheckBoxValues();
            string csvString = tbFirstName.Text + "," + tbLastName.Text + "," + tbOrganizationName.Text + "," + cbOrganizationType.Text + "," + tbTitle.Text + "," + tbCity.Text + "," + comboBoxState.Text + "," + tbEmail.Text + "," + tbPhone.Text + "," + lead.playaway + "," + lead.view + "," + lead.bookpacks + "," + lead.launchpadApps + "," + lead.launchpadComics + "," + lead.launchpadVideo + "," + lead.playawayLock + "," + tbMoreInfo.Text + "\r\n";
            try
            {
                File.AppendAllText(csvPath, csvString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void ClearInputFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbOrganizationName.Text = "";
            cbOrganizationType.Text = "Select a type...";
            tbTitle.Text = "";
            tbCity.Text = "";
            comboBoxState.Text = "Select a state...";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbMoreInfo.Text = "";
            cbPlayaway.Checked = false;
            cbView.Checked = false;
            cbLock.Checked = false;
            cbLaunchpad.Checked = false;
            cbBookpacks.Checked = false;
            lead.playaway = "";
            lead.view = "";
            lead.bookpacks = "";
            lead.launchpadApps = "";
            lead.launchpadComics = "";
            lead.launchpadVideo = "";
            lead.playawayLock = "";

        }

        private void tbFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbOrganizationName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> requiedFields = new Dictionary<string, string>();
            requiedFields.Add("First Name", tbFirstName.Text);
            requiedFields.Add("Last Name", tbLastName.Text);
            requiedFields.Add("Organization Name", tbOrganizationName.Text);
            requiedFields.Add("Organization Type", cbOrganizationType.Text);
            requiedFields.Add("City", tbCity.Text);
            requiedFields.Add("State", comboBoxState.Text);
            requiedFields.Add("Email", tbEmail.Text);
            bool pass = true;
            string missingFields = "";
            foreach(KeyValuePair<string, string> field in requiedFields)
            {
                if (field.Value == "" || field.Value.ToLower() == "select a type..." || field.Value.ToLower() == "select a state...")
                {
                    missingFields = missingFields + field.Key + "\r\n";
                    pass = false;
                }
            }
            if (pass)
            {
                WriteLeadToCSV(lead);
                MessageBox.Show("Thank you!", "SUBMISSION COMPLETE");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please provide the following missing field(s):\r\n\r\n" + missingFields, "MISSING REQUIRED FIELDS");
            }
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select CSV to use...";
                ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    csvPath = ofd.FileName;
                }
                
            }
            if (e.Button == MouseButtons.Left)
            {
                if (this.TopMost != true || this.FormBorderStyle != FormBorderStyle.None || this.WindowState != FormWindowState.Maximized)
                {
                    this.TopMost = true;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.TopMost = false;
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private string ScrubCommas(string data)
        {
            if (data.Contains("\""))
            {
                data = data.Replace("\"", "\"\"");
            }

            if (data.Contains(","))
            {
                data = String.Format("\"{0}\"", data);
            }

            if (data.Contains(System.Environment.NewLine))
            {
                data = String.Format("\"{0}\"", data);
            }
            return data;
        }

        

        private void pictureBoxPlayaway_Click(object sender, EventArgs e)
        {
            if (cbPlayaway.Checked == false)
            {
                cbPlayaway.Checked = true;
            }
            else
            {
                cbPlayaway.Checked = false;
            }
        }

        private void pictureBoxLock_Click(object sender, EventArgs e)
        {
            if (cbLock.Checked == false)
            {
                cbLock.Checked = true;
            }
            else
            {
                cbLock.Checked = false;
            }
        }

        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            if (cbView.Checked == false)
            {
                cbView.Checked = true;
            }
            else
            {
                cbView.Checked = false;
            }
        }

        private void pictureBoxApps_Click(object sender, EventArgs e)
        {
            if (cbLaunchpad.Checked == false)
            {
                cbLaunchpad.Checked = true;
            }
            else
            {
                cbLaunchpad.Checked = false;
            }
        }

        private void pictureBoxComics_Click(object sender, EventArgs e)
        {
            if (cbComics.Checked == false)
            {
                cbComics.Checked = true;
            }
            else
            {
                cbComics.Checked = false;
            }
        }

        private void pictureBoxVideo_Click(object sender, EventArgs e)
        {
            if (cbVideo.Checked == false)
            {
                cbVideo.Checked = true;
            }
            else
            {
                cbVideo.Checked = false;
            }
        }

        private void pictureBoxBookpacks_Click(object sender, EventArgs e)
        {
            if (cbBookpacks.Checked == false)
            {
                cbBookpacks.Checked = true;
            }
            else
            {
                cbBookpacks.Checked = false;
            }
        }
    }
}
