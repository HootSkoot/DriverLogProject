using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLogProject
{
    public class VehicleHandler
    {
        private String name;
        private SQLiteHelper helper;

        public VehicleHandler(String _name)
        {
            name = _name;
        }

        override public string ToString()
        {
            return name + "_handler";
        }

        public void CreateVehicleTable(string db)
        {
            helper = new SQLiteHelper(db);
            helper.DBActionNoParams($"CREATE TABLE IF NOT EXISTS '{name}' (id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, Building TEXT, OnDemand TEXT, ArriveDepart TEXT, OnTime BOOLEAN, ArriveTime TEXT, DepartTime TEXT, Pieces INTEGER, Utilization INTEGER)");
        }

        
    }
}
