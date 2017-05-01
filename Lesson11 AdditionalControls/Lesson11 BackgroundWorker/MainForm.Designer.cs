namespace Lesson11_BackgroundWorker
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
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_Status = new System.Windows.Forms.Label();
            this.pb_Process = new System.Windows.Forms.ProgressBar();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(13, 29);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(247, 36);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "BgWorker Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(13, 9);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(0, 16);
            this.lb_Status.TabIndex = 1;
            // 
            // pb_Process
            // 
            this.pb_Process.Location = new System.Drawing.Point(12, 122);
            this.pb_Process.Name = "pb_Process";
            this.pb_Process.Size = new System.Drawing.Size(247, 23);
            this.pb_Process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_Process.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(13, 73);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(247, 36);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "BgWorker Cancel Execution";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 157);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pb_Process);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.btn_start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Background Worker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.ProgressBar pb_Process;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

