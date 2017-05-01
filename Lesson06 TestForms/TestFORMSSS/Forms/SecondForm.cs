using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFORMSSS.Forms
{
    public partial class SecondForm : Form
    {
        private User user;
        public User User
        {
            get { return user;}
        }

        public SecondForm()  // add
        {
            InitializeComponent();
        }

        public SecondForm(User user) // update
        {
            InitializeComponent();
            this.user = user;
            tbUserName.Text= user.Name;
            tbAge.Text=user.Age.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if(user==null)
                user = new User();
            user.Name = tbUserName.Text;
            user.Age= Convert.ToInt32(tbAge.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
