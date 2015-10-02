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
    public partial class outpatientWizard : Form
    {
        public outpatientWizard()
        {
            InitializeComponent();
        }

        private void wizardCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
    }
}
