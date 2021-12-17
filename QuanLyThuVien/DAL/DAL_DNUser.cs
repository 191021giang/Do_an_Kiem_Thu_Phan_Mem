using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DNUser:DNU
    {
        public string CheckUser(DTO_Users dto_user)
        {
            string us = CheckDTO(dto_user);
            return us;
        }
    }
}
