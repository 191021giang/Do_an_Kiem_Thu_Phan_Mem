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
    }   
}
