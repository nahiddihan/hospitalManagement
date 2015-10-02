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
    public partial class inpatienWizard : Form
    {
        public inpatienWizard()
        {
            InitializeComponent();
        }

        private void wizardCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
