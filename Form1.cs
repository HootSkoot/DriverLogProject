using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;

namespace DriverLogProject
{
    public partial class DriverDatabaseForm : Form
    {


        private BindingList<string> bindinglist { get; set; }
        //private string db = "InMemorySample;Mode=Memory;Cache=Shared";
        //private string db = ".\\DriverDatabase.db";
        private string db = "DriverDatabaseConsolidated.db";
        private string vehicleTable = "VehicleSchedule";
        private string scheduleTable = "ScheduleTable";
        private string vehicleNameTable = "VehicleNameTable";
        private Dictionary<string, List<object>> tableRows;
        private VehicleHandler handler;
        public DriverDatabaseForm()
        {
            InitializeComponent();
        }


        private void DriverDatabaseForm_Load(object sender, EventArgs e)
        {
            VehicleHandler handler = new VehicleHandler(vehicleNameTable, db);
            handler.CreateVehicleNameTable();
            DataTable assetsRaw = handler.RetrieveVehicleAssetNames();

            bindinglist = new BindingList<string>();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindinglist;

            VehicleList.DataSource = bSource;
            VehicleSumList.DataSource = bSource;


            if (assetsRaw.Rows == null)
            {
                bindinglist[0] = "";
            }
            else
            {
                foreach (DataRow row in assetsRaw.Rows)
                {
                    bindinglist.Add((string)row["VehicleNameAsset"]);
                }
            }

            bSource.ResetBindings(true);

            //VehicleList.DataSource = bSource;
            //VehicleSumList.DataSource = bSource;

            DisableTabControls();

            driverLogTable.Columns["ArriveTime"].DefaultCellStyle.Format = "t";
            driverLogTable.Columns["DepartTime"].DefaultCellStyle.Format = "t";
            scheduleGrid.Columns["Time"].DefaultCellStyle.Format = "t";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";

            

            //VehicleList.Items.AddRange(Properties.Settings.Default.VehicleList.Cast<string>().ToArray());
        }

        /*
        private SQLiteConnection GetConnection() => new SQLiteConnection("Data source=" + db);

        private void ExecuteWithConnection(Action<SQLiteConnection> action)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                action(connection);
            }
        }

        private T ExecuteWithConnection<T>(Func<SQLiteConnection, T> action)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                return action(connection);
            }
        }
        */

        private void ClearVehicleTable()
        {
            if (driverLogTable.Rows.Count > 1 || driverLogTable.Rows[0].Cells["Building"].Value == null)
            {
                driverLogTable.Rows.Clear();
                
            }
        }



        private void MenuAddVehicle_Click(object sender, EventArgs e)
        {
            VehicleHandler handler3 = new VehicleHandler(vehicleNameTable, db);
            handler3.CreateVehicleNameTable();

            String input = Interaction.InputBox("Enter an alphanumeric name, use underscores for spaces", "Vehicle Name", default);

            if (Regex.IsMatch(input, "^[a-zA-Z0-9_]*$"))
            {
                /*if (!Properties.Settings.Default.VehicleList.Contains(input))
                {
                    Properties.Settings.Default.VehicleList.Add(input);
                    Properties.Settings.Default.Save();
                    bindinglist.Add(input);
                }*/
                handler3.InsertVehicleNameAsset(input);
                bindinglist.Add(input);


                
                
            }
            else
            {
                MessageBox.Show("Invalid Truck Name");
            }

            VehicleHandler handler1 = new VehicleHandler(vehicleTable, db);
            handler1.CreateVehicleTable();
            VehicleHandler handler2 = new VehicleHandler(scheduleTable, db);
            handler2.CreateScheduleTable();
            

        }

        //Invoke this whenever the vehicle selection is changed
        private void DisableTabControls() {
            foreach (Control item in tabPage1TablePanel.Controls)
            {
                if (item.Name == "activateVehicle" || item.Name == "VehicleList")
                {
                    item.Enabled = true;
                }
                else
                {
                    item.Enabled = false;
                }
            }
        }

        private void EnableTabControls()
        {
            foreach (Control item in tabPage1TablePanel.Controls)
            {
                item.Enabled = true;
            }
        }

        private void VehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleGrid.Rows.Clear();
            ClearVehicleTable();
            DisableTabControls();
            handler = null;
        }

        private void activateVehicle_Click(object sender, EventArgs e)
        {

            if (VehicleList.SelectedItem != null)
            {
                EnableTabControls();
                //VehicleHandler handler = new VehicleHandler(VehicleList.SelectedItem.ToString(), db);
                handler = new VehicleHandler(scheduleTable, db);

                scheduleGrid.Rows.Clear();

                foreach (DataRow row in handler.RerieveScheduleTable(VehicleList.SelectedItem.ToString()).Rows)
                {
                    scheduleGrid.Rows.Add(row["ScheduleID"], row["ScheduleVehicleName"], row["ScheduleBuilding"], DateTime.Parse(row["Time"].ToString()));

                }
            }
                
        }

        /// <summary>
        /// Basic data insertion button, creates a dictionary of rows to List of row parameters to pass to vehicle handler
        /// for OnTime: 0 - not relevant, 1 - Not on time, 2 - on time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logDataButton_Click(object sender, EventArgs e)
        {
            handler = new VehicleHandler(vehicleTable, db);
            
            handler.InsertDriverData(createTableRowCollection(), null);
            
        }

        private void selectDateButton_Click(object sender, EventArgs e)
        {
            handler = new VehicleHandler(vehicleTable, db);

            ClearVehicleTable();
            
            
            foreach (DataRow row in handler.RetrieveDriverData(dateTimePicker1.Value.ToString("yyyy-MM-dd"),VehicleList.SelectedItem.ToString()).Rows)
            {
                driverLogTable.Rows.Add(row["id"], row["VehicleName"], row["Building"].ToString(), row["OnDemand"], row["PickDeliverBoth"], row["OnTime"],DateTime.Parse(row["ArriveTime"].ToString()), row["ArriveActualDate"], row["ArriveActualTime"], DateTime.Parse(row["DepartTime"].ToString()), row["PiecesPicked"], row["PickupUtilization"], row["PiecesDelivered"], row["DeliveryUtilization"], row["LoggingDate"]);
                
            }



        }

        //for adding only new lines to DB
        private void updateButton_Click(object sender, EventArgs e)
        {
            handler = new VehicleHandler(vehicleTable, db);
            if (driverLogTable.Rows.Count > 0)
            {
                var driverTableItems = new List<object>();
                Dictionary<string, List<object>> rowDict = new Dictionary<string, List<object>>();

                int count = 1;

                foreach (DataGridViewRow row in driverLogTable.Rows)
                {
                    if (row.Cells["Building"].Value != null && row.Cells["Building"].Value.ToString().Trim().Length >= 1)
                    {
                        driverTableItems = new List<object>();

                        DateTime depart = (DateTime)row.Cells["DepartTime"].Value;
                        DateTime arrive = (DateTime)row.Cells["ArriveTime"].Value;

                        driverTableItems.Add(row.Cells["id"].Value);
                        driverTableItems.Add(row.Cells["VehicleName"].Value);
                        driverTableItems.Add(row.Cells["Building"].Value.ToString());
                        driverTableItems.Add(row.Cells["OnDemand"].Value);
                        driverTableItems.Add(row.Cells["PickDeliverBoth"].Value);
                        driverTableItems.Add(row.Cells["OnTime"].Value ?? 0);
                        driverTableItems.Add((DateTime)row.Cells["ArriveTime"].Value);
                        driverTableItems.Add(arrive.ToShortDateString());
                        driverTableItems.Add(arrive.ToShortTimeString());
                        driverTableItems.Add((DateTime)row.Cells["DepartTime"].Value);
                        driverTableItems.Add(row.Cells["PiecesPicked"].Value);
                        driverTableItems.Add(row.Cells["PickupUtilization"].Value);
                        driverTableItems.Add(row.Cells["PiecesDelivered"].Value);
                        driverTableItems.Add(row.Cells["DeliveryUtilization"].Value);
                        driverTableItems.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                        rowDict.Add("row" + count, driverTableItems);
                        count++;
                    }

                }
                
                handler.UpdateDriverData(rowDict, null);
            }
        }
        
        //--------------------------------------------------------------------------------------------------------
        //
        //Taken from https://www.c-sharpcorner.com/uploadfile/ankurmee/custom-time-cell-in-datagridview/
        //

        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn() : base(new CalendarCell())
            {
            }

            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    // Ensure that the cell used for the template is a CalendarCell.
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class CalendarCell : DataGridViewTextBoxCell
        {

            public CalendarCell()
                : base()
            {
                // Use the short date format.
                this.Style.Format = "t";
            }

            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;
                // Use the default row value when Value property is null.
                if (this.Value == null)
                {
                    ctl.Value = (DateTime)this.DefaultNewRowValue;
                }
                else
                {
                    ctl.Value = (DateTime)this.Value;
                }
            }

            public override Type EditType
            {
                get
                {
                    // Return the type of the editing control that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.

                    return typeof(DateTime);
                }
            }

            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    return DateTime.Now;
                }
            }
        }

        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;

            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Time;
            }

            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortTimeString();
                }
                set
                {
                    if (value is String)
                    {
                        try
                        {
                            // This will throw an exception of the string is
                            // null, empty, or not in the format of a date.
                            this.Value = DateTime.Parse((String)value);
                        }
                        catch
                        {
                            // In the case of an exception, just use the
                            // default value so we're not left with a null
                            // value.
                            this.Value = DateTime.Now;
                        }
                    }
                }
            }

            // Implements the
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            // Implements the
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
            }

            // Implements the IDataGridViewEditingControl.EditingControlRowIndex
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }

            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return !dataGridViewWantsInputKey;
                }
            }

            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }

            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }

            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }

        private void dataSummaryButton_Click(object sender, EventArgs e)
        {
            if (VehicleSumList.CheckedItems.Count > 0)
            {
                handler = new VehicleHandler(vehicleTable, db);

                Dictionary<string, double> results = handler.QuerySummarizer(VehicleSumList.CheckedItems.OfType<string>().ToList(), dateSummary1.Value.ToString("yyyy-MM-dd"), dateSummary2.Value.ToString("yyyy-MM-dd"));

                dataBox1.Text = results["TotalTrips"].ToString("F1");
                dataBox2.Text = results["TotalScheduledTrips"].ToString("F1");
                dataBox3.Text = results["TotalPickTrips"].ToString("F1");
                dataBox4.Text = results["TotalDeliverTrips"].ToString("F1");
                dataBox5.Text = results["TotalOnTimeScheduledTrips"].ToString("F1");
                dataBox6.Text = results["TotalOnTimeScheduledPickTrips"].ToString("F1");
                dataBox7.Text = results["TotalOnTimeScheduledDeliverTrips"].ToString("F1");
                dataBox8.Text = results["TotalOffTimeScheduledTrips"].ToString("F1");
                dataBox9.Text = results["TotalOffTimeScheduledPickTrips"].ToString("F1");
                dataBox10.Text = results["TotalOffTimeScheduledDeliverTrips"].ToString("F1");
                dataBox11.Text = results["PickupAvgUtilization"].ToString("F1");
                dataBox12.Text = results["DeliveryAvgUtilization"].ToString("F1");
                dataBox13.Text = results["TotalPickupItems"].ToString("F1");
                dataBox14.Text = results["TotalDeliveryItems"].ToString("F1");
                double temp = Convert.ToDouble(results["OnTimePickupPercentage"].ToString("F1"));
                temp *= 100.0;
                dataBox15.Text = temp.ToString("F1");
                temp = Convert.ToDouble(results["OnTimeDeliveryPercentage"].ToString("F1"));
                temp *= 100.0;
                dataBox16.Text = temp.ToString("F1");
                dataBox17.Text = results["TotalScheduledPickups"].ToString("F1");
                dataBox18.Text = results["TotalScheduledDelivery"].ToString("F1");
            }
            
            
        }

        private void driverLogTable_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["PiecesPicked"].Value = 0;
            e.Row.Cells["PickupUtilization"].Value = 0;
            e.Row.Cells["PiecesDelivered"].Value = 0;
            e.Row.Cells["DeliveryUtilization"].Value = 0;
        }

        private void saveScheduleButton_Click(object sender, EventArgs e)
        {
            handler = new VehicleHandler(scheduleTable, db);
            if (scheduleGrid.Rows.Count > 0)
            {
                var scheduleTableItems = new List<object>();
                Dictionary<string, List<object>> rowDict = new Dictionary<string, List<object>>();

                int count = 1;

                foreach (DataGridViewRow row in scheduleGrid.Rows)
                {
                    if (row.Cells["ScheduleBuilding"].Value != null && row.Cells["ScheduleBuilding"].Value.ToString().Length > 1)
                    {
                        scheduleTableItems = new List<object>();
                        scheduleTableItems.Add(row.Cells["ScheduleID"].Value is null ? DBNull.Value : row.Cells["ScheduleID"].Value);
                        scheduleTableItems.Add(VehicleList.SelectedItem.ToString());
                        scheduleTableItems.Add(row.Cells["ScheduleBuilding"].Value.ToString());
                        scheduleTableItems.Add((DateTime)row.Cells["Time"].Value);

                        rowDict.Add("row" + count, scheduleTableItems);
                        count++;
                    }

                }

                handler.InsertOrUpdateScheduleData(rowDict);
            }
        }

        private Dictionary<string,List<object>> createTableRowCollection()
        {
            Dictionary<string, List<object>> tempRows = new Dictionary<string, List<object>>();

            if (driverLogTable.Rows.Count > 0)
            {
                var driverTableItems = new List<object>();

                int count = 1;

                foreach (DataGridViewRow row in driverLogTable.Rows)
                {
                    if (row.Cells["Building"].Value != null && row.Cells["Building"].Value.ToString().Trim().Length >= 1)
                    {
                        driverTableItems = new List<object>();

                        DateTime depart = (DateTime)row.Cells["DepartTime"].Value;
                        DateTime arrive = (DateTime)row.Cells["ArriveTime"].Value;
                        driverTableItems.Add(VehicleList.SelectedItem.ToString());
                        driverTableItems.Add(row.Cells["Building"].Value);
                        driverTableItems.Add(row.Cells["OnDemand"].Value);
                        driverTableItems.Add(row.Cells["PickDeliverBoth"].Value);
                        driverTableItems.Add(row.Cells["OnTime"].Value ?? 0);
                        driverTableItems.Add((DateTime)row.Cells["ArriveTime"].Value);
                        driverTableItems.Add(arrive.ToShortDateString());
                        driverTableItems.Add(arrive.ToShortTimeString());
                        driverTableItems.Add((DateTime)row.Cells["DepartTime"].Value);
                        driverTableItems.Add(row.Cells["PiecesPicked"].Value);
                        driverTableItems.Add(row.Cells["PickupUtilization"].Value);
                        driverTableItems.Add(row.Cells["PiecesDelivered"].Value);
                        driverTableItems.Add(row.Cells["DeliveryUtilization"].Value);
                        driverTableItems.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                        tempRows.Add("row" + count, driverTableItems);
                        count++;
                    }

                }

                
            }

            return tempRows;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            tableRows = createTableRowCollection();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            if (tableRows != null && tableRows.Count > 0)
            {
                ClearVehicleTable();

                foreach (List<object> item in tableRows.Values)
                {
                    driverLogTable.Rows.Add(0, item[0], item[1].ToString(), item[2], item[3], item[4], DateTime.Parse(item[5].ToString()), item[6], item[7], DateTime.Parse(item[8].ToString()), item[9], item[10], item[11], item[12], item[13]);
                }
                tableRows = null;
            }
            
        }




        //
        //---------------------------------------------------------------------------------------------------------
        //
    }
}
