using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_Books
    {
        private DAL_Books dal = new DAL_Books();
        public DataTable GetBooks()
        {
            return dal.GetBooks();
        }

        public bool Insert(DTO_Books dto_book)
        {
            return dal.Insert(dto_book);
        }
        public bool Update(DTO_Books dto_book,int index)
        {
            return dal.Update(dto_book, index);
        }
        public bool Delete( int index)
        {
            return dal.Delete(index);
        }
    }
}