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
    public partial class outpatientDiagnosisUI : Form
    {
        public outpatientDiagnosisUI()
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

        private void outpatientSchedulingInfoButton_Click(object sender, EventArgs e)
        {
            outpatientSchedulingUI outpatientSchedulingUIObject = new outpatientSchedulingUI();
            outpatientSchedulingUIObject.MdiParent = this.MdiParent;
            this.Close();
            outpatientSchedulingUIObject.Show();

        }
    }
}
