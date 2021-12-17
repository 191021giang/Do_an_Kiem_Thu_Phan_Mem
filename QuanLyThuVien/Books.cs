using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyThuVien
{
    public partial class Books : Form
    {
        DTO_Categories dto_cate = new DTO_Categories();
        DTO_Books dto_book = new DTO_Books();
        public Books()
        {
            InitializeComponent();
        }
        BUS_Books bus_book;
       

        private void Books_Load(object sender, EventArgs e)
        {
            bus_book = new BUS_Books();
            try
            {
                grid.DataSource = bus_book.GetBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI! " + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            DTO_Books dto_book = new DTO_Books();
            //dto_book.book_id = int.Parse(txtBook_id.Text);
            dto_book.book_name = txtBookname.Text;
            dto_book.author_id = int.Parse(txtAuthor_id.Text);
            dto_book.category_id = int.Parse(txtCategory_id.Text);
            dto_book.publisher_name = txtPublisher.Text;
            dto_book.quantity = int.Parse(txtQuantity.Text);
            dto_book.available_quantity = int.Parse(txtAquantity.Text);
            //dto_cate = new DTO_Categories();
            //dto_cate.category_id = int.Parse(txtCategory_id.Text);
            if (bus_book.Insert(dto_book))
            {
                bus_book = new BUS_Books();
                grid.DataSource = bus_book.GetBooks();
                MessageBox.Show("Thêm thành công !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                    
            else
                MessageBox.Show("Thêm thất bại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if(grid.CurrentRow.Index != -1)
                {
                    grid.CurrentRow.Selected = true;
                    txtBookname.Text = grid.CurrentRow.Cells[1].Value.ToString();
                    txtAuthor_id.Text = grid.CurrentRow.Cells[2].Value.ToString();
                    txtCategory_id.Text = grid.CurrentRow.Cells[3].Value.ToString();
                    txtPublisher.Text = grid.CurrentRow.Cells[4].Value.ToString();
                    txtQuantity.Text = grid.CurrentRow.Cells[5].Value.ToString();
                    txtAquantity.Text = grid.CurrentRow.Cells[6].Value.ToString();           
                }   
                
            }
            catch (Exception ex1)
            {

                 MessageBox.Show(ex1.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if(grid.SelectedCells.Count > 0)
                {
                    if(txtBookname.Text !=" "&& txtAuthor_id.Text != " " && txtCategory_id.Text != " " && txtPublisher.Text != " " && txtQuantity.Text != " ")
                    {
                       
                        dto_book.book_name = txtBookname.Text;
                        dto_book.author_id = int.Parse(txtAuthor_id.Text);
                        dto_book.category_id = int.Parse(txtCategory_id.Text);
                        dto_book.publisher_name = txtPublisher.Text;
                        dto_book.quantity = int.Parse(txtQuantity.Text);
                        dto_book.available_quantity = int.Parse(txtAquantity.Text);
                        bus_book = new BUS_Books();
                        int index = Int32.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                        if (bus_book.Update(dto_book,index) == true)

                        {

                            grid.DataSource = bus_book.GetBooks();
                            MessageBox.Show("Sửa thành công !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Thêm thất bại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }    
            }
            catch (Exception ex2)
            {

                MessageBox.Show(ex2.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid.SelectedCells.Count > 0)
                {
                    if (txtBookname.Text != " " && txtAuthor_id.Text != " " && txtCategory_id.Text != " " && txtPublisher.Text != " " && txtQuantity.Text != " ")
                    {

                        dto_book.book_name = txtBookname.Text;
                        dto_book.author_id = int.Parse(txtAuthor_id.Text);
                        dto_book.category_id = int.Parse(txtCategory_id.Text);
                        dto_book.publisher_name = txtPublisher.Text;
                        dto_book.quantity = int.Parse(txtQuantity.Text);
                        dto_book.available_quantity = int.Parse(txtAquantity.Text);
                        bus_book = new BUS_Books();
                        int index = Int32.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                        if (bus_book.Delete(index) == true)

                        {

                            grid.DataSource = bus_book.GetBooks();
                            MessageBox.Show("Xóa thành công !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Xóa thất bại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex2)
            {

                MessageBox.Show(ex2.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void txtCategory_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }

        private void txtAuthor_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }

        private void txtAquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
        }

        private void txtBookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Space && (Keys)e.KeyChar != Keys.Back)//oke
                e.Handled = true;
        }

        private void txtPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Space && (Keys)e.KeyChar != Keys.Back)//oke
                e.Handled = true;
        }
    }  
}
