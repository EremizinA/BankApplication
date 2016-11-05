using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace MyVisualApplication
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ConnectToDb();
        }

        private void ConnectToDb()
        {
            WorkForm wf = new WorkForm();
            wf.Controls["label1"].Text = "Welcome, ";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
                cn.Open();

                string query = String.Format("Select cl.ClientFirstName, cl.ClientFatherName from Clients as cl "
                    + "join Accounts as a on (a.ClientID = cl.ClientID) "
                    + "where a.AccountLogin = '{0}' and a.AccountPassword = '{1}'", textBox1.Text, textBox2.Text);

                SqlCommand sqlCommand = new SqlCommand(query, cn);

                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while(dr.Read())
                    {
                       
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            wf.Controls["label1"].Text += String.Format(dr.GetValue(i).ToString() + " ");
                        }
                        wf.Show();
                        wf.Update();
                        Thread.Sleep(2000);
                    }
                }
            }
        }
    }
}
