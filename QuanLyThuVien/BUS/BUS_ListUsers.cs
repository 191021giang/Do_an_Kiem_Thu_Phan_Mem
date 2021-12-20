using QuanLyThuVien_DAL;
using System.Data;

namespace QuanLyThuVien_BUS
{
    public class BUS_ListUsers
    {
        private DAL_ListUsers dal_ListUsers = new DAL_ListUsers();

        public DataTable UsersName()
        {
            return dal_ListUsers.UsersName();
        }
    }
}
