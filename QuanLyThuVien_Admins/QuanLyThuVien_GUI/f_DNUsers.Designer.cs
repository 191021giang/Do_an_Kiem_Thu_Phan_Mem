﻿
namespace QuanLyThuVien
{
    partial class f_DNUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DNUsers));
            this.btThoatDangNhapUser = new System.Windows.Forms.Button();
            this.btDangNhapUser = new System.Windows.Forms.Button();
            this.txtMatKhauUser = new System.Windows.Forms.TextBox();
            this.txtTaiKhoanUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.cbHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoatDangNhapUser
            // 
            this.btThoatDangNhapUser.BackColor = System.Drawing.Color.Moccasin;
            this.btThoatDangNhapUser.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoatDangNhapUser.Location = new System.Drawing.Point(509, 471);
            this.btThoatDangNhapUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoatDangNhapUser.Name = "btThoatDangNhapUser";
            this.btThoatDangNhapUser.Size = new System.Drawing.Size(141, 62);
            this.btThoatDangNhapUser.TabIndex = 17;
            this.btThoatDangNhapUser.Text = "Thoát";
            this.btThoatDangNhapUser.UseVisualStyleBackColor = false;
            this.btThoatDangNhapUser.Click += new System.EventHandler(this.btThoatDangNhapUser_Click);
            // 
            // btDangNhapUser
            // 
            this.btDangNhapUser.BackColor = System.Drawing.Color.Moccasin;
            this.btDangNhapUser.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDangNhapUser.Location = new System.Drawing.Point(132, 471);
            this.btDangNhapUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDangNhapUser.Name = "btDangNhapUser";
            this.btDangNhapUser.Size = new System.Drawing.Size(141, 62);
            this.btDangNhapUser.TabIndex = 4;
            this.btDangNhapUser.Text = "Đăng Nhập ";
            this.btDangNhapUser.UseVisualStyleBackColor = false;
            this.btDangNhapUser.Click += new System.EventHandler(this.btDangNhapUser_Click);
            // 
            // txtMatKhauUser
            // 
            this.txtMatKhauUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhauUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMatKhauUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauUser.Location = new System.Drawing.Point(282, 328);
            this.txtMatKhauUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhauUser.Multiline = true;
            this.txtMatKhauUser.Name = "txtMatKhauUser";
            this.txtMatKhauUser.PasswordChar = '*';
            this.txtMatKhauUser.Size = new System.Drawing.Size(223, 41);
            this.txtMatKhauUser.TabIndex = 2;
            this.txtMatKhauUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhauUser_MouseClick);
            this.txtMatKhauUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauUser_KeyPress);
            // 
            // txtTaiKhoanUser
            // 
            this.txtTaiKhoanUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoanUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTaiKhoanUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoanUser.Location = new System.Drawing.Point(284, 204);
            this.txtTaiKhoanUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoanUser.Multiline = true;
            this.txtTaiKhoanUser.Name = "txtTaiKhoanUser";
            this.txtTaiKhoanUser.Size = new System.Drawing.Size(223, 41);
            this.txtTaiKhoanUser.TabIndex = 1;
            this.txtTaiKhoanUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTaiKhoanUser_MouseClick);
            this.txtTaiKhoanUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoanUser_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật Khẩu ";
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.Linen;
            this.lbDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lbDangNhap.Location = new System.Drawing.Point(278, 88);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(283, 41);
            this.lbDangNhap.TabIndex = 11;
            this.lbDangNhap.Text = "ĐĂNG NHẬP USER";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbHienThiMatKhau
            // 
            this.cbHienThiMatKhau.AutoSize = true;
            this.cbHienThiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbHienThiMatKhau.Location = new System.Drawing.Point(284, 398);
            this.cbHienThiMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHienThiMatKhau.Name = "cbHienThiMatKhau";
            this.cbHienThiMatKhau.Size = new System.Drawing.Size(151, 24);
            this.cbHienThiMatKhau.TabIndex = 3;
            this.cbHienThiMatKhau.Text = "Hiển thị mật khẩu ";
            this.cbHienThiMatKhau.UseVisualStyleBackColor = true;
            this.cbHienThiMatKhau.CheckedChanged += new System.EventHandler(this.cbHienThiMatKhau_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // DNUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbHienThiMatKhau);
            this.Controls.Add(this.btThoatDangNhapUser);
            this.Controls.Add(this.btDangNhapUser);
            this.Controls.Add(this.txtMatKhauUser);
            this.Controls.Add(this.txtTaiKhoanUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DNUsers";
            this.Text = "USER LOGIN ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoatDangNhapUser;
        private System.Windows.Forms.Button btDangNhapUser;
        private System.Windows.Forms.TextBox txtMatKhauUser;
        private System.Windows.Forms.TextBox txtTaiKhoanUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.CheckBox cbHienThiMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}