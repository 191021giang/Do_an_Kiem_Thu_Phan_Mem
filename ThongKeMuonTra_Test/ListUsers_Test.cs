using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLyThuVien_DAL;
using System.Data;

namespace ThongKeMuonTra_Test
{
    [TestClass]
    public class ListUsers_Test
    {
        private DAL_ListUsers user;

        [TestInitialize]
        public void SetUp()
        {
            this.user = new DAL_ListUsers();
        }

        [TestMethod]
        public void TestUserName()
        {
            DataTable dt = user.UsersName();

            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
}
