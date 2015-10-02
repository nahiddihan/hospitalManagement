using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class inpatientDiagnosisUI : Form
    {
        public inpatientDiagnosisUI()
        {
            InitializeComponent();
        }

        private void inpatientPersonalInfoButton_Click(object sender, EventArgs e)
        {
            inpatientPersonalInfoUI inpatientPersonalInfoUIObject = new inpatientPersonalInfoUI();
            inpatientPersonalInfoUIObject.MdiParent = this.MdiParent;
            this.Close();
            inpatientPersonalInfoUIObject.Show();
        }

        private void inpatientMedicalInfoButton_Click(object sender, EventArgs e)
        {
            inpatientMedicalInfoUI inpatientMedicalInfoUIObject = new inpatientMedicalInfoUI();
            inpatientMedicalInfoUIObject.MdiParent = this.MdiParent;
            this.Close();
            inpatientMedicalInfoUIObject.Show();
        }
    }
}
