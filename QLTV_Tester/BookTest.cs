using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuanLyThuVien;
using DAL;
using DTO;
namespace QLTV_Tester
{
    [TestClass]
    public class BookTest
    {
        private DAL_Books dal_book;
        private DTO_Books dto_book;
        [TestInitialize]
        public void Setup()
        {
            this.dal_book = new DAL_Books();
            this.dto_book = new DTO_Books();
        }
        [TestMethod]
        public void Themsach()
        {
            dto_book.book_name = "Sach moi";
            dto_book.author_id = 10;
            dto_book.category_id = 10;
            dto_book.available_quantity = 10;
            dto_book.quantity = 10;
            dto_book.publisher_name = "Nhan";
            Assert.AreEqual(true, dal_book.Insert(dto_book));
        }
        [TestMethod]
        public void Chinhsuasach()
        {
            dto_book.book_name = "Sach moi";
            dto_book.author_id = 10;
            dto_book.category_id = 10;
            dto_book.available_quantity = 10;
            dto_book.quantity = 10;
            dto_book.publisher_name = "Nhan";
            Assert.AreEqual(true, dal_book.Update(dto_book,5));
        }
        [TestMethod]
        public void Xoasach()
        {         
            Assert.AreEqual(true, dal_book.Delete(1));
        }
    }
}
