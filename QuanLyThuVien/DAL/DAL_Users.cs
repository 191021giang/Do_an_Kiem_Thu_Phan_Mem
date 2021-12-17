using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_Users
    {
        private SqlConnection conn = DBConnection.GetDBConnection();
        public int Insert(DTO_Users us)
        {
            StringBuilder sb = new StringBuilder("Insert into UsersInformation (users_id, users_name, users_email, users_phone, users_district, users_city, users_account, users_password)");
            sb.AppendFormat("values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}');", us.users_id, us.users_name, us.users_email, us.users_phone, us.users_district, us.users_city, us.users_account, us.users_password);
            sb.Append("select cast (@@IDENTITY as int) ");
            int res = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                res = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception e)
            {
                res = 0;
                if(conn.State == ConnectionState.Open)
                conn.Close();
            }
            return res;
        }
        //public bool Insert(DTO_Users us)
        //{
        //    string sb = string.Format(@"INSERT INTO UsersInformation
        //                                (
        //                                    users_id,
        //                                    users_name,
        //                                    users_email,
        //                                    users_phone,
        //                                    users_district,
        //                                    users_city,
        //                                    users_account,
        //                                    users_password
        //                                )
        //                                VALUES
        //                                (   {0}   -- users_id - int
        //                                    '{1}', -- users_name - nvarchar(100)
        //                                    '{2}',  -- users_email - varchar(50)
        //                                    '{3}',  -- users_phone - varchar(20)
        //                                    '{4}', -- users_district - nvarchar(max)
        //                                    '{5}', -- users_city - nvarchar(max)
        //                                    '{6}',  -- users_account - varchar(20)
        //                                    '{7}'   -- users_password - varchar(20)
        //                                    )", us.users_id, us.users_name, us.users_email, us.users_phone, us.users_district, us.users_city, us.users_account, us.users_password);
        //    SqlCommand cmd = new SqlCommand(sb, conn);
        //    try
        //    {
        //        conn.Open();
        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception ex1)
        //    {
        //        throw ex1;

        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return true;                  
        //}
        //public bool KTraSV(int id )
        //{

        //    string sb = string.Format("select student_id from StudentID where student_id = {0}", id);
        //    SqlCommand cmd = new SqlCommand(sb, conn);

        //    try
        //    {
        //        conn.Open();
        //        SqlDataReader red = cmd.ExecuteReader();
        //        if(red.HasRows)
        //            return true;
        //    }
        //    catch(SqlException ex )
        //    {
        //        throw ex;
        //    } 
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return false;            
        //}
    }
}
