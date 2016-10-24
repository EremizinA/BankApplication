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
            var tbList = (from Control tb in RegisterForm.ActiveForm.Controls
                            where tb is TextBox
                            select tb).ToList<Control>();

            string infoPath;
            
            
        }
    }
}
