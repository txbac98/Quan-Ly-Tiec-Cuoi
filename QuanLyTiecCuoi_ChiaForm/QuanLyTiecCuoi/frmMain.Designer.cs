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
            this.lbDanhSachTiecTrongNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbKetQua.Location = new System.Drawing.Point(429, 432);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(161, 16);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "Thực hiện thành công !!";
            // 
            // btSanh
            // 
            this.btSanh.Location = new System.Drawing.Point(12, 64);
            this.btSanh.Name = "btSanh";
            this.btSanh.Size = new System.Drawing.Size(75, 23);
            this.btSanh.TabIndex = 11;
            this.btSanh.Text = "Sảnh";
            this.btSanh.UseVisualStyleBackColor = true;
            // 
            // btCa
            // 
            this.btCa.Location = new System.Drawing.Point(12, 173);
            this.btCa.Name = "btCa";
            this.btCa.Size = new System.Drawing.Size(75, 23);
            this.btCa.TabIndex = 12;
            this.btCa.Text = "Ca";
            this.btCa.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(12, 262);
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
            this.dataGridView1.Location = new System.Drawing.Point(178, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 276);
            this.dataGridView1.TabIndex = 14;
            // 
            // lbDanhSachTiecTrongNgay
            // 
            this.lbDanhSachTiecTrongNgay.AutoSize = true;
            this.lbDanhSachTiecTrongNgay.Location = new System.Drawing.Point(178, 118);
            this.lbDanhSachTiecTrongNgay.Name = "lbDanhSachTiecTrongNgay";
            this.lbDanhSachTiecTrongNgay.Size = new System.Drawing.Size(132, 13);
            this.lbDanhSachTiecTrongNgay.TabIndex = 15;
            this.lbDanhSachTiecTrongNgay.Text = "Danh sách tiệc trong ngày";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(671, 453);
            this.Controls.Add(this.lbDanhSachTiecTrongNgay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btCa);
            this.Controls.Add(this.btSanh);
            this.Controls.Add(this.lbKetQua);
            this.Name = "frmMain";
            this.Text = "Quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lbDanhSachTiecTrongNgay;
    }
}

