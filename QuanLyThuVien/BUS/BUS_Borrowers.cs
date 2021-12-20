using QuanLyThuVien_DTO;
using QuanLyThuVien_DAL;
using System.Data;
using DTO;

namespace QuanLyThuVien_BUS
{
    public class BUS_Borrowers
    {
        private DAL_Borrowers dal_borrow = new DAL_Borrowers();

        public DataTable searching_Borrow(string value)
        {
            return dal_borrow.searching_Borrow(value);
        }

        public DataTable getGrid_Borrowers()
        {
            return dal_borrow.getGrid_Borrowers();
        }

        public bool addBorrow(DTO_Borrowers borrow)
        {
            return dal_borrow.addBorrow(borrow);
        }

        public bool update_date_of_return(DTO_Borrowers dto_borrow, int stt)
        {
            return dal_borrow.update_date_of_return(dto_borrow, stt);
        }

        public DataTable borrower(DTO_Users user)
        {
            return dal_borrow.borrower(user);
        }
    }
}
