using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLyThuVien;
using DTO;
using DAL;
using BUS;
namespace QLTV_Tester
{
    [TestClass]
    public class DNTest
    {
        private DAL_DNAdmin dal_ad;
        private DNA dna;
        private BUS_Admin bus_admin;
        [TestInitialize]
        public void SetUp()
        {       
            this.dal_ad = new DAL_DNAdmin();
        }
        [TestMethod]
        public void LoginadPass()
        {        
            DTO_Admin dto_ad = new DTO_Admin();
            dto_ad.admin_user = "xuangiangAD";
            dto_ad.admin_password = "xuangiangAD01";
            Assert.AreEqual(null, dal_ad.CheckAdmin(dto_ad));
        }
        [TestMethod]
        public void LoginadFail1()
        {
            DTO_Admin dto_ad = new DTO_Admin();
            bus_admin = new BUS_Admin();
            string ex = "Khongtaikhoan";          
            dto_ad.admin_user ="";
            dto_ad.admin_password = "xuangiangAD01";
            Assert.AreEqual(ex, bus_admin.CheckAdmin(dto_ad));
        }
        [TestMethod]
        public void LoginadFail2()
        {
            DTO_Admin dto_ad = new DTO_Admin();
            bus_admin = new BUS_Admin();
            string ex = "Khongmatkhau";
            dto_ad.admin_user = "xuangiangAD01";
            dto_ad.admin_password ="" ;
            Assert.AreEqual(ex, bus_admin.CheckAdmin(dto_ad));
        }
        [TestMethod]
        public void LoginadFail3()
        {
            DTO_Admin dto_ad = new DTO_Admin();
            dna = new DNA();
            string ex = "Tài khoản hoặc mật khẩu không chính xác!";
            dto_ad.admin_user = "";
            dto_ad.admin_password = "";
            string ac = DAL.DNA.Checkdto(dto_ad);
            Assert.AreEqual(ex,ac);
        }
    }
    [TestClass]
    public class DNUsers
    {
        
        private DAL_DNUser dal_us;
        private DNU dna;
        private BUS_DNUser bus_us;
        private DTO_Users dto_us;
        
        [TestInitialize]
        public void SetUp()
        {           
            this.dal_us = new DAL_DNUser();
            this.dto_us = new DTO_Users();
        }
        [TestMethod]
        public void LoginusPass()
        {          
            dto_us.users_account = "ngocbichSV";
            dto_us.users_password = "ngocbichSV2000";
            Assert.AreEqual(null, dal_us.CheckUser(dto_us));
        }
        [TestMethod]
        public void LoginusFail1()
        {          
            bus_us = new BUS_DNUser();
            string ex = "Khongtaikhoan";            
            dto_us.users_account = "";
            dto_us.users_password = "ngocbichSV2000";
            Assert.AreEqual(ex, bus_us.CheckUser(dto_us));
        }
        [TestMethod]
        public void LoginusFail2()
        {
            bus_us = new BUS_DNUser();
            string ex = "Khongmatkhau";
            dto_us.users_account = "ngocbichSV2000";
            dto_us.users_password = "";
            Assert.AreEqual(ex, bus_us.CheckUser(dto_us));
        }
    
        [TestMethod]
        public void LoginadFail3()
        {
            DTO_Admin dto_ad = new DTO_Admin();
            dna = new DNU();
            string ex = "Tài khoản hoặc mật khẩu không chính xác!";
            dto_us.users_account = "";
            dto_us.users_password= "";
            string ac = DAL.DNU.CheckDTO(dto_us);
            Assert.AreEqual(ex, ac);
        }
    }
}

