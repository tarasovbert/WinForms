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
    public partial class FindUserForm : Form
    {
        public FindUserForm()
        {
            InitializeComponent();
        }

        private void FindUserForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var Users = ((MainForm)this.Owner).Users;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Name.Contains(textBox1.Text))
                {
                    ((MainForm)this.Owner).UserSelect = Users[i];
                }
            }
        }
    }
}
