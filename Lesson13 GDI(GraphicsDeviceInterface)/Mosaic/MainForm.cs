using Mosaic.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ChooseImage();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        private void pictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }

        private void ChooseImage()
        {
            OpenFileDialog OFDialog = new OpenFileDialog();
            OFDialog.Filter = "Image files (*.jpg;*.jpeg;*bmp)|*.jpg;*.jpeg;*bmp";
            OFDialog.Title = "Choose image to start game";
            OFDialog.RestoreDirectory = true;
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                pb_Main.Load(OFDialog.FileName);
            }
        }
    }
}
