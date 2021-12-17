using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Books
    {
        public Int32 book_id { get; set; }
        public string book_name { get; set; }
        public Int32 author_id { get; set; }
        public Int32 category_id { get; set; }
        public string publisher_name { get; set; }
        public Int32 quantity { get; set; }
        public Int32 available_quantity { get; set; }
        public DTO_Books()
        {

        }
        public DTO_Books(Int32 book_id, string book_name, Int32 author_id, Int32 category_id, string publisher_name, Int32 quantity, Int32 available_quantity)
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
