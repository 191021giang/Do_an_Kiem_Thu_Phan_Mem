using System;
using System.Collections.Generic;
using System.Text;
using QuanLyThuVien_DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien_DAL
{
    public class DAL_Statis
    {
        private SqlConnection conn = DBConnection.GetDBConnection();

        /// <summary>
        /// Tính tổng số lượng sách nhập vào và số lượng sách hiện có trong bảng BooksStore
        /// </summary>
        /// <returns></returns>
        public DataTable sum_of_book()
        {
            string query = string.Format(@"SELECT 
                                            SUM(quantity), 
                                            SUM(available_quantity)
                                        FROM 
	                                        dbo.BooksStore");
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

        /// <summary>
        /// Lấy ra danh sách tất cả các sách trong bảng BooksStore
        /// </summary>
        /// <returns></returns>
        public DataTable list_statis()
        {
            string query = string.Format(@"SELECT 
                                                book_id AS N'Mã sách', 
                                                book_name AS N'Tên sách', 
                                                available_quantity AS N'Số lượng sách hiện tại'
                                            FROM
	                                            dbo.BooksStore");
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

        /// <summary>
        /// Lấy thông tin người mượn theo ngày
        /// </summary>
        /// <param name="date">ngày cần xem thống kê</param>
        /// <returns>danh sách người mượn phù hợp với ngày được nhập vào</returns>
        public DataTable statis_Borrow(string date)
        {
            string query = string.Format(@"SELECT
	                                b.student_id AS 'Mã độc giả',
	                                s.student_name AS 'Tên độc giả',
	                                bs.book_name AS 'Tên sách',
	                                b.qtt_borrow AS 'Số lượng mượn',
	                                b.date_of_return AS 'Ngày trả',
	                                b.note AS 'Tình trạng'
                                FROM
	                                dbo.Borrowers b INNER JOIN dbo.StudentID s
	                                ON s.student_id = b.student_id INNER JOIN dbo.BooksStore bs
	                                ON bs.book_id = b.book_id
                                WHERE
	                                b.date_of_return BETWEEN '{0} 00:00:00' AND '{0} 23:59:59'
	                                OR b.date_of_borrow BETWEEN '{0} 00:00:00' AND '{0} 23:59:59'", date);
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

        /// <summary>
        /// Đếm số lượt mượn sách trong khoảng thời gian được chọn theo mã sách
        /// </summary>
        /// <param name="start">ngày bắt đầu tra cứu</param>
        /// <param name="end">ngày kết thúc tra cứu</param>
        /// <returns>số lượt mượn theo mã sách</returns>
        public DataTable statis_Count(string start, string end)
        {
            string query = string.Format(@"SELECT
	                                        b.book_id AS 'Mã sách mượn',
	                                        bs.book_name AS 'Tên sách mượn',
	                                        COUNT(b.book_id) AS N'Số lượt mượn'
                                        FROM
	                                        dbo.Borrowers b INNER JOIN dbo.BooksStore bs
	                                        ON bs.book_id = b.book_id
                                        WHERE
	                                        b.date_of_borrow BETWEEN '{0} 00:00:00' AND '{1} 23:59:59'
                                        GROUP BY
	                                        b.book_id,
	                                        bs.book_name", start, end);
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
    }
}
