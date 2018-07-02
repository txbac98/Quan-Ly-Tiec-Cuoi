namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    partial class frmQuanLySanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpThongTinSanh = new System.Windows.Forms.GroupBox();
            this.llbThemMoi = new System.Windows.Forms.LinkLabel();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongBanTD = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSoLuongBanTD = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblTenSanh = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaSanh = new System.Windows.Forms.TextBox();
            this.grbDanhSachSan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSanh = new System.Windows.Forms.DataGridView();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grpChucNang.SuspendLayout();
            this.grpThongTinSanh.SuspendLayout();
            this.grbDanhSachSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanh)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Location = new System.Drawing.Point(325, 12);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(114, 218);
            this.grpChucNang.TabIndex = 32;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Actions_insert_horizontal_rule_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(6, 45);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(6, 123);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::QuanLyTiecCuoiUI.Properties.Resources.edit_validated_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(6, 83);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpThongTinSanh
            // 
            this.grpThongTinSanh.Controls.Add(this.llbThemMoi);
            this.grpThongTinSanh.Controls.Add(this.txtDonGiaBan);
            this.grpThongTinSanh.Controls.Add(this.label5);
            this.grpThongTinSanh.Controls.Add(this.label4);
            this.grpThongTinSanh.Controls.Add(this.label3);
            this.grpThongTinSanh.Controls.Add(this.label1);
            this.grpThongTinSanh.Controls.Add(this.txtSoLuongBanTD);
            this.grpThongTinSanh.Controls.Add(this.lblGhiChu);
            this.grpThongTinSanh.Controls.Add(this.lblSoLuongBanTD);
            this.grpThongTinSanh.Controls.Add(this.lblDonGiaBan);
            this.grpThongTinSanh.Controls.Add(this.lblTenSanh);
            this.grpThongTinSanh.Controls.Add(this.txtGhiChu);
            this.grpThongTinSanh.Controls.Add(this.txtMaSanh);
            this.grpThongTinSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpThongTinSanh.Location = new System.Drawing.Point(12, 12);
            this.grpThongTinSanh.Name = "grpThongTinSanh";
            this.grpThongTinSanh.Size = new System.Drawing.Size(307, 218);
            this.grpThongTinSanh.TabIndex = 31;
            this.grpThongTinSanh.TabStop = false;
            this.grpThongTinSanh.Text = "Thông tin sảnh";
            // 
            // llbThemMoi
            // 
            this.llbThemMoi.AutoSize = true;
            this.llbThemMoi.Location = new System.Drawing.Point(221, 19);
            this.llbThemMoi.Name = "llbThemMoi";
            this.llbThemMoi.Size = new System.Drawing.Size(53, 13);
            this.llbThemMoi.TabIndex = 7;
            this.llbThemMoi.TabStop = true;
            this.llbThemMoi.Text = "Thêm mới";
            this.llbThemMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemMoi_LinkClicked);
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(162, 71);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBan.MaxLength = 10;
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(138, 20);
            this.txtDonGiaBan.TabIndex = 1;
            this.txtDonGiaBan.TextChanged += new System.EventHandler(this.txtDonGiaBan_TextChanged);
            this.txtDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBan_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Các mục (*) không được để trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(136, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(103, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "*";
            // 
            // txtSoLuongBanTD
            // 
            this.txtSoLuongBanTD.Location = new System.Drawing.Point(162, 102);
            this.txtSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongBanTD.MaxLength = 3;
            this.txtSoLuongBanTD.Name = "txtSoLuongBanTD";
            this.txtSoLuongBanTD.Size = new System.Drawing.Size(138, 20);
            this.txtSoLuongBanTD.TabIndex = 2;
            this.txtSoLuongBanTD.TextChanged += new System.EventHandler(this.txtSoLuongBanTD_TextChanged);
            this.txtSoLuongBanTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoBanToiDa_KeyPress);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(7, 140);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lblGhiChu.TabIndex = 39;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblSoLuongBanTD
            // 
            this.lblSoLuongBanTD.AutoSize = true;
            this.lblSoLuongBanTD.Location = new System.Drawing.Point(7, 108);
            this.lblSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongBanTD.Name = "lblSoLuongBanTD";
            this.lblSoLuongBanTD.Size = new System.Drawing.Size(100, 13);
            this.lblSoLuongBanTD.TabIndex = 38;
            this.lblSoLuongBanTD.Text = "Số lượng bàn tối đa";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Location = new System.Drawing.Point(7, 77);
            this.lblDonGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(68, 13);
            this.lblDonGiaBan.TabIndex = 37;
            this.lblDonGiaBan.Text = "Đơn giá bàn ";
            // 
            // lblTenSanh
            // 
            this.lblTenSanh.AutoSize = true;
            this.lblTenSanh.Location = new System.Drawing.Point(7, 45);
            this.lblTenSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSanh.Name = "lblTenSanh";
            this.lblTenSanh.Size = new System.Drawing.Size(48, 13);
            this.lblTenSanh.TabIndex = 35;
            this.lblTenSanh.Text = "Mã sảnh";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(162, 140);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(138, 48);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // txtMaSanh
            // 
            this.txtMaSanh.Location = new System.Drawing.Point(162, 42);
            this.txtMaSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSanh.MaxLength = 100;
            this.txtMaSanh.Name = "txtMaSanh";
            this.txtMaSanh.Size = new System.Drawing.Size(138, 20);
            this.txtMaSanh.TabIndex = 0;
            this.txtMaSanh.TextChanged += new System.EventHandler(this.txtMaSanh_TextChanged);
            // 
            // grbDanhSachSan
            // 
            this.grbDanhSachSan.Controls.Add(this.dgvDanhSachSanh);
            this.grbDanhSachSan.Location = new System.Drawing.Point(12, 233);
            this.grbDanhSachSan.Name = "grbDanhSachSan";
            this.grbDanhSachSan.Size = new System.Drawing.Size(427, 178);
            this.grbDanhSachSan.TabIndex = 33;
            this.grbDanhSachSan.TabStop = false;
            this.grbDanhSachSan.Text = "Danh sách sảnh";
            // 
            // dgvDanhSachSanh
            // 
            this.dgvDanhSachSanh.AllowUserToAddRows = false;
            this.dgvDanhSachSanh.AllowUserToDeleteRows = false;
            this.dgvDanhSachSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanh.Location = new System.Drawing.Point(6, 16);
            this.dgvDanhSachSanh.Name = "dgvDanhSachSanh";
            this.dgvDanhSachSanh.Size = new System.Drawing.Size(413, 156);
            this.dgvDanhSachSanh.TabIndex = 0;
            this.dgvDanhSachSanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanh_CellClick);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(12, 418);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 34;
            this.lblKetQua.Text = "Kết quả";
            // 
            // frmQuanLySanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 443);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.grbDanhSachSan);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTinSanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmQuanLySanh";
            this.Text = "Quản lý sảnh";
            this.grpChucNang.ResumeLayout(false);
            this.grpThongTinSanh.ResumeLayout(false);
            this.grpThongTinSanh.PerformLayout();
            this.grbDanhSachSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.GroupBox grpThongTinSanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongBanTD;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblSoLuongBanTD;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblTenSanh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaSanh;
        private System.Windows.Forms.LinkLabel llbThemMoi;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.GroupBox grbDanhSachSan;
        private System.Windows.Forms.DataGridView dgvDanhSachSanh;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}