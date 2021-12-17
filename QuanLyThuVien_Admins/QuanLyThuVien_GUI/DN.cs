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
    public partial class DN : Form
    {
        public DN()
        {
            InitializeComponent();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DK dlg2 = new DK();
            dlg2.ShowDialog();
        }

        private void btThoatDN_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DNAdmin dlg2 = new DNAdmin();
            dlg2.ShowDialog();

        }

        private void btUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DNUsers dlg2 = new DNUsers();
            dlg2.ShowDialog();
        }
    }
}
