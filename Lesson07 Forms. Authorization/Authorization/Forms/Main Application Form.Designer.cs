namespace Authorization.Forms
{
    partial class Main_Application_Form
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
            this.tb_NameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ProceedToWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_NameSurname
            // 
            this.tb_NameSurname.Location = new System.Drawing.Point(18, 41);
            this.tb_NameSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NameSurname.Name = "tb_NameSurname";
            this.tb_NameSurname.Size = new System.Drawing.Size(164, 22);
            this.tb_NameSurname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "You have enetered as:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Authorization.Properties.Resources.Hello__work_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(200, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 327);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ProceedToWork
            // 
            this.btn_ProceedToWork.Location = new System.Drawing.Point(18, 71);
            this.btn_ProceedToWork.Name = "btn_ProceedToWork";
            this.btn_ProceedToWork.Size = new System.Drawing.Size(164, 23);
            this.btn_ProceedToWork.TabIndex = 3;
            this.btn_ProceedToWork.Text = "Proceed to work";
            this.btn_ProceedToWork.UseVisualStyleBackColor = true;
            this.btn_ProceedToWork.Click += new System.EventHandler(this.btn_ProceedToWork_Click);
            // 
            // Main_Application_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 359);
            this.Controls.Add(this.btn_ProceedToWork);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NameSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Application_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Application Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Application_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ProceedToWork;
        internal System.Windows.Forms.TextBox tb_NameSurname;
    }
}