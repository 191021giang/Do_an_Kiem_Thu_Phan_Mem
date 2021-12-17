
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
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(38, 80);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(934, 245);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(35, 388);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(84, 17);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "BookName";
            // 
            // lbAuthor_id
            // 
            this.lbAuthor_id.AutoSize = true;
            this.lbAuthor_id.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor_id.Location = new System.Drawing.Point(35, 483);
            this.lbAuthor_id.Name = "lbAuthor_id";
            this.lbAuthor_id.Size = new System.Drawing.Size(78, 17);
            this.lbAuthor_id.TabIndex = 4;
            this.lbAuthor_id.Text = "Author_id";
            // 
            // txtAuthor_id
            // 
            this.txtAuthor_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor_id.Location = new System.Drawing.Point(144, 479);
            this.txtAuthor_id.Multiline = true;
            this.txtAuthor_id.Name = "txtAuthor_id";
            this.txtAuthor_id.Size = new System.Drawing.Size(83, 31);
            this.txtAuthor_id.TabIndex = 3;
            this.txtAuthor_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Publisher_name";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Location = new System.Drawing.Point(568, 385);
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(231, 24);
            this.txtPublisher.TabIndex = 5;
            this.txtPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisher_KeyPress);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(433, 434);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(72, 17);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = " Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(568, 428);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 31);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lbCategory_id
            // 
            this.lbCategory_id.AutoSize = true;
            this.lbCategory_id.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory_id.Location = new System.Drawing.Point(35, 437);
            this.lbCategory_id.Name = "lbCategory_id";
            this.lbCategory_id.Size = new System.Drawing.Size(93, 17);
            this.lbCategory_id.TabIndex = 10;
            this.lbCategory_id.Text = "Category_id";
            // 
            // txtCategory_id
            // 
            this.txtCategory_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory_id.Location = new System.Drawing.Point(144, 430);
            this.txtCategory_id.Multiline = true;
            this.txtCategory_id.Name = "txtCategory_id";
            this.txtCategory_id.Size = new System.Drawing.Size(83, 28);
            this.txtCategory_id.TabIndex = 9;
            this.txtCategory_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategory_id_KeyPress);
            // 
            // lbAquantity
            // 
            this.lbAquantity.AutoSize = true;
            this.lbAquantity.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAquantity.Location = new System.Drawing.Point(415, 480);
            this.lbAquantity.Name = "lbAquantity";
            this.lbAquantity.Size = new System.Drawing.Size(136, 17);
            this.lbAquantity.TabIndex = 12;
            this.lbAquantity.Text = " Available Quantity";
            // 
            // txtAquantity
            // 
            this.txtAquantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAquantity.Location = new System.Drawing.Point(568, 477);
            this.txtAquantity.Multiline = true;
            this.txtAquantity.Name = "txtAquantity";
            this.txtAquantity.Size = new System.Drawing.Size(80, 30);
            this.txtAquantity.TabIndex = 11;
            this.txtAquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAquantity_KeyPress);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btInsert.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(836, 356);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(136, 40);
            this.btInsert.TabIndex = 13;
            this.btInsert.Text = "THÊM ";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(836, 418);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(136, 40);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "SỬA";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(836, 479);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 40);
            this.btDelete.TabIndex = 15;
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
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(836, 543);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 40);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtBookname
            // 
            this.txtBookname.Location = new System.Drawing.Point(144, 385);
            this.txtBookname.Multiline = true;
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(262, 25);
            this.txtBookname.TabIndex = 21;
            this.txtBookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookname_KeyPress);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1021, 617);
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
