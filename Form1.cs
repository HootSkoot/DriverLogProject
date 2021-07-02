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
using Microsoft.VisualBasic;

namespace DriverLogProject
{
    public partial class DriverDatabaseForm : Form
    {


        private BindingList<string> bindinglist { get; set; }
        private string db = "InMemorySample;Mode=Memory;Cache=Shared";
        private VehicleHandler handler;
        public DriverDatabaseForm()
        {
            InitializeComponent();
        }


        private void DriverDatabaseForm_Load(object sender, EventArgs e)
        {
            bindinglist = new BindingList<string>();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindinglist;
            if (Properties.Settings.Default.VehicleList == null)
            {
                bindinglist[0] = "";
            }
            else
            {
                foreach (var item in Properties.Settings.Default.VehicleList)
                {
                    bindinglist.Add(item);
                }
            }

            VehicleList.DataSource = bSource;
            VehicleSumList.DataSource = bSource;

            DisableTabControls();

            driverLogTable.Columns["ArriveTime"].DefaultCellStyle.Format = "t";
            driverLogTable.Columns["DepartTime"].DefaultCellStyle.Format = "t";

            //VehicleList.Items.AddRange(Properties.Settings.Default.VehicleList.Cast<string>().ToArray());
        }

        private SQLiteConnection GetConnection() => new SQLiteConnection("Data source=DriverDatabase.db");

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

        private void MenuAddVehicle_Click(object sender, EventArgs e)
        {
            String input = Interaction.InputBox("Enter an alphanumeric name, use underscores for spaces", "Vehicle Name", default);

            if (Regex.IsMatch(input, "^[a-zA-Z0-9_]*$"))
            {
                Properties.Settings.Default.VehicleList.Add(input);
                Properties.Settings.Default.Save();
                bindinglist.Add(input);
            }
            else
            {
                MessageBox.Show("Invalid Truck Name");
            }

            VehicleHandler handler = new VehicleHandler(input, db);
            handler.CreateVehicleTable();
            handler = null;
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
            DisableTabControls();
            handler = null;
        }

        private void activateVehicle_Click(object sender, EventArgs e)
        {

            if (VehicleList.SelectedItem != null)
            {
                EnableTabControls();
                VehicleHandler handler = new VehicleHandler(VehicleList.SelectedItem.ToString(), db);

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
            if (driverLogTable.Rows.Count > 0)
            {
                var driverTableItems = new List<object>();
                Dictionary<string, List<object>> rowDict = new Dictionary<string, List<object>>();

                int count = 1;

                foreach (DataGridViewRow row in driverLogTable.Rows)
                {
                    driverTableItems = new List<object>();

                    driverTableItems.Add(row.Cells["Buildings"]);
                    driverTableItems.Add(row.Cells["OnDemand"]);
                    driverTableItems.Add(row.Cells["ArriveDepart"]);
                    driverTableItems.Add(row.Cells["OnTime"]);
                    driverTableItems.Add(row.Cells["ArriveTime"]);
                    driverTableItems.Add(row.Cells["DepartTime"]);
                    driverTableItems.Add(row.Cells["Pieces"]);
                    driverTableItems.Add(row.Cells["Utilization"]);
                    driverTableItems.Add(dateTimePicker1.Value.ToString("MM/dd/yyyy"));

                    rowDict.Add("row" + count, driverTableItems);
                    count++;
                }

                handler.InsertDriverData(rowDict);
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

        

        //
        //---------------------------------------------------------------------------------------------------------
        //

    }
}
