using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11_DragAndDrop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tb_Source_MouseDown(object sender, MouseEventArgs e)
        {
            tb_Source.DoDragDrop(tb_Source.Text, DragDropEffects.Copy);
        }

        private void lB_Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void lB_Main_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string item = (string)e.Data.GetData(DataFormats.Text);
                lB_Main.Items.Add(item);
            }
            if (lB_Main.BackColor != Color.White)
                lB_Main.BackColor = Color.White;
        }

        private void lB_Main_DragLeave(object sender, EventArgs e)
        {
            lB_Main.BackColor = Color.White;
        }

        private void lB_Main_DragOver(object sender, DragEventArgs e)
        {
            lB_Main.BackColor = Color.Yellow;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += (oo, ee) =>
            {
                ee.Effect = DragDropEffects.Link;
            };
            pictureBox1.DragDrop += (oo, ee) =>
            {
                var filePath = (string[])ee.Data.GetData(DataFormats.FileDrop);
                if (filePath.Length > 0)
                    pictureBox1.ImageLocation = filePath[0];
            };
        }

        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}
