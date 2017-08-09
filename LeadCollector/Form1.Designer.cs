namespace LeadCollector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPlayaway = new System.Windows.Forms.CheckBox();
            this.cbView = new System.Windows.Forms.CheckBox();
            this.cbBookpacks = new System.Windows.Forms.CheckBox();
            this.cbLock = new System.Windows.Forms.CheckBox();
            this.cbLaunchpad = new System.Windows.Forms.CheckBox();
            this.panelCheckBoxes = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelCheckBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(825, 313);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 61);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(234, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 61);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(360, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.MinimumSize = new System.Drawing.Size(1000, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 200);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelCheckBoxes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(129, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 387);
            this.panel1.TabIndex = 4;
            // 
            // cbPlayaway
            // 
            this.cbPlayaway.AutoSize = true;
            this.cbPlayaway.ForeColor = System.Drawing.SystemColors.Control;
            this.cbPlayaway.Location = new System.Drawing.Point(12, 9);
            this.cbPlayaway.Name = "cbPlayaway";
            this.cbPlayaway.Size = new System.Drawing.Size(89, 21);
            this.cbPlayaway.TabIndex = 4;
            this.cbPlayaway.Text = "Playaway";
            this.cbPlayaway.UseVisualStyleBackColor = true;
            // 
            // cbView
            // 
            this.cbView.AutoSize = true;
            this.cbView.ForeColor = System.Drawing.SystemColors.Control;
            this.cbView.Location = new System.Drawing.Point(12, 36);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(122, 21);
            this.cbView.TabIndex = 5;
            this.cbView.Text = "Playaway View";
            this.cbView.UseVisualStyleBackColor = true;
            // 
            // cbBookpacks
            // 
            this.cbBookpacks.AutoSize = true;
            this.cbBookpacks.ForeColor = System.Drawing.SystemColors.Control;
            this.cbBookpacks.Location = new System.Drawing.Point(12, 63);
            this.cbBookpacks.Name = "cbBookpacks";
            this.cbBookpacks.Size = new System.Drawing.Size(162, 21);
            this.cbBookpacks.TabIndex = 6;
            this.cbBookpacks.Text = "Playaway Bookpacks";
            this.cbBookpacks.UseVisualStyleBackColor = true;
            // 
            // cbLock
            // 
            this.cbLock.AutoSize = true;
            this.cbLock.ForeColor = System.Drawing.SystemColors.Control;
            this.cbLock.Location = new System.Drawing.Point(12, 90);
            this.cbLock.Name = "cbLock";
            this.cbLock.Size = new System.Drawing.Size(123, 21);
            this.cbLock.TabIndex = 7;
            this.cbLock.Text = "Playaway Lock";
            this.cbLock.UseVisualStyleBackColor = true;
            // 
            // cbLaunchpad
            // 
            this.cbLaunchpad.AutoSize = true;
            this.cbLaunchpad.ForeColor = System.Drawing.SystemColors.Control;
            this.cbLaunchpad.Location = new System.Drawing.Point(12, 117);
            this.cbLaunchpad.Name = "cbLaunchpad";
            this.cbLaunchpad.Size = new System.Drawing.Size(164, 21);
            this.cbLaunchpad.TabIndex = 8;
            this.cbLaunchpad.Text = "Playaway Launchpad";
            this.cbLaunchpad.UseVisualStyleBackColor = true;
            // 
            // panelCheckBoxes
            // 
            this.panelCheckBoxes.Controls.Add(this.cbPlayaway);
            this.panelCheckBoxes.Controls.Add(this.cbLaunchpad);
            this.panelCheckBoxes.Controls.Add(this.cbView);
            this.panelCheckBoxes.Controls.Add(this.cbLock);
            this.panelCheckBoxes.Controls.Add(this.cbBookpacks);
            this.panelCheckBoxes.Location = new System.Drawing.Point(500, 196);
            this.panelCheckBoxes.Name = "panelCheckBoxes";
            this.panelCheckBoxes.Size = new System.Drawing.Size(181, 152);
            this.panelCheckBoxes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LeadCollector.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1445, 686);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCheckBoxes.ResumeLayout(false);
            this.panelCheckBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCheckBoxes;
        private System.Windows.Forms.CheckBox cbPlayaway;
        private System.Windows.Forms.CheckBox cbLaunchpad;
        private System.Windows.Forms.CheckBox cbView;
        private System.Windows.Forms.CheckBox cbLock;
        private System.Windows.Forms.CheckBox cbBookpacks;
    }
}

