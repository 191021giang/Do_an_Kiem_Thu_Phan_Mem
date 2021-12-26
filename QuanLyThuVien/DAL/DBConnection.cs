using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
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
    public class DNU
    {
        public static string CheckDTO (DTO_Users dto_user)
        {
            string user = null;
            SqlConnection conn = DBConnection.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DNUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Taikhoan", dto_user.users_account);
            cmd.Parameters.AddWithValue("@Matkhau", dto_user.users_password);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                while(reader.Read())
                {
                    user = reader.GetString(7);
                }
                reader.Close();
                conn.Close();
            }    
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }
    }
    public class DNA
    {
        public static string Checkdto (DTO_Admin dto_admin)
        {
            string admin = null;
            SqlConnection conn = DBConnection.GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DNAdmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Taikhoan", dto_admin.admin_user);
            cmd.Parameters.AddWithValue("@Matkhau", dto_admin.admin_password);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                while (reader.Read())
                {
                    admin = reader.GetString(3);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return admin;
        }
    }
}
