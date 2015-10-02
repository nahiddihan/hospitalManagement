namespace HospitalManagementSystem
{
    partial class outpatientPersonalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(outpatientPersonalInfo));
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.submitPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.delateButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.outpatientPersonalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.civilStatusLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.outpatientWizardButton = new System.Windows.Forms.Button();
            this.outpatientDiagnosisTestButton = new System.Windows.Forms.Button();
            this.outpatientSchedulingInfoButton = new System.Windows.Forms.Button();
            this.outpatientPersonalInfoButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.submitPanel.SuspendLayout();
            this.outpatientPersonalInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Controls.Add(this.headerLabel);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Location = new System.Drawing.Point(2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(972, 113);
            this.topPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.Location = new System.Drawing.Point(207, 64);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(633, 27);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Maintain outpatients records in database";
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Location = new System.Drawing.Point(187, 17);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(638, 36);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Outpatient Maintainence Module";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.Screenshot_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.containerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Controls.Add(this.submitPanel);
            this.containerPanel.Controls.Add(this.outpatientPersonalInfoGroupBox);
            this.containerPanel.Controls.Add(this.outpatientWizardButton);
            this.containerPanel.Controls.Add(this.outpatientDiagnosisTestButton);
            this.containerPanel.Controls.Add(this.outpatientSchedulingInfoButton);
            this.containerPanel.Controls.Add(this.outpatientPersonalInfoButton);
            this.containerPanel.Location = new System.Drawing.Point(2, 121);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(972, 508);
            this.containerPanel.TabIndex = 1;
            // 
            // submitPanel
            // 
            this.submitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submitPanel.Controls.Add(this.closeButton);
            this.submitPanel.Controls.Add(this.saveButton);
            this.submitPanel.Controls.Add(this.delateButton);
            this.submitPanel.Controls.Add(this.updateButton);
            this.submitPanel.Controls.Add(this.addNewButton);
            this.submitPanel.Location = new System.Drawing.Point(170, 392);
            this.submitPanel.Name = "submitPanel";
            this.submitPanel.Size = new System.Drawing.Size(533, 98);
            this.submitPanel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.closeButton.Location = new System.Drawing.Point(422, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 74);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(115, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 74);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // delateButton
            // 
            this.delateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delateButton.Location = new System.Drawing.Point(320, 13);
            this.delateButton.Name = "delateButton";
            this.delateButton.Size = new System.Drawing.Size(96, 74);
            this.delateButton.TabIndex = 2;
            this.delateButton.Text = "Delate";
            this.delateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delateButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateButton.Location = new System.Drawing.Point(218, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 74);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // addNewButton
            // 
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNewButton.Location = new System.Drawing.Point(13, 12);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(96, 74);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add New ";
            this.addNewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addNewButton.UseVisualStyleBackColor = true;
            // 
            // outpatientPersonalInfoGroupBox
            // 
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.comboBox2);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.comboBox1);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.textBox6);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.textBox5);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.textBox4);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.textBox3);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.textBox2);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.textBox1);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.addressLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.mobileLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.civilStatusLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.ageLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.genderLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.outpatientPersonalInfoGroupBox.Controls.Add(this.patientIdLabel);
            this.outpatientPersonalInfoGroupBox.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.outpatientPersonalInfoGroupBox.Location = new System.Drawing.Point(21, 61);
            this.outpatientPersonalInfoGroupBox.Name = "outpatientPersonalInfoGroupBox";
            this.outpatientPersonalInfoGroupBox.Size = new System.Drawing.Size(804, 325);
            this.outpatientPersonalInfoGroupBox.TabIndex = 4;
            this.outpatientPersonalInfoGroupBox.TabStop = false;
            this.outpatientPersonalInfoGroupBox.Text = "Personal Info";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.comboBox2.Location = new System.Drawing.Point(470, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 33);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(139, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(138, 154);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(186, 33);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(466, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 33);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 249);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 33);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(466, 159);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 97);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 33);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 33);
            this.textBox1.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.addressLabel.Location = new System.Drawing.Point(380, 159);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(73, 21);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.mobileLabel.Location = new System.Drawing.Point(380, 104);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(67, 21);
            this.mobileLabel.TabIndex = 6;
            this.mobileLabel.Text = "Mobile ";
            // 
            // civilStatusLabel
            // 
            this.civilStatusLabel.AutoSize = true;
            this.civilStatusLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.civilStatusLabel.Location = new System.Drawing.Point(368, 49);
            this.civilStatusLabel.Name = "civilStatusLabel";
            this.civilStatusLabel.Size = new System.Drawing.Size(95, 21);
            this.civilStatusLabel.TabIndex = 5;
            this.civilStatusLabel.Text = "Civil Status";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ageLabel.Location = new System.Drawing.Point(34, 256);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 21);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.genderLabel.Location = new System.Drawing.Point(34, 204);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(65, 21);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lastNameLabel.Location = new System.Drawing.Point(34, 154);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 21);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.firstNameLabel.Location = new System.Drawing.Point(34, 99);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 21);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.patientIdLabel.Location = new System.Drawing.Point(34, 49);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(81, 21);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "Patient Id";
            // 
            // outpatientWizardButton
            // 
            this.outpatientWizardButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outpatientWizardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outpatientWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outpatientWizardButton.Location = new System.Drawing.Point(512, 14);
            this.outpatientWizardButton.Name = "outpatientWizardButton";
            this.outpatientWizardButton.Size = new System.Drawing.Size(279, 23);
            this.outpatientWizardButton.TabIndex = 3;
            this.outpatientWizardButton.Text = "Launch Outpatient Search Wizard";
            this.outpatientWizardButton.UseVisualStyleBackColor = false;
            this.outpatientWizardButton.Click += new System.EventHandler(this.outpatientWizardButton_Click);
            // 
            // outpatientDiagnosisTestButton
            // 
            this.outpatientDiagnosisTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outpatientDiagnosisTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outpatientDiagnosisTestButton.Location = new System.Drawing.Point(275, 14);
            this.outpatientDiagnosisTestButton.Name = "outpatientDiagnosisTestButton";
            this.outpatientDiagnosisTestButton.Size = new System.Drawing.Size(114, 24);
            this.outpatientDiagnosisTestButton.TabIndex = 2;
            this.outpatientDiagnosisTestButton.Text = "Diagnosis Info ";
            this.outpatientDiagnosisTestButton.UseVisualStyleBackColor = true;
            this.outpatientDiagnosisTestButton.Click += new System.EventHandler(this.outpatientDiagnosisTestButton_Click);
            // 
            // outpatientSchedulingInfoButton
            // 
            this.outpatientSchedulingInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outpatientSchedulingInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outpatientSchedulingInfoButton.Location = new System.Drawing.Point(147, 14);
            this.outpatientSchedulingInfoButton.Name = "outpatientSchedulingInfoButton";
            this.outpatientSchedulingInfoButton.Size = new System.Drawing.Size(113, 24);
            this.outpatientSchedulingInfoButton.TabIndex = 1;
            this.outpatientSchedulingInfoButton.Text = "Scheduling Info";
            this.outpatientSchedulingInfoButton.UseVisualStyleBackColor = true;
            this.outpatientSchedulingInfoButton.Click += new System.EventHandler(this.outpatientSchedulingInfoButton_Click);
            // 
            // outpatientPersonalInfoButton
            // 
            this.outpatientPersonalInfoButton.Enabled = false;
            this.outpatientPersonalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outpatientPersonalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outpatientPersonalInfoButton.Location = new System.Drawing.Point(38, 14);
            this.outpatientPersonalInfoButton.Name = "outpatientPersonalInfoButton";
            this.outpatientPersonalInfoButton.Size = new System.Drawing.Size(99, 24);
            this.outpatientPersonalInfoButton.TabIndex = 0;
            this.outpatientPersonalInfoButton.Text = "Personal info";
            this.outpatientPersonalInfoButton.UseVisualStyleBackColor = true;
            // 
            // outpatientPersonalInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1062, 631);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "outpatientPersonalInfo";
            this.ShowInTaskbar = false;
            this.Text = "outpatientPersonalInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.submitPanel.ResumeLayout(false);
            this.outpatientPersonalInfoGroupBox.ResumeLayout(false);
            this.outpatientPersonalInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button outpatientDiagnosisTestButton;
        private System.Windows.Forms.Button outpatientSchedulingInfoButton;
        private System.Windows.Forms.Button outpatientPersonalInfoButton;
        private System.Windows.Forms.Button outpatientWizardButton;
        private System.Windows.Forms.GroupBox outpatientPersonalInfoGroupBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label civilStatusLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel submitPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button delateButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button closeButton;

    }
}