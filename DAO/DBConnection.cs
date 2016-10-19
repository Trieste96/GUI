using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class DBConnection
    {
        static SqlConnection conn;
        public static SqlConnection openConnection()
        {
            try
            {
                if (conn == null)
                {
                    string server   = Properties.Settings.Default.server,
                           database = Properties.Settings.Default.database,
                           username = Properties.Settings.Default.username,
                           password = Properties.Settings.Default.password;
                    string db_info = String.Format("Server = {0}; database = {1}; uid = {2}; pwd= {3}; ", server, database, username, password);
                    conn = new SqlConnection(db_info);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return conn;
        }
    }
}
