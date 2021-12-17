using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class DTO_Users
    {
        public Int32 number { get; set; }
        public Int32 users_id { get; set; }
        public string users_name { get; set; }
        public string users_email { get; set; }
        public string users_phone { get; set; }
        public string users_district { get; set; }
        public string users_city { get; set; }
        public string users_account { get; set; }
        public string users_password { get; set; }

        public DTO_Users()
        {

        }

        public DTO_Users(Int32 number,Int32 users_id, string users_name, string users_email, string users_phone, string users_district, string users_city, string users_account, string users_password)
        {
            this.number = number;
            this.users_id = users_id;
            this.users_name = users_name;
            this.users_email = users_email;
            this.users_phone = users_phone;
            this.users_district = users_district;
            this.users_city = users_city;
            this.users_account = users_account;
            this.users_password = users_password;
        }

    }
}
