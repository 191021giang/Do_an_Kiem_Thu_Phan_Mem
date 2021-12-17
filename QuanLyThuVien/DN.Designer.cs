
namespace QuanLyThuVien
{
    partial class DN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DN));
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
            this.btAdmin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.Location = new System.Drawing.Point(227, 155);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(31, 30);
            this.btAdmin.TabIndex = 1;
            this.btAdmin.UseVisualStyleBackColor = false;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.Location = new System.Drawing.Point(227, 222);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(31, 31);
            this.btUser.TabIndex = 2;
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(314, 54);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(203, 36);
            this.lbDangNhap.TabIndex = 3;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btDangKy
            // 
            this.btDangKy.BackColor = System.Drawing.Color.Moccasin;
            this.btDangKy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.Location = new System.Drawing.Point(227, 353);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(165, 60);
            this.btDangKy.TabIndex = 4;
            this.btDangKy.Text = "Đăng Ký";
            this.btDangKy.UseVisualStyleBackColor = false;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btThoatDN
            // 
            this.btThoatDN.BackColor = System.Drawing.Color.Moccasin;
            this.btThoatDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoatDN.Location = new System.Drawing.Point(430, 353);
            this.btThoatDN.Name = "btThoatDN";
            this.btThoatDN.Size = new System.Drawing.Size(165, 60);
            this.btThoatDN.TabIndex = 5;
            this.btThoatDN.Text = "Thoát";
            this.btThoatDN.UseVisualStyleBackColor = false;
            this.btThoatDN.Click += new System.EventHandler(this.btThoatDN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đăng nhập tư cách Admin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đăng nhập tư cách User ";
            // 
            // DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoatDN);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.btAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

