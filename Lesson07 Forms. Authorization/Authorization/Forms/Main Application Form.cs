using System;
using System.Windows.Forms;

namespace Authorization.Forms
{
    public partial class Main_Application_Form : Form
    {
        public Main_Application_Form()
        {
            InitializeComponent();
        }

        private void btn_ProceedToWork_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void Main_Application_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
