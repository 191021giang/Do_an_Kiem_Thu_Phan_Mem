
namespace QuanLyThuVien
{
    partial class f_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Books));
            this.grid = new System.Windows.Forms.DataGridView();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAuthor_id = new System.Windows.Forms.Label();
            this.txtAuthor_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbCategory_id = new System.Windows.Forms.Label();
            this.txtCategory_id = new System.Windows.Forms.TextBox();
            this.lbAquantity = new System.Windows.Forms.Label();
            this.txtAquantity = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbTSX = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtBookname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(38, 100);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(934, 306);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBookName.Location = new System.Drawing.Point(53, 518);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(85, 25);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "Tên sách";
            // 
            // lbAuthor_id
            // 
            this.lbAuthor_id.AutoSize = true;
            this.lbAuthor_id.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAuthor_id.Location = new System.Drawing.Point(53, 637);
            this.lbAuthor_id.Name = "lbAuthor_id";
            this.lbAuthor_id.Size = new System.Drawing.Size(101, 25);
            this.lbAuthor_id.TabIndex = 4;
            this.lbAuthor_id.Text = "Mã tác giả";
            // 
            // txtAuthor_id
            // 
            this.txtAuthor_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor_id.Location = new System.Drawing.Point(179, 632);
            this.txtAuthor_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthor_id.Multiline = true;
            this.txtAuthor_id.Name = "txtAuthor_id";
            this.txtAuthor_id.Size = new System.Drawing.Size(83, 38);
            this.txtAuthor_id.TabIndex = 3;
            this.txtAuthor_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(542, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhà xuất bản";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Location = new System.Drawing.Point(739, 516);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(231, 29);
            this.txtPublisher.TabIndex = 5;
            this.txtPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisher_KeyPress);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantity.Location = new System.Drawing.Point(542, 581);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(136, 25);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "Số lượng nhập";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(739, 573);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 38);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lbCategory_id
            // 
            this.lbCategory_id.AutoSize = true;
            this.lbCategory_id.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategory_id.Location = new System.Drawing.Point(53, 579);
            this.lbCategory_id.Name = "lbCategory_id";
            this.lbCategory_id.Size = new System.Drawing.Size(118, 25);
            this.lbCategory_id.TabIndex = 10;
            this.lbCategory_id.Text = "Mã loại sách";
            // 
            // txtCategory_id
            // 
            this.txtCategory_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory_id.Location = new System.Drawing.Point(179, 571);
            this.txtCategory_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory_id.Multiline = true;
            this.txtCategory_id.Name = "txtCategory_id";
            this.txtCategory_id.Size = new System.Drawing.Size(83, 34);
            this.txtCategory_id.TabIndex = 9;
            this.txtCategory_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategory_id_KeyPress);
            // 
            // lbAquantity
            // 
            this.lbAquantity.AutoSize = true;
            this.lbAquantity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAquantity.Location = new System.Drawing.Point(542, 639);
            this.lbAquantity.Name = "lbAquantity";
            this.lbAquantity.Size = new System.Drawing.Size(155, 25);
            this.lbAquantity.TabIndex = 12;
            this.lbAquantity.Text = "Số lượng hiện có";
            // 
            // txtAquantity
            // 
            this.txtAquantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAquantity.Location = new System.Drawing.Point(739, 634);
            this.txtAquantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAquantity.Multiline = true;
            this.txtAquantity.Name = "txtAquantity";
            this.txtAquantity.Size = new System.Drawing.Size(80, 36);
            this.txtAquantity.TabIndex = 11;
            this.txtAquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAquantity_KeyPress);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Moccasin;
            this.btInsert.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btInsert.Location = new System.Drawing.Point(551, 434);
            this.btInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(136, 50);
            this.btInsert.TabIndex = 13;
            this.btInsert.Text = "THÊM ";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Moccasin;
            this.btUpdate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUpdate.Location = new System.Drawing.Point(694, 434);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(136, 50);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "SỬA";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Moccasin;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelete.Location = new System.Drawing.Point(836, 434);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 50);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "XÓA";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbTSX
            // 
            this.lbTSX.AutoSize = true;
            this.lbTSX.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTSX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTSX.Location = new System.Drawing.Point(317, 31);
            this.lbTSX.Name = "lbTSX";
            this.lbTSX.Size = new System.Drawing.Size(413, 38);
            this.lbTSX.TabIndex = 19;
            this.lbTSX.Text = "DANH SÁCH SÁCH THƯ VIỆN ";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Moccasin;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThoat.Location = new System.Drawing.Point(834, 708);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 50);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtBookname
            // 
            this.txtBookname.Location = new System.Drawing.Point(179, 514);
            this.txtBookname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookname.Multiline = true;
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(262, 30);
            this.txtBookname.TabIndex = 21;
            this.txtBookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookname_KeyPress);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1021, 771);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lbTSX);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.lbAquantity);
            this.Controls.Add(this.txtAquantity);
            this.Controls.Add(this.lbCategory_id);
            this.Controls.Add(this.txtCategory_id);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lbAuthor_id);
            this.Controls.Add(this.txtAuthor_id);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Books";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbAuthor_id;
        private System.Windows.Forms.TextBox txtAuthor_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbCategory_id;
        private System.Windows.Forms.TextBox txtCategory_id;
        private System.Windows.Forms.Label lbAquantity;
        private System.Windows.Forms.TextBox txtAquantity;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbTSX;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtBookname;
    }
}
