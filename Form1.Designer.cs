
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleSumList = new System.Windows.Forms.CheckedListBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnDemand = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ArriveDepart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OnTime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ArriveTime = new DriverLogProject.DriverDatabaseForm.CalendarColumn();
            this.ArriveActualDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveActualTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartTime = new DriverLogProject.DriverDatabaseForm.CalendarColumn();
            this.Pieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1144, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsMenu
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddVehicle});
            this.actionsMenu.Name = "actionsMenu";
            this.actionsMenu.Size = new System.Drawing.Size(87, 30);
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
            this.tabControl.Location = new System.Drawing.Point(0, 36);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1144, 499);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPage1TablePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1136, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicle Handler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage1TablePanel
            // 
            this.tabPage1TablePanel.ColumnCount = 6;
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
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
            this.tabPage1TablePanel.Size = new System.Drawing.Size(1136, 466);
            this.tabPage1TablePanel.TabIndex = 3;
            // 
            // VehicleList
            // 
            this.VehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleList.FormattingEnabled = true;
            this.VehicleList.Location = new System.Drawing.Point(3, 3);
            this.VehicleList.Name = "VehicleList";
            this.VehicleList.Size = new System.Drawing.Size(171, 28);
            this.VehicleList.TabIndex = 1;
            this.VehicleList.SelectedIndexChanged += new System.EventHandler(this.VehicleList_SelectedIndexChanged);
            // 
            // activateVehicle
            // 
            this.activateVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activateVehicle.Location = new System.Drawing.Point(180, 3);
            this.activateVehicle.Name = "activateVehicle";
            this.activateVehicle.Size = new System.Drawing.Size(167, 29);
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
            this.Building,
            this.OnDemand,
            this.ArriveDepart,
            this.OnTime,
            this.ArriveTime,
            this.ArriveActualDate,
            this.ArriveActualTime,
            this.DepartTime,
            this.Pieces,
            this.Utilization,
            this.Date,
            this.VehicleDate});
            this.tabPage1TablePanel.SetColumnSpan(this.driverLogTable, 5);
            this.driverLogTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverLogTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.driverLogTable.Location = new System.Drawing.Point(3, 49);
            this.driverLogTable.Name = "driverLogTable";
            this.driverLogTable.RowHeadersVisible = false;
            this.driverLogTable.RowHeadersWidth = 62;
            this.driverLogTable.RowTemplate.Height = 28;
            this.driverLogTable.Size = new System.Drawing.Size(924, 379);
            this.driverLogTable.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(503, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // selectDateButton
            // 
            this.selectDateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDateButton.Location = new System.Drawing.Point(703, 3);
            this.selectDateButton.Name = "selectDateButton";
            this.selectDateButton.Size = new System.Drawing.Size(224, 29);
            this.selectDateButton.TabIndex = 5;
            this.selectDateButton.Text = "Select Date";
            this.selectDateButton.UseVisualStyleBackColor = true;
            this.selectDateButton.Click += new System.EventHandler(this.selectDateButton_Click);
            // 
            // logDataButton
            // 
            this.logDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDataButton.Location = new System.Drawing.Point(3, 434);
            this.logDataButton.Name = "logDataButton";
            this.logDataButton.Size = new System.Drawing.Size(171, 29);
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
            this.label1.Location = new System.Drawing.Point(353, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Square: Not Relevant, Empty: Not On Time, Check: On Time";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1136, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Summary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.39789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.60211F));
            this.tableLayoutPanel1.Controls.Add(this.VehicleSumList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // VehicleSumList
            // 
            this.VehicleSumList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleSumList.FormattingEnabled = true;
            this.VehicleSumList.Location = new System.Drawing.Point(3, 3);
            this.VehicleSumList.Name = "VehicleSumList";
            this.VehicleSumList.Size = new System.Drawing.Size(203, 227);
            this.VehicleSumList.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // Building
            // 
            this.Building.DataPropertyName = "Building";
            this.Building.HeaderText = "Building";
            this.Building.MinimumWidth = 8;
            this.Building.Name = "Building";
            this.Building.Width = 150;
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
            this.OnDemand.Width = 150;
            // 
            // ArriveDepart
            // 
            this.ArriveDepart.DataPropertyName = "ArriveDepart";
            this.ArriveDepart.HeaderText = "Arrival/Departure";
            this.ArriveDepart.Items.AddRange(new object[] {
            "",
            "A",
            "D"});
            this.ArriveDepart.MinimumWidth = 8;
            this.ArriveDepart.Name = "ArriveDepart";
            this.ArriveDepart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ArriveDepart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ArriveDepart.Width = 150;
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
            this.OnTime.Width = 150;
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
            this.ArriveTime.Width = 150;
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
            this.DepartTime.Width = 150;
            // 
            // Pieces
            // 
            this.Pieces.DataPropertyName = "Pieces";
            this.Pieces.HeaderText = "Pieces Carried";
            this.Pieces.MinimumWidth = 8;
            this.Pieces.Name = "Pieces";
            this.Pieces.Width = 150;
            // 
            // Utilization
            // 
            this.Utilization.DataPropertyName = "Utilization";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Utilization.DefaultCellStyle = dataGridViewCellStyle3;
            this.Utilization.HeaderText = "Utilization";
            this.Utilization.MinimumWidth = 8;
            this.Utilization.Name = "Utilization";
            this.Utilization.Width = 150;
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
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Location = new System.Drawing.Point(180, 434);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(167, 29);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update Existing";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // DriverDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 535);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewComboBoxColumn OnDemand;
        private System.Windows.Forms.DataGridViewComboBoxColumn ArriveDepart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnTime;
        private CalendarColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveActualDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveActualTime;
        private CalendarColumn DepartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleDate;
        private System.Windows.Forms.Button updateButton;
    }
}

