﻿
namespace QuanLyThuVien
{
    partial class f_DNAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DNAdmin));
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoanAdmin = new System.Windows.Forms.TextBox();
            this.txtMatKhauAdmin = new System.Windows.Forms.TextBox();
            this.btDangNhapAdmin = new System.Windows.Forms.Button();
            this.btThoatDangNhapAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lbDangNhap.Location = new System.Drawing.Point(258, 101);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(314, 41);
            this.lbDangNhap.TabIndex = 4;
            this.lbDangNhap.Text = "ĐĂNG NHẬP ADMIN";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mật Khẩu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(289, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài Khoản";
            // 
            // txtTaiKhoanAdmin
            // 
            this.txtTaiKhoanAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoanAdmin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTaiKhoanAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoanAdmin.Location = new System.Drawing.Point(291, 215);
            this.txtTaiKhoanAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoanAdmin.Multiline = true;
            this.txtTaiKhoanAdmin.Name = "txtTaiKhoanAdmin";
            this.txtTaiKhoanAdmin.Size = new System.Drawing.Size(200, 41);
            this.txtTaiKhoanAdmin.TabIndex = 1;
            this.txtTaiKhoanAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTaiKhoanAdmin_MouseClick);
            this.txtTaiKhoanAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoanAdmin_KeyPress);
            // 
            // txtMatKhauAdmin
            // 
            this.txtMatKhauAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhauAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMatKhauAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauAdmin.Location = new System.Drawing.Point(291, 346);
            this.txtMatKhauAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhauAdmin.Multiline = true;
            this.txtMatKhauAdmin.Name = "txtMatKhauAdmin";
            this.txtMatKhauAdmin.PasswordChar = '*';
            this.txtMatKhauAdmin.Size = new System.Drawing.Size(200, 41);
            this.txtMatKhauAdmin.TabIndex = 15;
            this.txtMatKhauAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhauAdmin_MouseClick);
            this.txtMatKhauAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauAdmin_KeyPress);
            // 
            // btDangNhapAdmin
            // 
            this.btDangNhapAdmin.BackColor = System.Drawing.Color.Moccasin;
            this.btDangNhapAdmin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDangNhapAdmin.Location = new System.Drawing.Point(139, 456);
            this.btDangNhapAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDangNhapAdmin.Name = "btDangNhapAdmin";
            this.btDangNhapAdmin.Size = new System.Drawing.Size(141, 62);
            this.btDangNhapAdmin.TabIndex = 4;
            this.btDangNhapAdmin.Text = "Đăng Nhập ";
            this.btDangNhapAdmin.UseVisualStyleBackColor = false;
            this.btDangNhapAdmin.Click += new System.EventHandler(this.btDangNhapAdmin_Click);
            // 
            // btThoatDangNhapAdmin
            // 
            this.btThoatDangNhapAdmin.BackColor = System.Drawing.Color.Moccasin;
            this.btThoatDangNhapAdmin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoatDangNhapAdmin.Location = new System.Drawing.Point(472, 456);
            this.btThoatDangNhapAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoatDangNhapAdmin.Name = "btThoatDangNhapAdmin";
            this.btThoatDangNhapAdmin.Size = new System.Drawing.Size(141, 62);
            this.btThoatDangNhapAdmin.TabIndex = 10;
            this.btThoatDangNhapAdmin.Text = "Thoát";
            this.btThoatDangNhapAdmin.UseVisualStyleBackColor = false;
            this.btThoatDangNhapAdmin.Click += new System.EventHandler(this.btThoatDangNhapAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(321, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 12;
            // 
            // cbHienThiMatKhau
            // 
            this.cbHienThiMatKhau.AutoSize = true;
            this.cbHienThiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbHienThiMatKhau.Location = new System.Drawing.Point(291, 421);
            this.cbHienThiMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHienThiMatKhau.Name = "cbHienThiMatKhau";
            this.cbHienThiMatKhau.Size = new System.Drawing.Size(147, 24);
            this.cbHienThiMatKhau.TabIndex = 3;
            this.cbHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.cbHienThiMatKhau.UseVisualStyleBackColor = true;
            this.cbHienThiMatKhau.CheckedChanged += new System.EventHandler(this.cbHienThiMatKhau_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DNAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(777, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbHienThiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btThoatDangNhapAdmin);
            this.Controls.Add(this.btDangNhapAdmin);
            this.Controls.Add(this.txtMatKhauAdmin);
            this.Controls.Add(this.txtTaiKhoanAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DNAdmin";
            this.Text = "ADMIN LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoanAdmin;
        private System.Windows.Forms.TextBox txtMatKhauAdmin;
        private System.Windows.Forms.Button btDangNhapAdmin;
        private System.Windows.Forms.Button btThoatDangNhapAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbHienThiMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}