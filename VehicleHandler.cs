using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            helper.DBActionNoParams($"CREATE TABLE IF NOT EXISTS '{name}' (id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, Building TEXT, OnDemand TEXT, ArriveDepart TEXT, OnTime TEXT, ArriveTime TEXT, ArriveActualDate TEXT, ArriveActualTime TEXT, DepartTime TEXT, Pieces INTEGER, Utilization INTEGER, LoggingDate TEXT)");
        }

        public void InsertDriverData(Dictionary<string, List<object>> driverDict, string insertCommand)
        {
            helper = new SQLiteHelper(db);
            if (insertCommand is null)
            {
                insertCommand = $"INSERT INTO '{name}' (Building, OnDemand, ArriveDepart, OnTime, ArriveTime, ArriveActualDate, ArriveActualTime, DepartTime, Pieces, Utilization, LoggingDate) VALUES ";
            }
            List<object> list = new List<object>();
            int count = 1;
            int p = 1;
            if (driverDict.Count == 1)
            {
                insertCommand += BuildParameterQueryString(driverDict["row1"], ref count);
                helper.DBActionWithParams(insertCommand, driverDict["row1"]);
            }
            else if (driverDict.Count > 1)
            {
                
                while (count < driverDict.Count)
                {
                    insertCommand += BuildParameterQueryStringMultiple(driverDict["row" + count], ref p);
                    list.AddRange(driverDict["row" + count]);
                    count++;
                }
                insertCommand += BuildParameterQueryString(driverDict["row" + count], ref p);
                list.AddRange(driverDict["row" + count]);
                helper.DBActionWithParams(insertCommand, list);
            }
        }

        public void UpdateDriverData(Dictionary<string, List<object>> driverDict, string insertCommand)
        {
            helper = new SQLiteHelper(db);
            List<object> list = new List<object>();
            foreach (KeyValuePair<string,List<object>> item in driverDict)
            {
                list.AddRange(item.Value);
            }
            helper.DBUpdateWithParams($"UPDATE '{name}' SET Building=@param2, OnDemand=@param3, ArriveDepart=@param4, OnTime=@param5, ArriveTime=@param6, ArriveActualDate=@param7, ArriveActualTime=@param8,DepartTime=@param9,Pieces=@param10,Utilization=@param11,LoggingDate=@param12 WHERE id=@param1",list,driverDict.Count,driverDict["row1"].Count);
        }

        public DataTable RetrieveDriverData(string date)
        {
            DataTable table = new DataTable();

            helper = new SQLiteHelper(db);
            string selectCommand = $"SELECT id,Building, OnDemand, ArriveDepart, OnTime, ArriveTime, datetime(ArriveActualDate) as ArriveActualDate, datetime(ArriveActualTime) as ArriveActualTime, DepartTime, Pieces, Utilization, LoggingDate from '{name}' WHERE LoggingDate=@param1";
            List<object> list = new List<object>();
            list.Add(date);
            return helper.DBDataTableReturnWithParams(selectCommand, list);
            
            
        }

        private string BuildParameterQueryString(List<object> list, ref int startingNum)
        {
            string value = "(";
            int count = 1;
            foreach (var item in list)
            {
                value += "@param" + startingNum++;
                value += count++ < list.Count ? "," : "";
            }
            value += ")";
            return value;
        }

        private string BuildParameterQueryStringMultiple(List<object> list, ref int startingNum)
        {
            return BuildParameterQueryString(list, ref startingNum) + ",";
        }
    }
}
