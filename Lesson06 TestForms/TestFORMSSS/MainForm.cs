using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFORMSSS.Forms;

namespace TestFORMSSS
{
    public partial class MainForm : Form
    {
        private BindingList<User> users;
        public BindingList<User> Users
        {
            get
            {
                return users;
            }
        }

        public User UserSelect
        {
            set { listBox1.SelectedItem = value; } 
        }


        public MainForm()
        {
            InitializeComponent();
            users = new BindingList<User>();
            listBox1.DataSource = Users;
        }

       

        // ADD
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SecondForm form = new SecondForm();
            form.ShowDialog();
            Users.Add(form.User);
        }

        // UPDATE
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                User selUser = (User)listBox1.SelectedItem;
                SecondForm form = new SecondForm(selUser);
                form.ShowDialog();
                Users.ResetBindings();
                //listBox1.DataSource = null;
                //listBox1.DataSource = users;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FindUserForm form = new FindUserForm();
            form.Show(this);
        }
    }
}
