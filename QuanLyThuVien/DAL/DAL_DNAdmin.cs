using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DNAdmin:DNA
    {       
        public string CheckAdmin(DTO_Admin dto_admin)
        {
            string ad = Checkdto(dto_admin);
            return ad;
        }       
    }
}
