namespace CarFile.Forms
{
    partial class AddCarForm
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
            this.tb_Mark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mass = new System.Windows.Forms.TextBox();
            this.cb_Country = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Importer = new System.Windows.Forms.ComboBox();
            this.btn_AddCar = new System.Windows.Forms.Button();
            this.btn_AddCountry = new System.Windows.Forms.Button();
            this.btn_AddImporter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Mark
            // 
            this.tb_Mark.Location = new System.Drawing.Point(20, 52);
            this.tb_Mark.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mark.Name = "tb_Mark";
            this.tb_Mark.Size = new System.Drawing.Size(181, 22);
            this.tb_Mark.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mass, kg";
            // 
            // tb_mass
            // 
            this.tb_mass.Location = new System.Drawing.Point(20, 121);
            this.tb_mass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mass.Name = "tb_mass";
            this.tb_mass.Size = new System.Drawing.Size(181, 22);
            this.tb_mass.TabIndex = 2;
            // 
            // cb_Country
            // 
            this.cb_Country.FormattingEnabled = true;
            this.cb_Country.Location = new System.Drawing.Point(25, 189);
            this.cb_Country.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Country.Name = "cb_Country";
            this.cb_Country.Size = new System.Drawing.Size(180, 24);
            this.cb_Country.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country of Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importer";
            // 
            // cb_Importer
            // 
            this.cb_Importer.FormattingEnabled = true;
            this.cb_Importer.Location = new System.Drawing.Point(25, 290);
            this.cb_Importer.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Importer.Name = "cb_Importer";
            this.cb_Importer.Size = new System.Drawing.Size(180, 24);
            this.cb_Importer.TabIndex = 6;
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.Location = new System.Drawing.Point(20, 364);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.Size = new System.Drawing.Size(185, 47);
            this.btn_AddCar.TabIndex = 8;
            this.btn_AddCar.Text = "Add Car";
            this.btn_AddCar.UseVisualStyleBackColor = true;
            this.btn_AddCar.Click += new System.EventHandler(this.btn_AddCar_Click);
            // 
            // btn_AddCountry
            // 
            this.btn_AddCountry.Location = new System.Drawing.Point(25, 220);
            this.btn_AddCountry.Name = "btn_AddCountry";
            this.btn_AddCountry.Size = new System.Drawing.Size(180, 23);
            this.btn_AddCountry.TabIndex = 9;
            this.btn_AddCountry.Text = "Add country";
            this.btn_AddCountry.UseVisualStyleBackColor = true;
            this.btn_AddCountry.Click += new System.EventHandler(this.btn_AddCountry_Click);
            // 
            // btn_AddImporter
            // 
            this.btn_AddImporter.Location = new System.Drawing.Point(20, 321);
            this.btn_AddImporter.Name = "btn_AddImporter";
            this.btn_AddImporter.Size = new System.Drawing.Size(185, 23);
            this.btn_AddImporter.TabIndex = 10;
            this.btn_AddImporter.Text = "Add importer";
            this.btn_AddImporter.UseVisualStyleBackColor = true;
            this.btn_AddImporter.Click += new System.EventHandler(this.btn_AddImporter_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 435);
            this.Controls.Add(this.btn_AddImporter);
            this.Controls.Add(this.btn_AddCountry);
            this.Controls.Add(this.btn_AddCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Importer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Mark);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCarForm";
            this.Text = "Add Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Mark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddCar;
        private System.Windows.Forms.Button btn_AddCountry;
        private System.Windows.Forms.Button btn_AddImporter;
        internal System.Windows.Forms.ComboBox cb_Country;
        internal System.Windows.Forms.ComboBox cb_Importer;
    }
}