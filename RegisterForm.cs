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
using System.IO;
using BankQueryLibrary;

namespace MyVisualApplication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void SendDataToDB()
        {
            Control.ControlCollection controls = RegisterForm.ActiveForm.Controls;

           
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Client client = new Client(17, FirstNameForm.Text, FatherNameForm.Text, SurNameForm.Text, 0, new Card());
            Employee emp = new Employee(1005);
            BankQuery bq = new BankQuery();
            
            bq.OpenConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = MyDB; Integrated Security = True");
            try
            {
        
                client = new Client(18, FirstNameForm.Text + "Mad", FatherNameForm.Text, SurNameForm.Text, 0, new Card());
                bq.UpdateClientData(client, emp.EmployeeID);
            }

            catch (Exception) { }

            bq.CloseConnection();
        }
    }
}
