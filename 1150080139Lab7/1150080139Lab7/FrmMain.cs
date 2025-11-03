using System;
using System.Windows.Forms;

namespace _1150080139Lab7
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemNXB f1 = new FrmThemNXB();
            f1.ShowDialog();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            FrmQuanLyNXB f2 = new FrmQuanLyNXB();
            f2.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReportSinhVien f = new FrmReportSinhVien();
            f.ShowDialog();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
