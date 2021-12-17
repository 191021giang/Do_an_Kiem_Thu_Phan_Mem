using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Users
    {
        private DAL_Users dal = new DAL_Users();
             
        public int Insert(DTO_Users us)
        {
            return dal.Insert(us);
        }

        //public bool KTraSV(int id)
        //{
        //    return dal.KTraSV(id);
        //}
    }

}

