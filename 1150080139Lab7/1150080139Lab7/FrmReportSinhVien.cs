using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace _1150080139Lab7
{
    public partial class FrmReportSinhVien : Form
    {
        // 🔹 Dùng cùng chuỗi kết nối như FrmQuanLyNXB
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;
Initial Catalog=QuanLyBanSach;
Integrated Security=True";

        public FrmReportSinhVien()
        {
            InitializeComponent();
        }

        private void FrmReportSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();

                    // ✅ Kiểm tra xem đang kết nối đúng database
                    MessageBox.Show("Đang kết nối đến DB: " + conn.Database,
                        "Kết nối thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Truy vấn dữ liệu từ bảng SinhVien
                    string query = "SELECT * FROM SinhVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu trong bảng SinhVien!", "Thông báo");
                        return;
                    }

                    // ✅ Gắn dữ liệu vào ReportViewer
                    reportViewer1.LocalReport.ReportPath = "rptSinhVien.rdlc";
                    ReportDataSource rds = new ReportDataSource("dsSinhVien", dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("❌ Lỗi SQL khi load dữ liệu báo cáo:\n" + ex.Message,
                    "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi hệ thống:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
