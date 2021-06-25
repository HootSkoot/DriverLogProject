using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;


namespace DriverLogProject
{
    public class VehicleScheduleSetting : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public List<string> ScheduleList
        {
            get
            {
                return ((List<string>)this["ScheduleList"]);
            }
            set
            {
                this["ScheduleList"] = (List<string>)value;
            }
        }
    }
}
