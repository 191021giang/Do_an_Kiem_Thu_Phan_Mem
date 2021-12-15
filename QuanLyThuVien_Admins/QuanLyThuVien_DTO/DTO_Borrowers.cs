using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien_DTO
{
    public class DTO_Borrowers
    {
        public Int32 borrower_number { get; set; }
        public Int32 student_id { get; set; }
        public Int64 book_id { get; set; }
        public Int64 qtt_borrow { get; set; }
        public DateTime date_of_borrow { get; set; }
        public DateTime date_of_appoint_return { get; set; }
        public DateTime date_of_return { get; set; }
        public String note { get; set; }
         
        public DTO_Borrowers()
        {

        }

        public DTO_Borrowers(Int32 borrower_number, Int32 student_id, Int64 book_id, Int64 qtt_borrow, DateTime date_of_borrow, DateTime date_of_appoint_return, DateTime date_of_return, String note)
        {
            this.borrower_number = borrower_number;
            this.student_id = student_id;
            this.book_id = book_id;
            this.date_of_borrow = date_of_borrow;
            this.date_of_return = date_of_return;
            this.note = note;
            this.date_of_appoint_return = date_of_appoint_return;
            this.qtt_borrow = qtt_borrow;
        }
    }
}
