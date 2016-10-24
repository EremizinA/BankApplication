using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyVisualApplication
{
    public partial class GreetingsForm : Form
    {
        public GreetingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SigninForm sf = new SigninForm();
            sf.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

 
    }
}
