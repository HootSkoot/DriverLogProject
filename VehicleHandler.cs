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
            helper.DBActionNoParams($"CREATE TABLE IF NOT EXISTS '{name}' (id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, VehicleName TEXT, Building TEXT, OnDemand TEXT, PickDeliverBoth TEXT, OnTime TEXT, ArriveTime TEXT, ArriveActualDate TEXT, ArriveActualTime TEXT, DepartTime TEXT, PiecesPicked INTEGER, PickupUtilization INTEGER, PiecesDelivered INTEGER, DeliveryUtilization INTEGER, LoggingDate TEXT)");
        }

        public void InsertDriverData(Dictionary<string, List<object>> driverDict, string insertCommand)
        {
            helper = new SQLiteHelper(db);
            if (insertCommand is null)
            {
                insertCommand = $"INSERT INTO '{name}' (VehicleName, Building, OnDemand, PickDeliverBoth, OnTime, ArriveTime, ArriveActualDate, ArriveActualTime, DepartTime, PiecesPicked, PickupUtilization, PiecesDelivered, DeliveryUtilization, LoggingDate) VALUES ";
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
            helper.DBUpdateWithParams($"UPDATE '{name}' SET VehicleName=@param2, Building=@param3, OnDemand=@param4, PickDeliverBoth=@param5, OnTime=@param6, ArriveTime=@param7, ArriveActualDate=@param8, ArriveActualTime=@param9, DepartTime=@param10, PiecesPicked=@param11, PickupUtilization=@param12, PiecesDelivered=@param13, DeliveryUtilization=@param14, LoggingDate=@param15 WHERE id=@param1",list,driverDict.Count,driverDict["row1"].Count);
        }

        public DataTable RetrieveDriverData(string date, string vehicleName)
        {
            DataTable table = new DataTable();

            helper = new SQLiteHelper(db);
            string selectCommand = $"SELECT id, VehicleName, Building, OnDemand, PickDeliverBoth, OnTime, ArriveTime, datetime(ArriveActualDate) as ArriveActualDate, datetime(ArriveActualTime) as ArriveActualTime, DepartTime, PiecesPicked, PickupUtilization, PiecesDelivered, DeliveryUtilization, LoggingDate from '{name}' WHERE LoggingDate=@param1 and VehicleName=@param2";
            List<object> list = new List<object>();
            list.Add(date);
            list.Add(vehicleName);
            return helper.DBDataTableReturnWithParams(selectCommand, list);
            
            
        }

        public Dictionary<string,double> QuerySummarizer(List<string> vehicleList, string startDate, string endDate)
        {
            Dictionary<string,double> results = new Dictionary<string, double>();

            DataTable table = BuildMultipleVehiclesInQueryString(vehicleList, startDate, endDate);
            if(table.Rows.Count > 0)
            {
                results.Add("TotalTrips", table.Rows.Count);
                results.Add("TotalScheduledTrips", Convert.ToDouble(table.Compute("Count(Building)", "OnDemand='N' or OnDemand=''")));
                results.Add("TotalPickTrips", Convert.ToDouble(table.Compute("Count(Building)", "PickDeliverBoth='P' or PickDeliverBoth='B'")));
                results.Add("TotalDeliverTrips", Convert.ToDouble(table.Compute("Count(Building)", "PickDeliverBoth='D' or PickDeliverBoth='B'")));
                results.Add("TotalOnTimeScheduledTrips", Convert.ToDouble(table.Compute("Count(Building)", "(OnDemand='N' or OnDemand='') and OnTime=2")));
                results.Add("TotalOnTimeScheduledPickTrips", Convert.ToDouble(table.Compute("Count(Building)", "(OnDemand='N' or OnDemand='') and (PickDeliverBoth='P'  or PickDeliverBoth='B') and OnTime=2")));
                results.Add("TotalOnTimeScheduledDeliverTrips", Convert.ToDouble(table.Compute("Count(Building)", "(OnDemand='N' or OnDemand='') and (PickDeliverBoth='D'  or PickDeliverBoth='B') and OnTime=2")));
                results.Add("TotalOffTimeScheduledTrips", Convert.ToDouble(table.Compute("Count(Building)", "(OnDemand='N' or OnDemand='') and OnTime=1")));
                results.Add("TotalOffTimeScheduledPickTrips", Convert.ToDouble(table.Compute("Count(Building)", "(OnDemand='N' or OnDemand='') and OnTime=1 and (PickDeliverBoth='P' or PickDeliverBoth='B')")));
                results.Add("TotalOffTimeScheduledDeliverTrips", Convert.ToDouble(table.Compute("Count(Building)", "(OnDemand='N' or OnDemand='') and OnTime=1 and PickDeliverBoth='D'  or PickDeliverBoth='B'")));
                results.Add("PickupAvgUtilization", Convert.ToDouble(table.Compute("Avg(PickupUtilization)", "PickDeliverBoth='P'  or PickDeliverBoth='B'")));
                results.Add("DeliveryAvgUtilization", Convert.ToDouble(table.Compute("Avg(DeliveryUtilization)", "PickDeliverBoth='D'  or PickDeliverBoth='B'")));
                results.Add("TotalPickupItems", Convert.ToDouble(table.Compute("Sum(PiecesPicked)", "PickDeliverBoth='P'  or PickDeliverBoth='B'")));
                results.Add("TotalDeliveryItems", Convert.ToDouble(table.Compute("Sum(PiecesDelivered)", "PickDeliverBoth='D'  or PickDeliverBoth='B'")));
                results.Add("TotalScheduledPickups", Convert.ToDouble(table.Compute("Count(Building)", "(PickDeliverBoth='P' or PickDeliverBoth='B') and OnDemand='N'")));
                results.Add("TotalScheduledDelivery", Convert.ToDouble(table.Compute("Count(Building)", "(PickDeliverBoth='D' or PickDeliverBoth='B') and OnDemand='N'")));
                results.Add("OnTimePickupPercentage", results["TotalScheduledPickups"] / results["TotalOnTimeScheduledPickTrips"]);
                results.Add("OnTimeDeliveryPercentage", results["TotalScheduledDelivery"] / results["TotalOnTimeScheduledDeliverTrips"]);

                
            }
            else
            {
                results.Add("TotalTrips", 0.0);
                results.Add("TotalScheduledTrips", 0.0);
                results.Add("TotalPickTrips", 0.0);
                results.Add("TotalDeliverTrips", 0.0);
                results.Add("TotalOnTimeScheduledTrips", 0.0);
                results.Add("TotalOnTimeScheduledPickTrips", 0.0);
                results.Add("TotalOnTimeScheduledDeliverTrips", 0.0);
                results.Add("TotalOffTimeScheduledTrips", 0.0);
                results.Add("TotalOffTimeScheduledPickTrips", 0.0);
                results.Add("TotalOffTimeScheduledDeliverTrips", 0.0);
                results.Add("PickupAvgUtilization", 0.0);
                results.Add("DeliveryAvgUtilization", 0.0);
                results.Add("TotalPickupItems", 0.0);
                results.Add("TotalDeliveryItems", 0.0);
                results.Add("TotalScheduledPickups", 0.0);
                results.Add("TotalScheduledDelivery", 0.0);
                results.Add("OnTimePickupPercentage", 0.0);
                results.Add("OnTimeDeliveryPercentage", 0.0);

                

            }
            return results;
        }

        private DataTable BuildMultipleVehiclesInQueryString(List<string> vehicleList, string startDate, string endDate)
        {
            DataTable table = new DataTable();

            helper = new SQLiteHelper(db);

            List<object> list = new List<object>();
            

            string query = $"SELECT * FROM '{name}' WHERE ";
            int count = 1;
            foreach (string item in vehicleList)
            {
                query += "VehicleName=@param" + count + (count==vehicleList.Count ? "" : " and ");
                count++;
                list.Add(item);
            }
            query += " and date(LoggingDate)>=date(@param" + count++ + ") and date(LoggingDate)<=date(@param" + count++ + ")";

            list.Add(startDate);
            list.Add(endDate);

            return helper.DBDataTableReturnWithParams(query, list);
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
