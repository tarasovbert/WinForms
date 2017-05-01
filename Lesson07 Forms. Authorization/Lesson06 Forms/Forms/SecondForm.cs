using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson06_Forms.Forms
{
    public partial class SecondForm : Form
    {        
        public string UserName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public SecondForm():this(String.Empty)
        {
            //InitializeComponent();
        }

        public SecondForm(string message)
        {
            InitializeComponent();
            textBox1.Text = message;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK!");
           // ((MainForm)this.Owner).MyProperty = textBox1.Text;
            //this.DialogResult = DialogResult.OK;//form will be closed in modal regime only;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel.");
            this.DialogResult = DialogResult.Cancel;//form will be closed in modal regime only;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }

    internal class Car
    {
        
    }
}
