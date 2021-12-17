using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyThuVien
{
    public partial class f_DNUsers : Form
    {
        public f_DNUsers()
        {
            InitializeComponent();
        }

        private void btThoatDangNhapUser_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                f_DN dg1 = new f_DN();
                dg1.ShowDialog();
                this.Close();
            }
        }

        private void btDangNhapUser_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationSettings.AppSettings["mssql_cnstr"];

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "DNUsers";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Taikhoan", txtTaiKhoanUser.Text);
                cmd.Parameters.AddWithValue("@Matkhau", txtMatKhauUser.Text);
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaiKhoanUser.Text = "";
                    txtMatKhauUser.Text = "";
                    txtTaiKhoanUser.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaiKhoanUser.Text = "";
                    txtMatKhauUser.Text = "";
                    txtTaiKhoanUser.Focus();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
