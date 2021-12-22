
namespace QuanLyThuVien_GUI
{
    partial class f_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ThongKe));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuantity = new System.Windows.Forms.TabPage();
            this.btnThoat_tab1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBook = new System.Windows.Forms.Label();
            this.lbSumBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridStatis = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabQuantity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStatis)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuantity);
            this.tabControl1.Controls.Add(this.tabBorrow);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQuantity
            // 
            this.tabQuantity.BackColor = System.Drawing.Color.Linen;
            this.tabQuantity.Controls.Add(this.btnThoat_tab1);
            this.tabQuantity.Controls.Add(this.groupBox2);
            this.tabQuantity.Controls.Add(this.groupBox1);
            this.tabQuantity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabQuantity.Location = new System.Drawing.Point(4, 27);
            this.tabQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabQuantity.Name = "tabQuantity";
            this.tabQuantity.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabQuantity.Size = new System.Drawing.Size(1195, 650);
            this.tabQuantity.TabIndex = 0;
            this.tabQuantity.Text = "Thống kê số lượng sách";
            // 
            // btnThoat_tab1
            // 
            this.btnThoat_tab1.BackColor = System.Drawing.Color.Moccasin;
            this.btnThoat_tab1.Location = new System.Drawing.Point(980, 119);
            this.btnThoat_tab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat_tab1.Name = "btnThoat_tab1";
            this.btnThoat_tab1.Size = new System.Drawing.Size(159, 50);
            this.btnThoat_tab1.TabIndex = 2;
            this.btnThoat_tab1.Text = "Thoát";
            this.btnThoat_tab1.UseVisualStyleBackColor = false;
            this.btnThoat_tab1.Click += new System.EventHandler(this.btnThoat_tab1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridBook);
            this.groupBox2.Location = new System.Drawing.Point(36, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1102, 472);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách số lượng sách";
            // 
            // gridBook
            // 
            this.gridBook.BackgroundColor = System.Drawing.Color.White;
            this.gridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBook.Location = new System.Drawing.Point(29, 39);
            this.gridBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridBook.Name = "gridBook";
            this.gridBook.ReadOnly = true;
            this.gridBook.RowHeadersWidth = 51;
            this.gridBook.RowTemplate.Height = 29;
            this.gridBook.Size = new System.Drawing.Size(1053, 421);
            this.gridBook.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBook);
            this.groupBox1.Controls.Add(this.lbSumBook);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1102, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê số lượng sách";
            // 
            // lbBook
            // 
            this.lbBook.BackColor = System.Drawing.Color.White;
            this.lbBook.Location = new System.Drawing.Point(778, 35);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(135, 36);
            this.lbBook.TabIndex = 1;
            this.lbBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSumBook
            // 
            this.lbSumBook.BackColor = System.Drawing.Color.White;
            this.lbSumBook.Location = new System.Drawing.Point(322, 35);
            this.lbSumBook.Name = "lbSumBook";
            this.lbSumBook.Size = new System.Drawing.Size(135, 36);
            this.lbSumBook.TabIndex = 1;
            this.lbSumBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số sách hiện có:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số sách nhập vào:";
            // 
            // tabBorrow
            // 
            this.tabBorrow.BackColor = System.Drawing.Color.Linen;
            this.tabBorrow.Controls.Add(this.btnThoat);
            this.tabBorrow.Controls.Add(this.lbEnd);
            this.tabBorrow.Controls.Add(this.lbStart);
            this.tabBorrow.Controls.Add(this.label6);
            this.tabBorrow.Controls.Add(this.label4);
            this.tabBorrow.Controls.Add(this.groupBox5);
            this.tabBorrow.Controls.Add(this.groupBox4);
            this.tabBorrow.Controls.Add(this.groupBox3);
            this.tabBorrow.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabBorrow.Location = new System.Drawing.Point(4, 27);
            this.tabBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBorrow.Size = new System.Drawing.Size(1195, 650);
            this.tabBorrow.TabIndex = 1;
            this.tabBorrow.Text = "Thống kê Mượn - Trả sách";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Moccasin;
            this.btnThoat.Location = new System.Drawing.Point(1014, 241);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 48);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_tab1_Click);
            // 
            // lbEnd
            // 
            this.lbEnd.BackColor = System.Drawing.Color.White;
            this.lbEnd.Location = new System.Drawing.Point(809, 196);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(205, 34);
            this.lbEnd.TabIndex = 5;
            this.lbEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStart
            // 
            this.lbStart.BackColor = System.Drawing.Color.White;
            this.lbStart.Location = new System.Drawing.Point(809, 139);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(205, 34);
            this.lbStart.TabIndex = 5;
            this.lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridStatis);
            this.groupBox5.Location = new System.Drawing.Point(24, 292);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1131, 346);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách thống kê";
            // 
            // gridStatis
            // 
            this.gridStatis.BackgroundColor = System.Drawing.Color.White;
            this.gridStatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStatis.Location = new System.Drawing.Point(19, 36);
            this.gridStatis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridStatis.Name = "gridStatis";
            this.gridStatis.ReadOnly = true;
            this.gridStatis.RowHeadersWidth = 51;
            this.gridStatis.RowTemplate.Height = 29;
            this.gridStatis.Size = new System.Drawing.Size(1089, 296);
            this.gridStatis.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpEnd);
            this.groupBox4.Controls.Add(this.dtpStart);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(24, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(569, 218);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tùy chọn thời gian";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(258, 103);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(281, 31);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(258, 32);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(281, 31);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Moccasin;
            this.btnShow.Location = new System.Drawing.Point(398, 155);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 48);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày kết  thúc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpDate);
            this.groupBox3.Location = new System.Drawing.Point(624, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(504, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem thống kê theo Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chọn ngày:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(219, 52);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(227, 31);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.MouseCaptureChanged += new System.EventHandler(this.dtpDate_MouseCaptureChanged);
            // 
            // f_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 681);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "f_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_ThongKe";
            this.Load += new System.EventHandler(this.f_ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuantity.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBorrow.ResumeLayout(false);
            this.tabBorrow.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStatis)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuantity;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridBook;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.Label lbSumBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView gridStatis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThoat_tab1;
    }
}