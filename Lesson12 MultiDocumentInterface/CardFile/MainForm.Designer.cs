namespace CarFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.mi_CarsList = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_AddCar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_AddCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_AddImporter = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtn_CarsList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtn_AddCar = new System.Windows.Forms.ToolStripButton();
            this.tbtn_AddCountry = new System.Windows.Forms.ToolStripButton();
            this.tbtn_AddImporter = new System.Windows.Forms.ToolStripButton();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtn_Load = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_Menu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ms_Menu
            // 
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_CarsList,
            this.addCarToolStripMenuItem,
            this.saveListToolStripMenuItem,
            this.loadListToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(537, 24);
            this.ms_Menu.TabIndex = 1;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // mi_CarsList
            // 
            this.mi_CarsList.Image = global::CardFile.Properties.Resources.ic_directions_car_48px_32;
            this.mi_CarsList.Name = "mi_CarsList";
            this.mi_CarsList.Size = new System.Drawing.Size(76, 20);
            this.mi_CarsList.Text = "&Cars list";
            this.mi_CarsList.Click += new System.EventHandler(this.mi_CarsList_Click);
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_AddCar,
            this.mi_AddCountry,
            this.mi_AddImporter});
            this.addCarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCarToolStripMenuItem.Image")));
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.addCarToolStripMenuItem.Text = "&Add";
            // 
            // mi_AddCar
            // 
            this.mi_AddCar.Image = global::CardFile.Properties.Resources.ic_directions_car_48px_32;
            this.mi_AddCar.Name = "mi_AddCar";
            this.mi_AddCar.Size = new System.Drawing.Size(165, 22);
            this.mi_AddCar.Text = "Car";
            this.mi_AddCar.Click += new System.EventHandler(this.mi_AddCar_Click);
            // 
            // mi_AddCountry
            // 
            this.mi_AddCountry.Image = global::CardFile.Properties.Resources.world;
            this.mi_AddCountry.Name = "mi_AddCountry";
            this.mi_AddCountry.Size = new System.Drawing.Size(165, 22);
            this.mi_AddCountry.Text = "Country of origin";
            this.mi_AddCountry.Click += new System.EventHandler(this.mi_AddCountry_Click);
            // 
            // mi_AddImporter
            // 
            this.mi_AddImporter.Image = global::CardFile.Properties.Resources.skyscraper_03_32;
            this.mi_AddImporter.Name = "mi_AddImporter";
            this.mi_AddImporter.Size = new System.Drawing.Size(165, 22);
            this.mi_AddImporter.Text = "Importer";
            this.mi_AddImporter.Click += new System.EventHandler(this.mi_AddImporter_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtn_CarsList,
            this.toolStripSeparator1,
            this.tbtn_AddCar,
            this.tbtn_AddCountry,
            this.tbtn_AddImporter,
            this.toolStripSeparator2,
            this.tbtn_Save,
            this.toolStripSeparator3,
            this.tbtn_Load,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtn_CarsList
            // 
            this.tbtn_CarsList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_CarsList.Image = global::CardFile.Properties.Resources.list;
            this.tbtn_CarsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_CarsList.Name = "tbtn_CarsList";
            this.tbtn_CarsList.Size = new System.Drawing.Size(23, 22);
            this.tbtn_CarsList.Text = "Open list";
            this.tbtn_CarsList.Click += new System.EventHandler(this.tbtn_CarsList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtn_AddCar
            // 
            this.tbtn_AddCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_AddCar.Image = global::CardFile.Properties.Resources.ic_directions_car_48px_32;
            this.tbtn_AddCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_AddCar.Name = "tbtn_AddCar";
            this.tbtn_AddCar.Size = new System.Drawing.Size(23, 22);
            this.tbtn_AddCar.Text = "Add car to list";
            this.tbtn_AddCar.Click += new System.EventHandler(this.tbtn_AddCar_Click);
            // 
            // tbtn_AddCountry
            // 
            this.tbtn_AddCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_AddCountry.Image = global::CardFile.Properties.Resources.world;
            this.tbtn_AddCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_AddCountry.Name = "tbtn_AddCountry";
            this.tbtn_AddCountry.Size = new System.Drawing.Size(23, 22);
            this.tbtn_AddCountry.Text = "Add country of origin";
            this.tbtn_AddCountry.Click += new System.EventHandler(this.tbtn_AddCountry_Click);
            // 
            // tbtn_AddImporter
            // 
            this.tbtn_AddImporter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_AddImporter.Image = global::CardFile.Properties.Resources.skyscraper_03_32;
            this.tbtn_AddImporter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_AddImporter.Name = "tbtn_AddImporter";
            this.tbtn_AddImporter.Size = new System.Drawing.Size(23, 22);
            this.tbtn_AddImporter.Text = "Add importer";
            this.tbtn_AddImporter.Click += new System.EventHandler(this.tbtn_AddImporter_Click);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Image = global::CardFile.Properties.Resources.Download_24;
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.saveListToolStripMenuItem.Text = "&Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.Image = global::CardFile.Properties.Resources.ic_open_in_new_48px_24;
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadListToolStripMenuItem.Text = "&Load List";
            this.loadListToolStripMenuItem.Click += new System.EventHandler(this.loadListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_Save.Image = global::CardFile.Properties.Resources.Download_24;
            this.tbtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_Save.Name = "tbtn_Save";
            this.tbtn_Save.Size = new System.Drawing.Size(23, 22);
            this.tbtn_Save.Text = "Save list";
            this.tbtn_Save.Click += new System.EventHandler(this.tbtn_Save_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtn_Load
            // 
            this.tbtn_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_Load.Image = global::CardFile.Properties.Resources.ic_open_in_new_48px_24;
            this.tbtn_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_Load.Name = "tbtn_Load";
            this.tbtn_Load.Size = new System.Drawing.Size(23, 22);
            this.tbtn_Load.Text = "Load list";
            this.tbtn_Load.Click += new System.EventHandler(this.tbtn_Load_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 402);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ms_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "MainForm";
            this.Text = "CarsFile";
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem mi_CarsList;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_AddCar;
        private System.Windows.Forms.ToolStripMenuItem mi_AddCountry;
        private System.Windows.Forms.ToolStripMenuItem mi_AddImporter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtn_AddCar;
        private System.Windows.Forms.ToolStripButton tbtn_AddCountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtn_CarsList;
        private System.Windows.Forms.ToolStripButton tbtn_AddImporter;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtn_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtn_Load;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

