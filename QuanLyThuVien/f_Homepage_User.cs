using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class f_Homepage_User : Form
    {
        public DTO_Users dto_user;
        public f_Homepage_User()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được cập nhật!\nVui lòng quay lại sau!");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_XemSach xemSach = new f_XemSach();
            xemSach.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN dangNhap = new DN();
            dangNhap.ShowDialog();
        }
    }
}
