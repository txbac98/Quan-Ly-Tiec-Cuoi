namespace QuanLyTiecCuoiUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btSanh = new System.Windows.Forms.Button();
            this.btCa = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbQuanLy = new System.Windows.Forms.GroupBox();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnMonAn = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnDatTiec = new System.Windows.Forms.Button();
            this.btnTiec = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbQuanLy.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbKetQua.Location = new System.Drawing.Point(466, 377);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(161, 16);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "Thực hiện thành công !!";
            // 
            // btSanh
            // 
            this.btSanh.Location = new System.Drawing.Point(20, 145);
            this.btSanh.Name = "btSanh";
            this.btSanh.Size = new System.Drawing.Size(75, 23);
            this.btSanh.TabIndex = 11;
            this.btSanh.Text = "Sảnh";
            this.btSanh.UseVisualStyleBackColor = true;
            this.btSanh.Click += new System.EventHandler(this.btSanh_Click);
            // 
            // btCa
            // 
            this.btCa.Location = new System.Drawing.Point(20, 116);
            this.btCa.Name = "btCa";
            this.btCa.Size = new System.Drawing.Size(75, 23);
            this.btCa.TabIndex = 12;
            this.btCa.Text = "Ca";
            this.btCa.UseVisualStyleBackColor = true;
            this.btCa.Click += new System.EventHandler(this.btCa_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(16, 110);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnKhachHang.TabIndex = 13;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 297);
            this.dataGridView1.TabIndex = 14;
            // 
            // grbQuanLy
            // 
            this.grbQuanLy.Controls.Add(this.btnChucVu);
            this.grbQuanLy.Controls.Add(this.btnDichVu);
            this.grbQuanLy.Controls.Add(this.btnMonAn);
            this.grbQuanLy.Controls.Add(this.btnNhanVien);
            this.grbQuanLy.Controls.Add(this.btSanh);
            this.grbQuanLy.Controls.Add(this.btCa);
            this.grbQuanLy.Location = new System.Drawing.Point(623, 46);
            this.grbQuanLy.Name = "grbQuanLy";
            this.grbQuanLy.Size = new System.Drawing.Size(134, 297);
            this.grbQuanLy.TabIndex = 15;
            this.grbQuanLy.TabStop = false;
            this.grbQuanLy.Text = "Quản lý";
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(20, 252);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(75, 23);
            this.btnDichVu.TabIndex = 18;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.Location = new System.Drawing.Point(20, 213);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnMonAn.TabIndex = 17;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.UseVisualStyleBackColor = true;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(20, 87);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnNhanVien.TabIndex = 15;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnDatTiec);
            this.grbChucNang.Controls.Add(this.btnTiec);
            this.grbChucNang.Controls.Add(this.btnKhachHang);
            this.grbChucNang.Location = new System.Drawing.Point(12, 46);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(134, 297);
            this.grbChucNang.TabIndex = 16;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnDatTiec
            // 
            this.btnDatTiec.Location = new System.Drawing.Point(16, 157);
            this.btnDatTiec.Name = "btnDatTiec";
            this.btnDatTiec.Size = new System.Drawing.Size(75, 23);
            this.btnDatTiec.TabIndex = 15;
            this.btnDatTiec.Text = "Đặt tiệc";
            this.btnDatTiec.UseVisualStyleBackColor = true;
            this.btnDatTiec.Click += new System.EventHandler(this.btnDatTiec_Click);
            // 
            // btnTiec
            // 
            this.btnTiec.Location = new System.Drawing.Point(16, 45);
            this.btnTiec.Name = "btnTiec";
            this.btnTiec.Size = new System.Drawing.Size(75, 23);
            this.btnTiec.TabIndex = 14;
            this.btnTiec.Text = "Tiệc";
            this.btnTiec.UseVisualStyleBackColor = true;
            // 
            // btnChucVu
            // 
            this.btnChucVu.Location = new System.Drawing.Point(20, 58);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(75, 23);
            this.btnChucVu.TabIndex = 19;
            this.btnChucVu.Text = "Chức vụ";
            this.btnChucVu.UseVisualStyleBackColor = true;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(772, 413);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbQuanLy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbKetQua);
            this.Name = "frmMain";
            this.Text = "Quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbQuanLy.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btSanh;
        private System.Windows.Forms.Button btCa;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbQuanLy;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnTiec;
        private System.Windows.Forms.Button btnDatTiec;
        private System.Windows.Forms.Button btnMonAn;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnChucVu;
    }
}

