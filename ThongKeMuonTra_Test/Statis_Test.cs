using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLyThuVien_DAL;
using System.Data;
using System.Data.SqlClient;

namespace ThongKeMuonTra_Test
{
    [TestClass]
    public class Statis_Test
    {
        private DAL_Statis statis;

        [TestInitialize]
        public void SetUp()
        {
            this.statis = new DAL_Statis();
        }

        [TestMethod]
        public void TestSumOfBook()
        {
            DataTable dt = statis.sum_of_book();

            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void TestListStatis()
        {
            DataTable dt = statis.list_statis();

            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void TestStatisBorrow()
        {
            string date = "20220115";

            DataTable dt = statis.statis_Borrow(date);

            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void TestStatisBorrowWithText()
        {
            string date = "abc";

            DataTable dt = statis.statis_Borrow(date);
        }

        [TestMethod]
        public void TestStatisCount()
        {
            string begin = "20220101";
            string end = "20220115";

            DataTable dt = statis.statis_Count(begin, end);

            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void TestStatisCountWithText()
        {
            string begin = "a";
            string end = "b";

            DataTable dt = statis.statis_Count(begin, end);
        }

    }
}
