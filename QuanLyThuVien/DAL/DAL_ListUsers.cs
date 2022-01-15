using DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien_DAL
{
    public class DAL_ListUsers
    {
        private SqlConnection conn = DBConnection.GetDBConnection();

        public DataTable UsersName()
        {
            string query = string.Format("SELECT student_id FROM dbo.StudentID");

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
