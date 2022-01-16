using System;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;

namespace ThongKeMuonTra_Test
{
    [TestClass]
    public class Borrow_Test
    {
        private DAL_Borrowers borr;

        [TestInitialize]
        public void SetUp()
        {
            this.borr = new DAL_Borrowers();
        }

        [TestMethod]
        public void Test_BorrowBook_TrueValue()
        {
            DateTime date_borr, date_areturn = new DateTime();
            date_borr = DateTime.Today;
            date_areturn = date_borr.AddDays(30);
            DTO_Borrowers dto = new DTO_Borrowers(1954052005, 5, 1, date_borr, date_areturn);
            Assert.AreEqual(borr.addBorrow(dto), true);
        }

        [TestMethod]
        public void Test_BorrowBook_NotBook()
        {
            DateTime date_borr, date_areturn = new DateTime();
            date_borr = DateTime.Today;
            date_areturn = date_borr.AddDays(30);
            DTO_Borrowers dto = new DTO_Borrowers(1954052005, 33, 1, date_borr, date_areturn);
            Assert.AreEqual(borr.addBorrow(dto), false);
        }

        [TestMethod]
        public void Test_Count()
        {
            Assert.AreEqual(borr.count_qtt(33), 0);
        }

    }
}
