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
    public partial class MainUI : Form
    {

     

        public MainUI()
        {
            InitializeComponent();
           
          
        }

        private void inpatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inpatientPersonalInfoUI inpatientPersonalInfoObject = new inpatientPersonalInfoUI();
            inpatientPersonalInfoObject.MdiParent = this;
            inpatientPersonalInfoObject.Show();

        }

        private void outpatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outpatientPersonalInfo outpatientPersonalInfoObject = new outpatientPersonalInfo();
            outpatientPersonalInfoObject.MdiParent = this;
            outpatientPersonalInfoObject.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

    
      


      
      

       

      

     

       

      
      

      

       
       

       
      

       
    }
   
}
