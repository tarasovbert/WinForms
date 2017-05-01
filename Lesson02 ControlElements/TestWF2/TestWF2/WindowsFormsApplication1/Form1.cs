using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckBox sel=(CheckBox)sender;
            TextBox selTb=(TextBox)this.Controls[sel.Tag.ToString()];
            selTb.Text = String.Empty;
            selTb.Enabled = sel.Checked;
        }
    }
}
