using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            DisableTabControls();
            
            
            //VehicleList.Items.AddRange(Properties.Settings.Default.VehicleList.Cast<string>().ToArray());
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
        }

        private void activateVehicle_Click(object sender, EventArgs e)
        {

            if (VehicleList.SelectedItem != null)
            {
                EnableTabControls();
            }
                
        }

        
    }
}
