
namespace QuanLyThuVien
{
    partial class f_DN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DN));
            this.btAdmin = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.btDangKy = new System.Windows.Forms.Button();
            this.btThoatDN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.Color.Moccasin;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAdmin.Location = new System.Drawing.Point(227, 194);
            this.btAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(31, 38);
            this.btAdmin.TabIndex = 1;
            this.btAdmin.UseVisualStyleBackColor = false;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.Moccasin;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUser.Location = new System.Drawing.Point(227, 278);
            this.btUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(31, 39);
            this.btUser.TabIndex = 2;
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDangNhap.Location = new System.Drawing.Point(298, 65);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(200, 41);
            this.lbDangNhap.TabIndex = 3;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btDangKy
            // 
            this.btDangKy.BackColor = System.Drawing.Color.Moccasin;
            this.btDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDangKy.Location = new System.Drawing.Point(227, 441);
            this.btDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(165, 75);
            this.btDangKy.TabIndex = 4;
            this.btDangKy.Text = "Đăng Ký";
            this.btDangKy.UseVisualStyleBackColor = false;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btThoatDN
            // 
            this.btThoatDN.BackColor = System.Drawing.Color.Moccasin;
            this.btThoatDN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoatDN.Location = new System.Drawing.Point(430, 441);
            this.btThoatDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoatDN.Name = "btThoatDN";
            this.btThoatDN.Size = new System.Drawing.Size(165, 75);
            this.btThoatDN.TabIndex = 5;
            this.btThoatDN.Text = "Thoát";
            this.btThoatDN.UseVisualStyleBackColor = false;
            this.btThoatDN.Click += new System.EventHandler(this.btThoatDN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đăng nhập tư cách Admin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(298, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đăng nhập tư cách User ";
            // 
            // DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoatDN);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.btAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DN";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Button btThoatDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

