using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VK_Api.Properties;
using VkNet;
using VkNet.Exception;
using Vk_Api;

namespace VK_Api
{
    public partial class MainForm : Form
    {
        int appID = 5423881;                      // ID приложения
        //string email = "test@test.com";         // email или телефон
        public string Email { get; set; }
        public string Pass { get; set; }

       
      
        public MainForm()
        {
            InitializeComponent();
        }

        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm AuthForm = new AuthorizationForm();
            AuthForm.ShowDialog();
            if (AuthForm.ShowDialog() == DialogResult.OK)
            {
                Email = AuthForm.Email;
                Pass = AuthForm.Pass;
            }
            
            VkNet.Enums.Filters.Settings scope = VkNet.Enums.Filters.Settings.All;      // Приложение имеет доступ к друзьям
            var vkApi = new VkApi();
          
            var user = new ApiAuthParams()
            {
                ApplicationId = (ulong)appID,
                Login = Email,
                Password = Pass,
                Settings = scope
            };

            try
            {
                vkApi.Authorize(user);
                tsStatusInfo.Text = "Connected";
                InitializeMenu(true);
            }
            catch (CaptchaNeededException ex)
            {
                CaptchaForm captchForm = new CaptchaForm(ex.Img.AbsoluteUri);
                captchForm.Text = "Capthca error";
                if (DialogResult.OK == captchForm.ShowDialog())
                {
                    user.CaptchaKey = captchForm.UserInfo.CaptchaKey;
                    user.CaptchaSid = ex.Sid;
                    vkApi.Authorize(user);

                    tsStatusInfo.Text = "Подключено...";
                    //InitializeMenu(true);
                }
            }
        }
    }
}
