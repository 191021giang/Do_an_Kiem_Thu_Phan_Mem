using System;
using System.Data.SqlClient;

namespace QuanLyThuVien_DAL
{
    public class DBConnection
    {
        private static SqlConnection conn;
        
        public static SqlConnection GetDBConnection()
        {            
            try
            {                
                //Data Source=LAPTOP-RL3S5CVA;Initial Catalog=Library_System;Integrated Security=True
                string sqlConnStr = @"Data Source=" + "LAPTOP-RL3S5CVA" + ";Initial Catalog=" + "Library_System" + ";Integrated Security=True";
                conn = new SqlConnection(sqlConnStr);
                //conn.Open();
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
