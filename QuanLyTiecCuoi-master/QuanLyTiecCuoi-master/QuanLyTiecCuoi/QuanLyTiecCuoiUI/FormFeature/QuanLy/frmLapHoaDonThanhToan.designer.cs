namespace QuanLyTiecCuoiUI
{
    partial class frmLapHoaDonThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenChuRe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenCoDau = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabThongTinOrder = new System.Windows.Forms.TabControl();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvCacDichVu = new System.Windows.Forms.DataGridView();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMonAn = new System.Windows.Forms.TabPage();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTongTienPhat = new System.Windows.Forms.Label();
            this.lblSoNgayTre = new System.Windows.Forms.Label();
            this.lblPhanTramPhat = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblConLai = new System.Windows.Forms.Label();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.lblTongTienDV = new System.Windows.Forms.Label();
            this.lblTongTienHD = new System.Windows.Forms.Label();
            this.lblTongTienBan = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblSoLuongBan = new System.Windows.Forms.Label();
            this.lblNgayThanhToan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTienDaThanhToan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNTTInfo = new System.Windows.Forms.Label();
            this.btnLayThongTin = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayDaiTiec = new System.Windows.Forms.DateTimePicker();
            this.gbThanhToan = new System.Windows.Forms.GroupBox();
            this.lblThanhToanXong = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtSoTienTra = new System.Windows.Forms.TextBox();
            this.lblSoTienTra = new System.Windows.Forms.Label();
            this.gbThongTinThanhToan = new System.Windows.Forms.GroupBox();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabThongTinOrder.SuspendLayout();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVu)).BeginInit();
            this.tabMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.gbThanhToan.SuspendLayout();
            this.gbThongTinThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chú rể:";
            // 
            // cbbTenChuRe
            // 
            this.cbbTenChuRe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenChuRe.FormattingEnabled = true;
            this.cbbTenChuRe.Location = new System.Drawing.Point(112, 22);
            this.cbbTenChuRe.Name = "cbbTenChuRe";
            this.cbbTenChuRe.Size = new System.Drawing.Size(191, 24);
            this.cbbTenChuRe.TabIndex = 1;
            this.cbbTenChuRe.SelectedIndexChanged += new System.EventHandler(this.cbbTenChuRe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Tên cô dâu:";
            // 
            // cbbTenCoDau
            // 
            this.cbbTenCoDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenCoDau.FormattingEnabled = true;
            this.cbbTenCoDau.Location = new System.Drawing.Point(408, 22);
            this.cbbTenCoDau.Name = "cbbTenCoDau";
            this.cbbTenCoDau.Size = new System.Drawing.Size(191, 24);
            this.cbbTenCoDau.TabIndex = 3;
            this.cbbTenCoDau.SelectedIndexChanged += new System.EventHandler(this.cbbTenCoDau_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabThongTinOrder);
            this.groupBox1.Controls.Add(this.lblTongTienThanhToan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblTongTienPhat);
            this.groupBox1.Controls.Add(this.lblSoNgayTre);
            this.groupBox1.Controls.Add(this.lblPhanTramPhat);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblConLai);
            this.groupBox1.Controls.Add(this.lblTienDatCoc);
            this.groupBox1.Controls.Add(this.lblTongTienDV);
            this.groupBox1.Controls.Add(this.lblTongTienHD);
            this.groupBox1.Controls.Add(this.lblTongTienBan);
            this.groupBox1.Controls.Add(this.lblDonGiaBan);
            this.groupBox1.Controls.Add(this.lblSoLuongBan);
            this.groupBox1.Controls.Add(this.lblNgayThanhToan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblTienDaThanhToan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNTTInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 327);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn thanh toán";
            // 
            // tabThongTinOrder
            // 
            this.tabThongTinOrder.Controls.Add(this.tabDichVu);
            this.tabThongTinOrder.Controls.Add(this.tabMonAn);
            this.tabThongTinOrder.Location = new System.Drawing.Point(17, 22);
            this.tabThongTinOrder.Name = "tabThongTinOrder";
            this.tabThongTinOrder.SelectedIndex = 0;
            this.tabThongTinOrder.Size = new System.Drawing.Size(570, 134);
            this.tabThongTinOrder.TabIndex = 31;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvCacDichVu);
            this.tabDichVu.Location = new System.Drawing.Point(4, 25);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(562, 105);
            this.tabDichVu.TabIndex = 0;
            this.tabDichVu.Text = "Dịch Vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // dgvCacDichVu
            // 
            this.dgvCacDichVu.AllowUserToAddRows = false;
            this.dgvCacDichVu.AllowUserToDeleteRows = false;
            this.dgvCacDichVu.AllowUserToResizeRows = false;
            this.dgvCacDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCacDichVu.ColumnHeadersHeight = 25;
            this.dgvCacDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThanhTien,
            this.Column2,
            this.DonGia,
            this.Column4});
            this.dgvCacDichVu.EnableHeadersVisualStyles = false;
            this.dgvCacDichVu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvCacDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvCacDichVu.MultiSelect = false;
            this.dgvCacDichVu.Name = "dgvCacDichVu";
            this.dgvCacDichVu.ReadOnly = true;
            this.dgvCacDichVu.RowHeadersVisible = false;
            this.dgvCacDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvCacDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCacDichVu.Size = new System.Drawing.Size(562, 105);
            this.dgvCacDichVu.TabIndex = 9;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "TenDichVu";
            this.ThanhTien.HeaderText = "Dịch vụ";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá (VND)";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThanhTien";
            this.Column4.HeaderText = "Thành tiền (VND)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabMonAn
            // 
            this.tabMonAn.Controls.Add(this.dgvMonAn);
            this.tabMonAn.Location = new System.Drawing.Point(4, 25);
            this.tabMonAn.Name = "tabMonAn";
            this.tabMonAn.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonAn.Size = new System.Drawing.Size(562, 105);
            this.tabMonAn.TabIndex = 1;
            this.tabMonAn.Text = "Món Ăn";
            this.tabMonAn.UseVisualStyleBackColor = true;
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.AllowUserToResizeRows = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(0, 0);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(562, 105);
            this.dgvMonAn.TabIndex = 0;
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(471, 299);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(14, 17);
            this.lblTongTienThanhToan.TabIndex = 30;
            this.lblTongTienThanhToan.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Còn lại:";
            // 
            // lblTongTienPhat
            // 
            this.lblTongTienPhat.AutoSize = true;
            this.lblTongTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPhat.Location = new System.Drawing.Point(471, 271);
            this.lblTongTienPhat.Name = "lblTongTienPhat";
            this.lblTongTienPhat.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienPhat.TabIndex = 28;
            this.lblTongTienPhat.Text = "-";
            // 
            // lblSoNgayTre
            // 
            this.lblSoNgayTre.AutoSize = true;
            this.lblSoNgayTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayTre.Location = new System.Drawing.Point(471, 217);
            this.lblSoNgayTre.Name = "lblSoNgayTre";
            this.lblSoNgayTre.Size = new System.Drawing.Size(13, 17);
            this.lblSoNgayTre.TabIndex = 27;
            this.lblSoNgayTre.Text = "-";
            // 
            // lblPhanTramPhat
            // 
            this.lblPhanTramPhat.AutoSize = true;
            this.lblPhanTramPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanTramPhat.Location = new System.Drawing.Point(471, 244);
            this.lblPhanTramPhat.Name = "lblPhanTramPhat";
            this.lblPhanTramPhat.Size = new System.Drawing.Size(13, 17);
            this.lblPhanTramPhat.TabIndex = 26;
            this.lblPhanTramPhat.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(309, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "Tổng tiền phạt:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(309, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Giá trị phạt (%/ngày):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(309, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Số ngày trễ:";
            // 
            // lblConLai
            // 
            this.lblConLai.AutoSize = true;
            this.lblConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConLai.Location = new System.Drawing.Point(160, 299);
            this.lblConLai.Name = "lblConLai";
            this.lblConLai.Size = new System.Drawing.Size(13, 17);
            this.lblConLai.TabIndex = 22;
            this.lblConLai.Text = "-";
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.AutoSize = true;
            this.lblTienDatCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDatCoc.Location = new System.Drawing.Point(160, 271);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(13, 17);
            this.lblTienDatCoc.TabIndex = 21;
            this.lblTienDatCoc.Text = "-";
            // 
            // lblTongTienDV
            // 
            this.lblTongTienDV.AutoSize = true;
            this.lblTongTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienDV.Location = new System.Drawing.Point(160, 217);
            this.lblTongTienDV.Name = "lblTongTienDV";
            this.lblTongTienDV.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienDV.TabIndex = 20;
            this.lblTongTienDV.Text = "-";
            // 
            // lblTongTienHD
            // 
            this.lblTongTienHD.AutoSize = true;
            this.lblTongTienHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHD.Location = new System.Drawing.Point(160, 244);
            this.lblTongTienHD.Name = "lblTongTienHD";
            this.lblTongTienHD.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienHD.TabIndex = 19;
            this.lblTongTienHD.Text = "-";
            // 
            // lblTongTienBan
            // 
            this.lblTongTienBan.AutoSize = true;
            this.lblTongTienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienBan.Location = new System.Drawing.Point(160, 186);
            this.lblTongTienBan.Name = "lblTongTienBan";
            this.lblTongTienBan.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienBan.TabIndex = 18;
            this.lblTongTienBan.Text = "-";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaBan.Location = new System.Drawing.Point(471, 159);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(13, 17);
            this.lblDonGiaBan.TabIndex = 17;
            this.lblDonGiaBan.Text = "-";
            // 
            // lblSoLuongBan
            // 
            this.lblSoLuongBan.AutoSize = true;
            this.lblSoLuongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongBan.Location = new System.Drawing.Point(471, 186);
            this.lblSoLuongBan.Name = "lblSoLuongBan";
            this.lblSoLuongBan.Size = new System.Drawing.Size(13, 17);
            this.lblSoLuongBan.TabIndex = 16;
            this.lblSoLuongBan.Text = "-";
            // 
            // lblNgayThanhToan
            // 
            this.lblNgayThanhToan.AutoSize = true;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhToan.Location = new System.Drawing.Point(192, 159);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.Size = new System.Drawing.Size(13, 17);
            this.lblNgayThanhToan.TabIndex = 15;
            this.lblNgayThanhToan.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số tiền cần thanh toán:";
            // 
            // lblTienDaThanhToan
            // 
            this.lblTienDaThanhToan.AutoSize = true;
            this.lblTienDaThanhToan.Location = new System.Drawing.Point(14, 271);
            this.lblTienDaThanhToan.Name = "lblTienDaThanhToan";
            this.lblTienDaThanhToan.Size = new System.Drawing.Size(90, 17);
            this.lblTienDaThanhToan.TabIndex = 12;
            this.lblTienDaThanhToan.Text = "Tiền đặt cọc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tổng tiền hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng tiền dịch vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng tiền bàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng bàn:";
            // 
            // lblNTTInfo
            // 
            this.lblNTTInfo.AutoSize = true;
            this.lblNTTInfo.Location = new System.Drawing.Point(14, 159);
            this.lblNTTInfo.Name = "lblNTTInfo";
            this.lblNTTInfo.Size = new System.Drawing.Size(117, 17);
            this.lblNTTInfo.TabIndex = 5;
            this.lblNTTInfo.Text = "Ngày thanh toán:";
            // 
            // btnLayThongTin
            // 
            this.btnLayThongTin.Location = new System.Drawing.Point(474, 50);
            this.btnLayThongTin.Name = "btnLayThongTin";
            this.btnLayThongTin.Size = new System.Drawing.Size(125, 30);
            this.btnLayThongTin.TabIndex = 5;
            this.btnLayThongTin.Text = "Lấy Thông Tin";
            this.btnLayThongTin.UseVisualStyleBackColor = true;
            this.btnLayThongTin.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ngày đãi tiệc:";
            // 
            // dtpNgayDaiTiec
            // 
            this.dtpNgayDaiTiec.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpNgayDaiTiec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDaiTiec.Location = new System.Drawing.Point(112, 52);
            this.dtpNgayDaiTiec.Name = "dtpNgayDaiTiec";
            this.dtpNgayDaiTiec.Size = new System.Drawing.Size(191, 23);
            this.dtpNgayDaiTiec.TabIndex = 8;
            this.dtpNgayDaiTiec.ValueChanged += new System.EventHandler(this.dtpNgayDaiTiec_ValueChanged);
            // 
            // gbThanhToan
            // 
            this.gbThanhToan.Controls.Add(this.lblThanhToanXong);
            this.gbThanhToan.Controls.Add(this.lblResult);
            this.gbThanhToan.Controls.Add(this.lblStart);
            this.gbThanhToan.Controls.Add(this.btnThanhToan);
            this.gbThanhToan.Controls.Add(this.txtSoTienTra);
            this.gbThanhToan.Controls.Add(this.lblSoTienTra);
            this.gbThanhToan.Location = new System.Drawing.Point(12, 441);
            this.gbThanhToan.Name = "gbThanhToan";
            this.gbThanhToan.Size = new System.Drawing.Size(607, 64);
            this.gbThanhToan.TabIndex = 9;
            this.gbThanhToan.TabStop = false;
            this.gbThanhToan.Text = "Thanh Toán";
            // 
            // lblThanhToanXong
            // 
            this.lblThanhToanXong.AutoSize = true;
            this.lblThanhToanXong.ForeColor = System.Drawing.Color.Red;
            this.lblThanhToanXong.Location = new System.Drawing.Point(230, 33);
            this.lblThanhToanXong.Name = "lblThanhToanXong";
            this.lblThanhToanXong.Size = new System.Drawing.Size(215, 17);
            this.lblThanhToanXong.TabIndex = 5;
            this.lblThanhToanXong.Text = "Hóa đơn này đã thanh toán xong";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Control;
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(482, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = System.Drawing.Color.Red;
            this.lblStart.Location = new System.Drawing.Point(126, 33);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(23, 17);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "(*)";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(324, 26);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 31);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(155, 30);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Size = new System.Drawing.Size(129, 23);
            this.txtSoTienTra.TabIndex = 1;
            this.txtSoTienTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienTra_KeyPress);
            // 
            // lblSoTienTra
            // 
            this.lblSoTienTra.AutoSize = true;
            this.lblSoTienTra.Location = new System.Drawing.Point(58, 33);
            this.lblSoTienTra.Name = "lblSoTienTra";
            this.lblSoTienTra.Size = new System.Drawing.Size(73, 17);
            this.lblSoTienTra.TabIndex = 0;
            this.lblSoTienTra.Text = "Số tiền trả";
            // 
            // gbThongTinThanhToan
            // 
            this.gbThongTinThanhToan.Controls.Add(this.cbbTenChuRe);
            this.gbThongTinThanhToan.Controls.Add(this.label1);
            this.gbThongTinThanhToan.Controls.Add(this.dtpNgayDaiTiec);
            this.gbThongTinThanhToan.Controls.Add(this.label2);
            this.gbThongTinThanhToan.Controls.Add(this.label12);
            this.gbThongTinThanhToan.Controls.Add(this.cbbTenCoDau);
            this.gbThongTinThanhToan.Controls.Add(this.btnLayThongTin);
            this.gbThongTinThanhToan.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinThanhToan.Name = "gbThongTinThanhToan";
            this.gbThongTinThanhToan.Size = new System.Drawing.Size(607, 90);
            this.gbThongTinThanhToan.TabIndex = 10;
            this.gbThongTinThanhToan.TabStop = false;
            this.gbThongTinThanhToan.Text = "Thông tin thanh toán";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatHoaDon.Location = new System.Drawing.Point(499, 511);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(120, 30);
            this.btnXuatHoaDon.TabIndex = 11;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            //this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // frmLapHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(631, 552);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.gbThongTinThanhToan);
            this.Controls.Add(this.gbThanhToan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLapHoaDonThanhToan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP HÓA ĐƠN THANH TOÁN";
            this.Load += new System.EventHandler(this.frmLapHoaDonThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabThongTinOrder.ResumeLayout(false);
            this.tabDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVu)).EndInit();
            this.tabMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.gbThanhToan.ResumeLayout(false);
            this.gbThanhToan.PerformLayout();
            this.gbThongTinThanhToan.ResumeLayout(false);
            this.gbThongTinThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenChuRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenCoDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCacDichVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNTTInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTienDaThanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.Label lblTongTienDV;
        private System.Windows.Forms.Label lblTongTienHD;
        private System.Windows.Forms.Label lblTongTienBan;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.Label lblNgayThanhToan;
        private System.Windows.Forms.Button btnLayThongTin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTongTienPhat;
        private System.Windows.Forms.Label lblSoNgayTre;
        private System.Windows.Forms.Label lblPhanTramPhat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpNgayDaiTiec;
        private System.Windows.Forms.GroupBox gbThanhToan;
        private System.Windows.Forms.TextBox txtSoTienTra;
        private System.Windows.Forms.Label lblSoTienTra;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblThanhToanXong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gbThongTinThanhToan;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.TabPage tabMonAn;
        private System.Windows.Forms.TabControl tabThongTinOrder;
        private System.Windows.Forms.DataGridView dgvMonAn;
    }
}