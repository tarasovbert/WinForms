using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vk_Api.Entities;

namespace Vk_Api
{
    public partial class CaptchaForm : Form
    {

        private UserInfo userInfo;

        public UserInfo UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

        public CaptchaForm(string UriImage)
        {
            InitializeComponent();
            //pbCaptcha.LoadAsync(@"http://api.vk.com/captcha.php?sid=244398979176");

            pbCaptha.ImageLocation = UriImage;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            userInfo = new Entities.UserInfo();
         
            UserInfo.CaptchaKey = tbCaptcha.Text;

            DialogResult = DialogResult.OK;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            userInfo = new Entities.UserInfo();
            DialogResult = DialogResult.Cancel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // pbCaptcha.LoadAsync(@"http://api.vk.com/captcha.php?sid=244398979176");
        }
    }
}
