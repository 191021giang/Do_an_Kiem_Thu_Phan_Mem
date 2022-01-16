using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien_BUS;

namespace QuanLyThuVien_GUI
{
    public partial class f_ThongKe : Form
    {
        BUS_Statics bus_static = new BUS_Statics();
        public f_ThongKe()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        public string start_date, end_date;
        #endregion

        private void f_ThongKe_Load(object sender, EventArgs e)
        {
            start_date = dtpStart.Value.ToString();
            end_date = dtpEnd.Value.ToString();
            sum_of_book();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            string date;
            date = convert_date(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);

            DataTable dt_date = bus_static.statis_Borrow(date);
            gridStatis.DataSource = dt_date;
            gridBook.Columns[0].Width = (int)(gridStatis.Width * 0.15);
            gridStatis.Columns[1].Width = (int)(gridStatis.Width * 0.2);
            gridStatis.Columns[2].Width = (int)(gridStatis.Width * 0.3);
            gridStatis.Columns[3].Width = (int)(gridStatis.Width * 0.075);
            gridStatis.Columns[4].Width = (int)(gridStatis.Width * 0.17);
            gridStatis.Columns[5].Width = (int)(gridStatis.Width * 0.1);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime start, end;
            start = DateTime.Parse(start_date);
            end = DateTime.Parse(end_date);

            try
            {
                if (start > end)
                {
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc!!!\nVui lòng chọn lại thời gian!!!");
                }
                else
                {
                    DataTable dt = bus_static.statis_Count(start_date, end_date);
                    gridStatis.DataSource = dt;
                    gridStatis.Columns[0].Width = (int)(gridStatis.Width * 0.15);
                    gridStatis.Columns[1].Width = (int)(gridStatis.Width * 0.5);
                    gridStatis.Columns[2].Width = (int)(gridStatis.Width * 0.15);
                    if (gridStatis.CurrentCell == null) 
                    {
                        MessageBox.Show("Không có thông tin thống kê!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            start_date = convert_date(dtpStart.Value.Year, dtpStart.Value.Month, dtpStart.Value.Day);
            lbStart.Text = dtpStart.Value.ToString();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            end_date = convert_date(dtpEnd.Value.Year, dtpEnd.Value.Month, dtpEnd.Value.Day);
            lbEnd.Text = dtpEnd.Value.ToString();
        }

        private void sum_of_book()
        {
            DataTable dt_sum_book = bus_static.sum_of_book();
            lbSumBook.Text = dt_sum_book.Rows[0][0].ToString();
            lbBook.Text = dt_sum_book.Rows[0][1].ToString();

            DataTable dt_list_book = bus_static.list_statics();
            gridBook.DataSource = dt_list_book;
            gridBook.Columns[0].Width = (int)(gridBook.Width * 0.15);
            gridBook.Columns[1].Width = (int)(gridBook.Width * 0.6);
            gridBook.Columns[2].Width = (int)(gridBook.Width * 0.15);
        }

        private void dtpDate_MouseCaptureChanged(object sender, EventArgs e)
        {
            lbStart.Text = "";
            lbEnd.Text = "";
            dtpStart.Value = dtpEnd.Value = DateTime.Today;
        }

        private void btnThoat_tab1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_HomePage home = new f_HomePage();
            home.ShowDialog();
        }

        private string convert_date(int yyyy, int mm, int dd)
        {
            string format_date;
            format_date = yyyy.ToString() + '-' + mm.ToString() + '-' + dd.ToString();
            return format_date;            
        }
        
    }
}
