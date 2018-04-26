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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTiec
            // 
            this.btnTiec.Location = new System.Drawing.Point(294, 24);
            this.btnTiec.Name = "btnTiec";
            this.btnTiec.Size = new System.Drawing.Size(96, 53);
            this.btnTiec.TabIndex = 0;
            this.btnTiec.Text = "Tiệc";
            this.btnTiec.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(538, 24);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(96, 53);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(420, 24);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(96, 53);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(660, 24);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(96, 53);
            this.btnDichVu.TabIndex = 3;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTiec);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnDichVu);
            this.Name = "FormMain";
            this.Text = "Quản lý tiệc cưới";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTiec;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

