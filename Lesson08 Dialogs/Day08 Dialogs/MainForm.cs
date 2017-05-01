using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_Dialogs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tb_Main_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            openFileDialog_Main.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*|Docs(*.doc;*docx)|*.doc;*docx";
            openFileDialog_Main.FilterIndex = 1;
            openFileDialog_Main.RestoreDirectory = true;
            openFileDialog_Main.ShowReadOnly = true;
            openFileDialog_Main.Title = "We're opening the file!";

            if (openFileDialog_Main.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog_Main.FileNames.Length; i++)
                {
                    // string pathFile = openFileDialog_Main.FileNames;
                    tb_Main.Text += File.ReadAllText(openFileDialog_Main.FileNames[i], Encoding.Default);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "File.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, tb_Main.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                tb_Main.ForeColor = panel1.BackColor = cld.Color;
            }
        }

        private void linklabel_Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tb_Main.Font = linklabel_Font.Font = fd.Font;

            }
        }

        private void btn_GetFilesName_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                for (int i = 0; i < files.Length; i++)
                {
                    tb_Main.AppendText(Path.GetFileName(files[i]));
                    tb_Main.AppendText(Environment.NewLine);
                }

            }
        }
    }
}

