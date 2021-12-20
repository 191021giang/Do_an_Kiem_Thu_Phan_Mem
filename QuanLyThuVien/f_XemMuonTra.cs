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
using QuanLyThuVien_BUS;

namespace QuanLyThuVien
{
    public partial class f_XemMuonTra : Form
    {
        public DTO_Users dto_user;
        BUS_Borrowers bus_borr = new BUS_Borrowers();
        public f_XemMuonTra(DTO_Users dto_user)
        {
            InitializeComponent();
            this.dto_user = dto_user;
        }

        private void f_XemMuonTra_Load(object sender, EventArgs e)
        {
            DataTable dt = bus_borr.borrower(dto_user);
            gridXemMT.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Homepage_User home_User = new f_Homepage_User(dto_user);
            home_User.ShowDialog();
        }
    }
}
