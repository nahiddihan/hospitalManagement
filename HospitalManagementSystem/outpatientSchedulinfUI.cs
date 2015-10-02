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
    public partial class outpatientSchedulingUI : Form
    {
        public outpatientSchedulingUI()
        {
            InitializeComponent();
        }

        private void outpatientPersonalInfoButton_Click(object sender, EventArgs e)
        {
            outpatientPersonalInfo outpatientPersonalInfoObject = new outpatientPersonalInfo();
            outpatientPersonalInfoObject.MdiParent = this.MdiParent;
            this.Close();
            outpatientPersonalInfoObject.Show();


        }

        private void outpatientDiagnosisTestButton_Click(object sender, EventArgs e)
        {
            outpatientDiagnosisUI outpatientDiagnosisUIObject = new outpatientDiagnosisUI();
            outpatientDiagnosisUIObject.MdiParent = this.MdiParent;
            this.Close();
            outpatientDiagnosisUIObject.Show();
        }
    }
}
