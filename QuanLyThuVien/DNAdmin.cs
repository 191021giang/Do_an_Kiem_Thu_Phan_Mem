﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyThuVien
{
    public partial class DNAdmin : Form
    {

        DTO_Admin dto_admin = new DTO_Admin();
        BUS_Admin bus_admin = new BUS_Admin();
        public DNAdmin()
        {
            InitializeComponent();
        }

        private void btDangNhapAdmin_Click(object sender, EventArgs e)
        {
            dto_admin.admin_user = txtTaiKhoanAdmin.Text;
            dto_admin.admin_password = txtMatKhauAdmin.Text;
            string us = bus_admin.CheckAdmin(dto_admin);
            switch (us)
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
            MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DNAdmin_Load(object sender, EventArgs e)
        {

        }
    }   
}

