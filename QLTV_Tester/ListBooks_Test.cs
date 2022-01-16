using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;
using System.Data;

namespace ThongKeMuonTra_Test
{
    [TestClass]
    public class ListBooks_Test
    {
        private DAL_ListBooks lstBook;

        [TestInitialize]
        public void SetUp()
        {
            this.lstBook = new DAL_ListBooks();
        }

        [TestMethod]
        public void TestUpdateQttAvailid()
        {
            DTO_BooksStore dtoBook = new DTO_BooksStore();
            dtoBook.book_id = 5;
            int qttA = 3;

            Assert.AreEqual(lstBook.updateQuantity_Availid(dtoBook, qttA), true);
        }

        [TestMethod]
        public void TestSearchingBook()
        {
            string name = "Tổ chức xây dựng công trình";
            DataTable dt = lstBook.search_book(name);

            Assert.AreEqual(dt.Rows.Count, 1);
        }

        [TestMethod]
        public void TestSearchingBookWithFalse()
        {
            string name = "ABC";
            DataTable dt = lstBook.search_book(name);

            Assert.IsFalse(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void TestBookInfor()
        {
            int book = 10;
            DataTable dt = lstBook.BookInfor(book);

            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void TestBookInforWithFalseValue()
        {
            int book = 42;
            DataTable dt = lstBook.BookInfor(book);

            Assert.IsFalse(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void TestGetTable()
        {
            DataTable dt = lstBook.getBooksStore();

            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
}
