using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MyGameStore.Classes
{
    internal class Connection
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source = NAYASHOV; Database = GameStore; Integrated Security=true;");
        public void OpenCon()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseCon()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetCon()
        {
            return sqlConnection;
        }
    }
}
