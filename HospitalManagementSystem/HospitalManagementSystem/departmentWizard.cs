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
    public partial class departmentWizard : Form
    {
        public departmentWizard()
        {
            InitializeComponent();
        }

        private void wizardCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentWizard_Load(object sender, EventArgs e)
        {
            String connectionString = @"server = MITHUN-PC; database = hospital; integrated security = true ";
            SqlConnection connection= new SqlConnection(connectionString);
            connection.Open();
          
       
           // string query = String.Format("insert into userLogin values ('{0}','{1}')",userName,password);
            string query = String.Format("select * from department");
             SqlCommand command=new SqlCommand(query,connection);
            // command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();

            List<department> departmentList=new List<department>();
            while (reader.Read())
            {
                department departmentObject=new department();
                departmentObject.departmentId = reader[0].ToString();
                departmentObject.departmentname = reader[1].ToString();
                departmentList.Add(departmentObject);
                MessageBox.Show("" + departmentObject.departmentId);
            }
            departmentDataGridView.DataSource = departmentList;
        }
    }

    
}
