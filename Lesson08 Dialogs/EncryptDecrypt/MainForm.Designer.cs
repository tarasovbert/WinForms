namespace EncryptDecrypt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.gb_MethodsOfEncrypting = new System.Windows.Forms.GroupBox();
            this.ll_Details = new System.Windows.Forms.LinkLabel();
            this.rb_DES = new System.Windows.Forms.RadioButton();
            this.openFileDialog_Main = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.gb_MethodsOfEncrypting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to file";
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(13, 33);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(507, 20);
            this.tb_Path.TabIndex = 1;
            // 
            // gb_MethodsOfEncrypting
            // 
            this.gb_MethodsOfEncrypting.Controls.Add(this.ll_Details);
            this.gb_MethodsOfEncrypting.Controls.Add(this.rb_DES);
            this.gb_MethodsOfEncrypting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_MethodsOfEncrypting.Location = new System.Drawing.Point(16, 109);
            this.gb_MethodsOfEncrypting.Name = "gb_MethodsOfEncrypting";
            this.gb_MethodsOfEncrypting.Size = new System.Drawing.Size(504, 48);
            this.gb_MethodsOfEncrypting.TabIndex = 4;
            this.gb_MethodsOfEncrypting.TabStop = false;
            this.gb_MethodsOfEncrypting.Text = "Methods of encrypting";
            // 
            // ll_Details
            // 
            this.ll_Details.AutoSize = true;
            this.ll_Details.Location = new System.Drawing.Point(308, 24);
            this.ll_Details.Name = "ll_Details";
            this.ll_Details.Size = new System.Drawing.Size(57, 16);
            this.ll_Details.TabIndex = 1;
            this.ll_Details.TabStop = true;
            this.ll_Details.Text = "Details";
            this.ll_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Details_LinkClicked);
            // 
            // rb_DES
            // 
            this.rb_DES.AutoSize = true;
            this.rb_DES.Checked = true;
            this.rb_DES.Location = new System.Drawing.Point(7, 22);
            this.rb_DES.Name = "rb_DES";
            this.rb_DES.Size = new System.Drawing.Size(222, 20);
            this.rb_DES.TabIndex = 0;
            this.rb_DES.TabStop = true;
            this.rb_DES.Text = "symmetrical algorithm (DES)";
            this.rb_DES.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_Main
            // 
            this.openFileDialog_Main.FileName = "file";
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChooseFile.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ChooseFile.Image = global::EncryptDecrypt.Properties.Resources.folder_32;
            this.btn_ChooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChooseFile.Location = new System.Drawing.Point(355, 60);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(165, 43);
            this.btn_ChooseFile.TabIndex = 5;
            this.btn_ChooseFile.Text = "      Choose file";
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Decrypt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Decrypt.Image = global::EncryptDecrypt.Properties.Resources.unlocked_32;
            this.btn_Decrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Decrypt.Location = new System.Drawing.Point(184, 60);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(165, 43);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "      Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Encrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Encrypt.Image = global::EncryptDecrypt.Properties.Resources.locked_32;
            this.btn_Encrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Encrypt.Location = new System.Drawing.Point(13, 60);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(165, 43);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "      Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 169);
            this.Controls.Add(this.btn_ChooseFile);
            this.Controls.Add(this.gb_MethodsOfEncrypting);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Encrypt Methods";
            this.gb_MethodsOfEncrypting.ResumeLayout(false);
            this.gb_MethodsOfEncrypting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.GroupBox gb_MethodsOfEncrypting;
        private System.Windows.Forms.LinkLabel ll_Details;
        private System.Windows.Forms.RadioButton rb_DES;
        private System.Windows.Forms.Button btn_ChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Main;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

