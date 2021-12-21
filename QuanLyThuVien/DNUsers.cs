using System;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyThuVien
{
    public partial class DNUsers : Form
    {
        DTO_Users dto_user = new DTO_Users();
        BUS_DNUser bus_dnuser = new BUS_DNUser();
        public DNUsers()
        {
            InitializeComponent();
        }

        private void btThoatDangNhapUser_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                DN dg1 = new DN();
                dg1.ShowDialog();
                this.Close();
            }
        }

        private void btDangNhapUser_Click(object sender, EventArgs e)
        {
            dto_user.users_account = txtTaiKhoanUser.Text;
            dto_user.users_password = txtMatKhauUser.Text;
            string us = bus_dnuser.CheckUser(dto_user);
            switch(us)
            {
                case "Khongtaikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "Khongmatkhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Hide();
            f_Homepage_User homeUser = new f_Homepage_User();
            homeUser.ShowDialog();
        }
       
        private void txtTaiKhoanUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaiKhoanUser.SelectAll();
        }

        private void txtMatKhauUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatKhauUser.SelectAll();
        }

        private void txtMatKhauUser_KeyPress(object sender, KeyPressEventArgs e)
        {        
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btDangNhapUser.PerformClick();
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMatKhauUser.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhauUser.PasswordChar = '*';
            }
        }

        private void txtTaiKhoanUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }

        private void DNUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
