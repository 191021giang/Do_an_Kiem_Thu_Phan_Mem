
namespace QuanLyThuVien
{
    partial class DK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DK));
            this.lbDangKy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btDangKy = new System.Windows.Forms.Button();
            this.btThoatDangKy = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lnTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbNhapLaiMK = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDangKy
            // 
            this.lbDangKy.AutoSize = true;
            this.lbDangKy.BackColor = System.Drawing.Color.Linen;
            this.lbDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKy.ForeColor = System.Drawing.Color.Maroon;
            this.lbDangKy.Location = new System.Drawing.Point(231, 24);
            this.lbDangKy.Name = "lbDangKy";
            this.lbDangKy.Size = new System.Drawing.Size(336, 36);
            this.lbDangKy.TabIndex = 23;
            this.lbDangKy.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.lbDangKy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Họ và tên :";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(263, 193);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 33);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // btDangKy
            // 
            this.btDangKy.BackColor = System.Drawing.Color.Moccasin;
            this.btDangKy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.Location = new System.Drawing.Point(162, 534);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(141, 50);
            this.btDangKy.TabIndex = 10;
            this.btDangKy.Text = "Đăng Ký";
            this.btDangKy.UseVisualStyleBackColor = false;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btThoatDangKy
            // 
            this.btThoatDangKy.BackColor = System.Drawing.Color.Moccasin;
            this.btThoatDangKy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoatDangKy.Location = new System.Drawing.Point(496, 534);
            this.btThoatDangKy.Name = "btThoatDangKy";
            this.btThoatDangKy.Size = new System.Drawing.Size(141, 50);
            this.btThoatDangKy.TabIndex = 9;
            this.btThoatDangKy.Text = "Thoát";
            this.btThoatDangKy.UseVisualStyleBackColor = false;
            this.btThoatDangKy.Click += new System.EventHandler(this.btThoatDangKy_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(263, 241);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(432, 33);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email : ";
            // 
            // txtQuan
            // 
            this.txtQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuan.Location = new System.Drawing.Point(263, 306);
            this.txtQuan.Multiline = true;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(175, 33);
            this.txtQuan.TabIndex = 5;
            this.txtQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuan_KeyPress);
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(79, 241);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(133, 23);
            this.lbSDT.TabIndex = 30;
            this.lbSDT.Text = "Số điện thoại :";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTaiKhoan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(263, 345);
            this.txtTenTaiKhoan.Multiline = true;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(432, 33);
            this.txtTenTaiKhoan.TabIndex = 7;
            this.txtTenTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTaiKhoan_KeyPress);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(77, 303);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(80, 23);
            this.lbDiaChi.TabIndex = 32;
            this.lbDiaChi.Text = "Địa chỉ :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Location = new System.Drawing.Point(263, 398);
            this.txtMatKhau.MaxLength = 10;
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(432, 33);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // lnTenTaiKhoan
            // 
            this.lnTenTaiKhoan.AutoSize = true;
            this.lnTenTaiKhoan.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnTenTaiKhoan.Location = new System.Drawing.Point(77, 344);
            this.lnTenTaiKhoan.Name = "lnTenTaiKhoan";
            this.lnTenTaiKhoan.Size = new System.Drawing.Size(138, 23);
            this.lnTenTaiKhoan.TabIndex = 34;
            this.lnTenTaiKhoan.Text = "Tên tài khoản :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(263, 146);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(432, 33);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // lbNhapLaiMK
            // 
            this.lbNhapLaiMK.AutoSize = true;
            this.lbNhapLaiMK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapLaiMK.Location = new System.Drawing.Point(79, 451);
            this.lbNhapLaiMK.Name = "lbNhapLaiMK";
            this.lbNhapLaiMK.Size = new System.Drawing.Size(177, 23);
            this.lbNhapLaiMK.TabIndex = 37;
            this.lbNhapLaiMK.Text = "Nhập lại mật khẩu :";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapLaiMK.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLaiMK.Location = new System.Drawing.Point(263, 451);
            this.txtNhapLaiMK.Multiline = true;
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(432, 33);
            this.txtNhapLaiMK.TabIndex = 9;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(79, 397);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(101, 23);
            this.lbMatKhau.TabIndex = 38;
            this.lbMatKhau.Text = "Mật khẩu :";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhPho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtThanhPho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhPho.Location = new System.Drawing.Point(496, 306);
            this.txtThanhPho.Multiline = true;
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(199, 33);
            this.txtThanhPho.TabIndex = 6;
            this.txtThanhPho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhPho_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Thành phố ";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(263, 93);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(432, 33);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(79, 92);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(139, 23);
            this.lbMSSV.TabIndex = 43;
            this.lbMSSV.Text = "Mã số sinh viên";
            // 
            // DK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(794, 592);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbMSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThanhPho);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbNhapLaiMK);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lnTenTaiKhoan);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btThoatDangKy);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDangKy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DK";
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.DK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Button btThoatDangKy;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lnTenTaiKhoan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbNhapLaiMK;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbMSSV;
    }


}
