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

namespace TestDialogs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            opfMain.Filter = "Txt files(*.txt)|*.txt|All Files (*.*)|*.*|Docs(*.doc;*.docx)|*.doc;*.docx";
            opfMain.FilterIndex = 3;
            opfMain.RestoreDirectory = true;

            opfMain.ShowReadOnly = true;
            opfMain.Title = "Мы отрываем файл"; // !!!!
            
            if (opfMain.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < opfMain.FileNames.Length; i++)
                {
                    tbMain.Text += File.ReadAllText(opfMain.FileNames[i], Encoding.Default);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "File.txt";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, tbMain.Text);
            }
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                tbMain.ForeColor = cld.Color;
                panelColor.BackColor = cld.Color;
            }
        }

        private void llFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbMain.Font = fd.Font;
                llFont.Text = fd.Font.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fbdMain.ShowDialog() == DialogResult.OK)
            {
               var files= Directory.GetFiles(fbdMain.SelectedPath);
                for (int i = 0; i < files.Length; i++)
                {
                    tbMain.AppendText(Path.GetFileName(files[i])+Environment.NewLine);
                }
            }
        }
    }
}
