namespace Lesson11_DragAndDrop
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
            this.tb_Source = new System.Windows.Forms.TextBox();
            this.lB_Main = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Source
            // 
            this.tb_Source.Location = new System.Drawing.Point(18, 15);
            this.tb_Source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Source.Name = "tb_Source";
            this.tb_Source.Size = new System.Drawing.Size(282, 22);
            this.tb_Source.TabIndex = 0;
            this.tb_Source.Text = "C#";
            this.tb_Source.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_Source_MouseDown);
            // 
            // lB_Main
            // 
            this.lB_Main.AllowDrop = true;
            this.lB_Main.FormattingEnabled = true;
            this.lB_Main.ItemHeight = 16;
            this.lB_Main.Location = new System.Drawing.Point(310, 15);
            this.lB_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lB_Main.Name = "lB_Main";
            this.lB_Main.Size = new System.Drawing.Size(312, 260);
            this.lB_Main.TabIndex = 1;
            this.lB_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.lB_Main_DragDrop);
            this.lB_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.lB_Main_DragEnter);
            this.lB_Main.DragOver += new System.Windows.Forms.DragEventHandler(this.lB_Main_DragOver);
            this.lB_Main.DragLeave += new System.EventHandler(this.lB_Main_DragLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lesson11_DragAndDrop.Properties.Resources.Screen_Shot_2014_09_04_at_7_00_35_am;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragOver);
            this.pictureBox1.DragLeave += new System.EventHandler(this.pictureBox1_DragLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lB_Main);
            this.Controls.Add(this.tb_Source);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Drag and drop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Source;
        private System.Windows.Forms.ListBox lB_Main;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

