using Authorization.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Authorization
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();            

            if (File.Exists("users.bin"))
            {
                using (FileStream fs = new FileStream("users.bin", FileMode.Open, FileAccess.Read))
                {                    
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    Repository.Users = binFormatter.Deserialize(fs) as List<Repository.Data>;
                }
            }
        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {
            if (tb_Login.ForeColor != Color.Black)
                tb_Login.ForeColor = Color.Black;
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (tb_Password.ForeColor != Color.Black)
            {
                tb_Password.ForeColor = Color.Black;
                tb_Password.PasswordChar = '*';
            }
        }

        private void linkLabel_RestorePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
                this.Visible = false;
                RestorationForm RestForm = new RestorationForm();
                RestForm.ShowDialog(this);
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.ShowDialog(this);
        }
       
        private void textBox_Login_Click(object sender, EventArgs e)
        {
            tb_Login.Text = String.Empty;
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            tb_Password.Text = String.Empty;
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            tb_Status.Visible = true;
            tb_Status.BackColor = Color.LightBlue;
            tb_Status.ForeColor = Color.DarkBlue;
            tb_Status.Text = "Data is checking";
            int index = Repository.ContainsLoginAndPassword(tb_Login.Text, tb_Password.Text);
            if (index >= 0)
            {
                Main_Application_Form form = new Main_Application_Form();
                form.tb_NameSurname.Text = String.Format("{0} {1}", Repository.Users[index].Name, Repository.Users[index].Surname);
                form.Show();
                this.Visible = false;
            }
            else
            {
                tb_Status.BackColor = Color.Red;
                tb_Status.ForeColor = Color.Black;
                tb_Status.Text = "!!!ACCESS DENIED!!!";
            }           
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
