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
    public partial class outpatientPersonalInfo : Form
    {
        public outpatientPersonalInfo()
        {
            InitializeComponent();
        }

        private void outpatientSchedulingInfoButton_Click(object sender, EventArgs e)
        {
            outpatientSchedulingUI outpatientSchedulingUIObject = new outpatientSchedulingUI();
            outpatientSchedulingUIObject.MdiParent = this.MdiParent;
            this.Close();
            outpatientSchedulingUIObject.Show();
        }

        private void outpatientDiagnosisTestButton_Click(object sender, EventArgs e)
        {
            outpatientDiagnosisUI outpatientDiagnosisUIObject = new outpatientDiagnosisUI();
            outpatientDiagnosisUIObject.MdiParent = this.MdiParent;
            this.Close();
            outpatientDiagnosisUIObject.Show();
        }

        private void outpatientWizardButton_Click(object sender, EventArgs e)
        {
            outpatientWizard outpatientWizardObject = new outpatientWizard();
            outpatientWizardObject.ShowDialog();
        }
    }
}
