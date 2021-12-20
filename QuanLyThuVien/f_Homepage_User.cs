using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class f_Homepage_User : Form
    {
        public DTO_Users dto_user;
        public f_Homepage_User(DTO_Users dto_user)
        {
            InitializeComponent();
            this.dto_user = dto_user;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_XemMuonTra muonTra = new f_XemMuonTra(dto_user);
            muonTra.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_XemSach xemSach = new f_XemSach(dto_user);
            xemSach.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN dangNhap = new DN();
            dangNhap.ShowDialog();
        }
    }
}
