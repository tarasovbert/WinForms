using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKApi.Entities;

namespace VkClient
{
    public partial class LoginForm : Form
    {

        private UserInfo userInfo;

        public UserInfo UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

        public LoginForm()
        {
            InitializeComponent();

            //pbCaptcha.LoadAsync(@"http://api.vk.com/captcha.php?sid=244398979176");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            userInfo = new Entities.UserInfo();

            UserInfo.Email = tbEmail.Text;
            UserInfo.Password = tbPass.Text;

            DialogResult = DialogResult.OK;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            userInfo = new Entities.UserInfo();
            DialogResult = DialogResult.Cancel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //pbCaptcha.LoadAsync(@"http://api.vk.com/captcha.php?sid=244398979176");
        }
    }
}
