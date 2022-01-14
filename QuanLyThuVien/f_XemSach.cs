using QuanLyThuVien_BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class f_XemSach : Form
    {
        BUS_ListBooks bus_Book = new BUS_ListBooks();
        public f_XemSach()
        {
            InitializeComponent();
        }

        private void f_XemSach_Load(object sender, EventArgs e)
        {
            load_Book();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = bus_Book.search_book(txtSearch.Text);
            gridBook.DataSource = dt;
            gridBook.Columns[0].HeaderText = "Mã Sách";
            gridBook.Columns[1].HeaderText = "Tên Sách";
            gridBook.Columns[2].HeaderText = "Tác giả";
            gridBook.Columns[3].HeaderText = "Mã loại sách";
            gridBook.Columns[4].HeaderText = "Nhà xuất bản";
            gridBook.Columns[5].HeaderText = "Số lượng nhập";
            gridBook.Columns[6].HeaderText = "Số lượng hiện có";
            gridBook.ReadOnly = true;
        }

        private void btnAllBook_Click(object sender, EventArgs e)
        {
            load_Book();
        }

        public void load_Book()
        {
            DataTable dt = bus_Book.getBooksStore();
            gridBook.DataSource = dt;
            gridBook.Columns[0].HeaderText = "Mã Sách";
            gridBook.Columns[1].HeaderText = "Tên Sách";
            gridBook.Columns[2].HeaderText = "Tác giả";
            gridBook.Columns[3].HeaderText = "Mã loại sách";
            gridBook.Columns[4].HeaderText = "Nhà xuất bản";
            gridBook.Columns[5].HeaderText = "Số lượng nhập";
            gridBook.Columns[6].HeaderText = "Số lượng hiện có";
            gridBook.ReadOnly = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_Homepage_User home_user = new f_Homepage_User();
                home_user.ShowDialog();
            }            
        }
    }
}
