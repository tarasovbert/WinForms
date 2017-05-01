namespace CarFile.Forms
{
    partial class CarsListForm
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
            this.lb_listOfCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_listOfCars
            // 
            this.lb_listOfCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_listOfCars.FormattingEnabled = true;
            this.lb_listOfCars.ItemHeight = 16;
            this.lb_listOfCars.Location = new System.Drawing.Point(0, 0);
            this.lb_listOfCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_listOfCars.Name = "lb_listOfCars";
            this.lb_listOfCars.Size = new System.Drawing.Size(426, 322);
            this.lb_listOfCars.TabIndex = 0;
            // 
            // CarsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 322);
            this.Controls.Add(this.lb_listOfCars);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarsListForm";
            this.Text = "List of cars";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lb_listOfCars;
    }
}