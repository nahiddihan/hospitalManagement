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
    public partial class inpatientMedicalInfoUI : Form
    {
        public inpatientMedicalInfoUI()
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

        private void inpatientDiagnosisTestButton_Click(object sender, EventArgs e)
        {
            inpatientDiagnosisUI inpatientDiagnosisObject = new inpatientDiagnosisUI();
            inpatientDiagnosisObject.MdiParent = this.MdiParent;
            this.Close();
            inpatientDiagnosisObject.Show();
            

        }

        private void doctorIdSearchButton_Click(object sender, EventArgs e)
        {
            doctorWizard doctorWizardObject = new doctorWizard();
            doctorWizardObject.ShowDialog();
        }

        private void departmentSearchButton_Click(object sender, EventArgs e)
        {
            departmentWizard departmentWizardObject = new departmentWizard();
            departmentWizardObject.ShowDialog();
        }

        private void roomWizardButton_Click(object sender, EventArgs e)
        {
            roomWizard roomWzardObject = new roomWizard();
            roomWzardObject.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var patientId = patientIdTextBox.Text;
            var admissionDate = admissionDateTimePicker.Text;
            var doctorsId = doctorIdTextBox.Text;
            var departmentId = departmentIdTextBox.Text;
            var roomNo = roomNoTextBox.Text;
            var wardNo = wardNoTextBox.Text;




            String connectionString = @"server = MITHUN-PC; database = hospital; integrated security = true ";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string query =
                String.Format("insert into inpatient values ('{0}','{1}','{2}','{3}','{4}','{5}')", patientId, admissionDate, doctorsId, departmentId,roomNo, wardNo);

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            patientIdTextBox.Text = null;
            doctorIdTextBox.Text = null;
            departmentIdTextBox.Text = null;
            roomNoTextBox.Text = null;
            wardNoTextBox.Text = null;
            admissionDateTimePicker.Text = null;
            doctorNameTextBox.Text = null;
            departmentNameTextBox.Text = null;

        }

      
    }
}
