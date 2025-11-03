using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080139Lab7
{
    public partial class FrmQuanLyNXB : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
Initial Catalog=QuanLyBanSach;
Integrated Security=True";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int vt = -1;

        public FrmQuanLyNXB()
        {
            InitializeComponent();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void HienThiDuLieu()
        {
            MoKetNoi();
            string sql = "SELECT * FROM NhaXuatBan";
            adapter = new SqlDataAdapter(sql, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblNhaXuatBan");
            dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
        }

        private void FrmQuanLyNXB_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            txtMaXB.Text = row["MaXB"].ToString();
            txtTenXB.Text = row["TenXB"].ToString();
            txtDiaChi.Text = row["DiaChi"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Chọn dòng để sửa!");
                return;
            }

            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            row["TenXB"] = txtTenXB.Text.Trim();
            row["DiaChi"] = txtDiaChi.Text.Trim();

            int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
            if (kq > 0)
            {
                MessageBox.Show("✅ Sửa thành công!");
                HienThiDuLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Chọn dòng để xóa!");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
                row.Delete();
                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show("🗑️ Xóa thành công!");
                    HienThiDuLieu();
                }
            }
        }
    }
}
