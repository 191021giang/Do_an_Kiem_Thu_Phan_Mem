using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien_DTO;
using QuanLyThuVien_BUS;

namespace QuanLyThuVien_GUI
{
    public partial class f_MuonTraSach : Form
    {
        #region Khai báo thư viện
        BUS_ListBooks bus_book = new BUS_ListBooks();
        BUS_ListUsers bus_user = new BUS_ListUsers();
        BUS_Borrowers bus_borrow = new BUS_Borrowers();
        public DTO_Borrowers dto_Borrow;
        public DTO_BooksStore dto_book; 
        #endregion

        public f_MuonTraSach()
        {
            InitializeComponent();
            //bus_book = new BUS_ListBooks();
        }

        #region Biến toàn cục
        bool co = false;
        bool co1 = false;
        int stt;
        #endregion

        private void f_MuonTraSach_Load(object sender, EventArgs e)
        {
            //Load thông tin tên sách, student_id vào combobox tên sách và combobox mã đọc giả
            Combobox_Load_tabMuon();

            Combobox_Load_tabTra();
        }

        /// <summary>
        /// Lấy giá trị đang chọn của combobox Tên sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBookName_tabMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co == true)
            {
                string item1 = cbBookName_tabMuon.SelectedValue.ToString();
                int item = Int32.Parse(item1);

                DataTable dtGroupBox = bus_book.BookInfor(item);

                //Điền thông tin vào các label liên quan (tự động)
                lbBookID_tabMuon.Text = lbBookID2_tabMuon.Text = lbBookID3_tabMuon.Text = dtGroupBox.Rows[0][0].ToString();
                lbCategoryName_tabMuon.Text = dtGroupBox.Rows[0][1].ToString();
                lbAuthName_tabMuon.Text = dtGroupBox.Rows[0][2].ToString();
                lbAvaidlid_tabMuon.Text = dtGroupBox.Rows[0][3].ToString();
            }
        }

        /// <summary>
        /// Tự động tính ngày hẹn trả sách (cộng thêm 30 ngày) sau khi người dùng chọn ngày mượn sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDateBorrow_tabMuon_ValueChanged(object sender, EventArgs e)
        {
            //Cập nhật vào datetimepicker Ngày hẹn trả sách (cộng thêm 30 ngày từ ngày mượn)
            dtpAppointDateReturn_tabMuon.Value = dtpDateBorrow_tabMuon.Value.AddDays(30);
        }

        /// <summary>
        /// Xử lý nút Xác nhận
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbAvaidlid_tabMuon.Text == "" || cbUserID_tabMuon.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ các trường bị thiếu!!!");
                }
                if (numQttBorrow.Value == 0)
                {
                    throw new Exception("Số lượng sách mượn phải lớn hơn 0!");                    
                }
                int qtt_availid;
                qtt_availid = Int32.Parse(lbAvaidlid_tabMuon.Text.ToString());

                if (numQttBorrow.Value > qtt_availid)
                {
                    throw new Exception("Số lượng sách hiện không đủ để mượn!!!");
                }

                if (co == true)
                {
                    string item1 = cbUserID_tabMuon.SelectedValue.ToString();
                    int item = Int32.Parse(item1);
                    bool check;
                    check = check_Qtt_Borrow(item);
                    if (check == true)
                    {
                        throw new Exception("Số lượng sách mượn vượt mức cho phép!!!\n Không thể mượn thêm!!!");
                    }
                }
                //Cập nhật giá trị sách hiện có vào label Còn lại
                //trong groupbox Số lượng sách sau khi mượn thành công
                //sau khi mượn thành công
                update_qttRemain();

                //Thêm dữ liệu vào bảng Borrowers
                insert_Borrowers();

                //Tải lại Datagridview Danh sách mượn
                DataTable dtBorrow = bus_borrow.getGrid_Borrowers();
                gridListBorrow.DataSource = dtBorrow;

                //Cập nhật lại các label về rỗng sau khi mượn thành công
                cbBookName_tabMuon.Text = cbUserID_tabMuon.Text = "";
                lbBookID_tabMuon.Text = lbBookID2_tabMuon.Text = lbBookID3_tabMuon.Text = "";
                lbCategoryName_tabMuon.Text = lbAuthName_tabMuon.Text = "";
                lbAvaidlid_tabMuon.Text = lbQAfterBorrow_tabMuon.Text = "";
                dtpDateBorrow_tabMuon.Value = DateTime.Now;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                numQttBorrow.Value = 0;
            }
            
        }

        /// <summary>
        /// Hiện toàn bộ thông tin người mượn vào Datagridview Danh sách mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAllListBorrow_Click(object sender, EventArgs e)
        {
            DataTable dtBorrow = bus_borrow.getGrid_Borrowers();
            gridListBorrow.DataSource = dtBorrow;

        }

        /// <summary>
        /// Xóa toàn bộ thông tin người mượn ở Datagridview Danh sách mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelAllListBorrow_Click(object sender, EventArgs e)
        {
            gridListBorrow.DataSource = "";
        }

        /// <summary>
        /// Hàm tìm kiếm Danh sách mượn theo MSSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_tabMuon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = txtSearch_tabMuon.Text;
                DataTable dt = bus_borrow.searching_Borrow(value);
                gridListBorrow.DataSource = dt;
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_tabMuon_Click(object sender, EventArgs e)
        {
            DataTable dt = bus_borrow.getGrid_Borrowers();
            gridListBorrow.DataSource = dt;
        }




        /*==========================================================================
         * ==========================CÁC HÀM DÙNG TRONG FORM=======================
         ===========================================================================*/
        
        /*=================TAB MƯỢN SÁCH=====================*/

        /// <summary>
        /// Hàm load thông tin
        /// </summary>
        private void Combobox_Load_tabMuon()
        {
            //Xử lý cho combobox Tên sách
            DataTable dtBooks = bus_book.getBooksStore();
            cbBookName_tabMuon.DataSource = dtBooks;
            cbBookName_tabMuon.DisplayMember = "book_name";
            cbBookName_tabMuon.ValueMember = "book_id";
            cbBookName_tabMuon.SelectedIndex = -1;

            //Xử lý cho combobox Mã đọc giả
            ////Tab Mượn Sách
            DataTable dtUsers = bus_user.UsersName();
            cbUserID_tabMuon.DataSource = dtUsers;
            cbUserID_tabMuon.DisplayMember = "student_id";
            cbUserID_tabMuon.ValueMember = "student_id";
            cbUserID_tabMuon.SelectedIndex = -1;

            //Tự thêm giá trị cho Ngày hẹn trả
            dtpAppointDateReturn_tabMuon.Value = dtpDateBorrow_tabMuon.Value.AddDays(30);

            //Đặt số lượng mượn sách là 0
            numQttBorrow.Value = 0;

            co = true;
        }

        /// <summary>
        /// Hàm cập nhật số lượng sách còn lại sau khi có người mượn sách thành công
        /// </summary>
        private void update_qttRemain()
        {
            try
            {
                int qtt_availid, qtt_borrow, qtt_remain;
                //Chuyển đổi giá trị của Số lượng mượn về int
                qtt_availid = Int32.Parse(lbAvaidlid_tabMuon.Text.ToString());
                decimal qtt = numQttBorrow.Value;
                qtt_borrow = (int)qtt;

                qtt_remain = qtt_availid - qtt_borrow;

                //Cập nhật vào label Còn lại trong groupbox Số lượng sách sau khi mượn thành công
                lbQAfterBorrow_tabMuon.Text = qtt_remain.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Hàm thêm người mượn vào bảng Borrowers
        /// </summary>
        private void insert_Borrowers()
        {

            dto_Borrow = new DTO_Borrowers();

            int bookID = Int32.Parse(lbBookID_tabMuon.Text.ToString());
            decimal qtt = numQttBorrow.Value;
            int qtt_borrow = (int)qtt;

            //Gán thông tin cho các thuộc tính của bảng Borrowers
            dto_Borrow.student_id = (int)cbUserID_tabMuon.SelectedValue;
            dto_Borrow.book_id = bookID;
            dto_Borrow.date_of_borrow = dtpDateBorrow_tabMuon.Value;
            dto_Borrow.date_of_appoint_return = dtpAppointDateReturn_tabMuon.Value;
            dto_Borrow.qtt_borrow = qtt_borrow;

            //Gán thông tin cho thuộc tính book_id của bảng BooksStore và available_quantity
            dto_book = new DTO_BooksStore();
            int qtt_availid = Int32.Parse(lbQAfterBorrow_tabMuon.Text.ToString());

            dto_book.book_id = bookID;
            dto_book.available_quantity = qtt_availid;
            if (bus_borrow.addBorrow(dto_Borrow) == true)
            {
                if (bus_book.updateQuantity_Availid(dto_book, qtt_availid) == true)
                {
                    MessageBox.Show("Mượn thành công!!!");
                }
            }
        }

        /// <summary>
        /// Hàm kiểm tra số lượng sách người mượn có vượt quá quy định không?
        /// Với mỗi student_id, chỉ được mượn tối đa 5 cuốn
        /// </summary>
        /// <param name="borrowName">Thông tin người mượn (ở đây là student_id)</param>
        /// <returns>true khi số lượng mượn là 5, false khi số lượng mượn dưới 5 hoặc trên 5</returns>
        private bool check_Qtt_Borrow(int borrowName)
        {
            bool check = false;
            int count = 0;
            int value_id;
            DataTable dtBorrow = bus_borrow.getGrid_Borrowers();

            foreach (DataRow item in dtBorrow.Rows)
            {
                value_id = Int32.Parse(item[1].ToString());
                if (borrowName == value_id && item[6].ToString() == "")
                {
                    count = count + 1;
                }

                if (count == 5)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }


        /*=================TAB TRẢ SÁCH=====================*/

        /// <summary>
        /// Hàm load combobox mã đọc giả ở tab trả sách
        /// </summary>
        private void Combobox_Load_tabTra()
        {
            if (tabControl_MuonTra.SelectedTab == tabControl_MuonTra.TabPages["tabMuonSach"])
            {
                DataTable dtTra = bus_user.UsersName();
                cbUser_tabTra.DataSource = dtTra;
                cbUser_tabTra.DisplayMember = "student_id";
                cbUser_tabTra.ValueMember = "student_id";
                cbUser_tabTra.SelectedIndex = -1;

                co1 = true;
            }
        }

        /// <summary>
        /// Hàm load thông tin các trường khác khi mã đọc giả được chọn
        /// </summary>
        private void load_Information_tabTra()
        {
            try
            {
                //Kiểm tra dòng đang được chọn của datagridview
                if (gridListReturn_tabTra.CurrentRow.Index != -1)
                {                 
                    //Lấy thông tin của các cột của dòng đang được chọn trong datagridview đổ vào các label
                    //và datetimepicker tương ứng ở tab trả sách
                    gridListReturn_tabTra.CurrentRow.Selected = true;
                    lbBookID_tabTra.Text = gridListReturn_tabTra.CurrentRow.Cells["Mã sách mượn"].Value.ToString();
                    lbQttBorrow_tabTra.Text = gridListReturn_tabTra.CurrentRow.Cells["Số lượng mượn"].Value.ToString();
                    lbNote_tabTra.Text = gridListReturn_tabTra.CurrentRow.Cells["Ghi chú"].Value.ToString();
                    dtpBorrow_tabTra.Value = (DateTime)gridListReturn_tabTra.CurrentRow.Cells["Ngày mượn"].Value;
                    dtpAppoint_tabTra.Value = (DateTime)gridListReturn_tabTra.CurrentRow.Cells["Ngày hẹn trả"].Value;
                    
                    //Cập nhật số lượng sách hiện có và số lượng sách sau khi trả
                    int bookID = Int32.Parse(lbBookID_tabTra.Text);
                    DataTable dt = bus_book.BookInfor(bookID);
                    lbQttAvailid_tabTra.Text = dt.Rows[0][3].ToString();

                    stt = Int32.Parse(gridListReturn_tabTra.CurrentRow.Cells["STT"].Value.ToString());

                    //Nếu cột Ngày thực trả của dòng đang chọn trong datagridview khác null thì chuyển đổi giá trị sang
                    //datetime để cập nhật vào datetimepicker của Ngày thực trả trên groupbox
                    if (gridListReturn_tabTra.CurrentRow.Cells["Ngày thực trả"].Value.ToString() != "")
                    {
                        dtpReturn_tabTra.Value = (DateTime)gridListReturn_tabTra.CurrentRow.Cells["Ngày thực trả"].Value;
                        dtpReturn_tabTra.Enabled = false;
                        lbQttAReturn_tabTra.Text = "";
                        rbDonePaid_tabTra.Enabled = false;
                        rbNotPaid_tabTra.Enabled = false;
                        btnConfirm_tabTra.Enabled = false;
                    }
                    //Nếu Ngày thực trả của dòng đang chọn trong datagridview là rỗng thì thực hiện cập nhật
                    //số lượng sách sau khi trả vào label Sau khi trả
                    else
                    {
                        dtpReturn_tabTra.Enabled = true;
                        dtpReturn_tabTra.Value = DateTime.Now;

                        int bookBorr = Int32.Parse(lbQttBorrow_tabTra.Text);
                        int bookAvi = Int32.Parse(lbQttAvailid_tabTra.Text);
                        int bookAfter = bookBorr + bookAvi;
                        lbQttAReturn_tabTra.Text = bookAfter.ToString();
                        rbDonePaid_tabTra.Enabled = true;
                        rbNotPaid_tabTra.Enabled = true;
                        btnConfirm_tabTra.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Sự kiện chọn giá trị trong combobox, load thông tin tìm kiếm theo Mã đọc giả vào datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUser_tabTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nếu như co1 = true (datasource của combobox Mã đọc giả đã load xong) thì thực hiện load thông tin
            //tìm kiếm theo mã đọc giả
            if (co1 == true)
            {
                //Load datagridview theo mã đọc giả (sử dụng hàm searching_Borrow)
                string value = cbUser_tabTra.Text;
                DataTable dtLoad = bus_borrow.searching_Borrow(value);
                gridListReturn_tabTra.DataSource = dtLoad;

                if (gridListReturn_tabTra.CurrentCell == null)
                {
                    dtpReturn_tabTra.Enabled = false;
                    lbBookID_tabTra.Text = "";
                    lbQttAReturn_tabTra.Text = "";
                    lbQttBorrow_tabTra.Text = "";
                    lbQttAvailid_tabTra.Text = "";
                    lbNote_tabTra.Text = "";
                    rbDonePaid_tabTra.Enabled = false;
                    rbNotPaid_tabTra.Enabled = false;
                    btnConfirm_tabTra.Enabled = false;
                }

            }
        }

        /// <summary>
        /// Sự kiện chọn một ô trong datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridListReturn_tabTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_Information_tabTra();
        }

        private void rbDonePaid_tabTra_CheckedChanged(object sender, EventArgs e)
        {
            lbNote_tabTra.Text = rbDonePaid_tabTra.Text;
            rbDonePaid_tabTra.Checked = false;
        }

        private void rbNotPaid_tabTra_CheckedChanged(object sender, EventArgs e)
        {
            lbNote_tabTra.Text = rbNotPaid_tabTra.Text;
            rbNotPaid_tabTra.Checked = false;
        }

        private void dtpReturn_tabTra_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpReturn_tabTra.Value < dtpBorrow_tabTra.Value)
                {
                    throw new Exception("Ngày thực trả nhỏ hơn ngày mượn!\nVui lòng chọn lại!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirm_tabTra_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dtpReturn_tabTra.Value > dtpAppoint_tabTra.Value)
                {
                    if (lbNote_tabTra.Text == "")
                    {
                        throw new Exception("Trễ hạn nộp phạt!!!\nVui lòng chọn Tình trạng nộp phạt!!!");
                    }
                    else
                    {
                        dto_Borrow = new DTO_Borrowers();
                        dto_Borrow.date_of_return = dtpReturn_tabTra.Value;
                        dto_Borrow.note = lbNote_tabTra.Text;

                        if (bus_borrow.update_date_of_return(dto_Borrow, stt) == true)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            string value = cbUser_tabTra.Text;
                            DataTable dtLoad = bus_borrow.searching_Borrow(value);
                            gridListReturn_tabTra.DataSource = dtLoad;
                        }

                    }
                }

                if(dtpReturn_tabTra.Value >= dtpBorrow_tabTra.Value && dtpReturn_tabTra.Value <= dtpAppoint_tabTra.Value)
                {
                    if (lbNote_tabTra.Text != "")
                    {
                        lbNote_tabTra.Text = "";
                    }

                    dto_Borrow = new DTO_Borrowers();
                    dto_Borrow.date_of_return = dtpReturn_tabTra.Value;
                    dto_Borrow.note = lbNote_tabTra.Text;

                    if (bus_borrow.update_date_of_return(dto_Borrow, stt) == true)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        string value = cbUser_tabTra.Text;
                        DataTable dtLoad = bus_borrow.searching_Borrow(value);
                        gridListReturn_tabTra.DataSource = dtLoad;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lbNote_tabTra.Text = "";
            }
        }

        private string convert_date(int yyyy, int mm, int dd, int hh, int m, int s)
        {
            string format_date;
            format_date = yyyy.ToString() + '-' + mm.ToString() + '-' + dd.ToString() + ' '
                + hh.ToString() + ':' + m.ToString() + ':' + s.ToString();
            return format_date;
        }

        private void btnThoat_tabMuon_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_HomePage home = new f_HomePage();
            home.ShowDialog();
        }

        /*==========================================================================
         * ====================KẾT THÚC CÁC HÀM DÙNG TRONG FORM====================
         ===========================================================================*/

    }
}
