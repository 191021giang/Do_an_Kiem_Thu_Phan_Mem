﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyThuVien
{
    public partial class DK : Form
    {

        DTO_Users dto_user = new DTO_Users();
        BUS_DNUser bus_dnuser = new BUS_DNUser();
        public DK()
        {
            InitializeComponent();
        }
        BUS_Users bus_user = new BUS_Users();

        static public bool KiemTraHoTen(string hoTen)//Kiểm tra có chữ Hoa 
        {
            string[] arr = hoTen.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i][0]) == true)
                    return false;

            }
            return true;
        }
        public bool KTMatKhau()
        {
            bool kq = false;
            if (txtMatKhau.Text == txtNhapLaiMK.Text)
                kq = true;
            return kq;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {

            if (txtID.Text.Trim() != "" && txtHoTen.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtQuan.Text.Trim() != "" && txtThanhPho.Text.Trim() != "" && txtTenTaiKhoan.Text.Trim() != "" && txtMatKhau.Text.Trim() != "")
            {
                if (KTMatKhau())
                {
                    string ht = txtHoTen.Text;
                    if (KiemTraHoTen(ht))
                    {
                        if (txtSDT.Text.Length >= 9)
                        {
                            dto_user.users_id = Int32.Parse(txtID.Text);
                            dto_user.users_name = txtHoTen.Text;
                            dto_user.users_email = txtEmail.Text;
                            dto_user.users_phone = txtSDT.Text;
                            dto_user.users_district = txtQuan.Text;
                            dto_user.users_city = txtThanhPho.Text;
                            dto_user.users_account = txtTenTaiKhoan.Text;
                            dto_user.users_password = txtMatKhau.Text;
                            txtID.ResetText();
                            txtHoTen.ResetText();
                            txtEmail.ResetText();
                            txtQuan.ResetText();
                            txtThanhPho.ResetText();
                            txtMatKhau.ResetText();
                            txtNhapLaiMK.ResetText();
                            int i = bus_user.Insert(dto_user);
                            if (i != 0)
                            {
                                MessageBox.Show("Đăng ký thành công !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtID.Text = i.ToString();
                                LoadData();
                            }
                            else
                                MessageBox.Show("Bạn không phải sinh viên OU !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("SĐT có độ dài từ 9-11 ký tự !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Độ dài Họ tên tối thiểu 10 ký tự, ký tự đầu phải viết hoa  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xác nhận mật khẩu không trùng khớp !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DK_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {

        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e) //oke
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Space && (Keys)e.KeyChar != Keys.Back)//oke
                e.Handled = true;
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)//oke
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }
        private void txtQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Space && (Keys)e.KeyChar != Keys.Back)//oke
                e.Handled = true;
        }

        private void txtThanhPho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Space && (Keys)e.KeyChar != Keys.Back) //oke
                e.Handled = true;
        }

        private void txtTenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e) //pass test case
        {
            if (!Char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
            if ((int)e.KeyChar > 127)
                e.Handled = true;
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text
               .RegularExpressions.Regex(@"^[0-9a-zA-Z._-][\w\.-]{2,28}@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9](\.(vn|[a-zA-Z]{2}))$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng đăng ký bằng email trường", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex MK = new System.Text
              .RegularExpressions.Regex(@"^.*(?=.{8,10})(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$");
            if (txtMatKhau.Text.Length > 0)
            {
                if (!MK.IsMatch(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu có chữ hoa, chữ thường, số. Tối thiểu 8 ký tự, tối đa 10 ký tự !!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void btThoatDangKy_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                DN dangNhap = new DN();
                dangNhap.ShowDialog();
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
            if (cbHienThiMatKhau.Checked)
            {
                txtNhapLaiMK.PasswordChar = (char)0;
            }
            else
            {
                txtNhapLaiMK.PasswordChar = '*';
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex SDT = new System.Text
              .RegularExpressions.Regex(@"0(3\d{9}|4\d{8}|5\d{7}|7\d{6}|8\d{5}|9\d{4})");
            if (txtSDT.Text.Length > 0)
            {
                if (!SDT.IsMatch(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không tồn tại !!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}


