namespace QuanLyTiecCuoiUI
{
    partial class frmTraCuuDichVu
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
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.gbThongTinDichVu = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTenDichVu = new System.Windows.Forms.Label();
            this.ptrHinh = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.tcTraCuuDichVu = new System.Windows.Forms.TabControl();
            this.gbTimKiem.SuspendLayout();
            this.gbThongTinDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinh)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).BeginInit();
            this.tcTraCuuDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.txtTuKhoa);
            this.gbTimKiem.Location = new System.Drawing.Point(12, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(400, 55);
            this.gbTimKiem.TabIndex = 4;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(294, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(7, 23);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(281, 23);
            this.txtTuKhoa.TabIndex = 0;
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            // 
            // gbThongTinDichVu
            // 
            this.gbThongTinDichVu.Controls.Add(this.btnChon);
            this.gbThongTinDichVu.Controls.Add(this.lbGhiChu);
            this.gbThongTinDichVu.Controls.Add(this.lbDonGia);
            this.gbThongTinDichVu.Controls.Add(this.lbTenDichVu);
            this.gbThongTinDichVu.Controls.Add(this.ptrHinh);
            this.gbThongTinDichVu.Location = new System.Drawing.Point(12, 73);
            this.gbThongTinDichVu.Name = "gbThongTinDichVu";
            this.gbThongTinDichVu.Size = new System.Drawing.Size(400, 149);
            this.gbThongTinDichVu.TabIndex = 5;
            this.gbThongTinDichVu.TabStop = false;
            this.gbThongTinDichVu.Text = "Thông tin dịch vụ";
            // 
            // btnChon
            // 
            this.btnChon.ForeColor = System.Drawing.Color.Red;
            this.btnChon.Location = new System.Drawing.Point(135, 109);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 30);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbGhiChu.Location = new System.Drawing.Point(132, 62);
            this.lbGhiChu.MinimumSize = new System.Drawing.Size(250, 77);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(250, 77);
            this.lbGhiChu.TabIndex = 1;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.ForeColor = System.Drawing.Color.Red;
            this.lbDonGia.Location = new System.Drawing.Point(132, 45);
            this.lbDonGia.MinimumSize = new System.Drawing.Size(250, 0);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(250, 17);
            this.lbDonGia.TabIndex = 1;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // lbTenDichVu
            // 
            this.lbTenDichVu.AutoSize = true;
            this.lbTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDichVu.Location = new System.Drawing.Point(131, 23);
            this.lbTenDichVu.MinimumSize = new System.Drawing.Size(250, 0);
            this.lbTenDichVu.Name = "lbTenDichVu";
            this.lbTenDichVu.Size = new System.Drawing.Size(250, 22);
            this.lbTenDichVu.TabIndex = 1;
            this.lbTenDichVu.Text = "Tên dịch vụ";
            // 
            // ptrHinh
            // 
            this.ptrHinh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptrHinh.Location = new System.Drawing.Point(6, 22);
            this.ptrHinh.Name = "ptrHinh";
            this.ptrHinh.Size = new System.Drawing.Size(120, 120);
            this.ptrHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHinh.TabIndex = 0;
            this.ptrHinh.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvKetQuaTimKiem);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kết quả tìm kiếm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AllowUserToAddRows = false;
            this.dgvKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dgvKetQuaTimKiem.AllowUserToResizeRows = false;
            this.dgvKetQuaTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimKiem.EnableHeadersVisualStyles = false;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(0, 0);
            this.dgvKetQuaTimKiem.MultiSelect = false;
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.ReadOnly = true;
            this.dgvKetQuaTimKiem.RowHeadersVisible = false;
            this.dgvKetQuaTimKiem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvKetQuaTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(392, 252);
            this.dgvKetQuaTimKiem.TabIndex = 0;
            this.dgvKetQuaTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTimKiem_CellClick);
            this.dgvKetQuaTimKiem.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvKetQuaTimKiem_DataBindingComplete);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDanhSachDichVu);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachDichVu
            // 
            this.dgvDanhSachDichVu.AllowUserToAddRows = false;
            this.dgvDanhSachDichVu.AllowUserToDeleteRows = false;
            this.dgvDanhSachDichVu.AllowUserToResizeRows = false;
            this.dgvDanhSachDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDichVu.EnableHeadersVisualStyles = false;
            this.dgvDanhSachDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachDichVu.MultiSelect = false;
            this.dgvDanhSachDichVu.Name = "dgvDanhSachDichVu";
            this.dgvDanhSachDichVu.ReadOnly = true;
            this.dgvDanhSachDichVu.RowHeadersVisible = false;
            this.dgvDanhSachDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvDanhSachDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDichVu.Size = new System.Drawing.Size(392, 252);
            this.dgvDanhSachDichVu.TabIndex = 0;
            this.dgvDanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDichVu_CellClick);
            this.dgvDanhSachDichVu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDanhSachDichVu_DataBindingComplete);
            // 
            // tcTraCuuDichVu
            // 
            this.tcTraCuuDichVu.Controls.Add(this.tabPage1);
            this.tcTraCuuDichVu.Controls.Add(this.tabPage2);
            this.tcTraCuuDichVu.Location = new System.Drawing.Point(12, 228);
            this.tcTraCuuDichVu.Name = "tcTraCuuDichVu";
            this.tcTraCuuDichVu.SelectedIndex = 0;
            this.tcTraCuuDichVu.Size = new System.Drawing.Size(400, 281);
            this.tcTraCuuDichVu.TabIndex = 3;
            // 
            // frmTraCuuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 521);
            this.Controls.Add(this.tcTraCuuDichVu);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThongTinDichVu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTraCuuDichVu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU DỊCH VỤ";
            this.Load += new System.EventHandler(this.frmTraCuuDichVu_Load);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbThongTinDichVu.ResumeLayout(false);
            this.gbThongTinDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).EndInit();
            this.tcTraCuuDichVu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.GroupBox gbThongTinDichVu;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenDichVu;
        private System.Windows.Forms.PictureBox ptrHinh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDanhSachDichVu;
        private System.Windows.Forms.TabControl tcTraCuuDichVu;
    }
}