using DAL;
using DTO;

namespace BUS
{
    public class BUS_Users
    {
        private DAL_Users dal = new DAL_Users();
             
        public int Insert(DTO_Users us)
        {
            return dal.Insert(us);
        }         
    }
    public class BUS_DNUser
    {
        DAL_DNUser dal_dnuser = new DAL_DNUser();
        public string CheckUser(DTO_Users dto_user)
        {
            if(dto_user.users_account == "")
            {
                return "Khongtaikhoan";
            }
            if(dto_user.users_password== "")
            {
                return "Khongmatkhau";
            }
            string us = dal_dnuser.CheckUser(dto_user);
            return us;
        }
    }
}

