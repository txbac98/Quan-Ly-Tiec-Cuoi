namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    partial class frmQuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDichVu));
            this.lbThongTinHinhAnh = new System.Windows.Forms.Label();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.lbCaution = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.lbCautionDonGia = new System.Windows.Forms.Label();
            this.lbHinhAnh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.lbTenDichVu = new System.Windows.Forms.Label();
            this.gbDanhSachDichVu = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.gbThongTinDichVu = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.llbThemMoi = new System.Windows.Forms.LinkLabel();
            this.lblThongTinMaDichVu = new System.Windows.Forms.Label();
            this.lblMaDichVu = new System.Windows.Forms.Label();
            this.ptrHinhAnh = new System.Windows.Forms.PictureBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnXoaTimKiem = new System.Windows.Forms.Button();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.txtTenDichVu_TimKiem = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.gbDanhSachDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).BeginInit();
            this.gbThongTinDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbThongTinHinhAnh
            // 
            this.lbThongTinHinhAnh.AutoSize = true;
            this.lbThongTinHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinHinhAnh.Location = new System.Drawing.Point(107, 410);
            this.lbThongTinHinhAnh.Name = "lbThongTinHinhAnh";
            this.lbThongTinHinhAnh.Size = new System.Drawing.Size(0, 16);
            this.lbThongTinHinhAnh.TabIndex = 13;
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.Location = new System.Drawing.Point(216, 167);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(100, 30);
            this.btnXoaAnh.TabIndex = 10;
            this.btnXoaAnh.Text = "Xoá ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // lbCaution
            // 
            this.lbCaution.AutoSize = true;
            this.lbCaution.ForeColor = System.Drawing.Color.Red;
            this.lbCaution.Location = new System.Drawing.Point(9, 426);
            this.lbCaution.Name = "lbCaution";
            this.lbCaution.Size = new System.Drawing.Size(150, 13);
            this.lbCaution.TabIndex = 10;
            this.lbCaution.Text = "(*) là những thông tin bắt buộc";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(110, 167);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 30);
            this.btnChonAnh.TabIndex = 11;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // lbCautionDonGia
            // 
            this.lbCautionDonGia.AutoSize = true;
            this.lbCautionDonGia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbCautionDonGia.ForeColor = System.Drawing.Color.Red;
            this.lbCautionDonGia.Location = new System.Drawing.Point(84, 90);
            this.lbCautionDonGia.Name = "lbCautionDonGia";
            this.lbCautionDonGia.Size = new System.Drawing.Size(11, 13);
            this.lbCautionDonGia.TabIndex = 5;
            this.lbCautionDonGia.Text = "*";
            // 
            // lbHinhAnh
            // 
            this.lbHinhAnh.AutoSize = true;
            this.lbHinhAnh.Location = new System.Drawing.Point(23, 173);
            this.lbHinhAnh.Name = "lbHinhAnh";
            this.lbHinhAnh.Size = new System.Drawing.Size(50, 13);
            this.lbHinhAnh.TabIndex = 9;
            this.lbHinhAnh.Text = "Hình ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(110, 87);
            this.txtDonGia.MaxLength = 18;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(206, 20);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(110, 116);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(206, 45);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(31, 119);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lbGhiChu.TabIndex = 0;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(31, 90);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(44, 13);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(110, 58);
            this.txtTenDichVu.MaxLength = 100;
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(206, 20);
            this.txtTenDichVu.TabIndex = 1;
            this.txtTenDichVu.TextChanged += new System.EventHandler(this.txtTenDichVu_TextChanged);
            // 
            // lbTenDichVu
            // 
            this.lbTenDichVu.AutoSize = true;
            this.lbTenDichVu.Location = new System.Drawing.Point(6, 61);
            this.lbTenDichVu.Name = "lbTenDichVu";
            this.lbTenDichVu.Size = new System.Drawing.Size(64, 13);
            this.lbTenDichVu.TabIndex = 0;
            this.lbTenDichVu.Text = "Tên dịch vụ";
            // 
            // gbDanhSachDichVu
            // 
            this.gbDanhSachDichVu.Controls.Add(this.dgvDanhSachDichVu);
            this.gbDanhSachDichVu.Location = new System.Drawing.Point(331, 92);
            this.gbDanhSachDichVu.Name = "gbDanhSachDichVu";
            this.gbDanhSachDichVu.Size = new System.Drawing.Size(432, 370);
            this.gbDanhSachDichVu.TabIndex = 11;
            this.gbDanhSachDichVu.TabStop = false;
            this.gbDanhSachDichVu.Text = "Danh sách dịch vụ";
            // 
            // dgvDanhSachDichVu
            // 
            this.dgvDanhSachDichVu.AllowUserToAddRows = false;
            this.dgvDanhSachDichVu.AllowUserToDeleteRows = false;
            this.dgvDanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDichVu.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSachDichVu.Name = "dgvDanhSachDichVu";
            this.dgvDanhSachDichVu.Size = new System.Drawing.Size(420, 340);
            this.dgvDanhSachDichVu.TabIndex = 0;
            this.dgvDanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDichVu_CellClick);
            // 
            // gbThongTinDichVu
            // 
            this.gbThongTinDichVu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gbThongTinDichVu.Controls.Add(this.btnThem);
            this.gbThongTinDichVu.Controls.Add(this.btnXoa);
            this.gbThongTinDichVu.Controls.Add(this.btnSua);
            this.gbThongTinDichVu.Controls.Add(this.llbThemMoi);
            this.gbThongTinDichVu.Controls.Add(this.lblThongTinMaDichVu);
            this.gbThongTinDichVu.Controls.Add(this.lblMaDichVu);
            this.gbThongTinDichVu.Controls.Add(this.lbThongTinHinhAnh);
            this.gbThongTinDichVu.Controls.Add(this.ptrHinhAnh);
            this.gbThongTinDichVu.Controls.Add(this.btnXoaAnh);
            this.gbThongTinDichVu.Controls.Add(this.lbCaution);
            this.gbThongTinDichVu.Controls.Add(this.btnChonAnh);
            this.gbThongTinDichVu.Controls.Add(this.lbCautionDonGia);
            this.gbThongTinDichVu.Controls.Add(this.lbHinhAnh);
            this.gbThongTinDichVu.Controls.Add(this.label2);
            this.gbThongTinDichVu.Controls.Add(this.txtDonGia);
            this.gbThongTinDichVu.Controls.Add(this.txtGhiChu);
            this.gbThongTinDichVu.Controls.Add(this.lbGhiChu);
            this.gbThongTinDichVu.Controls.Add(this.lbDonGia);
            this.gbThongTinDichVu.Controls.Add(this.txtTenDichVu);
            this.gbThongTinDichVu.Controls.Add(this.lbTenDichVu);
            this.gbThongTinDichVu.Location = new System.Drawing.Point(3, 12);
            this.gbThongTinDichVu.Name = "gbThongTinDichVu";
            this.gbThongTinDichVu.Size = new System.Drawing.Size(322, 483);
            this.gbThongTinDichVu.TabIndex = 10;
            this.gbThongTinDichVu.TabStop = false;
            this.gbThongTinDichVu.Text = "Thông tin dịch vụ";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Actions_insert_horizontal_rule_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 446);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(215, 446);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::QuanLyTiecCuoiUI.Properties.Resources.edit_validated_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(110, 446);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // llbThemMoi
            // 
            this.llbThemMoi.AutoSize = true;
            this.llbThemMoi.Location = new System.Drawing.Point(216, 30);
            this.llbThemMoi.Name = "llbThemMoi";
            this.llbThemMoi.Size = new System.Drawing.Size(53, 13);
            this.llbThemMoi.TabIndex = 16;
            this.llbThemMoi.TabStop = true;
            this.llbThemMoi.Text = "Thêm mới";
            this.llbThemMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemMoi_LinkClicked);
            // 
            // lblThongTinMaDichVu
            // 
            this.lblThongTinMaDichVu.AutoSize = true;
            this.lblThongTinMaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinMaDichVu.Location = new System.Drawing.Point(107, 31);
            this.lblThongTinMaDichVu.Name = "lblThongTinMaDichVu";
            this.lblThongTinMaDichVu.Size = new System.Drawing.Size(47, 17);
            this.lblThongTinMaDichVu.TabIndex = 15;
            this.lblThongTinMaDichVu.Text = "DV01";
            // 
            // lblMaDichVu
            // 
            this.lblMaDichVu.AutoSize = true;
            this.lblMaDichVu.Location = new System.Drawing.Point(6, 31);
            this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(60, 13);
            this.lblMaDichVu.TabIndex = 14;
            this.lblMaDichVu.Text = "Mã dịch vụ";
            // 
            // ptrHinhAnh
            // 
            this.ptrHinhAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptrHinhAnh.Location = new System.Drawing.Point(110, 203);
            this.ptrHinhAnh.Name = "ptrHinhAnh";
            this.ptrHinhAnh.Size = new System.Drawing.Size(206, 206);
            this.ptrHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHinhAnh.TabIndex = 12;
            this.ptrHinhAnh.TabStop = false;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnXoaTimKiem);
            this.grbTimKiem.Controls.Add(this.lblTenDichVu);
            this.grbTimKiem.Controls.Add(this.txtTenDichVu_TimKiem);
            this.grbTimKiem.Location = new System.Drawing.Point(331, 12);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(432, 59);
            this.grbTimKiem.TabIndex = 12;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnXoaTimKiem
            // 
            this.btnXoaTimKiem.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnXoaTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTimKiem.Location = new System.Drawing.Point(322, 17);
            this.btnXoaTimKiem.Name = "btnXoaTimKiem";
            this.btnXoaTimKiem.Size = new System.Drawing.Size(85, 31);
            this.btnXoaTimKiem.TabIndex = 15;
            this.btnXoaTimKiem.Text = "        Hủy tìm";
            this.btnXoaTimKiem.UseVisualStyleBackColor = true;
            this.btnXoaTimKiem.Click += new System.EventHandler(this.btnXoaTimKiem_Click);
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.Location = new System.Drawing.Point(37, 22);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(64, 13);
            this.lblTenDichVu.TabIndex = 14;
            this.lblTenDichVu.Text = "Tên dịch vụ";
            // 
            // txtTenDichVu_TimKiem
            // 
            this.txtTenDichVu_TimKiem.Location = new System.Drawing.Point(118, 19);
            this.txtTenDichVu_TimKiem.MaxLength = 100;
            this.txtTenDichVu_TimKiem.Name = "txtTenDichVu_TimKiem";
            this.txtTenDichVu_TimKiem.Size = new System.Drawing.Size(154, 20);
            this.txtTenDichVu_TimKiem.TabIndex = 14;
            this.txtTenDichVu_TimKiem.TextChanged += new System.EventHandler(this.txtTenDichVu_TimKiem_TextChanged);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(355, 482);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 13;
            this.lblKetQua.Text = "Kết quả";
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 507);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.gbDanhSachDichVu);
            this.Controls.Add(this.gbThongTinDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyDichVu";
            this.Text = "Quản lý dịch vụ";
            this.gbDanhSachDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).EndInit();
            this.gbThongTinDichVu.ResumeLayout(false);
            this.gbThongTinDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongTinHinhAnh;
        private System.Windows.Forms.PictureBox ptrHinhAnh;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Label lbCaution;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label lbCautionDonGia;
        private System.Windows.Forms.Label lbHinhAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label lbTenDichVu;
        private System.Windows.Forms.GroupBox gbDanhSachDichVu;
        private System.Windows.Forms.GroupBox gbThongTinDichVu;
        private System.Windows.Forms.DataGridView dgvDanhSachDichVu;
        private System.Windows.Forms.Label lblThongTinMaDichVu;
        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnXoaTimKiem;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.TextBox txtTenDichVu_TimKiem;
        private System.Windows.Forms.LinkLabel llbThemMoi;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}