namespace MobilePhoneShop
{
    partial class PhoneShop_MainForm
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneShop_MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox_PhonesList = new System.Windows.Forms.GroupBox();
            this.listBox_PhonesList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1_PhoneListButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button_ReadFromFile = new System.Windows.Forms.Button();
            this.button_SaveToFile = new System.Windows.Forms.Button();
            this.button_ClearList = new System.Windows.Forms.Button();
            this.button_DeleteCurrent = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_CellphoneInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2_PhoneInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panel1_CellphoneParameters = new System.Windows.Forms.Panel();
            this.groupBox_Options = new System.Windows.Forms.GroupBox();
            this.listBox_Options = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3_PhoneParameters = new System.Windows.Forms.TableLayoutPanel();
            this.label1_Model = new System.Windows.Forms.Label();
            this.label4_Price = new System.Windows.Forms.Label();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_CPU = new System.Windows.Forms.TextBox();
            this.label2_OS = new System.Windows.Forms.Label();
            this.label3_CPU = new System.Windows.Forms.Label();
            this.textBox_OS = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.pictureBox_CellphoneImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2_EditInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ParametersEdit = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ModelEdit = new System.Windows.Forms.TextBox();
            this.textBox_CPUEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_OSEdit = new System.Windows.Forms.TextBox();
            this.textBox_PictureEdit = new System.Windows.Forms.TextBox();
            this.textBox_PriceEdit = new System.Windows.Forms.TextBox();
            this.checkedListBox_EditOptions = new System.Windows.Forms.CheckedListBox();
            this.button_SaveChanges = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_AddPhone = new System.Windows.Forms.Button();
            this.button_ClearFields = new System.Windows.Forms.Button();
            this.button_RemoveOption = new System.Windows.Forms.Button();
            this.button_AddOption = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_OptionName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox_PhonesList.SuspendLayout();
            this.tableLayoutPanel1_PhoneListButtons.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_CellphoneInfo.SuspendLayout();
            this.tableLayoutPanel2_PhoneInfo.SuspendLayout();
            this.panel1_CellphoneParameters.SuspendLayout();
            this.groupBox_Options.SuspendLayout();
            this.tableLayoutPanel3_PhoneParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CellphoneImage)).BeginInit();
            this.tabPage2_EditInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_ParametersEdit.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(3, 109);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 13);
            label3.TabIndex = 6;
            label3.Text = "  Picture";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(610, 518);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_PhonesList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1_PhoneListButtons);
            this.splitContainer2.Size = new System.Drawing.Size(258, 518);
            this.splitContainer2.SplitterDistance = 385;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox_PhonesList
            // 
            this.groupBox_PhonesList.Controls.Add(this.listBox_PhonesList);
            this.groupBox_PhonesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PhonesList.Location = new System.Drawing.Point(0, 0);
            this.groupBox_PhonesList.Name = "groupBox_PhonesList";
            this.groupBox_PhonesList.Size = new System.Drawing.Size(258, 385);
            this.groupBox_PhonesList.TabIndex = 0;
            this.groupBox_PhonesList.TabStop = false;
            this.groupBox_PhonesList.Text = "Cellphones List";
            // 
            // listBox_PhonesList
            // 
            this.listBox_PhonesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_PhonesList.FormattingEnabled = true;
            this.listBox_PhonesList.Location = new System.Drawing.Point(3, 16);
            this.listBox_PhonesList.Name = "listBox_PhonesList";
            this.listBox_PhonesList.Size = new System.Drawing.Size(252, 366);
            this.listBox_PhonesList.TabIndex = 0;
            this.listBox_PhonesList.SelectedIndexChanged += new System.EventHandler(this.listBox_PhonesList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1_PhoneListButtons
            // 
            this.tableLayoutPanel1_PhoneListButtons.ColumnCount = 2;
            this.tableLayoutPanel1_PhoneListButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_PhoneListButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_PhoneListButtons.Controls.Add(this.button_ReadFromFile, 1, 1);
            this.tableLayoutPanel1_PhoneListButtons.Controls.Add(this.button_SaveToFile, 0, 1);
            this.tableLayoutPanel1_PhoneListButtons.Controls.Add(this.button_ClearList, 1, 0);
            this.tableLayoutPanel1_PhoneListButtons.Controls.Add(this.button_DeleteCurrent, 0, 0);
            this.tableLayoutPanel1_PhoneListButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1_PhoneListButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1_PhoneListButtons.Name = "tableLayoutPanel1_PhoneListButtons";
            this.tableLayoutPanel1_PhoneListButtons.RowCount = 2;
            this.tableLayoutPanel1_PhoneListButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_PhoneListButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_PhoneListButtons.Size = new System.Drawing.Size(258, 129);
            this.tableLayoutPanel1_PhoneListButtons.TabIndex = 0;
            // 
            // button_ReadFromFile
            // 
            this.button_ReadFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ReadFromFile.ForeColor = System.Drawing.Color.DarkRed;
            this.button_ReadFromFile.Location = new System.Drawing.Point(132, 67);
            this.button_ReadFromFile.Name = "button_ReadFromFile";
            this.button_ReadFromFile.Size = new System.Drawing.Size(123, 59);
            this.button_ReadFromFile.TabIndex = 3;
            this.button_ReadFromFile.Text = "Read from file";
            this.button_ReadFromFile.UseVisualStyleBackColor = true;
            this.button_ReadFromFile.Click += new System.EventHandler(this.button_ReadFromFile_Click);
            // 
            // button_SaveToFile
            // 
            this.button_SaveToFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveToFile.ForeColor = System.Drawing.Color.DarkRed;
            this.button_SaveToFile.Location = new System.Drawing.Point(3, 67);
            this.button_SaveToFile.Name = "button_SaveToFile";
            this.button_SaveToFile.Size = new System.Drawing.Size(123, 59);
            this.button_SaveToFile.TabIndex = 2;
            this.button_SaveToFile.Text = "Save to file";
            this.button_SaveToFile.UseVisualStyleBackColor = true;
            this.button_SaveToFile.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // button_ClearList
            // 
            this.button_ClearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ClearList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_ClearList.Location = new System.Drawing.Point(132, 3);
            this.button_ClearList.Name = "button_ClearList";
            this.button_ClearList.Size = new System.Drawing.Size(123, 58);
            this.button_ClearList.TabIndex = 1;
            this.button_ClearList.Text = "Clear list";
            this.button_ClearList.UseVisualStyleBackColor = true;
            this.button_ClearList.Click += new System.EventHandler(this.button_ClearList_Click);
            // 
            // button_DeleteCurrent
            // 
            this.button_DeleteCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_DeleteCurrent.Location = new System.Drawing.Point(3, 3);
            this.button_DeleteCurrent.Name = "button_DeleteCurrent";
            this.button_DeleteCurrent.Size = new System.Drawing.Size(123, 58);
            this.button_DeleteCurrent.TabIndex = 0;
            this.button_DeleteCurrent.Text = "Delete current";
            this.button_DeleteCurrent.UseVisualStyleBackColor = true;
            this.button_DeleteCurrent.Click += new System.EventHandler(this.button_DeleteCurrent_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_CellphoneInfo);
            this.tabControl1.Controls.Add(this.tabPage2_EditInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_CellphoneInfo
            // 
            this.tabPage_CellphoneInfo.Controls.Add(this.tableLayoutPanel2_PhoneInfo);
            this.tabPage_CellphoneInfo.Controls.Add(this.label1);
            this.tabPage_CellphoneInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CellphoneInfo.Name = "tabPage_CellphoneInfo";
            this.tabPage_CellphoneInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CellphoneInfo.Size = new System.Drawing.Size(340, 492);
            this.tabPage_CellphoneInfo.TabIndex = 0;
            this.tabPage_CellphoneInfo.Text = "Cellphone Info";
            this.tabPage_CellphoneInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2_PhoneInfo
            // 
            this.tableLayoutPanel2_PhoneInfo.ColumnCount = 1;
            this.tableLayoutPanel2_PhoneInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2_PhoneInfo.Controls.Add(this.panel1_CellphoneParameters, 0, 2);
            this.tableLayoutPanel2_PhoneInfo.Controls.Add(this.tableLayoutPanel3_PhoneParameters, 0, 1);
            this.tableLayoutPanel2_PhoneInfo.Controls.Add(this.pictureBox_CellphoneImage, 0, 0);
            this.tableLayoutPanel2_PhoneInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2_PhoneInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2_PhoneInfo.Name = "tableLayoutPanel2_PhoneInfo";
            this.tableLayoutPanel2_PhoneInfo.RowCount = 3;
            this.tableLayoutPanel2_PhoneInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2_PhoneInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2_PhoneInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2_PhoneInfo.Size = new System.Drawing.Size(334, 486);
            this.tableLayoutPanel2_PhoneInfo.TabIndex = 2;
            // 
            // panel1_CellphoneParameters
            // 
            this.panel1_CellphoneParameters.Controls.Add(this.groupBox_Options);
            this.panel1_CellphoneParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_CellphoneParameters.Location = new System.Drawing.Point(3, 348);
            this.panel1_CellphoneParameters.Name = "panel1_CellphoneParameters";
            this.panel1_CellphoneParameters.Size = new System.Drawing.Size(328, 135);
            this.panel1_CellphoneParameters.TabIndex = 1;
            // 
            // groupBox_Options
            // 
            this.groupBox_Options.Controls.Add(this.listBox_Options);
            this.groupBox_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Options.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Options.Name = "groupBox_Options";
            this.groupBox_Options.Size = new System.Drawing.Size(328, 135);
            this.groupBox_Options.TabIndex = 0;
            this.groupBox_Options.TabStop = false;
            this.groupBox_Options.Text = "Options";
            // 
            // listBox_Options
            // 
            this.listBox_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Options.FormattingEnabled = true;
            this.listBox_Options.Location = new System.Drawing.Point(3, 16);
            this.listBox_Options.Name = "listBox_Options";
            this.listBox_Options.Size = new System.Drawing.Size(322, 116);
            this.listBox_Options.TabIndex = 1;
            // 
            // tableLayoutPanel3_PhoneParameters
            // 
            this.tableLayoutPanel3_PhoneParameters.ColumnCount = 2;
            this.tableLayoutPanel3_PhoneParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3_PhoneParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.label1_Model, 0, 0);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.label4_Price, 0, 3);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.textBox_Model, 1, 0);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.textBox_CPU, 0, 2);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.label2_OS, 0, 1);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.label3_CPU, 0, 2);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.textBox_OS, 0, 1);
            this.tableLayoutPanel3_PhoneParameters.Controls.Add(this.textBox_Price, 1, 3);
            this.tableLayoutPanel3_PhoneParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3_PhoneParameters.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel3_PhoneParameters.Name = "tableLayoutPanel3_PhoneParameters";
            this.tableLayoutPanel3_PhoneParameters.RowCount = 4;
            this.tableLayoutPanel3_PhoneParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3_PhoneParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3_PhoneParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3_PhoneParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3_PhoneParameters.Size = new System.Drawing.Size(328, 129);
            this.tableLayoutPanel3_PhoneParameters.TabIndex = 0;
            // 
            // label1_Model
            // 
            this.label1_Model.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1_Model.AutoSize = true;
            this.label1_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_Model.ForeColor = System.Drawing.Color.Blue;
            this.label1_Model.Location = new System.Drawing.Point(3, 9);
            this.label1_Model.Name = "label1_Model";
            this.label1_Model.Size = new System.Drawing.Size(49, 13);
            this.label1_Model.TabIndex = 0;
            this.label1_Model.Text = "  Model";
            // 
            // label4_Price
            // 
            this.label4_Price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4_Price.AutoSize = true;
            this.label4_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4_Price.Location = new System.Drawing.Point(3, 106);
            this.label4_Price.Name = "label4_Price";
            this.label4_Price.Size = new System.Drawing.Size(44, 13);
            this.label4_Price.TabIndex = 6;
            this.label4_Price.Text = "  Price";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Model.Location = new System.Drawing.Point(134, 6);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(191, 20);
            this.textBox_Model.TabIndex = 1;
            // 
            // textBox_CPU
            // 
            this.textBox_CPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_CPU.Location = new System.Drawing.Point(134, 70);
            this.textBox_CPU.Name = "textBox_CPU";
            this.textBox_CPU.Size = new System.Drawing.Size(191, 20);
            this.textBox_CPU.TabIndex = 5;
            // 
            // label2_OS
            // 
            this.label2_OS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2_OS.AutoSize = true;
            this.label2_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_OS.ForeColor = System.Drawing.Color.Blue;
            this.label2_OS.Location = new System.Drawing.Point(3, 41);
            this.label2_OS.Name = "label2_OS";
            this.label2_OS.Size = new System.Drawing.Size(32, 13);
            this.label2_OS.TabIndex = 2;
            this.label2_OS.Text = "  OS";
            // 
            // label3_CPU
            // 
            this.label3_CPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3_CPU.AutoSize = true;
            this.label3_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_CPU.ForeColor = System.Drawing.Color.Blue;
            this.label3_CPU.Location = new System.Drawing.Point(3, 73);
            this.label3_CPU.Name = "label3_CPU";
            this.label3_CPU.Size = new System.Drawing.Size(40, 13);
            this.label3_CPU.TabIndex = 4;
            this.label3_CPU.Text = "  CPU";
            // 
            // textBox_OS
            // 
            this.textBox_OS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OS.Location = new System.Drawing.Point(134, 38);
            this.textBox_OS.Name = "textBox_OS";
            this.textBox_OS.Size = new System.Drawing.Size(191, 20);
            this.textBox_OS.TabIndex = 3;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Price.Location = new System.Drawing.Point(134, 102);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(191, 20);
            this.textBox_Price.TabIndex = 7;
            // 
            // pictureBox_CellphoneImage
            // 
            this.pictureBox_CellphoneImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CellphoneImage.ErrorImage = global::MobilePhoneShop.Properties.Resources.defaultPhone;
            this.pictureBox_CellphoneImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_CellphoneImage.Name = "pictureBox_CellphoneImage";
            this.pictureBox_CellphoneImage.Size = new System.Drawing.Size(328, 204);
            this.pictureBox_CellphoneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CellphoneImage.TabIndex = 0;
            this.pictureBox_CellphoneImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tabPage2_EditInfo
            // 
            this.tabPage2_EditInfo.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2_EditInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_EditInfo.Name = "tabPage2_EditInfo";
            this.tabPage2_EditInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_EditInfo.Size = new System.Drawing.Size(340, 492);
            this.tabPage2_EditInfo.TabIndex = 1;
            this.tabPage2_EditInfo.Text = "Edit Info";
            this.tabPage2_EditInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_ParametersEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox_EditOptions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_SaveChanges, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.9633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.90826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.522936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.23853F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel_ParametersEdit
            // 
            this.tableLayoutPanel_ParametersEdit.ColumnCount = 2;
            this.tableLayoutPanel_ParametersEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_ParametersEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(label3, 0, 3);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.textBox_ModelEdit, 1, 0);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.textBox_CPUEdit, 0, 2);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.textBox_OSEdit, 0, 1);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.textBox_PictureEdit, 1, 3);
            this.tableLayoutPanel_ParametersEdit.Controls.Add(this.textBox_PriceEdit, 1, 4);
            this.tableLayoutPanel_ParametersEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ParametersEdit.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ParametersEdit.Name = "tableLayoutPanel_ParametersEdit";
            this.tableLayoutPanel_ParametersEdit.RowCount = 5;
            this.tableLayoutPanel_ParametersEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ParametersEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ParametersEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ParametersEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ParametersEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_ParametersEdit.Size = new System.Drawing.Size(328, 169);
            this.tableLayoutPanel_ParametersEdit.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "  Price";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "  Model";
            // 
            // textBox_ModelEdit
            // 
            this.textBox_ModelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ModelEdit.Location = new System.Drawing.Point(134, 6);
            this.textBox_ModelEdit.Name = "textBox_ModelEdit";
            this.textBox_ModelEdit.Size = new System.Drawing.Size(191, 20);
            this.textBox_ModelEdit.TabIndex = 1;
            // 
            // textBox_CPUEdit
            // 
            this.textBox_CPUEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_CPUEdit.Location = new System.Drawing.Point(134, 72);
            this.textBox_CPUEdit.Name = "textBox_CPUEdit";
            this.textBox_CPUEdit.Size = new System.Drawing.Size(191, 20);
            this.textBox_CPUEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "  OS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "  CPU";
            // 
            // textBox_OSEdit
            // 
            this.textBox_OSEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OSEdit.Location = new System.Drawing.Point(134, 39);
            this.textBox_OSEdit.Name = "textBox_OSEdit";
            this.textBox_OSEdit.Size = new System.Drawing.Size(191, 20);
            this.textBox_OSEdit.TabIndex = 3;
            // 
            // textBox_PictureEdit
            // 
            this.textBox_PictureEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PictureEdit.Location = new System.Drawing.Point(134, 105);
            this.textBox_PictureEdit.Name = "textBox_PictureEdit";
            this.textBox_PictureEdit.Size = new System.Drawing.Size(191, 20);
            this.textBox_PictureEdit.TabIndex = 7;
            // 
            // textBox_PriceEdit
            // 
            this.textBox_PriceEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PriceEdit.Location = new System.Drawing.Point(134, 140);
            this.textBox_PriceEdit.Name = "textBox_PriceEdit";
            this.textBox_PriceEdit.Size = new System.Drawing.Size(191, 20);
            this.textBox_PriceEdit.TabIndex = 9;
            // 
            // checkedListBox_EditOptions
            // 
            this.checkedListBox_EditOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_EditOptions.FormattingEnabled = true;
            this.checkedListBox_EditOptions.Location = new System.Drawing.Point(3, 178);
            this.checkedListBox_EditOptions.Name = "checkedListBox_EditOptions";
            this.checkedListBox_EditOptions.Size = new System.Drawing.Size(328, 139);
            this.checkedListBox_EditOptions.TabIndex = 2;
            this.checkedListBox_EditOptions.ThreeDCheckBoxes = true;
            this.checkedListBox_EditOptions.Click += new System.EventHandler(this.checkedListBox_EditOptions_Click);
            // 
            // button_SaveChanges
            // 
            this.button_SaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveChanges.ForeColor = System.Drawing.Color.Maroon;
            this.button_SaveChanges.Location = new System.Drawing.Point(3, 323);
            this.button_SaveChanges.Name = "button_SaveChanges";
            this.button_SaveChanges.Size = new System.Drawing.Size(328, 30);
            this.button_SaveChanges.TabIndex = 3;
            this.button_SaveChanges.Text = "Save Changes";
            this.button_SaveChanges.UseVisualStyleBackColor = true;
            this.button_SaveChanges.Click += new System.EventHandler(this.button_SaveChanges_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_AddPhone, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_ClearFields, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_RemoveOption, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_AddOption, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_OptionName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 359);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 124);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // button_AddPhone
            // 
            this.button_AddPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddPhone.ForeColor = System.Drawing.Color.Red;
            this.button_AddPhone.Location = new System.Drawing.Point(167, 85);
            this.button_AddPhone.Name = "button_AddPhone";
            this.button_AddPhone.Size = new System.Drawing.Size(158, 36);
            this.button_AddPhone.TabIndex = 7;
            this.button_AddPhone.Text = "Add cellphone";
            this.button_AddPhone.UseVisualStyleBackColor = true;
            this.button_AddPhone.Click += new System.EventHandler(this.button_AddPhone_Click);
            // 
            // button_ClearFields
            // 
            this.button_ClearFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ClearFields.ForeColor = System.Drawing.Color.Red;
            this.button_ClearFields.Location = new System.Drawing.Point(3, 85);
            this.button_ClearFields.Name = "button_ClearFields";
            this.button_ClearFields.Size = new System.Drawing.Size(158, 36);
            this.button_ClearFields.TabIndex = 6;
            this.button_ClearFields.Text = "Clear fields";
            this.button_ClearFields.UseVisualStyleBackColor = true;
            this.button_ClearFields.Click += new System.EventHandler(this.button_ClearFields_Click);
            // 
            // button_RemoveOption
            // 
            this.button_RemoveOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RemoveOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RemoveOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_RemoveOption.Location = new System.Drawing.Point(167, 44);
            this.button_RemoveOption.Name = "button_RemoveOption";
            this.button_RemoveOption.Size = new System.Drawing.Size(158, 35);
            this.button_RemoveOption.TabIndex = 5;
            this.button_RemoveOption.Text = "Remove option";
            this.button_RemoveOption.UseVisualStyleBackColor = true;
            this.button_RemoveOption.Click += new System.EventHandler(this.button_RemoveOption_Click);
            // 
            // button_AddOption
            // 
            this.button_AddOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_AddOption.Location = new System.Drawing.Point(3, 44);
            this.button_AddOption.Name = "button_AddOption";
            this.button_AddOption.Size = new System.Drawing.Size(158, 35);
            this.button_AddOption.TabIndex = 4;
            this.button_AddOption.Text = "Add option";
            this.button_AddOption.UseVisualStyleBackColor = true;
            this.button_AddOption.Click += new System.EventHandler(this.button_AddOption_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "  Option Name";
            // 
            // textBox_OptionName
            // 
            this.textBox_OptionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OptionName.Location = new System.Drawing.Point(167, 10);
            this.textBox_OptionName.Name = "textBox_OptionName";
            this.textBox_OptionName.Size = new System.Drawing.Size(158, 20);
            this.textBox_OptionName.TabIndex = 1;
            // 
            // PhoneShop_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 518);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneShop_MainForm";
            this.Text = "Cellphone Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox_PhonesList.ResumeLayout(false);
            this.tableLayoutPanel1_PhoneListButtons.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_CellphoneInfo.ResumeLayout(false);
            this.tabPage_CellphoneInfo.PerformLayout();
            this.tableLayoutPanel2_PhoneInfo.ResumeLayout(false);
            this.panel1_CellphoneParameters.ResumeLayout(false);
            this.groupBox_Options.ResumeLayout(false);
            this.tableLayoutPanel3_PhoneParameters.ResumeLayout(false);
            this.tableLayoutPanel3_PhoneParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CellphoneImage)).EndInit();
            this.tabPage2_EditInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel_ParametersEdit.ResumeLayout(false);
            this.tableLayoutPanel_ParametersEdit.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1_PhoneListButtons;
        private System.Windows.Forms.GroupBox groupBox_PhonesList;
        private System.Windows.Forms.Button button_ReadFromFile;
        private System.Windows.Forms.Button button_SaveToFile;
        private System.Windows.Forms.Button button_ClearList;
        private System.Windows.Forms.Button button_DeleteCurrent;
        private System.Windows.Forms.ListBox listBox_PhonesList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2_EditInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ParametersEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ModelEdit;
        private System.Windows.Forms.TextBox textBox_CPUEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_OSEdit;
        private System.Windows.Forms.TextBox textBox_PictureEdit;
        private System.Windows.Forms.TextBox textBox_PriceEdit;
        private System.Windows.Forms.CheckedListBox checkedListBox_EditOptions;
        private System.Windows.Forms.Button button_SaveChanges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_AddPhone;
        private System.Windows.Forms.Button button_ClearFields;
        private System.Windows.Forms.Button button_RemoveOption;
        private System.Windows.Forms.Button button_AddOption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_OptionName;
        private System.Windows.Forms.TabPage tabPage_CellphoneInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2_PhoneInfo;
        private System.Windows.Forms.Panel panel1_CellphoneParameters;
        private System.Windows.Forms.GroupBox groupBox_Options;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3_PhoneParameters;
        private System.Windows.Forms.Label label1_Model;
        private System.Windows.Forms.Label label4_Price;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_CPU;
        private System.Windows.Forms.Label label2_OS;
        private System.Windows.Forms.Label label3_CPU;
        private System.Windows.Forms.TextBox textBox_OS;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.PictureBox pictureBox_CellphoneImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Options;
    }
}

