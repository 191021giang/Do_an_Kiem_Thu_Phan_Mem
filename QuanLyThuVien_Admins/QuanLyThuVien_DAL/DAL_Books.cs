using System.Data.SqlClient;
using System.Data;
using DTO;
using QuanLyThuVien_DAL;

namespace DAL
{
    public class DAL_Books
    {
        private SqlConnection conn = DBConnection.GetDBConnection();       
       public DataTable GetBooks()
        {
            string book = string.Format(@"select book_id,
                                        book_name ,
                                        author_id,
                                        category_id,
                                        publisher_name, 
                                        quantity, 
                                        available_quantity from BooksStore");
            SqlCommand cmd = new SqlCommand(book, conn);
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool Insert(DTO_Books dto_book)
        {

            string sb = string.Format(@"Insert into BooksStore (
                                        book_name ,
                                        author_id,
                                        category_id,
                                        publisher_name, 
                                        quantity, 
                                        available_quantity)values 
                                        (N'{0}',{1},{2},N'{3}',{4},{5})", dto_book.book_name, dto_book.author_id, dto_book.category_id, dto_book.publisher_name, dto_book.quantity, dto_book.available_quantity);
            SqlCommand cmd = new SqlCommand(sb, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex1)
            {

                throw ex1;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool Update (DTO_Books dto_book,int index )
        {
            string sb = string.Format(@"Update BooksStore set 
                                        book_name = N'{0}',
                                        author_id = {1},
                                        category_id = {2},
                                        publisher_name = N'{3}',
                                        quantity = {4},
                                        available_quantity={5} where book_id = {6} 
                                        ", dto_book.book_name, dto_book.author_id, dto_book.category_id, dto_book.publisher_name, dto_book.quantity, dto_book.available_quantity,index);
            SqlCommand cmd = new SqlCommand(sb, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex1)
            {
                
                throw ex1;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool Delete( int index)
        {
            string sb = string.Format(@"Delete from BooksStore 
                                         where book_id = {0} 
                                        ", index);
            SqlCommand cmd = new SqlCommand(sb, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex1)
            {

                throw ex1;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }

}

