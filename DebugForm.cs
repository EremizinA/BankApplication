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

namespace MyVisualApplication
{
    public partial class DebugForm : Form
    {
        public List<Control> receivedComponent { get; set; }

        public DebugForm()
        {
            InitializeComponent();
        }

        public DebugForm(List<Control> textBoxList)
        {
            InitializeComponent();
            receivedComponent = textBoxList;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            foreach (var tb in receivedComponent)
                label1.Text += tb.Name + "\n";
        }
    }
}
