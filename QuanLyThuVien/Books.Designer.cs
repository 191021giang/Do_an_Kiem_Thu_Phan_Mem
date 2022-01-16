
namespace QuanLyThuVien
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
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
            this.grid.Location = new System.Drawing.Point(38, 80);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(934, 245);
            this.grid.TabIndex = 1;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(39, 437);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(91, 22);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "Tên sách";
            // 
            // lbAuthor_id
            // 
            this.lbAuthor_id.AutoSize = true;
            this.lbAuthor_id.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor_id.Location = new System.Drawing.Point(39, 575);
            this.lbAuthor_id.Name = "lbAuthor_id";
            this.lbAuthor_id.Size = new System.Drawing.Size(102, 22);
            this.lbAuthor_id.TabIndex = 4;
            this.lbAuthor_id.Text = "Mã tác giả";
            // 
            // txtAuthor_id
            // 
            this.txtAuthor_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor_id.Location = new System.Drawing.Point(197, 573);
            this.txtAuthor_id.Multiline = true;
            this.txtAuthor_id.Name = "txtAuthor_id";
            this.txtAuthor_id.Size = new System.Drawing.Size(83, 40);
            this.txtAuthor_id.TabIndex = 4;
            this.txtAuthor_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhà xuất bản";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(721, 426);
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(222, 43);
            this.txtPublisher.TabIndex = 5;
            this.txtPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisher_KeyPress);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(537, 506);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(140, 22);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "Số lượng nhập";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(721, 504);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 39);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lbCategory_id
            // 
            this.lbCategory_id.AutoSize = true;
            this.lbCategory_id.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory_id.Location = new System.Drawing.Point(39, 506);
            this.lbCategory_id.Name = "lbCategory_id";
            this.lbCategory_id.Size = new System.Drawing.Size(121, 22);
            this.lbCategory_id.TabIndex = 10;
            this.lbCategory_id.Text = "Mã loại sách";
            // 
            // txtCategory_id
            // 
            this.txtCategory_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory_id.Location = new System.Drawing.Point(197, 504);
            this.txtCategory_id.Multiline = true;
            this.txtCategory_id.Name = "txtCategory_id";
            this.txtCategory_id.Size = new System.Drawing.Size(83, 39);
            this.txtCategory_id.TabIndex = 3;
            this.txtCategory_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategory_id_KeyPress);
            // 
            // lbAquantity
            // 
            this.lbAquantity.AutoSize = true;
            this.lbAquantity.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAquantity.Location = new System.Drawing.Point(537, 575);
            this.lbAquantity.Name = "lbAquantity";
            this.lbAquantity.Size = new System.Drawing.Size(160, 22);
            this.lbAquantity.TabIndex = 12;
            this.lbAquantity.Text = "Số lượng hiện có";
            // 
            // txtAquantity
            // 
            this.txtAquantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAquantity.Location = new System.Drawing.Point(721, 575);
            this.txtAquantity.Multiline = true;
            this.txtAquantity.Name = "txtAquantity";
            this.txtAquantity.Size = new System.Drawing.Size(80, 38);
            this.txtAquantity.TabIndex = 7;
            this.txtAquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAquantity_KeyPress);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Moccasin;
            this.btInsert.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(836, 344);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(136, 40);
            this.btInsert.TabIndex = 10;
            this.btInsert.Text = "THÊM ";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Moccasin;
            this.btUpdate.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(694, 344);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(136, 40);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "SỬA";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Moccasin;
            this.btDelete.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(552, 344);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 40);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "XÓA";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbTSX
            // 
            this.lbTSX.AutoSize = true;
            this.lbTSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTSX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTSX.Location = new System.Drawing.Point(317, 25);
            this.lbTSX.Name = "lbTSX";
            this.lbTSX.Size = new System.Drawing.Size(431, 32);
            this.lbTSX.TabIndex = 19;
            this.lbTSX.Text = "DANH SÁCH SÁCH THƯ VIỆN ";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Moccasin;
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(836, 659);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 40);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtBookname
            // 
            this.txtBookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookname.Location = new System.Drawing.Point(197, 426);
            this.txtBookname.Multiline = true;
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(262, 43);
            this.txtBookname.TabIndex = 2;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1021, 727);
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
            this.MaximizeBox = false;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Sách";
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
