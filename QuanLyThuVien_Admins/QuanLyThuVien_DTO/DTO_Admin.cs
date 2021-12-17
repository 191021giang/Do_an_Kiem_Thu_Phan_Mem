using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Admin
    {
        public Int32 admin_id { get; set; }
        public string admin_name { get; set; }
        public string admin_phone { get; set; }
        public string admin_user { get; set; }
        public string admin_password { get; set; }

        public DTO_Admin()
        {

        }

        public DTO_Admin(Int32 admin_id, string users_name, string admin_phone, string admin_user, string admin_password)
        {
            this.admin_id = admin_id;
            this.admin_name = admin_name;
            this.admin_phone = admin_phone;
            this.admin_user = admin_user;
            this.admin_password = admin_password;
        }
    }
}

