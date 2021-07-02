using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data;
//using System.Data.SQLite;

namespace DriverLogProject
{
    public class SQLiteHelper
    {
        private string db;


        // <summary>
        //  Standalone SQLite helper class, taken and modified from https://codereview.stackexchange.com/questions/138903/managing-a-sqlite-database-connection
        // <summary>

        public SQLiteHelper(String _db)
        {
            db = _db;
        }

        private SqliteConnection GetConnection() => new SqliteConnection("Data source=" + db);


        /// <summary>
        /// Insersts into DB
        /// </summary>
        /// <param name="statement">Use "@param1" and so on in statement</param>
        /// <param name="param"></param>
        public void DBActionWithParams(String statement, List<object> param)
        {
            ExecuteWithConnection(connection =>
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = statement;
                    command.CommandType = CommandType.Text;
                    int count = 1;
                    foreach (var item in param)
                    {
                        //command.Parameters.Add(new SqliteParameter("@param" + count, item));
                        command.Parameters.AddWithValue(String.Concat("@param" + count), item);
                        count++;
                    }
                    command.ExecuteNonQuery();
                }
            });
        }

        public void DBActionNoParams(String statement)
        {
            ExecuteWithConnection(connection =>
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = statement;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            });
        }

        public DataTable DBDataTableReturnNoParams(string statement)
        {

            DataTable table = new DataTable();
            ExecuteWithConnection(connection =>
            {
                
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = statement;
                    command.CommandType = CommandType.Text;
                    SqliteDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                    
                }
                
            });
            return table;
            
        }

        private void ExecuteWithConnection(Action<SqliteConnection> action)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                action(connection);
            }
        }

        private T ExecuteWithConnection<T>(Func<SqliteConnection, T> action)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                return action(connection);
            }
        }

        
    }
}
