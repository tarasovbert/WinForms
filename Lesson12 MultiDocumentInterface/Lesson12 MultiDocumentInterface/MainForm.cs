using Lesson12_MultiDocumentInterface.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson12_MultiDocumentInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mi_UserList_Click(object sender, EventArgs e)
        {
            UserListForm form = new UserListForm();
            form.MdiParent = this;
            form.Show();
        }

        private void mi_AddUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void miView_Click(object sender, EventArgs e)
        {
            int indexTag = Int32.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mi_Min_Click(object sender, EventArgs e)
        {
            Form[] forms = this.MdiChildren;
            foreach (var item in forms)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }

        private void mi_Max_Click(object sender, EventArgs e)
        {
            Form[] forms = this.MdiChildren;
            foreach (var item in forms)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }

        private void mi_CloseForm_Click(object sender, EventArgs e)
        {
            Form form = this.ActiveMdiChild;
            if(form != null)           
                form.Close();           
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void Save()
        {

        }
    }
}
