
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage1TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleList = new System.Windows.Forms.ComboBox();
            this.activateVehicle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveDepart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OnDemand = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage1TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabPage1TablePanel.ColumnCount = 4;
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tabPage1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 554F));
            this.tabPage1TablePanel.Controls.Add(this.VehicleList, 0, 0);
            this.tabPage1TablePanel.Controls.Add(this.activateVehicle, 1, 0);
            this.tabPage1TablePanel.Controls.Add(this.dataGridView1, 0, 2);
            this.tabPage1TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1TablePanel.Location = new System.Drawing.Point(0, 0);
            this.tabPage1TablePanel.Name = "tabPage1TablePanel";
            this.tabPage1TablePanel.RowCount = 3;
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tabPage1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.VehicleList.Size = new System.Drawing.Size(144, 28);
            this.VehicleList.TabIndex = 1;
            this.VehicleList.SelectedIndexChanged += new System.EventHandler(this.VehicleList_SelectedIndexChanged);
            // 
            // activateVehicle
            // 
            this.activateVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activateVehicle.Location = new System.Drawing.Point(153, 3);
            this.activateVehicle.Name = "activateVehicle";
            this.activateVehicle.Size = new System.Drawing.Size(194, 29);
            this.activateVehicle.TabIndex = 2;
            this.activateVehicle.Text = "Set Active Vechicle";
            this.activateVehicle.UseVisualStyleBackColor = true;
            this.activateVehicle.Click += new System.EventHandler(this.activateVehicle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Building,
            this.ArriveDepart,
            this.OnDemand});
            this.tabPage1TablePanel.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(576, 414);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1136, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Building
            // 
            this.Building.HeaderText = "Building";
            this.Building.MinimumWidth = 8;
            this.Building.Name = "Building";
            this.Building.Width = 150;
            // 
            // ArriveDepart
            // 
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
            // OnDemand
            // 
            this.OnDemand.HeaderText = "On-Demand";
            this.OnDemand.Items.AddRange(new object[] {
            "N",
            "Y"});
            this.OnDemand.MinimumWidth = 8;
            this.OnDemand.Name = "OnDemand";
            this.OnDemand.Width = 150;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewComboBoxColumn ArriveDepart;
        private System.Windows.Forms.DataGridViewComboBoxColumn OnDemand;
    }
}

