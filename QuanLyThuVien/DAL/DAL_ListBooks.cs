using System;
using QuanLyThuVien_DTO;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace QuanLyThuVien_DAL
{
    public class DAL_ListBooks
    {
        private SqlConnection conn = DBConnection.GetDBConnection();

        /// <summary>
        /// Hàm lấy toàn bộ danh sách thông tin sách
        /// </summary>
        /// <returns></returns>
        public DataTable getBooksStore()
        {
            string query = string.Format("SELECT * FROM dbo.BooksStore");

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable BookInfor(int bookId)
        {
            string queryBook = string.Format(@"SELECT
	                                                b.book_id,
	                                                c.category_name,
	                                                a.author_name,
	                                                b.available_quantity
                                                FROM
	                                                dbo.Categories c INNER JOIN dbo.BooksStore b
	                                                ON b.category_id = c.category_id 
	                                                INNER JOIN dbo.Authors a
	                                                ON a.author_id = b.author_id
                                                WHERE
	                                                b.book_id = {0}", bookId);
            
            SqlCommand cmmd = new SqlCommand(queryBook, conn);
            try
            {
                conn.Open();

                SqlDataAdapter daBook = new SqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                daBook.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool updateQuantity_Availid(DTO_BooksStore dto_book, int qtt)
        {
            string query = string.Format(@"UPDATE dbo.BooksStore 
                                            SET available_quantity = {0}
                                            WHERE book_id = {1}", qtt, dto_book.book_id);

            SqlCommand cmd = new SqlCommand(query, conn);
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
            return false;
        }

        public DataTable search_book(string name)
        {
            string query = string.Format(@"SELECT * 
                                            FROM dbo.BooksStore
                                            WHERE book_name LIKE '%{0}%'", name);
            SqlCommand cmmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();

                SqlDataAdapter daBook = new SqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                daBook.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
