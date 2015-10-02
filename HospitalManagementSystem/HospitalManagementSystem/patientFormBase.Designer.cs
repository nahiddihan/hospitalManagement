namespace HospitalManagementSystem
{
    partial class inpatientPersonalInfoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inpatientPersonalInfoUI));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.inpatientPersonalInfoButton = new System.Windows.Forms.Button();
            this.inpatientMedicalInfoButton = new System.Windows.Forms.Button();
            this.inpatientWizardButton = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.inpatientDiagnosisTestButton = new System.Windows.Forms.Button();
            this.inpatientPersonalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.civilStatusComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.civilStatusLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.submitPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.inpatientPersonalInfoGroupBox.SuspendLayout();
            this.submitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Controls.Add(this.headerLabel);
            this.topPanel.Location = new System.Drawing.Point(2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(972, 113);
            this.topPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(207, 64);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(633, 27);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Maintain inpatients records in database";
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(187, 17);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(638, 36);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Inpatient Maintainence Module";
            // 
            // inpatientPersonalInfoButton
            // 
            this.inpatientPersonalInfoButton.Enabled = false;
            this.inpatientPersonalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientPersonalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientPersonalInfoButton.Location = new System.Drawing.Point(38, 14);
            this.inpatientPersonalInfoButton.Name = "inpatientPersonalInfoButton";
            this.inpatientPersonalInfoButton.Size = new System.Drawing.Size(99, 24);
            this.inpatientPersonalInfoButton.TabIndex = 2;
            this.inpatientPersonalInfoButton.Text = "Personal info";
            this.inpatientPersonalInfoButton.UseVisualStyleBackColor = true;
            // 
            // inpatientMedicalInfoButton
            // 
            this.inpatientMedicalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientMedicalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientMedicalInfoButton.Location = new System.Drawing.Point(147, 14);
            this.inpatientMedicalInfoButton.Name = "inpatientMedicalInfoButton";
            this.inpatientMedicalInfoButton.Size = new System.Drawing.Size(99, 24);
            this.inpatientMedicalInfoButton.TabIndex = 3;
            this.inpatientMedicalInfoButton.Text = "Medical Info";
            this.inpatientMedicalInfoButton.UseVisualStyleBackColor = true;
            this.inpatientMedicalInfoButton.Click += new System.EventHandler(this.inpatientMedicalInfoButton_Click);
            // 
            // inpatientWizardButton
            // 
            this.inpatientWizardButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inpatientWizardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientWizardButton.Location = new System.Drawing.Point(512, 14);
            this.inpatientWizardButton.Name = "inpatientWizardButton";
            this.inpatientWizardButton.Size = new System.Drawing.Size(279, 23);
            this.inpatientWizardButton.TabIndex = 4;
            this.inpatientWizardButton.Text = "Launch Inpatient Search Wizard";
            this.inpatientWizardButton.UseVisualStyleBackColor = false;
            this.inpatientWizardButton.Click += new System.EventHandler(this.inpatientWizardButton_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.containerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Controls.Add(this.inpatientDiagnosisTestButton);
            this.containerPanel.Controls.Add(this.inpatientPersonalInfoGroupBox);
            this.containerPanel.Controls.Add(this.submitPanel);
            this.containerPanel.Controls.Add(this.inpatientWizardButton);
            this.containerPanel.Controls.Add(this.inpatientMedicalInfoButton);
            this.containerPanel.Controls.Add(this.inpatientPersonalInfoButton);
            this.containerPanel.Location = new System.Drawing.Point(2, 121);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(972, 496);
            this.containerPanel.TabIndex = 1;
            // 
            // inpatientDiagnosisTestButton
            // 
            this.inpatientDiagnosisTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientDiagnosisTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientDiagnosisTestButton.Location = new System.Drawing.Point(255, 14);
            this.inpatientDiagnosisTestButton.Name = "inpatientDiagnosisTestButton";
            this.inpatientDiagnosisTestButton.Size = new System.Drawing.Size(114, 24);
            this.inpatientDiagnosisTestButton.TabIndex = 8;
            this.inpatientDiagnosisTestButton.Text = "Diagnosis Test";
            this.inpatientDiagnosisTestButton.UseVisualStyleBackColor = true;
            this.inpatientDiagnosisTestButton.Click += new System.EventHandler(this.inpatientDiagnosisTestButton_Click);
            // 
            // inpatientPersonalInfoGroupBox
            // 
            this.inpatientPersonalInfoGroupBox.AutoSize = true;
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.civilStatusComboBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.genderComboBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.mobileTextBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.addressTextBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.ageTextBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.patientIdTextBox);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.addressLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.mobileLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.civilStatusLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.ageLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.genderLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.inpatientPersonalInfoGroupBox.Controls.Add(this.patientIdLabel);
            this.inpatientPersonalInfoGroupBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientPersonalInfoGroupBox.Location = new System.Drawing.Point(21, 61);
            this.inpatientPersonalInfoGroupBox.Name = "inpatientPersonalInfoGroupBox";
            this.inpatientPersonalInfoGroupBox.Size = new System.Drawing.Size(804, 325);
            this.inpatientPersonalInfoGroupBox.TabIndex = 7;
            this.inpatientPersonalInfoGroupBox.TabStop = false;
            this.inpatientPersonalInfoGroupBox.Text = "Personal Info";
            // 
            // civilStatusComboBox
            // 
            this.civilStatusComboBox.FormattingEnabled = true;
            this.civilStatusComboBox.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.civilStatusComboBox.Location = new System.Drawing.Point(466, 49);
            this.civilStatusComboBox.Name = "civilStatusComboBox";
            this.civilStatusComboBox.Size = new System.Drawing.Size(169, 33);
            this.civilStatusComboBox.TabIndex = 15;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(139, 200);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(142, 33);
            this.genderComboBox.TabIndex = 14;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(466, 99);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(186, 33);
            this.mobileTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(466, 159);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(216, 97);
            this.addressTextBox.TabIndex = 12;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(139, 249);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 33);
            this.ageTextBox.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(138, 154);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(186, 33);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(138, 100);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(186, 33);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Location = new System.Drawing.Point(138, 49);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(186, 33);
            this.patientIdTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(380, 159);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(65, 26);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // mobileLabel
            // 
            this.mobileLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.Location = new System.Drawing.Point(380, 104);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(70, 28);
            this.mobileLabel.TabIndex = 6;
            this.mobileLabel.Text = "Mobile ";
            // 
            // civilStatusLabel
            // 
            this.civilStatusLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civilStatusLabel.Location = new System.Drawing.Point(368, 49);
            this.civilStatusLabel.Name = "civilStatusLabel";
            this.civilStatusLabel.Size = new System.Drawing.Size(105, 25);
            this.civilStatusLabel.TabIndex = 5;
            this.civilStatusLabel.Text = "Civil Status";
            // 
            // ageLabel
            // 
            this.ageLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(34, 256);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(59, 26);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(34, 204);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(59, 23);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(34, 154);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 26);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(34, 99);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(104, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(34, 49);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(98, 25);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "Patient Id";
            // 
            // submitPanel
            // 
            this.submitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submitPanel.Controls.Add(this.closeButton);
            this.submitPanel.Controls.Add(this.deleteButton);
            this.submitPanel.Controls.Add(this.updateButton);
            this.submitPanel.Controls.Add(this.saveButton);
            this.submitPanel.Controls.Add(this.addNewButton);
            this.submitPanel.Location = new System.Drawing.Point(184, 390);
            this.submitPanel.Margin = new System.Windows.Forms.Padding(0);
            this.submitPanel.Name = "submitPanel";
            this.submitPanel.Size = new System.Drawing.Size(519, 98);
            this.submitPanel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(416, 14);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 74);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(314, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 74);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(212, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 74);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(110, 14);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 74);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewButton.BackgroundImage")));
            this.addNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(8, 13);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(96, 74);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            // 
            // inpatientPersonalInfoUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1062, 619);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inpatientPersonalInfoUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "inpatientPersonalInfoUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.inpatientPersonalInfoGroupBox.ResumeLayout(false);
            this.inpatientPersonalInfoGroupBox.PerformLayout();
            this.submitPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.Button inpatientPersonalInfoButton;
        public System.Windows.Forms.Button inpatientMedicalInfoButton;
        public System.Windows.Forms.Button inpatientWizardButton;
        public System.Windows.Forms.Panel containerPanel;
        public System.Windows.Forms.Panel submitPanel;
        public System.Windows.Forms.GroupBox inpatientPersonalInfoGroupBox;
        public System.Windows.Forms.ComboBox genderComboBox;
        public System.Windows.Forms.TextBox mobileTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox ageTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox patientIdTextBox;
        public System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.Label mobileLabel;
        public System.Windows.Forms.Label civilStatusLabel;
        public System.Windows.Forms.Label ageLabel;
        public System.Windows.Forms.Label genderLabel;
        public System.Windows.Forms.Label lastNameLabel;
        public System.Windows.Forms.Label firstNameLabel;
        public System.Windows.Forms.Label patientIdLabel;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Button addNewButton;
        public System.Windows.Forms.ComboBox civilStatusComboBox;
        private System.Windows.Forms.Button inpatientDiagnosisTestButton;
        public System.Windows.Forms.Button closeButton;


    }
}