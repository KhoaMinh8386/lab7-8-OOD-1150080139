namespace _1150080139Lab7
{
    partial class FrmThemNXB
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
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 30);
            this.lblTitle.Text = "THÊM NHÀ XUẤT BẢN";
            this.lblTitle.AutoSize = true;
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(30, 90);
            this.lblMa.Text = "Mã NXB:";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(30, 130);
            this.lblTen.Text = "Tên NXB:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(30, 170);
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(110, 90);
            this.txtMaXB.Width = 200;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(110, 130);
            this.txtTenXB.Width = 200;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 170);
            this.txtDiaChi.Width = 200;
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(110, 220);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(210, 220);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmThemNXB
            // 
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblMa, lblTen, lblDiaChi,
                txtMaXB, txtTenXB, txtDiaChi,
                btnThem, btnThoat});
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhà Xuất Bản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle, lblMa, lblTen, lblDiaChi;
        private System.Windows.Forms.TextBox txtMaXB, txtTenXB, txtDiaChi;
        private System.Windows.Forms.Button btnThem, btnThoat;
    }
}
