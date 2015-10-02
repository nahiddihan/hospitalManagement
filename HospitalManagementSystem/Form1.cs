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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var userName = userNameTextBox.Text;
            var password = passwordTextBox.Text;

           // MainUI mainui = new MainUI();
           // mainui.Show();

            String connectionString = @"server = MITHUN-PC; database = hospital; integrated security = true ";
            SqlConnection connection= new SqlConnection(connectionString);
            connection.Open();
          
       
           // string query = String.Format("insert into userLogin values ('{0}','{1}')",userName,password);
            string query = String.Format("select * from userLogin where username='{0}'",userName);
             SqlCommand command=new SqlCommand(query,connection);
            // command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String databaseUserName;
                String databasePassword;
                databaseUserName = reader[0].ToString();
                databasePassword = reader[1].ToString();
                if (databaseUserName == userName && databasePassword == password)
                {
                    this.Hide();
                    MainUI mainui = new MainUI();
                    mainui.Show();
                }
                else
                {
                    MessageBox.Show("Wrong userName Or Password");
                    userNameTextBox.Text = null;
                    passwordTextBox.Text = null;
                }


            }
           


        }
    }
}
