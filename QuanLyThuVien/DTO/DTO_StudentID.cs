using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_StudentID
    {
        public Int32 student_id { get; set; }
        public string student_name { get; set; }
        public string student_email { get; set; }
        public DTO_StudentID()
        {

        }

        public DTO_StudentID(int student_id, string student_name, string student_email)
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.student_email = student_email;
        }
    }
}
