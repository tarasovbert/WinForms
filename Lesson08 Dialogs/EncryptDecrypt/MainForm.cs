using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog_Main.Filter = "Txt files (*.txt)|*.txt";
            openFileDialog_Main.FilterIndex = 1;
            openFileDialog_Main.RestoreDirectory = true;
            openFileDialog_Main.ShowReadOnly = true;
            openFileDialog_Main.Title = "Choose the source file to encrypt";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "EncryptedFile.txt";

            if (openFileDialog_Main.ShowDialog() == DialogResult.OK)
                tb_Path.Text = openFileDialog_Main.FileName;
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (File.Exists(tb_Path.Text))
            {
                SaveFileDialog SFDialog = new SaveFileDialog();
                SFDialog.RestoreDirectory = true;
                SFDialog.Filter = "Txt files (*.txt)|*.txt";
                SFDialog.FileName = "EncryptedFile";
                SFDialog.Title = "Choose the destination file to encrypt.";
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    TripleDESCryptoServiceProvider cryptAlgorythm = new TripleDESCryptoServiceProvider();
                    using (FileStream fsFileOut = new FileStream(SFDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(fsFileOut, cryptAlgorythm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncStream = new StreamWriter(csEncrypt, Encoding.Default))
                            {
                                using (FileStream srStream = new FileStream(tb_Path.Text, FileMode.Open, FileAccess.Read))
                                {
                                    string[] content = File.ReadAllLines(tb_Path.Text);
                                    for (int i = 0; i < content.Length; i++)
                                        swEncStream.WriteLine(content[i]);
                                }
                                SFDialog.Filter = "Key files (*.key)|*.key";
                                SFDialog.FileName = "fsFileKey";
                                SFDialog.Title = "Choose the destination file to write the encryption key.";
                                if (SFDialog.ShowDialog() == DialogResult.OK)
                                    using (FileStream fsFileKey = new FileStream(SFDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                                    {
                                        //fsFileKey.Write(cryptAlgorythm.Key);
                                        BinaryWriter bwFile = new BinaryWriter(fsFileKey);
                                        bwFile.Write(cryptAlgorythm.Key);
                                        bwFile.Write(cryptAlgorythm.IV);
                                    }
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("Choose file to encrypt!");
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDialog = new OpenFileDialog();
            OFDialog.RestoreDirectory = true;
            OFDialog.Filter = "Key files (*.key)|*.key";
            OFDialog.FileName = "fsFileKey";
            OFDialog.Title = "Choose the key file to make decryption.";
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                TripleDESCryptoServiceProvider cryptAlgorithm = new TripleDESCryptoServiceProvider();

                using (FileStream fsFileKey = new FileStream(OFDialog.FileName, FileMode.Open,
                    FileAccess.Read))
                {
                    BinaryReader brFile = new BinaryReader(fsFileKey);
                    cryptAlgorithm.Key = brFile.ReadBytes(24);
                    cryptAlgorithm.IV = brFile.ReadBytes(8);

                    OFDialog.Filter = "Text files (*.txt)|*.txt";
                    OFDialog.FileName = "EncryptedFile";
                    OFDialog.Title = "Choose the source file to decrypt from.";
                    if (OFDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fsFileIn = new FileStream(OFDialog.FileName, FileMode.Open,
                            FileAccess.Read))
                        {
                            using (CryptoStream csEncrypt = new CryptoStream(fsFileIn,
                                cryptAlgorithm.CreateDecryptor(), CryptoStreamMode.Read))
                            {
                                using (StreamReader srEncStream = new StreamReader(csEncrypt, Encoding.Default))
                                {
                                    SaveFileDialog SFDialog = new SaveFileDialog();
                                    SFDialog.RestoreDirectory = true;
                                    SFDialog.Filter = "Txt files (*.txt)|*.txt";
                                    SFDialog.FileName = "DecryptedFile";
                                    SFDialog.Title = "Choose the destination file to decrypt.";
                                    if (SFDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        {

                                            8// открытие потока (swStream) на файл (файл 7) для записи дешифрованных данных  
9// построковое чтение данных из файла 2 (через поток srEncStream) и построковая запись в файл 2 (через поток swStream).


                                            using (FileStream swStream = new FileStream(SFDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                                            {
                                                swStream.Dispose();
                                                string content;
                                                for (int i = 0; srEncStream.EndOfStream; i++)
                                                {
                                                    content = srEncStream.ReadLine();
                                                    File.WriteAllText(SFDialog.FileName, content);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void ll_Details_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://ru.wikipedia.org/wiki/DES");
        }
    }
}

