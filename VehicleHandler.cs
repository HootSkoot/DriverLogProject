using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLogProject
{
    public class VehicleHandler
    {
        private string name;
        private string db;
        private SQLiteHelper helper;

        public VehicleHandler(string _name, string _db)
        {
            name = _name;
            db = _db;
        }

        override public string ToString()
        {
            return name + "_handler";
        }

        public void CreateVehicleTable()
        {
            helper = new SQLiteHelper(db);
            helper.DBActionNoParams($"CREATE TABLE IF NOT EXISTS '{name}' (id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, Building TEXT, OnDemand TEXT, ArriveDepart TEXT, OnTime TEXT, ArriveTime TEXT, DepartTime TEXT, Pieces INTEGER, Utilization INTEGER, Date TEXT)");
        }

        public void InsertDriverData(Dictionary<string, List<object>> driverDict)
        {
            helper = new SQLiteHelper(db);
            string insertCommand = $"INSERT INTO '{name}' (Building, OnDemand, ArriveDepart, OnTime, ArriveTime, DepartTime, Pieces, Utilization, Date) VALUES ";
            List<object> list = new List<object>();
            int count = 1;
            int p = 1;
            if (driverDict.Count == 1)
            {
                insertCommand = insertCommand + "(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9)";
                helper.DBActionWithParams(insertCommand, driverDict["row1"]);
            }
            else if (driverDict.Count > 1)
            {
                while (count < driverDict.Count)
                {
                    //insertCommand = insertCommand + "(@param1" + count + ",@param2" + count + ",@param3" + count + ",@param4" + count + ",@param5" + count + ",@param6" + count + ",@param7" + count + ",@param8" + count + ",@param9" + count + "),";
                    insertCommand = insertCommand + "(@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + "),";
                    list.AddRange(driverDict["row" + count]);
                    count++;
                }
                insertCommand = insertCommand + "(@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ",@param" + p++ + ")";
                list.AddRange(driverDict["row" + count]);
                helper.DBActionWithParams(insertCommand, list);
            }
        }
    }
}
