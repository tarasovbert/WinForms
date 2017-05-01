using Lesson06_Forms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson06_Forms
{
    public partial class MainForm : Form
    {
        public string MyProperty
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        SecondForm form;

        public MainForm()
        {
            InitializeComponent();
            form = new SecondForm();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm form = new SecondForm(textBox1.Text);
            form.UserName = textBox1.Text;
            if (DialogResult.OK == form.ShowDialog()) { } //ShowDialog invokes the modal form
            textBox1.Text = form.UserName;
            if (form != null) form.Close();
            form = new SecondForm();
            form.UserName = textBox1.Text;
            form.Visible = true;
            form.Show(this);
        }
    }
}
