namespace HospitalManagementSystem
{
    partial class inpatientMedicalInfoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inpatientMedicalInfoUI));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.submitLabel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.inpatientDiagnosisTestButton = new System.Windows.Forms.Button();
            this.inpatientMedicalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.wardNoTextBox = new System.Windows.Forms.TextBox();
            this.admissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomWizardButton = new System.Windows.Forms.Button();
            this.doctorIdSearchButton = new System.Windows.Forms.Button();
            this.departmentSearchButton = new System.Windows.Forms.Button();
            this.doctorsNameLabel = new System.Windows.Forms.Label();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentIdTextBox = new System.Windows.Forms.TextBox();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.wardNoLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.departmentIdLabel = new System.Windows.Forms.Label();
            this.assignedDoctorIdLabel = new System.Windows.Forms.Label();
            this.admissionDateLabel = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.inpatientWizardButton = new System.Windows.Forms.Button();
            this.inpatientMedicalInfoButton = new System.Windows.Forms.Button();
            this.inpatientPersonalInfoButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.submitLabel.SuspendLayout();
            this.inpatientMedicalInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.headerPictureBox);
            this.headerPanel.Location = new System.Drawing.Point(2, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(972, 113);
            this.headerPanel.TabIndex = 0;
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
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(187, 17);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(638, 36);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Inpatient Maintainence Module";
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.headerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headerPictureBox.Image")));
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
            this.containerPanel.Controls.Add(this.submitLabel);
            this.containerPanel.Controls.Add(this.inpatientDiagnosisTestButton);
            this.containerPanel.Controls.Add(this.inpatientMedicalInfoGroupBox);
            this.containerPanel.Controls.Add(this.inpatientWizardButton);
            this.containerPanel.Controls.Add(this.inpatientMedicalInfoButton);
            this.containerPanel.Controls.Add(this.inpatientPersonalInfoButton);
            this.containerPanel.Location = new System.Drawing.Point(2, 121);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(972, 514);
            this.containerPanel.TabIndex = 1;
            // 
            // submitLabel
            // 
            this.submitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submitLabel.Controls.Add(this.closeButton);
            this.submitLabel.Controls.Add(this.clearButton);
            this.submitLabel.Controls.Add(this.updateButton);
            this.submitLabel.Controls.Add(this.saveButton);
            this.submitLabel.Location = new System.Drawing.Point(184, 390);
            this.submitLabel.Name = "submitLabel";
            this.submitLabel.Size = new System.Drawing.Size(422, 98);
            this.submitLabel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(317, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 74);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(215, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 74);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(11, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 74);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // inpatientDiagnosisTestButton
            // 
            this.inpatientDiagnosisTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientDiagnosisTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientDiagnosisTestButton.Location = new System.Drawing.Point(271, 14);
            this.inpatientDiagnosisTestButton.Name = "inpatientDiagnosisTestButton";
            this.inpatientDiagnosisTestButton.Size = new System.Drawing.Size(114, 24);
            this.inpatientDiagnosisTestButton.TabIndex = 4;
            this.inpatientDiagnosisTestButton.Text = "Diagnosis Test";
            this.inpatientDiagnosisTestButton.UseVisualStyleBackColor = true;
            this.inpatientDiagnosisTestButton.Click += new System.EventHandler(this.inpatientDiagnosisTestButton_Click);
            // 
            // inpatientMedicalInfoGroupBox
            // 
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.wardNoTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.admissionDateTimePicker);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.roomWizardButton);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.doctorIdSearchButton);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.departmentSearchButton);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.doctorsNameLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.doctorNameTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.roomNoTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.departmentNameTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.departmentIdTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.doctorIdTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.wardNoLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.roomNoLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.patientIdTextBox);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.label10);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.departmentNameLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.departmentIdLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.assignedDoctorIdLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.admissionDateLabel);
            this.inpatientMedicalInfoGroupBox.Controls.Add(this.patientIdLabel);
            this.inpatientMedicalInfoGroupBox.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.inpatientMedicalInfoGroupBox.Location = new System.Drawing.Point(21, 61);
            this.inpatientMedicalInfoGroupBox.Name = "inpatientMedicalInfoGroupBox";
            this.inpatientMedicalInfoGroupBox.Size = new System.Drawing.Size(804, 317);
            this.inpatientMedicalInfoGroupBox.TabIndex = 3;
            this.inpatientMedicalInfoGroupBox.TabStop = false;
            this.inpatientMedicalInfoGroupBox.Text = "Medical Info";
            // 
            // wardNoTextBox
            // 
            this.wardNoTextBox.Location = new System.Drawing.Point(546, 234);
            this.wardNoTextBox.Multiline = true;
            this.wardNoTextBox.Name = "wardNoTextBox";
            this.wardNoTextBox.Size = new System.Drawing.Size(152, 25);
            this.wardNoTextBox.TabIndex = 29;
            // 
            // admissionDateTimePicker
            // 
            this.admissionDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.admissionDateTimePicker.Location = new System.Drawing.Point(189, 105);
            this.admissionDateTimePicker.Name = "admissionDateTimePicker";
            this.admissionDateTimePicker.Size = new System.Drawing.Size(163, 26);
            this.admissionDateTimePicker.TabIndex = 27;
            // 
            // roomWizardButton
            // 
            this.roomWizardButton.BackColor = System.Drawing.SystemColors.Window;
            this.roomWizardButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomWizardButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roomWizardButton.Location = new System.Drawing.Point(709, 176);
            this.roomWizardButton.Name = "roomWizardButton";
            this.roomWizardButton.Size = new System.Drawing.Size(36, 25);
            this.roomWizardButton.TabIndex = 26;
            this.roomWizardButton.Text = ". . . . . . . . . . .";
            this.roomWizardButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roomWizardButton.UseVisualStyleBackColor = false;
            this.roomWizardButton.Click += new System.EventHandler(this.roomWizardButton_Click);
            // 
            // doctorIdSearchButton
            // 
            this.doctorIdSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.doctorIdSearchButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.doctorIdSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doctorIdSearchButton.Location = new System.Drawing.Point(319, 172);
            this.doctorIdSearchButton.Name = "doctorIdSearchButton";
            this.doctorIdSearchButton.Size = new System.Drawing.Size(45, 29);
            this.doctorIdSearchButton.TabIndex = 25;
            this.doctorIdSearchButton.Text = ". . . . . . . . . . .";
            this.doctorIdSearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.doctorIdSearchButton.UseVisualStyleBackColor = false;
            this.doctorIdSearchButton.Click += new System.EventHandler(this.doctorIdSearchButton_Click);
            // 
            // departmentSearchButton
            // 
            this.departmentSearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.departmentSearchButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.departmentSearchButton.Location = new System.Drawing.Point(709, 58);
            this.departmentSearchButton.Name = "departmentSearchButton";
            this.departmentSearchButton.Size = new System.Drawing.Size(44, 25);
            this.departmentSearchButton.TabIndex = 24;
            this.departmentSearchButton.Text = ". . . . . . . . . . ";
            this.departmentSearchButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.departmentSearchButton.UseVisualStyleBackColor = false;
            this.departmentSearchButton.Click += new System.EventHandler(this.departmentSearchButton_Click);
            // 
            // doctorsNameLabel
            // 
            this.doctorsNameLabel.AutoSize = true;
            this.doctorsNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsNameLabel.Location = new System.Drawing.Point(25, 230);
            this.doctorsNameLabel.Name = "doctorsNameLabel";
            this.doctorsNameLabel.Size = new System.Drawing.Size(123, 21);
            this.doctorsNameLabel.TabIndex = 22;
            this.doctorsNameLabel.Text = "Doctor\'s Name";
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(191, 230);
            this.doctorNameTextBox.Multiline = true;
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(173, 37);
            this.doctorNameTextBox.TabIndex = 21;
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Location = new System.Drawing.Point(546, 176);
            this.roomNoTextBox.Multiline = true;
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(152, 25);
            this.roomNoTextBox.TabIndex = 18;
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(558, 106);
            this.departmentNameTextBox.Multiline = true;
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(195, 35);
            this.departmentNameTextBox.TabIndex = 17;
            // 
            // departmentIdTextBox
            // 
            this.departmentIdTextBox.Location = new System.Drawing.Point(558, 58);
            this.departmentIdTextBox.Multiline = true;
            this.departmentIdTextBox.Name = "departmentIdTextBox";
            this.departmentIdTextBox.Size = new System.Drawing.Size(140, 25);
            this.departmentIdTextBox.TabIndex = 16;
            // 
            // doctorIdTextBox
            // 
            this.doctorIdTextBox.Location = new System.Drawing.Point(191, 172);
            this.doctorIdTextBox.Multiline = true;
            this.doctorIdTextBox.Name = "doctorIdTextBox";
            this.doctorIdTextBox.Size = new System.Drawing.Size(120, 29);
            this.doctorIdTextBox.TabIndex = 14;
            // 
            // wardNoLabel
            // 
            this.wardNoLabel.AutoSize = true;
            this.wardNoLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.wardNoLabel.Location = new System.Drawing.Point(409, 234);
            this.wardNoLabel.Name = "wardNoLabel";
            this.wardNoLabel.Size = new System.Drawing.Size(78, 21);
            this.wardNoLabel.TabIndex = 10;
            this.wardNoLabel.Text = "Ward No";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.roomNoLabel.Location = new System.Drawing.Point(409, 176);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(85, 21);
            this.roomNoLabel.TabIndex = 9;
            this.roomNoLabel.Text = "Room No";
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Location = new System.Drawing.Point(190, 54);
            this.patientIdTextBox.Multiline = true;
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(162, 25);
            this.patientIdTextBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 7;
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentNameLabel.Location = new System.Drawing.Point(399, 110);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(144, 21);
            this.departmentNameLabel.TabIndex = 6;
            this.departmentNameLabel.Text = "Department Name";
            // 
            // departmentIdLabel
            // 
            this.departmentIdLabel.AutoSize = true;
            this.departmentIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentIdLabel.Location = new System.Drawing.Point(409, 58);
            this.departmentIdLabel.Name = "departmentIdLabel";
            this.departmentIdLabel.Size = new System.Drawing.Size(117, 21);
            this.departmentIdLabel.TabIndex = 5;
            this.departmentIdLabel.Text = "Department Id";
            // 
            // assignedDoctorIdLabel
            // 
            this.assignedDoctorIdLabel.AutoSize = true;
            this.assignedDoctorIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedDoctorIdLabel.Location = new System.Drawing.Point(13, 172);
            this.assignedDoctorIdLabel.Name = "assignedDoctorIdLabel";
            this.assignedDoctorIdLabel.Size = new System.Drawing.Size(158, 21);
            this.assignedDoctorIdLabel.TabIndex = 4;
            this.assignedDoctorIdLabel.Text = "Assigned Doctor Id";
            // 
            // admissionDateLabel
            // 
            this.admissionDateLabel.AutoSize = true;
            this.admissionDateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionDateLabel.Location = new System.Drawing.Point(43, 105);
            this.admissionDateLabel.Name = "admissionDateLabel";
            this.admissionDateLabel.Size = new System.Drawing.Size(129, 21);
            this.admissionDateLabel.TabIndex = 1;
            this.admissionDateLabel.Text = "Admission Date";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(43, 54);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(81, 21);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "Patient Id";
            // 
            // inpatientWizardButton
            // 
            this.inpatientWizardButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inpatientWizardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientWizardButton.Location = new System.Drawing.Point(512, 14);
            this.inpatientWizardButton.Name = "inpatientWizardButton";
            this.inpatientWizardButton.Size = new System.Drawing.Size(279, 23);
            this.inpatientWizardButton.TabIndex = 2;
            this.inpatientWizardButton.Text = "Launch Inpatient Search Wizard";
            this.inpatientWizardButton.UseVisualStyleBackColor = false;
            // 
            // inpatientMedicalInfoButton
            // 
            this.inpatientMedicalInfoButton.Enabled = false;
            this.inpatientMedicalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inpatientMedicalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpatientMedicalInfoButton.Location = new System.Drawing.Point(143, 14);
            this.inpatientMedicalInfoButton.Name = "inpatientMedicalInfoButton";
            this.inpatientMedicalInfoButton.Size = new System.Drawing.Size(118, 24);
            this.inpatientMedicalInfoButton.TabIndex = 1;
            this.inpatientMedicalInfoButton.Text = "Medical Info";
            this.inpatientMedicalInfoButton.UseVisualStyleBackColor = true;
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
            // inpatientMedicalInfoUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1062, 637);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inpatientMedicalInfoUI";
            this.Text = "Inpatient Medical Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.submitLabel.ResumeLayout(false);
            this.inpatientMedicalInfoGroupBox.ResumeLayout(false);
            this.inpatientMedicalInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox headerPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button inpatientWizardButton;
        private System.Windows.Forms.Button inpatientMedicalInfoButton;
        private System.Windows.Forms.Button inpatientPersonalInfoButton;
        private System.Windows.Forms.GroupBox inpatientMedicalInfoGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label departmentNameLabel;
        private System.Windows.Forms.Label departmentIdLabel;
        private System.Windows.Forms.Label assignedDoctorIdLabel;
        private System.Windows.Forms.Label admissionDateLabel;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.Label wardNoLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.TextBox doctorIdTextBox;
        private System.Windows.Forms.TextBox departmentIdTextBox;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.Button inpatientDiagnosisTestButton;
        private System.Windows.Forms.Label doctorsNameLabel;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.Panel submitLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button departmentSearchButton;
        private System.Windows.Forms.Button roomWizardButton;
        private System.Windows.Forms.Button doctorIdSearchButton;
        private System.Windows.Forms.DateTimePicker admissionDateTimePicker;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox wardNoTextBox;
    }
}