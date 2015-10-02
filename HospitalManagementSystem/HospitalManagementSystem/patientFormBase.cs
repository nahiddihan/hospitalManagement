using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class inpatientPersonalInfoUI : Form
    {
        public inpatientPersonalInfoUI()
        {
            InitializeComponent();
        }

        private void inpatientMedicalInfoButton_Click(object sender, EventArgs e)
        {
            inpatientMedicalInfoUI inpatientMedicalInfoObject = new inpatientMedicalInfoUI();
            inpatientMedicalInfoObject.MdiParent = this.MdiParent;
            this.Close();
            inpatientMedicalInfoObject.Show();
        }

        private void inpatientDiagnosisTestButton_Click(object sender, EventArgs e)
        {
            inpatientDiagnosisUI inpatientDiagnosisTestObject = new inpatientDiagnosisUI();
            inpatientDiagnosisTestObject.MdiParent = this.MdiParent;
            this.Close();
            inpatientDiagnosisTestObject.Show();

        }

        private void inpatientWizardButton_Click(object sender, EventArgs e)
        {
            inpatienWizard inpatientWizardObject = new inpatienWizard();
            inpatientWizardObject.ShowDialog();      
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String pid = patientIdTextBox.Text;
            String firstname = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String gender = genderComboBox.Text;
            String age = ageTextBox.Text;
            String civilStatus = civilStatusComboBox.Text;
            String mobile = mobileTextBox.Text;
            String address = addressTextBox.Text;
          
            String connectionString = @"server = MITHUN-PC; database = hospital; integrated security = true ";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query = 
                String.Format("insert into patient values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",pid,firstname,lastName,gender,age,civilStatus,mobile,address);
          
            SqlCommand command = new SqlCommand(query, connection);
             command.ExecuteNonQuery();

            //inserted successfully then 
             inpatientMedicalInfoUI inpatientMedicalInfoObject = new inpatientMedicalInfoUI();
             inpatientMedicalInfoObject.MdiParent = this.MdiParent;
             this.Close();
             inpatientMedicalInfoObject.Show();




        }


       
    }
}
