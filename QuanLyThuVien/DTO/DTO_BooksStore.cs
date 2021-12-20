using System;

namespace QuanLyThuVien_DTO
{
    public class DTO_BooksStore
    {
        public Int64 book_id { get; set; }
        public String book_name { get; set; }
        public Int64 author_id { get; set; }
        public Int64 category_id { get; set; }
        public String publisher_name { get; set; }
        public Int64 quantity { get; set; }
        public Int64 available_quantity { get; set; }

        public DTO_BooksStore()
        {

        }

        public DTO_BooksStore(Int64 book_id, String book_name, Int64 author_id, Int64 category_id, String publisher_name, Int64 quantity, Int64 available_quantity)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.author_id = author_id;
            this.category_id = category_id;
            this.publisher_name = publisher_name;
            this.quantity = quantity;
            this.available_quantity = available_quantity;
        }
    }
}
