using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace MyVisualApplication
{
    public partial class DebugForm : Form
    {


        public DebugForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ConnectToDB();
        }

        private static void ConnectToDB()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString =
               ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

                cn.Open();

                string sqlCommand1 = "Select * from Clients";
                string sqlCommand2 = "Select * from Cards";

                SqlCommand command1 = new SqlCommand(sqlCommand1, cn);
                SqlCommand command2 = new SqlCommand(sqlCommand2, cn);

                using (SqlDataReader dr = command1.ExecuteReader())
                {

                    while (dr.Read())
                    {
                      
                        DebugForm.ActiveForm.Controls["label1"].Text +=
                        String.Format("-> Client id : {0},\n Client name : {1},\n Client money : {2}\n",
                            dr["ClientID"].ToString(), dr["ClientFirstName"].ToString(), dr["ClientMoney"].ToString());
                        DebugForm.ActiveForm.Update();
                        Thread.Sleep(2000);
                    }
                }

            }
        }

    }
}
