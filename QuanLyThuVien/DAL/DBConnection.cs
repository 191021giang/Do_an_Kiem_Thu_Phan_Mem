using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DBConnection
    {
        private static SqlConnection conn;
        public static SqlConnection GetDBConnection()
        {
            try
            {
                string cntr = " Server = DESKTOP-47KF5PU\\SQLEXPRESS; Database = Library_System; Integrated Security =True;";
                conn = new SqlConnection(cntr);
                return conn;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
