using System;

namespace DTO
{
    public class DTO_Categories
    {
        public Int64 category_id { get; set; }
        public String category_name { get; set; }

        public DTO_Categories()
        {

        }

        public DTO_Categories(Int64 category_id, String category_name)
        {
            this.category_id = category_id;
            this.category_name = category_name;
        }
    }
}
