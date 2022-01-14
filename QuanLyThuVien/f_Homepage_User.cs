using DTO;
using System;
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
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                DN dangNhap = new DN();
                dangNhap.ShowDialog();
            }            
        }
    }
}
