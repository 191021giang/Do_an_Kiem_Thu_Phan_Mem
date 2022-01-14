using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;
using System.Data;
using System.Data.SqlClient;

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
        public void TestAddBorrowWithTrueValue()
        {
            DateTime date_borr, date_areturn = new DateTime();
            date_borr = DateTime.Now;
            date_areturn = date_borr.AddDays(30);
            DTO_Borrowers dto = new DTO_Borrowers(1954052005, 5, 1, date_borr, date_areturn);
            Assert.AreEqual(borr.addBorrow(dto), true);
        }

        [TestMethod]
        public void TestAddBorrowWithFalseValue()
        {
            DateTime date_borr, date_areturn = new DateTime();
            date_borr = DateTime.Now;
            date_areturn = date_borr.AddDays(30);
            DTO_Borrowers dto = new DTO_Borrowers(1954052005, 33, 1, date_borr, date_areturn);
            Assert.AreEqual(borr.addBorrow(dto), false);
        }

        [TestMethod]
        public void TestCountQuantity()
        {
            Assert.AreEqual(borr.count_qtt(33), 0);
        }

        [TestMethod]
        public void TestSearchingBorrower()
        {
            string borrower = "1954052000";
            DataTable dt = borr.searching_Borrow(borrower);

            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestSearchingBorrowerWithString()
        {
            string borrower = "a";
            borr.searching_Borrow(borrower);            
        }

        [TestMethod]
        public void TestUpdateDateOfReturn()
        {
            DTO_Borrowers dto_bor = new DTO_Borrowers();
            int stt = 30;
            dto_bor.date_of_return = DateTime.Now;
            dto_bor.note = "";
            Assert.AreEqual(borr.update_date_of_return(dto_bor, stt), true);
        }

        [TestMethod]
        public void TestGetBorrow()
        {
            DataTable dt = borr.getGrid_Borrowers();

            Assert.IsTrue(dt.Rows.Count > 0);
        }


    }
}
