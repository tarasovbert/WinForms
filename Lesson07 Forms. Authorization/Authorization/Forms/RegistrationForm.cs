using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Authorization.Forms
{
    public partial class RegistrationForm : Form
    {
        internal static string eMailPattern = @"\w+@\w+[.]\w+";
        public RegistrationForm()
        {
            InitializeComponent();
        }        

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Login.Text))
                MessageBox.Show("Enter your login to proceed!");
            else if (String.IsNullOrWhiteSpace(tb_EMail.Text))
                MessageBox.Show("Enter your E-mail to proceed!");
            else if (!Regex.IsMatch(tb_EMail.Text, eMailPattern))
                MessageBox.Show("Incorrect E-mail!");
            else if (String.IsNullOrWhiteSpace(tb_Password.Text))
                MessageBox.Show("Enter your password to proceed!");
            else if (tb_Password.Text.Length < 6)
                MessageBox.Show("Password has to be at least 6 characters long!");
            else if (String.IsNullOrWhiteSpace(tb_ConfirmPassword.Text))
                MessageBox.Show("Confirm your password to proceed!");
            else if (tb_ConfirmPassword.Text != tb_Password.Text)
                MessageBox.Show("Your confirmation of password is wrong!");
            else if (Repository.ContainsLogin(tb_Login.Text) >= 0)
                MessageBox.Show("A user with such login is already registered!");
            else if (Repository.ContainsEMail(tb_EMail.Text) >= 0)
                MessageBox.Show("A user with such E-mail is already registered!");
            else
            {
                Repository.AddUser(tb_Login.Text, tb_Password.Text, tb_EMail.Text,
                    tb_Name.Text, tb_Surname.Text);

                using (FileStream fs = new FileStream("users.bin", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    binFormatter.Serialize(fs, Repository.Users);
                }
                this.Owner.Visible = true;
                this.Close();
            };
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
    }
}

