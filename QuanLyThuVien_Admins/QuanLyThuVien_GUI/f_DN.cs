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
    public partial class f_DN : Form
    {
        public f_DN()
        {
            InitializeComponent();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_DK dlg2 = new f_DK();
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
            f_DNAdmin dlg2 = new f_DNAdmin();
            dlg2.ShowDialog();

        }

        private void btUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_DNUsers dlg2 = new f_DNUsers();
            dlg2.ShowDialog();
        }
    }
}
