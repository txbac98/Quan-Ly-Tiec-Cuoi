namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    partial class frmDanhSachTiec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachTiec));
            this.dgvDanhSachTiec = new System.Windows.Forms.DataGridView();
            this.lblDanhSachTiec = new System.Windows.Forms.Label();
            this.dtpNgayDaiTiec = new System.Windows.Forms.DateTimePicker();
            this.grbTimKiemTiec = new System.Windows.Forms.GroupBox();
            this.ckbNgayDatTiec = new System.Windows.Forms.CheckBox();
            this.btnHuyTim = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbSanh = new System.Windows.Forms.ComboBox();
            this.lblSanh = new System.Windows.Forms.Label();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.lblCa = new System.Windows.Forms.Label();
            this.btnThemTiec = new System.Windows.Forms.Button();
            this.btnSuaTiec = new System.Windows.Forms.Button();
            this.btnXoaTiec = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTiec)).BeginInit();
            this.grbTimKiemTiec.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachTiec
            // 
            this.dgvDanhSachTiec.AllowUserToAddRows = false;
            this.dgvDanhSachTiec.AllowUserToDeleteRows = false;
            this.dgvDanhSachTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTiec.Location = new System.Drawing.Point(13, 130);
            this.dgvDanhSachTiec.Name = "dgvDanhSachTiec";
            this.dgvDanhSachTiec.Size = new System.Drawing.Size(875, 319);
            this.dgvDanhSachTiec.TabIndex = 0;
            this.dgvDanhSachTiec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTiec_CellClick);
            // 
            // lblDanhSachTiec
            // 
            this.lblDanhSachTiec.AutoSize = true;
            this.lblDanhSachTiec.Location = new System.Drawing.Point(10, 114);
            this.lblDanhSachTiec.Name = "lblDanhSachTiec";
            this.lblDanhSachTiec.Size = new System.Drawing.Size(79, 13);
            this.lblDanhSachTiec.TabIndex = 1;
            this.lblDanhSachTiec.Text = "Danh sách tiệc";
            // 
            // dtpNgayDaiTiec
            // 
            this.dtpNgayDaiTiec.Location = new System.Drawing.Point(111, 31);
            this.dtpNgayDaiTiec.Name = "dtpNgayDaiTiec";
            this.dtpNgayDaiTiec.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDaiTiec.TabIndex = 2;
            // 
            // grbTimKiemTiec
            // 
            this.grbTimKiemTiec.Controls.Add(this.ckbNgayDatTiec);
            this.grbTimKiemTiec.Controls.Add(this.btnHuyTim);
            this.grbTimKiemTiec.Controls.Add(this.btnTimKiem);
            this.grbTimKiemTiec.Controls.Add(this.cbbSanh);
            this.grbTimKiemTiec.Controls.Add(this.lblSanh);
            this.grbTimKiemTiec.Controls.Add(this.cbbCa);
            this.grbTimKiemTiec.Controls.Add(this.lblCa);
            this.grbTimKiemTiec.Controls.Add(this.dtpNgayDaiTiec);
            this.grbTimKiemTiec.Location = new System.Drawing.Point(13, 13);
            this.grbTimKiemTiec.Name = "grbTimKiemTiec";
            this.grbTimKiemTiec.Size = new System.Drawing.Size(875, 89);
            this.grbTimKiemTiec.TabIndex = 3;
            this.grbTimKiemTiec.TabStop = false;
            this.grbTimKiemTiec.Text = "Tìm kiếm";
            // 
            // ckbNgayDatTiec
            // 
            this.ckbNgayDatTiec.AutoSize = true;
            this.ckbNgayDatTiec.Location = new System.Drawing.Point(16, 33);
            this.ckbNgayDatTiec.Name = "ckbNgayDatTiec";
            this.ckbNgayDatTiec.Size = new System.Drawing.Size(90, 17);
            this.ckbNgayDatTiec.TabIndex = 10;
            this.ckbNgayDatTiec.Text = "Ngày đặt tiệc";
            this.ckbNgayDatTiec.UseVisualStyleBackColor = true;
            // 
            // btnHuyTim
            // 
            this.btnHuyTim.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnHuyTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTim.Location = new System.Drawing.Point(743, 50);
            this.btnHuyTim.Name = "btnHuyTim";
            this.btnHuyTim.Size = new System.Drawing.Size(101, 33);
            this.btnHuyTim.TabIndex = 9;
            this.btnHuyTim.Text = "      Hủy tìm";
            this.btnHuyTim.UseVisualStyleBackColor = true;
            this.btnHuyTim.Click += new System.EventHandler(this.btnHuyTim_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(743, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 28);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "       Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbSanh
            // 
            this.cbbSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanh.FormattingEnabled = true;
            this.cbbSanh.Location = new System.Drawing.Point(559, 30);
            this.cbbSanh.Name = "cbbSanh";
            this.cbbSanh.Size = new System.Drawing.Size(109, 21);
            this.cbbSanh.TabIndex = 7;
            // 
            // lblSanh
            // 
            this.lblSanh.AutoSize = true;
            this.lblSanh.Location = new System.Drawing.Point(521, 33);
            this.lblSanh.Name = "lblSanh";
            this.lblSanh.Size = new System.Drawing.Size(32, 13);
            this.lblSanh.TabIndex = 6;
            this.lblSanh.Text = "Sảnh";
            // 
            // cbbCa
            // 
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(362, 30);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(153, 21);
            this.cbbCa.TabIndex = 5;
            this.cbbCa.SelectedIndexChanged += new System.EventHandler(this.cbbCa_SelectedIndexChanged);
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(336, 34);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(20, 13);
            this.lblCa.TabIndex = 4;
            this.lblCa.Text = "Ca";
            // 
            // btnThemTiec
            // 
            this.btnThemTiec.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Actions_insert_horizontal_rule_icon;
            this.btnThemTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTiec.Location = new System.Drawing.Point(124, 460);
            this.btnThemTiec.Name = "btnThemTiec";
            this.btnThemTiec.Size = new System.Drawing.Size(88, 33);
            this.btnThemTiec.TabIndex = 4;
            this.btnThemTiec.Text = "        Thêm tiệc";
            this.btnThemTiec.UseVisualStyleBackColor = true;
            this.btnThemTiec.Click += new System.EventHandler(this.btnThemTiec_Click);
            // 
            // btnSuaTiec
            // 
            this.btnSuaTiec.Enabled = false;
            this.btnSuaTiec.Image = global::QuanLyTiecCuoiUI.Properties.Resources.edit_validated_icon;
            this.btnSuaTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTiec.Location = new System.Drawing.Point(236, 460);
            this.btnSuaTiec.Name = "btnSuaTiec";
            this.btnSuaTiec.Size = new System.Drawing.Size(85, 33);
            this.btnSuaTiec.TabIndex = 5;
            this.btnSuaTiec.Text = "      Sửa tiệc";
            this.btnSuaTiec.UseVisualStyleBackColor = true;
            this.btnSuaTiec.Click += new System.EventHandler(this.btnSuaTiec_Click);
            // 
            // btnXoaTiec
            // 
            this.btnXoaTiec.Enabled = false;
            this.btnXoaTiec.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnXoaTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTiec.Location = new System.Drawing.Point(342, 460);
            this.btnXoaTiec.Name = "btnXoaTiec";
            this.btnXoaTiec.Size = new System.Drawing.Size(80, 33);
            this.btnXoaTiec.TabIndex = 6;
            this.btnXoaTiec.Text = "        Xóa tiệc";
            this.btnXoaTiec.UseVisualStyleBackColor = true;
            this.btnXoaTiec.Click += new System.EventHandler(this.btnXoaTiec_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(13, 460);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(89, 33);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "      Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // frmDanhSachTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaTiec);
            this.Controls.Add(this.btnSuaTiec);
            this.Controls.Add(this.btnThemTiec);
            this.Controls.Add(this.grbTimKiemTiec);
            this.Controls.Add(this.lblDanhSachTiec);
            this.Controls.Add(this.dgvDanhSachTiec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachTiec";
            this.Text = "Danh sách tiệc";
            this.Load += new System.EventHandler(this.frmDanhSachTiec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTiec)).EndInit();
            this.grbTimKiemTiec.ResumeLayout(false);
            this.grbTimKiemTiec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachTiec;
        private System.Windows.Forms.Label lblDanhSachTiec;
        private System.Windows.Forms.DateTimePicker dtpNgayDaiTiec;
        private System.Windows.Forms.GroupBox grbTimKiemTiec;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Button btnHuyTim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbSanh;
        private System.Windows.Forms.Label lblSanh;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Button btnThemTiec;
        private System.Windows.Forms.Button btnSuaTiec;
        private System.Windows.Forms.Button btnXoaTiec;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.CheckBox ckbNgayDatTiec;
    }
}