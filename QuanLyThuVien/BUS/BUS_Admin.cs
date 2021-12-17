using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Admin
    {
        DAL_DNAdmin dal_admin = new DAL_DNAdmin();
        public string CheckAdmin(DTO_Admin dto_admin)
        {
            if (dto_admin.admin_user == "")
            {
                return "Khongtaikhoan";
            }
            if (dto_admin.admin_password == "")
            {
                return "Khongmatkhau";
            }
            string ad = dal_admin.CheckAdmin(dto_admin);
            return ad;
        }
    }
}
