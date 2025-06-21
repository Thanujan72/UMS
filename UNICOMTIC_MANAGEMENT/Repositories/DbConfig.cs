using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNICOMTIC_MANAGEMENT.Repositories
{
    internal class DbConfig
    {
        private static string connectingstring = "Data source = UNICOMTICdb.db;Version = 3";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(connectingstring);
            conn.Open();
            return conn;

        }
    }
}
