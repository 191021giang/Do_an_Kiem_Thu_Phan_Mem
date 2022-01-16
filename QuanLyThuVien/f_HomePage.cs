using System;
using System.Windows.Forms;
using QuanLyThuVien;

namespace QuanLyThuVien_GUI
{
    public partial class f_HomePage : Form
    {
        public f_HomePage()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_MuonTraSach borr_return = new f_MuonTraSach();
            borr_return.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books f_book = new Books();
            f_book.ShowDialog();
        }

        private void btnStatis_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ThongKe statis = new f_ThongKe();
            statis.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN dangNhap = new DN();
            dangNhap.ShowDialog();
        }
    }
}
