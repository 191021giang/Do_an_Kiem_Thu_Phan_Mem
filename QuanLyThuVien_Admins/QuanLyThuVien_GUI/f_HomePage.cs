using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }

        private void btnStatis_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ThongKe statis = new f_ThongKe();
            statis.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
