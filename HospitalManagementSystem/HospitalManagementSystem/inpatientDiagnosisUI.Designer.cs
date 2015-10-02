namespace HospitalManagementSystem
{
    partial class inpatientDiagnosisUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inpatientDiagnosisUI));
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headingTopLabel = new System.Windows.Forms.Label();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.submitPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.inpatientDiagnosisTestGroupBox = new System.Windows.Forms.GroupBox();
            this.addTestButton = new System.Windows.Forms.Button();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testWizardButton = new System.Windows.Forms.Button();
            this.testNameTextBox = new System.Windows.Forms.TextBox();
            this.testIdTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.testIdLabel = new System.Windows.Forms.Label();
            this.inpatientWizardButton = new System.Windows.Forms.Button();
            this.inpatientDiagnosisTestButton = new System.Windows.Forms.Button();
            this.inpatientMedicalInfoButton = new System.Windows.Forms.Button();
            this.inpatientPersonalInfoButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.submitPanel.SuspendLayout();
            this.inpatientDiagnosisTestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Controls.Add(this.headingTopLabel);
            this.topPanel.Controls.Add(this.headerPictureBox);
            this.topPanel.Location = new System.Drawing.Point(2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(972, 113);
            this.topPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(207, 64);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(633, 27);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Maintain inpatients records in database";
            // 
            // headingTopLabel
            // 
            this.headingTopLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingTopLabel.Location = new System.Drawing.Point(187, 17);
            this.headingTopLabel.Name = "headingTopLabel";
            this.headingTopLabel.Size = new System.Drawing.Size(638, 36);
            this.headingTopLabel.TabIndex = 1;
            this.headingTopLabel.Text = "Inpatient Maintainence Module";
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Image = global::HospitalManagementSystem.Properties.Resources.Screenshot_1;
            this.headerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(178, 107);
            this.headerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerPictureBox.TabIndex = 0;
            this.headerPictureBox.TabStop = false;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.containerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Controls.Add(this.submitPanel);
            this.containerPanel.Controls.Add(this.inpatientDiagnosisTestGroupBox);
            this.containerPanel.Controls.Add(this.inpatientWizardButton);
            this.containerPanel.Controls.Add(this.inpatientDiagnosisTestButton);
            this.containerPanel.Controls.Add(this.inpatientMedicalInfoButton);
            this.containerPanel.Controls.Add(this.inpatientPersonalInfoButton);
            this.containerPanel.Location = new System.Drawing.Point(2, 121);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(972, 542);
            this.containerPanel.TabIndex = 1;
            // 
            // submitPanel
            // 
            this.submitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submitPanel.Controls.Add(this.closeButton);
            this.submitPanel.Controls.Add(this.updateButton);
            this.submitPanel.Controls.Add(this.saveButton);
            this.submitPanel.Location = new System.Drawing.Point(184, 390);
            this.submitPanel.Name = "submitPanel";
            this.submitPanel.Size = new System.Drawing.Size(323, 98);
            this.submitPanel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.closeButton.Location = new System.Drawing.Point(215, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 74);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateButton.Location = new System.Drawing.Point(113, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 74);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(11, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 74);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // inpatientDiagnosisTestGroupBox
            // 
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.addTestButton);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.dateDateTimePicker);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.testWizardButton);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.testNameTextBox);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.testIdTextBox);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.dateLabel);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.testNameLabel);
            this.inpatientDiagnosisTestGroupBox.Controls.Add(this.testIdLabel);
            this.inpatientDiagnosisTestGroupBox.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.inpatientDiagnosisTestGroupBox.Location = new System.Drawing.Point(21, 61);
            this.inpatientDiagnosisTestGroupBox.Name = "inpatientDiagnosisTestGroupBox";
            this.inpatientDiagnosisTestGroupBox.Size = new System.Drawing.Size(804, 325);
            this.inpatientDiagnosisTestGroupBox.TabIndex = 4;
            this.inpatientDiagnosisTestGroupBox.TabStop = false;
            this.inpatientDiagnosisTestGroupBox.Text = "Diagnosis Test";
            // 
            // addTestButton
            // 
            this.addTestButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTestButton.Location = new System.Drawing.Point(738, 50);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(32, 22);
            this.addTestButton.TabIndex = 7;
            this.addTestButton.Text = "+";
            this.addTestButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTestButton.UseVisualStyleBackColor = true;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(599, 49);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // testWizardButton
            // 
            this.testWizardButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.testWizardButton.Location = new System.Drawing.Point(208, 46);
            this.testWizardButton.Name = "testWizardButton";
            this.testWizardButton.Size = new System.Drawing.Size(36, 25);
            this.testWizardButton.TabIndex = 5;
            this.testWizardButton.Text = ". . . . . . .";
            this.testWizardButton.UseVisualStyleBackColor = true;
            // 
            // testNameTextBox
            // 
            this.testNameTextBox.Location = new System.Drawing.Point(384, 46);
            this.testNameTextBox.Multiline = true;
            this.testNameTextBox.Name = "testNameTextBox";
            this.testNameTextBox.Size = new System.Drawing.Size(144, 25);
            this.testNameTextBox.TabIndex = 4;
            // 
            // testIdTextBox
            // 
            this.testIdTextBox.Location = new System.Drawing.Point(82, 47);
            this.testIdTextBox.Multiline = true;
            this.testIdTextBox.Name = "testIdTextBox";
            this.testIdTextBox.Size = new System.Drawing.Size(120, 25);
            this.testIdTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.dateLabel.Location = new System.Drawing.Point(549, 50);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 21);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.testNameLabel.Location = new System.Drawing.Point(274, 49);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(90, 21);
            this.testNameLabel.TabIndex = 1;
            this.testNameLabel.Text = "Test Name";
            // 
            // testIdLabel
            // 
            this.testIdLabel.AutoSize = true;
            this.testIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.testIdLabel.Location = new System.Drawing.Point(13, 50);
            this.testIdLabel.Name = "testIdLabel";
            this.testIdLabel.Size = new System.Drawing.Size(63, 21);
            this.testIdLabel.TabIndex = 0;
            this.testIdLabel.Text = "Test Id";
            // 
            // inpatientWizardButton
            // 
            this.inpatientWizardButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inpatientWizardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.inpatientWizardButton.Location = new System.Drawing.Point(512, 14);
            this.inpatientWizardButton.Name = "inpatientWizardButton";
            this.inpatientWizardButton.Size = new System.Drawing.Size(279, 23);
            this.inpatientWizardButton.TabIndex = 3;
            this.inpatientWizardButton.Text = "Launch Inpatient Search Wizard";
            this.inpatientWizardButton.UseVisualStyleBackColor = false;
            // 
            // inpatientDiagnosisTestButton
            // 
            this.inpatientDiagnosisTestButton.Enabled = false;
            this.inpatientDiagnosisTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientDiagnosisTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientDiagnosisTestButton.Location = new System.Drawing.Point(271, 14);
            this.inpatientDiagnosisTestButton.Name = "inpatientDiagnosisTestButton";
            this.inpatientDiagnosisTestButton.Size = new System.Drawing.Size(114, 24);
            this.inpatientDiagnosisTestButton.TabIndex = 2;
            this.inpatientDiagnosisTestButton.Text = "Diagnosis Test";
            this.inpatientDiagnosisTestButton.UseVisualStyleBackColor = true;
            // 
            // inpatientMedicalInfoButton
            // 
            this.inpatientMedicalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientMedicalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientMedicalInfoButton.Location = new System.Drawing.Point(143, 14);
            this.inpatientMedicalInfoButton.Name = "inpatientMedicalInfoButton";
            this.inpatientMedicalInfoButton.Size = new System.Drawing.Size(118, 24);
            this.inpatientMedicalInfoButton.TabIndex = 1;
            this.inpatientMedicalInfoButton.Text = "Medical Info";
            this.inpatientMedicalInfoButton.UseVisualStyleBackColor = true;
            this.inpatientMedicalInfoButton.Click += new System.EventHandler(this.inpatientMedicalInfoButton_Click);
            // 
            // inpatientPersonalInfoButton
            // 
            this.inpatientPersonalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientPersonalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientPersonalInfoButton.Location = new System.Drawing.Point(38, 14);
            this.inpatientPersonalInfoButton.Name = "inpatientPersonalInfoButton";
            this.inpatientPersonalInfoButton.Size = new System.Drawing.Size(99, 24);
            this.inpatientPersonalInfoButton.TabIndex = 0;
            this.inpatientPersonalInfoButton.Text = "Personal info";
            this.inpatientPersonalInfoButton.UseVisualStyleBackColor = true;
            this.inpatientPersonalInfoButton.Click += new System.EventHandler(this.inpatientPersonalInfoButton_Click);
            // 
            // inpatientDiagnosisUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1062, 666);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inpatientDiagnosisUI";
            this.ShowInTaskbar = false;
            this.Text = "inpatientDiagnosisUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.submitPanel.ResumeLayout(false);
            this.inpatientDiagnosisTestGroupBox.ResumeLayout(false);
            this.inpatientDiagnosisTestGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.PictureBox headerPictureBox;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label headingTopLabel;
        public System.Windows.Forms.Panel containerPanel;
        public System.Windows.Forms.Button inpatientDiagnosisTestButton;
        public System.Windows.Forms.Button inpatientMedicalInfoButton;
        public System.Windows.Forms.Button inpatientPersonalInfoButton;
        public System.Windows.Forms.Button inpatientWizardButton;
        public System.Windows.Forms.GroupBox inpatientDiagnosisTestGroupBox;
        public System.Windows.Forms.TextBox testNameTextBox;
        public System.Windows.Forms.TextBox testIdTextBox;
        public System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Label testNameLabel;
        public System.Windows.Forms.Label testIdLabel;
        public System.Windows.Forms.Button testWizardButton;
        public System.Windows.Forms.DateTimePicker dateDateTimePicker;
        public System.Windows.Forms.Button addTestButton;
        public System.Windows.Forms.Panel submitPanel;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.Button saveButton;

    }
}