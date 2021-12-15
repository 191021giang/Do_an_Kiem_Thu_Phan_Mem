using System;
using System.Collections.Generic;
using System.Text;
using QuanLyThuVien_DTO;
using QuanLyThuVien_DAL;
using System.Data;

namespace QuanLyThuVien_BUS
{
    public class BUS_Statics
    {
        private DAL_Statis dal_sta = new DAL_Statis();

        public DataTable sum_of_book()
        {
            return dal_sta.sum_of_book();
        }

        public DataTable list_statics()
        {
            return dal_sta.list_statis();
        }

        public DataTable statis_Borrow(string date)
        {
            return dal_sta.statis_Borrow(date);
        }

        public DataTable statis_Count(string start, string end)
        {
            return dal_sta.statis_Count(start, end);
        }
    }
}
