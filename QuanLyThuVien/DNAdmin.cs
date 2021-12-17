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
    public partial class DNAdmin : Form
    {
        public DNAdmin()
        {
            InitializeComponent();
        }

        private void btDangNhapAdmin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationSettings.AppSettings["mssql_cnstr"];

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "DNAdmin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Taikhoan", txtTaiKhoanAdmin.Text);
                cmd.Parameters.AddWithValue("@Matkhau", txtMatKhauAdmin.Text);
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaiKhoanAdmin.Text = "";
                    txtMatKhauAdmin.Text = "";
                    txtTaiKhoanAdmin.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaiKhoanAdmin.Text = "";
                    txtMatKhauAdmin.Text = "";
                    txtTaiKhoanAdmin.Focus();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btThoatDangNhapAdmin_Click(object sender, EventArgs e)
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

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMatKhauAdmin.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhauAdmin.PasswordChar = '*';
            }
        }

        private void txtTaiKhoanAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaiKhoanAdmin.SelectAll();
        }

        private void txtMatKhauAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatKhauAdmin.SelectAll();
        }

        private void txtMatKhauAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btDangNhapAdmin.PerformClick();
            }
        }

        private void txtTaiKhoanAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }
    }   
}

