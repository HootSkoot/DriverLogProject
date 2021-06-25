using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLogProject
{
    class SQLiteHelper
    {
        private string db;


        // <summary>
        //  Standalone SQLite helper class, taken and modified from https://codereview.stackexchange.com/questions/138903/managing-a-sqlite-database-connection
        // <summary>

        public SQLiteHelper(String _db)
        {
            db = _db;
        }

        private SQLiteConnection GetConnection() => new SQLiteConnection("Data source=" + db);


        /// <summary>
        /// Insersts into DB
        /// </summary>
        /// <param name="statement">Use "@param1" and so on in statement</param>
        /// <param name="param"></param>
        private void DBActionWithParams(String statement, Array param)
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
                        command.Parameters.Add(new SQLiteParameter("@param" + count, item));
                    }
                    command.ExecuteNonQuery();
                }
            });
        }

        private void DBActionNoParams(String statement)
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

        private static void InsertScheduleSchema(IDbCommand command)
        {

        }
    }
}
