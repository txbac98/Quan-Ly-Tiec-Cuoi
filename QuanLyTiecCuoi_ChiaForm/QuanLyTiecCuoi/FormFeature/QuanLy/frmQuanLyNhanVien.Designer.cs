namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    partial class frmQuanLyNhanVien
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
            this.lbKetQua = new System.Windows.Forms.Label();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.grpThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lbThongTinHinhAnh = new System.Windows.Forms.Label();
            this.ptrHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.llbThemMoi = new System.Windows.Forms.LinkLabel();
            this.lblThongTinMaNhanVien = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblDanhSachNhanVien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaTimKiem = new System.Windows.Forms.Button();
            this.cbbChucVu_TimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtRong = new System.Windows.Forms.RadioButton();
            this.rbtNu_TimKiem = new System.Windows.Forms.RadioButton();
            this.rbtNam_TimKiem = new System.Windows.Forms.RadioButton();
            this.lbTenNV_TimKiem = new System.Windows.Forms.Label();
            this.txtTenNhanVien_TimKiem = new System.Windows.Forms.TextBox();
            this.grbMaNV = new System.Windows.Forms.GroupBox();
            this.txtMaNV_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.grpThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbMaNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(330, 515);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(74, 14);
            this.lbKetQua.TabIndex = 13;
            this.lbKetQua.Text = "Show ket qua";
            this.lbKetQua.Click += new System.EventHandler(this.lbKetQua_Click);
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AllowUserToAddRows = false;
            this.dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(299, 156);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(589, 339);
            this.dgvDanhSachNhanVien.TabIndex = 11;
            this.dgvDanhSachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhanVien_CellClick);
            // 
            // grpThongTinNhanVien
            // 
            this.grpThongTinNhanVien.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grpThongTinNhanVien.Controls.Add(this.btnThem);
            this.grpThongTinNhanVien.Controls.Add(this.btnXoa);
            this.grpThongTinNhanVien.Controls.Add(this.btnSua);
            this.grpThongTinNhanVien.Controls.Add(this.rbtNu);
            this.grpThongTinNhanVien.Controls.Add(this.rbtNam);
            this.grpThongTinNhanVien.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinNhanVien.Controls.Add(this.lblNgaySinh);
            this.grpThongTinNhanVien.Controls.Add(this.lblGioiTinh);
            this.grpThongTinNhanVien.Controls.Add(this.lbThongTinHinhAnh);
            this.grpThongTinNhanVien.Controls.Add(this.ptrHinhAnh);
            this.grpThongTinNhanVien.Controls.Add(this.btnXoaAnh);
            this.grpThongTinNhanVien.Controls.Add(this.btnChonAnh);
            this.grpThongTinNhanVien.Controls.Add(this.cbbChucVu);
            this.grpThongTinNhanVien.Controls.Add(this.lbChucVu);
            this.grpThongTinNhanVien.Controls.Add(this.llbThemMoi);
            this.grpThongTinNhanVien.Controls.Add(this.lblThongTinMaNhanVien);
            this.grpThongTinNhanVien.Controls.Add(this.txtDiaChi);
            this.grpThongTinNhanVien.Controls.Add(this.txtDienThoai);
            this.grpThongTinNhanVien.Controls.Add(this.txtTenNhanVien);
            this.grpThongTinNhanVien.Controls.Add(this.lblDiaChi);
            this.grpThongTinNhanVien.Controls.Add(this.lblDienThoai);
            this.grpThongTinNhanVien.Controls.Add(this.lblTenNhanVien);
            this.grpThongTinNhanVien.Controls.Add(this.lblMaNhanVien);
            this.grpThongTinNhanVien.Font = new System.Drawing.Font("Arial", 8.25F);
            this.grpThongTinNhanVien.Location = new System.Drawing.Point(3, 13);
            this.grpThongTinNhanVien.Name = "grpThongTinNhanVien";
            this.grpThongTinNhanVien.Size = new System.Drawing.Size(290, 516);
            this.grpThongTinNhanVien.TabIndex = 9;
            this.grpThongTinNhanVien.TabStop = false;
            this.grpThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Actions_insert_horizontal_rule_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(5, 476);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 32);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(204, 476);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 32);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::QuanLyTiecCuoiUI.Properties.Resources.edit_validated_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(104, 476);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 32);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(246, 146);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(39, 18);
            this.rbtNu.TabIndex = 2;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Location = new System.Drawing.Point(185, 146);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(46, 18);
            this.rbtNam.TabIndex = 1;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(184, 202);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(93, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(182, 181);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(55, 14);
            this.lblNgaySinh.TabIndex = 22;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(182, 125);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(46, 14);
            this.lblGioiTinh.TabIndex = 21;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lbThongTinHinhAnh
            // 
            this.lbThongTinHinhAnh.AutoSize = true;
            this.lbThongTinHinhAnh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinHinhAnh.Location = new System.Drawing.Point(12, 320);
            this.lbThongTinHinhAnh.Name = "lbThongTinHinhAnh";
            this.lbThongTinHinhAnh.Size = new System.Drawing.Size(78, 16);
            this.lbThongTinHinhAnh.TabIndex = 20;
            this.lbThongTinHinhAnh.Text = "Unknow.png";
            // 
            // ptrHinhAnh
            // 
            this.ptrHinhAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptrHinhAnh.Image = global::QuanLyTiecCuoiUI.Properties.Resources.avatar;
            this.ptrHinhAnh.Location = new System.Drawing.Point(9, 125);
            this.ptrHinhAnh.Name = "ptrHinhAnh";
            this.ptrHinhAnh.Size = new System.Drawing.Size(160, 190);
            this.ptrHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHinhAnh.TabIndex = 19;
            this.ptrHinhAnh.TabStop = false;
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaAnh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.Location = new System.Drawing.Point(182, 282);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(93, 32);
            this.btnXoaAnh.TabIndex = 5;
            this.btnXoaAnh.Text = "Xoá ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(182, 243);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(93, 32);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(83, 344);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(192, 22);
            this.cbbChucVu.TabIndex = 6;
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_SelectedIndexChanged);
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(12, 347);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(48, 14);
            this.lbChucVu.TabIndex = 15;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // llbThemMoi
            // 
            this.llbThemMoi.AutoSize = true;
            this.llbThemMoi.Location = new System.Drawing.Point(205, 36);
            this.llbThemMoi.Name = "llbThemMoi";
            this.llbThemMoi.Size = new System.Drawing.Size(53, 14);
            this.llbThemMoi.TabIndex = 12;
            this.llbThemMoi.TabStop = true;
            this.llbThemMoi.Text = "Thêm mới";
            this.llbThemMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemMoi_LinkClicked);
            // 
            // lblThongTinMaNhanVien
            // 
            this.lblThongTinMaNhanVien.AutoSize = true;
            this.lblThongTinMaNhanVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinMaNhanVien.Location = new System.Drawing.Point(115, 36);
            this.lblThongTinMaNhanVien.Name = "lblThongTinMaNhanVien";
            this.lblThongTinMaNhanVien.Size = new System.Drawing.Size(40, 16);
            this.lblThongTinMaNhanVien.TabIndex = 9;
            this.lblThongTinMaNhanVien.Text = "NV01";
            this.lblThongTinMaNhanVien.Click += new System.EventHandler(this.lblThongTinMaNhanVien_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(84, 407);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(192, 41);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(84, 378);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(192, 20);
            this.txtDienThoai.TabIndex = 7;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(9, 87);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(269, 20);
            this.txtTenNhanVien.TabIndex = 0;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(13, 410);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 14);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(13, 381);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(55, 14);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(6, 70);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(75, 14);
            this.lblTenNhanVien.TabIndex = 1;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(6, 36);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(71, 14);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // lblDanhSachNhanVien
            // 
            this.lblDanhSachNhanVien.AutoSize = true;
            this.lblDanhSachNhanVien.Location = new System.Drawing.Point(302, 135);
            this.lblDanhSachNhanVien.Name = "lblDanhSachNhanVien";
            this.lblDanhSachNhanVien.Size = new System.Drawing.Size(109, 14);
            this.lblDanhSachNhanVien.TabIndex = 12;
            this.lblDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaTimKiem);
            this.groupBox1.Controls.Add(this.cbbChucVu_TimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbTenNV_TimKiem);
            this.groupBox1.Controls.Add(this.txtTenNhanVien_TimKiem);
            this.groupBox1.Location = new System.Drawing.Point(438, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 108);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnXoaTimKiem
            // 
            this.btnXoaTimKiem.Location = new System.Drawing.Point(332, 72);
            this.btnXoaTimKiem.Name = "btnXoaTimKiem";
            this.btnXoaTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btnXoaTimKiem.TabIndex = 6;
            this.btnXoaTimKiem.Text = "Xóa tìm kiếm";
            this.btnXoaTimKiem.UseVisualStyleBackColor = true;
            this.btnXoaTimKiem.Click += new System.EventHandler(this.btnXoaTimKiem_Click);
            // 
            // cbbChucVu_TimKiem
            // 
            this.cbbChucVu_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu_TimKiem.FormattingEnabled = true;
            this.cbbChucVu_TimKiem.Location = new System.Drawing.Point(237, 40);
            this.cbbChucVu_TimKiem.Name = "cbbChucVu_TimKiem";
            this.cbbChucVu_TimKiem.Size = new System.Drawing.Size(181, 22);
            this.cbbChucVu_TimKiem.TabIndex = 5;
            this.cbbChucVu_TimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_TimKiem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chức vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtRong);
            this.panel1.Controls.Add(this.rbtNu_TimKiem);
            this.panel1.Controls.Add(this.rbtNam_TimKiem);
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 32);
            this.panel1.TabIndex = 17;
            // 
            // rbtRong
            // 
            this.rbtRong.AutoSize = true;
            this.rbtRong.Location = new System.Drawing.Point(172, 10);
            this.rbtRong.Name = "rbtRong";
            this.rbtRong.Size = new System.Drawing.Size(14, 13);
            this.rbtRong.TabIndex = 4;
            this.rbtRong.TabStop = true;
            this.rbtRong.UseVisualStyleBackColor = true;
            this.rbtRong.CheckedChanged += new System.EventHandler(this.rbtRong_CheckedChanged);
            // 
            // rbtNu_TimKiem
            // 
            this.rbtNu_TimKiem.AutoSize = true;
            this.rbtNu_TimKiem.Location = new System.Drawing.Point(103, 8);
            this.rbtNu_TimKiem.Name = "rbtNu_TimKiem";
            this.rbtNu_TimKiem.Size = new System.Drawing.Size(39, 18);
            this.rbtNu_TimKiem.TabIndex = 3;
            this.rbtNu_TimKiem.TabStop = true;
            this.rbtNu_TimKiem.Text = "Nữ";
            this.rbtNu_TimKiem.UseVisualStyleBackColor = true;
            this.rbtNu_TimKiem.CheckedChanged += new System.EventHandler(this.rbtNu_TimKiem_CheckedChanged);
            // 
            // rbtNam_TimKiem
            // 
            this.rbtNam_TimKiem.AutoSize = true;
            this.rbtNam_TimKiem.Location = new System.Drawing.Point(19, 8);
            this.rbtNam_TimKiem.Name = "rbtNam_TimKiem";
            this.rbtNam_TimKiem.Size = new System.Drawing.Size(46, 18);
            this.rbtNam_TimKiem.TabIndex = 2;
            this.rbtNam_TimKiem.TabStop = true;
            this.rbtNam_TimKiem.Text = "Nam";
            this.rbtNam_TimKiem.UseVisualStyleBackColor = true;
            this.rbtNam_TimKiem.CheckedChanged += new System.EventHandler(this.rbtNam_TimKiem_CheckedChanged);
            // 
            // lbTenNV_TimKiem
            // 
            this.lbTenNV_TimKiem.AutoSize = true;
            this.lbTenNV_TimKiem.Location = new System.Drawing.Point(6, 23);
            this.lbTenNV_TimKiem.Name = "lbTenNV_TimKiem";
            this.lbTenNV_TimKiem.Size = new System.Drawing.Size(75, 14);
            this.lbTenNV_TimKiem.TabIndex = 7;
            this.lbTenNV_TimKiem.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien_TimKiem
            // 
            this.txtTenNhanVien_TimKiem.Location = new System.Drawing.Point(9, 40);
            this.txtTenNhanVien_TimKiem.Name = "txtTenNhanVien_TimKiem";
            this.txtTenNhanVien_TimKiem.Size = new System.Drawing.Size(208, 20);
            this.txtTenNhanVien_TimKiem.TabIndex = 1;
            this.txtTenNhanVien_TimKiem.TextChanged += new System.EventHandler(this.txtTenNhanVien_TimKiem_TextChanged);
            // 
            // grbMaNV
            // 
            this.grbMaNV.Controls.Add(this.txtMaNV_TimKiem);
            this.grbMaNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMaNV.Location = new System.Drawing.Point(299, 14);
            this.grbMaNV.Name = "grbMaNV";
            this.grbMaNV.Size = new System.Drawing.Size(133, 108);
            this.grbMaNV.TabIndex = 15;
            this.grbMaNV.TabStop = false;
            this.grbMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV_TimKiem
            // 
            this.txtMaNV_TimKiem.Location = new System.Drawing.Point(6, 40);
            this.txtMaNV_TimKiem.Name = "txtMaNV_TimKiem";
            this.txtMaNV_TimKiem.Size = new System.Drawing.Size(117, 20);
            this.txtMaNV_TimKiem.TabIndex = 0;
            this.txtMaNV_TimKiem.TextChanged += new System.EventHandler(this.txtMaNV_TimKiem_TextChanged);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbMaNV);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.dgvDanhSachNhanVien);
            this.Controls.Add(this.grpThongTinNhanVien);
            this.Controls.Add(this.lblDanhSachNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.grpThongTinNhanVien.ResumeLayout(false);
            this.grpThongTinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbMaNV.ResumeLayout(false);
            this.grbMaNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.GroupBox grpThongTinNhanVien;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.LinkLabel llbThemMoi;
        private System.Windows.Forms.Label lblThongTinMaNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblDanhSachNhanVien;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lbThongTinHinhAnh;
        private System.Windows.Forms.PictureBox ptrHinhAnh;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaTimKiem;
        private System.Windows.Forms.ComboBox cbbChucVu_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtRong;
        private System.Windows.Forms.RadioButton rbtNu_TimKiem;
        private System.Windows.Forms.RadioButton rbtNam_TimKiem;
        private System.Windows.Forms.Label lbTenNV_TimKiem;
        private System.Windows.Forms.TextBox txtTenNhanVien_TimKiem;
        private System.Windows.Forms.GroupBox grbMaNV;
        private System.Windows.Forms.TextBox txtMaNV_TimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}