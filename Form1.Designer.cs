
namespace DriverLogProject
{
    partial class DriverDatabaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage1TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleList = new System.Windows.Forms.ComboBox();
            this.activateVehicle = new System.Windows.Forms.Button();
            this.driverLogTable = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.selectDateButton = new System.Windows.Forms.Button();
            this.logDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleSumList = new System.Windows.Forms.CheckedListBox();
            this.dataBox1 = new System.Windows.Forms.TextBox();
            this.dataBox2 = new System.Windows.Forms.TextBox();
            this.dataBox3 = new System.Windows.Forms.TextBox();
            this.dataBox4 = new System.Windows.Forms.TextBox();
            this.dataBox5 = new System.Windows.Forms.TextBox();
            this.dataSummaryButton = new System.Windows.Forms.Button();
            this.dateSummary1 = new System.Windows.Forms.DateTimePicker();
            this.dateSummary2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataBox6 = new System.Windows.Forms.TextBox();
            this.dataBox7 = new System.Windows.Forms.TextBox();
            this.dataBox11 = new System.Windows.Forms.TextBox();
            this.dataBox12 = new System.Windows.Forms.TextBox();
            this.dataBox8 = new System.Windows.Forms.TextBox();
            this.dataBox9 = new System.Windows.Forms.TextBox();
            this.dataBox10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataBox13 = new System.Windows.Forms.TextBox();
            this.dataBox14 = new System.Windows.Forms.TextBox();
            this.dataBox15 = new System.Windows.Forms.TextBox();
            this.dataBox16 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnDemand = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PickDeliverBoth = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OnTime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ArriveTime = new DriverLogProject.DriverDatabaseForm.CalendarColumn();
            this.ArriveActualDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveActualTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartTime = new DriverLogProject.DriverDatabaseForm.CalendarColumn();
            this.PiecesPicked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupUtilization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiecesDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryUtilization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage1TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverLogTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsMenu
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddVehicle});
            this.actionsMenu.Name = "actionsMenu";
            this.actionsMenu.Size = new System.Drawing.Size(87, 29);
            this.actionsMenu.Text = "Actions";
            // 
            // menuAddVehicle
            // 
            this.menuAddVehicle.Name = "menuAddVehicle";
            this.menuAddVehicle.Size = new System.Drawing.Size(247, 34);
            this.menuAddVehicle.Text = "Add New Vehicle";
            this.menuAddVehicle.Click += new System.EventHandler(this.MenuAddVehicle_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1180, 502);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPage1TablePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1172, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicle Handler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage1TablePanel
            // 
            this.tabPage1TablePanel.ColumnCount = 6;
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabPage1TablePanel.Controls.Add(this.VehicleList, 0, 0);
            this.tabPage1TablePanel.Controls.Add(this.activateVehicle, 1, 0);
            this.tabPage1TablePanel.Controls.Add(this.driverLogTable, 0, 2);
            this.tabPage1TablePanel.Controls.Add(this.dateTimePicker1, 3, 0);
            this.tabPage1TablePanel.Controls.Add(this.selectDateButton, 4, 0);
            this.tabPage1TablePanel.Controls.Add(this.logDataButton, 0, 3);
            this.tabPage1TablePanel.Controls.Add(this.label1, 2, 3);
            this.tabPage1TablePanel.Controls.Add(this.updateButton, 1, 3);
            this.tabPage1TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1TablePanel.Location = new System.Drawing.Point(0, 0);
            this.tabPage1TablePanel.Name = "tabPage1TablePanel";
            this.tabPage1TablePanel.RowCount = 4;
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tabPage1TablePanel.Size = new System.Drawing.Size(1172, 469);
            this.tabPage1TablePanel.TabIndex = 3;
            // 
            // VehicleList
            // 
            this.VehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleList.FormattingEnabled = true;
            this.VehicleList.Location = new System.Drawing.Point(3, 3);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.Size = new System.Drawing.Size(189, 28);
            this.VehicleList.TabIndex = 1;
            this.VehicleList.SelectedIndexChanged += new System.EventHandler(this.VehicleList_SelectedIndexChanged);
            // 
            // activateVehicle
            // 
            this.activateVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activateVehicle.Location = new System.Drawing.Point(198, 3);
            this.activateVehicle.Name = "activateVehicle";
            this.activateVehicle.Size = new System.Drawing.Size(189, 29);
            this.activateVehicle.TabIndex = 2;
            this.activateVehicle.Text = "Set Active Vechicle";
            this.activateVehicle.UseVisualStyleBackColor = true;
            this.activateVehicle.Click += new System.EventHandler(this.activateVehicle_Click);
            // 
            // driverLogTable
            // 
            this.driverLogTable.AllowUserToDeleteRows = false;
            this.driverLogTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverLogTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.VehicleName,
            this.Building,
            this.OnDemand,
            this.PickDeliverBoth,
            this.OnTime,
            this.ArriveTime,
            this.ArriveActualDate,
            this.ArriveActualTime,
            this.DepartTime,
            this.PiecesPicked,
            this.PickupUtilization,
            this.PiecesDelivered,
            this.DeliveryUtilization,
            this.Date,
            this.VehicleDate});
            this.tabPage1TablePanel.SetColumnSpan(this.driverLogTable, 10);
            this.driverLogTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverLogTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.driverLogTable.Location = new System.Drawing.Point(3, 49);
            this.driverLogTable.Name = "driverLogTable";
            this.driverLogTable.RowHeadersVisible = false;
            this.driverLogTable.RowHeadersWidth = 62;
            this.driverLogTable.RowTemplate.Height = 28;
            this.driverLogTable.Size = new System.Drawing.Size(1166, 382);
            this.driverLogTable.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // selectDateButton
            // 
            this.selectDateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDateButton.Location = new System.Drawing.Point(783, 3);
            this.selectDateButton.Name = "selectDateButton";
            this.selectDateButton.Size = new System.Drawing.Size(189, 29);
            this.selectDateButton.TabIndex = 5;
            this.selectDateButton.Text = "Select Date";
            this.selectDateButton.UseVisualStyleBackColor = true;
            this.selectDateButton.Click += new System.EventHandler(this.selectDateButton_Click);
            // 
            // logDataButton
            // 
            this.logDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDataButton.Location = new System.Drawing.Point(3, 437);
            this.logDataButton.Name = "logDataButton";
            this.logDataButton.Size = new System.Drawing.Size(189, 29);
            this.logDataButton.TabIndex = 6;
            this.logDataButton.Text = "Log Data";
            this.logDataButton.UseVisualStyleBackColor = true;
            this.logDataButton.Click += new System.EventHandler(this.logDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tabPage1TablePanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(393, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Square: Not Relevant, Empty: Not On Time, Check: On Time";
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Location = new System.Drawing.Point(198, 437);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(189, 29);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update Existing";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1172, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Summary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.VehicleSumList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataBox3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataBox4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataBox5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataSummaryButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateSummary1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateSummary2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dataBox6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataBox7, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.dataBox11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataBox12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataBox8, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.dataBox9, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.dataBox10, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label12, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataBox13, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataBox14, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataBox15, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataBox16, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // VehicleSumList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.VehicleSumList, 2);
            this.VehicleSumList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleSumList.FormattingEnabled = true;
            this.VehicleSumList.Location = new System.Drawing.Point(3, 3);
            this.VehicleSumList.Name = "VehicleSumList";
            this.tableLayoutPanel1.SetRowSpan(this.VehicleSumList, 5);
            this.VehicleSumList.Size = new System.Drawing.Size(462, 224);
            this.VehicleSumList.TabIndex = 0;
            // 
            // dataBox1
            // 
            this.dataBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox1.Location = new System.Drawing.Point(471, 10);
            this.dataBox1.Name = "dataBox1";
            this.dataBox1.ReadOnly = true;
            this.dataBox1.Size = new System.Drawing.Size(111, 26);
            this.dataBox1.TabIndex = 2;
            // 
            // dataBox2
            // 
            this.dataBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox2.Location = new System.Drawing.Point(471, 56);
            this.dataBox2.Name = "dataBox2";
            this.dataBox2.ReadOnly = true;
            this.dataBox2.Size = new System.Drawing.Size(111, 26);
            this.dataBox2.TabIndex = 3;
            // 
            // dataBox3
            // 
            this.dataBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox3.Location = new System.Drawing.Point(471, 102);
            this.dataBox3.Name = "dataBox3";
            this.dataBox3.ReadOnly = true;
            this.dataBox3.Size = new System.Drawing.Size(111, 26);
            this.dataBox3.TabIndex = 4;
            // 
            // dataBox4
            // 
            this.dataBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox4.Location = new System.Drawing.Point(471, 148);
            this.dataBox4.Name = "dataBox4";
            this.dataBox4.ReadOnly = true;
            this.dataBox4.Size = new System.Drawing.Size(111, 26);
            this.dataBox4.TabIndex = 5;
            // 
            // dataBox5
            // 
            this.dataBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox5.Location = new System.Drawing.Point(471, 194);
            this.dataBox5.Name = "dataBox5";
            this.dataBox5.ReadOnly = true;
            this.dataBox5.Size = new System.Drawing.Size(111, 26);
            this.dataBox5.TabIndex = 6;
            // 
            // dataSummaryButton
            // 
            this.dataSummaryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSummaryButton.Location = new System.Drawing.Point(3, 279);
            this.dataSummaryButton.Name = "dataSummaryButton";
            this.dataSummaryButton.Size = new System.Drawing.Size(228, 40);
            this.dataSummaryButton.TabIndex = 1;
            this.dataSummaryButton.Text = "Load Summary";
            this.dataSummaryButton.UseVisualStyleBackColor = true;
            this.dataSummaryButton.Click += new System.EventHandler(this.dataSummaryButton_Click);
            // 
            // dateSummary1
            // 
            this.dateSummary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateSummary1.Location = new System.Drawing.Point(3, 233);
            this.dateSummary1.Name = "dateSummary1";
            this.dateSummary1.Size = new System.Drawing.Size(228, 26);
            this.dateSummary1.TabIndex = 7;
            // 
            // dateSummary2
            // 
            this.dateSummary2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateSummary2.Location = new System.Drawing.Point(237, 233);
            this.dateSummary2.Name = "dateSummary2";
            this.dateSummary2.Size = new System.Drawing.Size(228, 26);
            this.dateSummary2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total of all Trip types";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Scheduled Trips";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Scheduled Pickup Trips";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Scheduled Delivery Trips";
            // 
            // dataBox6
            // 
            this.dataBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox6.Location = new System.Drawing.Point(471, 240);
            this.dataBox6.Name = "dataBox6";
            this.dataBox6.ReadOnly = true;
            this.dataBox6.Size = new System.Drawing.Size(111, 26);
            this.dataBox6.TabIndex = 16;
            // 
            // dataBox7
            // 
            this.dataBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox7.Location = new System.Drawing.Point(471, 286);
            this.dataBox7.Name = "dataBox7";
            this.dataBox7.ReadOnly = true;
            this.dataBox7.Size = new System.Drawing.Size(111, 26);
            this.dataBox7.TabIndex = 17;
            // 
            // dataBox11
            // 
            this.dataBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox11.Location = new System.Drawing.Point(822, 10);
            this.dataBox11.Name = "dataBox11";
            this.dataBox11.ReadOnly = true;
            this.dataBox11.Size = new System.Drawing.Size(111, 26);
            this.dataBox11.TabIndex = 18;
            // 
            // dataBox12
            // 
            this.dataBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox12.Location = new System.Drawing.Point(822, 56);
            this.dataBox12.Name = "dataBox12";
            this.dataBox12.ReadOnly = true;
            this.dataBox12.Size = new System.Drawing.Size(111, 26);
            this.dataBox12.TabIndex = 19;
            // 
            // dataBox8
            // 
            this.dataBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox8.Location = new System.Drawing.Point(471, 332);
            this.dataBox8.Name = "dataBox8";
            this.dataBox8.ReadOnly = true;
            this.dataBox8.Size = new System.Drawing.Size(111, 26);
            this.dataBox8.TabIndex = 22;
            // 
            // dataBox9
            // 
            this.dataBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox9.Location = new System.Drawing.Point(471, 378);
            this.dataBox9.Name = "dataBox9";
            this.dataBox9.ReadOnly = true;
            this.dataBox9.Size = new System.Drawing.Size(111, 26);
            this.dataBox9.TabIndex = 21;
            // 
            // dataBox10
            // 
            this.dataBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox10.Location = new System.Drawing.Point(471, 427);
            this.dataBox10.Name = "dataBox10";
            this.dataBox10.ReadOnly = true;
            this.dataBox10.Size = new System.Drawing.Size(111, 26);
            this.dataBox10.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Pickup Trips";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Delivery Trips";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total On-Time Scheduled Trips";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 40);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total Late/Early Scheduled Trips";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 40);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total Late/Early Scheduled Pickups";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(588, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 40);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total Late/Early Scheduled Deliveries";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(939, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Utilization of Pickup Trips";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(939, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Utilization of Pickup Trips";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(939, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(230, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total Picked Up Items";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(939, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(230, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total Delivery Items";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(939, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(230, 40);
            this.label16.TabIndex = 30;
            this.label16.Text = "% of Scheduled Pickup Trips that are On-Time";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(939, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(230, 40);
            this.label17.TabIndex = 31;
            this.label17.Text = "% of Scheduled Delivery Trips that are On-Time";
            // 
            // dataBox13
            // 
            this.dataBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox13.Location = new System.Drawing.Point(822, 102);
            this.dataBox13.Name = "dataBox13";
            this.dataBox13.ReadOnly = true;
            this.dataBox13.Size = new System.Drawing.Size(111, 26);
            this.dataBox13.TabIndex = 32;
            // 
            // dataBox14
            // 
            this.dataBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox14.Location = new System.Drawing.Point(822, 148);
            this.dataBox14.Name = "dataBox14";
            this.dataBox14.ReadOnly = true;
            this.dataBox14.Size = new System.Drawing.Size(111, 26);
            this.dataBox14.TabIndex = 33;
            // 
            // dataBox15
            // 
            this.dataBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox15.Location = new System.Drawing.Point(822, 194);
            this.dataBox15.Name = "dataBox15";
            this.dataBox15.ReadOnly = true;
            this.dataBox15.Size = new System.Drawing.Size(111, 26);
            this.dataBox15.TabIndex = 34;
            // 
            // dataBox16
            // 
            this.dataBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox16.Location = new System.Drawing.Point(822, 240);
            this.dataBox16.Name = "dataBox16";
            this.dataBox16.ReadOnly = true;
            this.dataBox16.Size = new System.Drawing.Size(111, 26);
            this.dataBox16.TabIndex = 35;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // VehicleName
            // 
            this.VehicleName.HeaderText = "Vehicle Name";
            this.VehicleName.MinimumWidth = 8;
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.Visible = false;
            this.VehicleName.Width = 50;
            // 
            // Building
            // 
            this.Building.DataPropertyName = "Building";
            this.Building.HeaderText = "Building";
            this.Building.MinimumWidth = 8;
            this.Building.Name = "Building";
            this.Building.Width = 50;
            // 
            // OnDemand
            // 
            this.OnDemand.DataPropertyName = "OnDemand";
            this.OnDemand.HeaderText = "On-Demand";
            this.OnDemand.Items.AddRange(new object[] {
            "N",
            "Y"});
            this.OnDemand.MinimumWidth = 8;
            this.OnDemand.Name = "OnDemand";
            this.OnDemand.Width = 70;
            // 
            // PickDeliverBoth
            // 
            this.PickDeliverBoth.DataPropertyName = "PickDeliverBoth";
            this.PickDeliverBoth.HeaderText = "Pickup/Delivery/Both";
            this.PickDeliverBoth.Items.AddRange(new object[] {
            "",
            "P",
            "D",
            "B"});
            this.PickDeliverBoth.MinimumWidth = 8;
            this.PickDeliverBoth.Name = "PickDeliverBoth";
            this.PickDeliverBoth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PickDeliverBoth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OnTime
            // 
            this.OnTime.DataPropertyName = "OnTime";
            this.OnTime.FalseValue = "1";
            this.OnTime.HeaderText = "On Time?";
            this.OnTime.IndeterminateValue = "0";
            this.OnTime.MinimumWidth = 8;
            this.OnTime.Name = "OnTime";
            this.OnTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OnTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OnTime.ThreeState = true;
            this.OnTime.TrueValue = "2";
            this.OnTime.Width = 70;
            // 
            // ArriveTime
            // 
            this.ArriveTime.DataPropertyName = "ArriveTime";
            dataGridViewCellStyle1.NullValue = null;
            this.ArriveTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.ArriveTime.HeaderText = "Arrival Time";
            this.ArriveTime.MinimumWidth = 8;
            this.ArriveTime.Name = "ArriveTime";
            this.ArriveTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ArriveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ArriveActualDate
            // 
            this.ArriveActualDate.HeaderText = "ArriveActualDate";
            this.ArriveActualDate.MinimumWidth = 8;
            this.ArriveActualDate.Name = "ArriveActualDate";
            this.ArriveActualDate.Visible = false;
            this.ArriveActualDate.Width = 150;
            // 
            // ArriveActualTime
            // 
            this.ArriveActualTime.HeaderText = "ArriveActualTime";
            this.ArriveActualTime.MinimumWidth = 8;
            this.ArriveActualTime.Name = "ArriveActualTime";
            this.ArriveActualTime.Visible = false;
            this.ArriveActualTime.Width = 150;
            // 
            // DepartTime
            // 
            this.DepartTime.DataPropertyName = "DepartTime";
            dataGridViewCellStyle2.NullValue = null;
            this.DepartTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.DepartTime.HeaderText = "Departure Time";
            this.DepartTime.MinimumWidth = 8;
            this.DepartTime.Name = "DepartTime";
            this.DepartTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PiecesPicked
            // 
            this.PiecesPicked.DataPropertyName = "PiecesPicked";
            this.PiecesPicked.HeaderText = "Pieces Pickedup";
            this.PiecesPicked.MinimumWidth = 8;
            this.PiecesPicked.Name = "PiecesPicked";
            this.PiecesPicked.Width = 60;
            // 
            // PickupUtilization
            // 
            this.PickupUtilization.DataPropertyName = "PickupUtilization";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.PickupUtilization.DefaultCellStyle = dataGridViewCellStyle3;
            this.PickupUtilization.HeaderText = "Pickup Utilization";
            this.PickupUtilization.MinimumWidth = 8;
            this.PickupUtilization.Name = "PickupUtilization";
            this.PickupUtilization.Width = 60;
            // 
            // PiecesDelivered
            // 
            this.PiecesDelivered.DataPropertyName = "PiecesDelivered";
            this.PiecesDelivered.HeaderText = "Pieces Delivered";
            this.PiecesDelivered.MinimumWidth = 8;
            this.PiecesDelivered.Name = "PiecesDelivered";
            this.PiecesDelivered.Width = 60;
            // 
            // DeliveryUtilization
            // 
            this.DeliveryUtilization.DataPropertyName = "DeliveryUtilization";
            dataGridViewCellStyle4.Format = "N0";
            this.DeliveryUtilization.DefaultCellStyle = dataGridViewCellStyle4;
            this.DeliveryUtilization.HeaderText = "Delivery Utilization";
            this.DeliveryUtilization.MinimumWidth = 8;
            this.DeliveryUtilization.Name = "DeliveryUtilization";
            this.DeliveryUtilization.Width = 60;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "LoggingDate";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Visible = false;
            this.Date.Width = 150;
            // 
            // VehicleDate
            // 
            this.VehicleDate.HeaderText = "Vehicle Date";
            this.VehicleDate.MinimumWidth = 8;
            this.VehicleDate.Name = "VehicleDate";
            this.VehicleDate.Visible = false;
            this.VehicleDate.Width = 150;
            // 
            // DriverDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 535);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DriverDatabaseForm";
            this.Text = "Driver Database";
            this.Load += new System.EventHandler(this.DriverDatabaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1TablePanel.ResumeLayout(false);
            this.tabPage1TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverLogTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAddVehicle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox VehicleList;
        private System.Windows.Forms.Button activateVehicle;
        private System.Windows.Forms.TableLayoutPanel tabPage1TablePanel;
        private System.Windows.Forms.DataGridView driverLogTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox VehicleSumList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button selectDateButton;
        private System.Windows.Forms.Button logDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button dataSummaryButton;
        private System.Windows.Forms.TextBox dataBox1;
        private System.Windows.Forms.TextBox dataBox2;
        private System.Windows.Forms.TextBox dataBox3;
        private System.Windows.Forms.TextBox dataBox4;
        private System.Windows.Forms.TextBox dataBox5;
        private System.Windows.Forms.DateTimePicker dateSummary1;
        private System.Windows.Forms.DateTimePicker dateSummary2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dataBox6;
        private System.Windows.Forms.TextBox dataBox7;
        private System.Windows.Forms.TextBox dataBox11;
        private System.Windows.Forms.TextBox dataBox12;
        private System.Windows.Forms.TextBox dataBox8;
        private System.Windows.Forms.TextBox dataBox9;
        private System.Windows.Forms.TextBox dataBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dataBox13;
        private System.Windows.Forms.TextBox dataBox14;
        private System.Windows.Forms.TextBox dataBox15;
        private System.Windows.Forms.TextBox dataBox16;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewComboBoxColumn OnDemand;
        private System.Windows.Forms.DataGridViewComboBoxColumn PickDeliverBoth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnTime;
        private CalendarColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveActualDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveActualTime;
        private CalendarColumn DepartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiecesPicked;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupUtilization;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiecesDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryUtilization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleDate;
    }
}

