using QuanLyThuVien_DTO;
using QuanLyThuVien_DAL;
using System.Data;

namespace QuanLyThuVien_BUS
{
    public class BUS_ListBooks
    {
        private DAL_ListBooks dal_ListBooks = new DAL_ListBooks();

        public DataTable getBooksStore()
        {
            return dal_ListBooks.getBooksStore();
        }

        public DataTable BookInfor(int bookid)
        {
            return dal_ListBooks.BookInfor(bookid);
        }

        public bool updateQuantity_Availid(DTO_BooksStore dto_book, int qtt)
        {
            return dal_ListBooks.updateQuantity_Availid(dto_book, qtt);
        }
    }
}
