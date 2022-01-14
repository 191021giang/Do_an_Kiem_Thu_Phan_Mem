using System;
using System.Data.SqlClient;
using System.Data;
using QuanLyThuVien_DTO;
using DAL;

namespace QuanLyThuVien_DAL
{
    public class DAL_Borrowers
    {
        private SqlConnection conn = DBConnection.GetDBConnection();

        /// <summary>
        /// Hàm lấy danh sách người mượn
        /// </summary>
        /// <returns></returns>
        public DataTable getGrid_Borrowers()
        {
            string query = string.Format(@"SELECT 
	                                            borrower_number AS 'STT', 
	                                            student_id AS 'Mã số người mượn', 
	                                            book_id AS 'Mã sách mượn', 
	                                            qtt_borrow AS 'Số lượng mượn', 
	                                            date_of_borrow AS 'Ngày mượn', 
	                                            date_of_appoint_return AS 'Ngày hẹn trả', 
	                                            date_of_return AS 'Ngày thực trả', 
	                                            note AS 'Ghi chú'
                                            FROM dbo.Borrowers");
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
        
        public int count_qtt(long book_id)
        {
            string query = string.Format(@"SELECT available_quantity
                                            FROM dbo.BooksStore
                                            WHERE book_id = {0}", book_id);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                int qtt = (int)cmd.ExecuteScalar();
                return qtt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }

        /// <summary>
        /// Hàm thêm thông tin người mượn vào bảng Borrowers
        /// </summary>
        /// <param name="dto_Borrow"></param>
        /// <returns></returns>
        public bool addBorrow(DTO_Borrowers dto_Borrow)
        {
            if (count_qtt(dto_Borrow.book_id) < dto_Borrow.qtt_borrow)
            {
                return false;
            }

            string query = string.Format(@"INSERT INTO dbo.Borrowers
                                            (
                                                student_id,
                                                book_id,
                                                date_of_borrow,
                                                date_of_appoint_return,
                                                qtt_borrow
                                            )
                                            VALUES
                                            (   {0},         -- student_id - int
                                                {1},         -- book_id - int
                                                '{2}', -- date_of_borrow - datetime
                                                '{3}', -- date_of_appoint_return - datetime
                                                {4}          -- qtt_borrow - int
                                                )", 
                                           dto_Borrow.student_id, dto_Borrow.book_id, dto_Borrow.date_of_borrow, 
                                           dto_Borrow.date_of_appoint_return, dto_Borrow.qtt_borrow);
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

        /// <summary>
        /// Hàm tìm kiếm thông tin người mượn qua mã số sinh viên
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DataTable searching_Borrow(string value)
        {
            int item = Int32.Parse(value);
            string query = string.Format(@"SELECT 
                                                borrower_number AS 'STT', 
	                                            student_id AS 'Mã số người mượn', 
	                                            book_id AS 'Mã sách mượn', 
	                                            qtt_borrow AS 'Số lượng mượn', 
	                                            date_of_borrow AS 'Ngày mượn', 
	                                            date_of_appoint_return AS 'Ngày hẹn trả', 
	                                            date_of_return AS 'Ngày thực trả', 
	                                            note AS 'Ghi chú'
                                            FROM 
	                                            dbo.Borrowers 
                                            WHERE
	                                            student_id LIKE '%{0}%'", item);
            SqlCommand cmd = new SqlCommand(query, conn);
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

        /// <summary>
        /// Cập nhật ngày thực trả sách
        /// </summary>
        /// <param name="date"></param>
        /// <param name="note"></param>
        /// <param name="stt"></param>
        /// <returns></returns>
        public bool update_date_of_return(DTO_Borrowers dto_borrow, int stt)
        {
            string query = string.Format(@"UPDATE dbo.Borrowers 
                                            SET 
	                                            date_of_return = '{0}',
	                                            note = N'{1}'
                                            WHERE
	                                            borrower_number = {2}", dto_borrow.date_of_return, dto_borrow.note, stt);
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
    }
}
