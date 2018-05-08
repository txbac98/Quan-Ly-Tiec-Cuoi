namespace QuanLyTiecCuoi
{
    partial class FormMain
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
            this.btnTiec = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.grbTiec = new System.Windows.Forms.GroupBox();
            this.btDatTiec = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grbTiec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTiec
            // 
            this.btnTiec.Location = new System.Drawing.Point(23, 194);
            this.btnTiec.Name = "btnTiec";
            this.btnTiec.Size = new System.Drawing.Size(96, 57);
            this.btnTiec.TabIndex = 0;
            this.btnTiec.Text = "Tiệc";
            this.btnTiec.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(23, 364);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(96, 57);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(23, 281);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(96, 57);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(23, 452);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(96, 57);
            this.btnDichVu.TabIndex = 3;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(138, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(644, 440);
            this.dataGridView.TabIndex = 6;
            // 
            // grbTiec
            // 
            this.grbTiec.Controls.Add(this.btTimKiem);
            this.grbTiec.Controls.Add(this.btDatTiec);
            this.grbTiec.Location = new System.Drawing.Point(138, 12);
            this.grbTiec.Name = "grbTiec";
            this.grbTiec.Size = new System.Drawing.Size(264, 78);
            this.grbTiec.TabIndex = 7;
            this.grbTiec.TabStop = false;
            this.grbTiec.Text = "Tiệc";
            // 
            // btDatTiec
            // 
            this.btDatTiec.Location = new System.Drawing.Point(36, 29);
            this.btDatTiec.Name = "btDatTiec";
            this.btDatTiec.Size = new System.Drawing.Size(75, 23);
            this.btDatTiec.TabIndex = 0;
            this.btDatTiec.Text = "Đặt tiệc";
            this.btDatTiec.UseVisualStyleBackColor = true;
            this.btDatTiec.Click += new System.EventHandler(this.btDatTiec_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(136, 29);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 538);
            this.Controls.Add(this.grbTiec);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnTiec);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnDichVu);
            this.Name = "FormMain";
            this.Text = "Quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grbTiec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTiec;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grbTiec;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btDatTiec;
    }
}

