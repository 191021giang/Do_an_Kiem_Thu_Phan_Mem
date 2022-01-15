using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLyThuVien;
using DTO;
using BUS;
using DAL;

namespace QLTV_Tester
{
    [TestClass]
    public class DKTest
    {
        private BUS_Users bus_user;
        private DTO_Users dto_user;
        private DAL_Users dal_user;

        [TestInitialize]
        public void SetUp()
        {
            this.bus_user = new BUS_Users();
            this.dto_user = new DTO_Users();
            this.dal_user = new DAL_Users();
        }
        [TestMethod]
        public void Dangkysaithongtin()
        {
            dto_user.users_id = 1954052049;
            dto_user.users_name = "Duong Thi Xuan Giang";
            dto_user.users_email = "195";
            dto_user.users_phone = "0356444487";
            dto_user.users_district = "BT";
            dto_user.users_city = "HCM";
            dto_user.users_account = "giangSV";
            dto_user.users_password = "123456Gh";
            int i = 0; 
            Assert.AreEqual(i,dal_user.Insert(dto_user));
        }
        //[TestMethod]
        //public void Dangkydungthongtin()
        //{
        //    dto_user.users_id = 1954052049;
        //    dto_user.users_name = "Duong Thi Xuan Giang";
        //    dto_user.users_email = "195giang@ou.edu.vn";
        //    dto_user.users_phone = "0356444487";
        //    dto_user.users_district = "BT";
        //    dto_user.users_city = "HCM";
        //    dto_user.users_account = "giangSV";
        //    dto_user.users_password = "123456Gh";
        //    int i = dal_user.Insert(dto_user);
        //    Assert.AreEqual(i!=0 ,dal_user.Insert(dto_user));
        //}
    }
}
