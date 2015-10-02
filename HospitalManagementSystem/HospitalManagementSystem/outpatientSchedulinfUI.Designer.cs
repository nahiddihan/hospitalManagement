namespace HospitalManagementSystem
{
    partial class outpatientSchedulingUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(outpatientSchedulingUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.submitPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.outpatientSchedulingGroupBox = new System.Windows.Forms.GroupBox();
            this.meetingTimeTextBox = new System.Windows.Forms.TextBox();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.addScheduleButton = new System.Windows.Forms.Button();
            this.meetingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doctorWizardButton = new System.Windows.Forms.Button();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.MeetingDateLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.doctorIdLabel = new System.Windows.Forms.Label();
            this.outpatientWizardButton = new System.Windows.Forms.Button();
            this.outpatientDiagnosisTestButton = new System.Windows.Forms.Button();
            this.outpatientSchedulingInfoButton = new System.Windows.Forms.Button();
            this.outpatientPersonalInfoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.submitPanel.SuspendLayout();
            this.outpatientSchedulingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 113);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(972, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.containerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.containerPanel.Controls.Add(this.submitPanel);
            this.containerPanel.Controls.Add(this.outpatientSchedulingGroupBox);
            this.containerPanel.Controls.Add(this.outpatientWizardButton);
            this.containerPanel.Controls.Add(this.outpatientDiagnosisTestButton);
            this.containerPanel.Controls.Add(this.outpatientSchedulingInfoButton);
            this.containerPanel.Controls.Add(this.outpatientPersonalInfoButton);
            this.containerPanel.Location = new System.Drawing.Point(2, 121);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(972, 508);
            this.containerPanel.TabIndex = 2;
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
            this.submitPanel.TabIndex = 6;
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
            // outpatientSchedulingGroupBox
            // 
            this.outpatientSchedulingGroupBox.Controls.Add(this.meetingTimeTextBox);
            this.outpatientSchedulingGroupBox.Controls.Add(this.meetingTimeLabel);
            this.outpatientSchedulingGroupBox.Controls.Add(this.addScheduleButton);
            this.outpatientSchedulingGroupBox.Controls.Add(this.meetingDateTimePicker);
            this.outpatientSchedulingGroupBox.Controls.Add(this.doctorWizardButton);
            this.outpatientSchedulingGroupBox.Controls.Add(this.doctorNameTextBox);
            this.outpatientSchedulingGroupBox.Controls.Add(this.doctorIdTextBox);
            this.outpatientSchedulingGroupBox.Controls.Add(this.MeetingDateLabel);
            this.outpatientSchedulingGroupBox.Controls.Add(this.doctorNameLabel);
            this.outpatientSchedulingGroupBox.Controls.Add(this.doctorIdLabel);
            this.outpatientSchedulingGroupBox.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.outpatientSchedulingGroupBox.Location = new System.Drawing.Point(21, 61);
            this.outpatientSchedulingGroupBox.Name = "outpatientSchedulingGroupBox";
            this.outpatientSchedulingGroupBox.Size = new System.Drawing.Size(804, 325);
            this.outpatientSchedulingGroupBox.TabIndex = 4;
            this.outpatientSchedulingGroupBox.TabStop = false;
            this.outpatientSchedulingGroupBox.Text = "Scheduling Info";
            // 
            // meetingTimeTextBox
            // 
            this.meetingTimeTextBox.Location = new System.Drawing.Point(544, 90);
            this.meetingTimeTextBox.Multiline = true;
            this.meetingTimeTextBox.Name = "meetingTimeTextBox";
            this.meetingTimeTextBox.Size = new System.Drawing.Size(144, 25);
            this.meetingTimeTextBox.TabIndex = 17;
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.AutoSize = true;
            this.meetingTimeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.meetingTimeLabel.Location = new System.Drawing.Point(408, 94);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(111, 21);
            this.meetingTimeLabel.TabIndex = 16;
            this.meetingTimeLabel.Text = "Meeting Time";
            // 
            // addScheduleButton
            // 
            this.addScheduleButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScheduleButton.Location = new System.Drawing.Point(709, 90);
            this.addScheduleButton.Name = "addScheduleButton";
            this.addScheduleButton.Size = new System.Drawing.Size(32, 22);
            this.addScheduleButton.TabIndex = 15;
            this.addScheduleButton.Text = "+";
            this.addScheduleButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addScheduleButton.UseVisualStyleBackColor = true;
            // 
            // meetingDateTimePicker
            // 
            this.meetingDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.meetingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.meetingDateTimePicker.Location = new System.Drawing.Point(140, 94);
            this.meetingDateTimePicker.Name = "meetingDateTimePicker";
            this.meetingDateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.meetingDateTimePicker.TabIndex = 14;
            // 
            // doctorWizardButton
            // 
            this.doctorWizardButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.doctorWizardButton.Location = new System.Drawing.Point(287, 40);
            this.doctorWizardButton.Name = "doctorWizardButton";
            this.doctorWizardButton.Size = new System.Drawing.Size(36, 25);
            this.doctorWizardButton.TabIndex = 13;
            this.doctorWizardButton.Text = ". . . . . . .";
            this.doctorWizardButton.UseVisualStyleBackColor = true;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(544, 37);
            this.doctorNameTextBox.Multiline = true;
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(144, 25);
            this.doctorNameTextBox.TabIndex = 12;
            // 
            // doctorIdTextBox
            // 
            this.doctorIdTextBox.Location = new System.Drawing.Point(140, 40);
            this.doctorIdTextBox.Multiline = true;
            this.doctorIdTextBox.Name = "doctorIdTextBox";
            this.doctorIdTextBox.Size = new System.Drawing.Size(120, 25);
            this.doctorIdTextBox.TabIndex = 11;
            // 
            // MeetingDateLabel
            // 
            this.MeetingDateLabel.AutoSize = true;
            this.MeetingDateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.MeetingDateLabel.Location = new System.Drawing.Point(26, 99);
            this.MeetingDateLabel.Name = "MeetingDateLabel";
            this.MeetingDateLabel.Size = new System.Drawing.Size(108, 21);
            this.MeetingDateLabel.TabIndex = 10;
            this.MeetingDateLabel.Text = "Meeting Date";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.doctorNameLabel.Location = new System.Drawing.Point(408, 37);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(111, 21);
            this.doctorNameLabel.TabIndex = 9;
            this.doctorNameLabel.Text = "Doctor Name";
            // 
            // doctorIdLabel
            // 
            this.doctorIdLabel.AutoSize = true;
            this.doctorIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.doctorIdLabel.Location = new System.Drawing.Point(32, 42);
            this.doctorIdLabel.Name = "doctorIdLabel";
            this.doctorIdLabel.Size = new System.Drawing.Size(84, 21);
            this.doctorIdLabel.TabIndex = 8;
            this.doctorIdLabel.Text = "Doctor Id";
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
            this.outpatientSchedulingInfoButton.Enabled = false;
            this.outpatientSchedulingInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outpatientSchedulingInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outpatientSchedulingInfoButton.Location = new System.Drawing.Point(147, 14);
            this.outpatientSchedulingInfoButton.Name = "outpatientSchedulingInfoButton";
            this.outpatientSchedulingInfoButton.Size = new System.Drawing.Size(113, 24);
            this.outpatientSchedulingInfoButton.TabIndex = 1;
            this.outpatientSchedulingInfoButton.Text = "Scheduling Info";
            this.outpatientSchedulingInfoButton.UseVisualStyleBackColor = true;
            // 
            // outpatientPersonalInfoButton
            // 
            this.outpatientPersonalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outpatientPersonalInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outpatientPersonalInfoButton.Location = new System.Drawing.Point(38, 14);
            this.outpatientPersonalInfoButton.Name = "outpatientPersonalInfoButton";
            this.outpatientPersonalInfoButton.Size = new System.Drawing.Size(99, 24);
            this.outpatientPersonalInfoButton.TabIndex = 0;
            this.outpatientPersonalInfoButton.Text = "Personal info";
            this.outpatientPersonalInfoButton.UseVisualStyleBackColor = true;
            this.outpatientPersonalInfoButton.Click += new System.EventHandler(this.outpatientPersonalInfoButton_Click);
            // 
            // outpatientSchedulingUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1056, 625);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "outpatientSchedulingUI";
            this.ShowInTaskbar = false;
            this.Text = "Schedulinginfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.submitPanel.ResumeLayout(false);
            this.outpatientSchedulingGroupBox.ResumeLayout(false);
            this.outpatientSchedulingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button outpatientDiagnosisTestButton;
        private System.Windows.Forms.Button outpatientSchedulingInfoButton;
        private System.Windows.Forms.Button outpatientPersonalInfoButton;
        private System.Windows.Forms.Button outpatientWizardButton;
        private System.Windows.Forms.GroupBox outpatientSchedulingGroupBox;
        public System.Windows.Forms.Panel submitPanel;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox meetingTimeTextBox;
        public System.Windows.Forms.Label meetingTimeLabel;
        public System.Windows.Forms.Button addScheduleButton;
        public System.Windows.Forms.DateTimePicker meetingDateTimePicker;
        public System.Windows.Forms.Button doctorWizardButton;
        public System.Windows.Forms.TextBox doctorNameTextBox;
        public System.Windows.Forms.TextBox doctorIdTextBox;
        public System.Windows.Forms.Label MeetingDateLabel;
        public System.Windows.Forms.Label doctorNameLabel;
        public System.Windows.Forms.Label doctorIdLabel;
    }
}