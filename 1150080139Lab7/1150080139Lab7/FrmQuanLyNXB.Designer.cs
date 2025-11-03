namespace _1150080139Lab7
{
    partial class FrmQuanLyNXB
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.AutoSize = true;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Location = new System.Drawing.Point(30, 70);
            this.dgvDanhSach.Size = new System.Drawing.Size(480, 180);
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(30, 270);
            this.lblMa.Text = "Mã XB:";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(30, 305);
            this.lblTen.Text = "Tên XB:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(30, 340);
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(90, 267);
            this.txtMaXB.Width = 200;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(90, 302);
            this.txtTenXB.Width = 200;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(90, 337);
            this.txtDiaChi.Width = 200;
            // 
            // btnSua
            // 
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Location = new System.Drawing.Point(330, 295);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(330, 335);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmQuanLyNXB
            // 
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, dgvDanhSach,
                lblMa, lblTen, lblDiaChi,
                txtMaXB, txtTenXB, txtDiaChi,
                btnSua, btnXoa});
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FrmQuanLyNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle, lblMa, lblTen, lblDiaChi;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtMaXB, txtTenXB, txtDiaChi;
        private System.Windows.Forms.Button btnSua, btnXoa;
    }
}
