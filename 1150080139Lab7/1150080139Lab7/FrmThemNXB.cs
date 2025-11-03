using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080139Lab7
{
    public partial class FrmThemNXB : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
Initial Catalog=QuanLyBanSach;
Integrated Security=True";

        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public FrmThemNXB()
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

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM NhaXuatBan";
                adapter = new SqlDataAdapter(sql, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");

                DataRow row = ds.Tables["tblNhaXuatBan"].NewRow();
                row["MaXB"] = txtMaXB.Text.Trim();
                row["TenXB"] = txtTenXB.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();
                ds.Tables["tblNhaXuatBan"].Rows.Add(row);

                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
                if (kq > 0)
                {
                    MessageBox.Show("✅ Thêm dữ liệu thành công!");
                    txtMaXB.Clear(); txtTenXB.Clear(); txtDiaChi.Clear();
                }
                else MessageBox.Show("❌ Thêm không thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
