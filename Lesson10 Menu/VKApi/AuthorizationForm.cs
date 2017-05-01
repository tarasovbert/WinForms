using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_Api
{
    public partial class AuthorizationForm : Form
    {
        public string Email { get; set; }
        public string Pass { get; set; }

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Email = tb_Email.Text;
            Pass = tb_Pass.Text;
        }
    }
}
