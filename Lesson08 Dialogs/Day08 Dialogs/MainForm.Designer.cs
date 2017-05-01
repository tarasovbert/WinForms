namespace Day08_Dialogs
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_Main = new System.Windows.Forms.TextBox();
            this.linklabel_Font = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.openFileDialog_Main = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_GetFilesName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_Main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_GetFilesName);
            this.splitContainer1.Panel2.Controls.Add(this.linklabel_Font);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Save);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Open);
            this.splitContainer1.Size = new System.Drawing.Size(630, 510);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.TabIndex = 0;
            // 
            // tb_Main
            // 
            this.tb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Main.Location = new System.Drawing.Point(0, 0);
            this.tb_Main.Margin = new System.Windows.Forms.Padding(10, 12, 12, 10);
            this.tb_Main.Multiline = true;
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Main.Size = new System.Drawing.Size(513, 510);
            this.tb_Main.TabIndex = 0;
            this.tb_Main.TextChanged += new System.EventHandler(this.tb_Main_TextChanged);
            // 
            // linklabel_Font
            // 
            this.linklabel_Font.AutoSize = true;
            this.linklabel_Font.Location = new System.Drawing.Point(12, 155);
            this.linklabel_Font.Name = "linklabel_Font";
            this.linklabel_Font.Size = new System.Drawing.Size(27, 13);
            this.linklabel_Font.TabIndex = 3;
            this.linklabel_Font.TabStop = true;
            this.linklabel_Font.Text = "Arial";
            this.linklabel_Font.Click += new System.EventHandler(this.linklabel_Font_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(34, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 50);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(3, 49);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 43);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(3, 0);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(110, 43);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // openFileDialog_Main
            // 
            this.openFileDialog_Main.FileName = "file";
            this.openFileDialog_Main.Multiselect = true;
            // 
            // btn_GetFilesName
            // 
            this.btn_GetFilesName.Location = new System.Drawing.Point(12, 466);
            this.btn_GetFilesName.Name = "btn_GetFilesName";
            this.btn_GetFilesName.Size = new System.Drawing.Size(89, 32);
            this.btn_GetFilesName.TabIndex = 4;
            this.btn_GetFilesName.Text = "Get Files Name";
            this.btn_GetFilesName.UseVisualStyleBackColor = true;
            this.btn_GetFilesName.Click += new System.EventHandler(this.btn_GetFilesName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 510);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_Main;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklabel_Font;
        private System.Windows.Forms.Button btn_GetFilesName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

