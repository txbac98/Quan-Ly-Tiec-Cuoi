namespace QuanLyTiecCuoi.Tiec
{
    partial class TimTiec
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
            this.lbMaTiec = new System.Windows.Forms.Label();
            this.lbTenNguoiDat = new System.Windows.Forms.Label();
            this.lbNgayDat = new System.Windows.Forms.Label();
            this.lbSanh = new System.Windows.Forms.Label();
            this.tbxMaTiec = new System.Windows.Forms.TextBox();
            this.tbxTenNguoiDat = new System.Windows.Forms.TextBox();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbSanh = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaTiec
            // 
            this.lbMaTiec.AutoSize = true;
            this.lbMaTiec.Location = new System.Drawing.Point(27, 31);
            this.lbMaTiec.Name = "lbMaTiec";
            this.lbMaTiec.Size = new System.Drawing.Size(41, 14);
            this.lbMaTiec.TabIndex = 0;
            this.lbMaTiec.Text = "Mã tiệc";
            // 
            // lbTenNguoiDat
            // 
            this.lbTenNguoiDat.AutoSize = true;
            this.lbTenNguoiDat.Location = new System.Drawing.Point(27, 66);
            this.lbTenNguoiDat.Name = "lbTenNguoiDat";
            this.lbTenNguoiDat.Size = new System.Drawing.Size(74, 14);
            this.lbTenNguoiDat.TabIndex = 1;
            this.lbTenNguoiDat.Text = "Tên người đặt";
            // 
            // lbNgayDat
            // 
            this.lbNgayDat.AutoSize = true;
            this.lbNgayDat.Location = new System.Drawing.Point(27, 105);
            this.lbNgayDat.Name = "lbNgayDat";
            this.lbNgayDat.Size = new System.Drawing.Size(50, 14);
            this.lbNgayDat.TabIndex = 2;
            this.lbNgayDat.Text = "Ngày đặt";
            // 
            // lbSanh
            // 
            this.lbSanh.AutoSize = true;
            this.lbSanh.Location = new System.Drawing.Point(27, 142);
            this.lbSanh.Name = "lbSanh";
            this.lbSanh.Size = new System.Drawing.Size(32, 14);
            this.lbSanh.TabIndex = 3;
            this.lbSanh.Text = "Sảnh";
            // 
            // tbxMaTiec
            // 
            this.tbxMaTiec.Location = new System.Drawing.Point(133, 31);
            this.tbxMaTiec.Name = "tbxMaTiec";
            this.tbxMaTiec.Size = new System.Drawing.Size(121, 20);
            this.tbxMaTiec.TabIndex = 4;
            // 
            // tbxTenNguoiDat
            // 
            this.tbxTenNguoiDat.Location = new System.Drawing.Point(133, 63);
            this.tbxTenNguoiDat.Name = "tbxTenNguoiDat";
            this.tbxTenNguoiDat.Size = new System.Drawing.Size(121, 20);
            this.tbxTenNguoiDat.TabIndex = 5;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(133, 100);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayDat.TabIndex = 6;
            // 
            // cbSanh
            // 
            this.cbSanh.FormattingEnabled = true;
            this.cbSanh.Location = new System.Drawing.Point(133, 139);
            this.cbSanh.Name = "cbSanh";
            this.cbSanh.Size = new System.Drawing.Size(121, 22);
            this.cbSanh.TabIndex = 7;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(179, 196);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 8;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // TimTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.cbSanh);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.tbxTenNguoiDat);
            this.Controls.Add(this.tbxMaTiec);
            this.Controls.Add(this.lbSanh);
            this.Controls.Add(this.lbNgayDat);
            this.Controls.Add(this.lbTenNguoiDat);
            this.Controls.Add(this.lbMaTiec);
            this.Name = "TimTiec";
            this.Text = "Tìm tiệc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaTiec;
        private System.Windows.Forms.Label lbTenNguoiDat;
        private System.Windows.Forms.Label lbNgayDat;
        private System.Windows.Forms.Label lbSanh;
        private System.Windows.Forms.TextBox tbxMaTiec;
        private System.Windows.Forms.TextBox tbxTenNguoiDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.ComboBox cbSanh;
        private System.Windows.Forms.Button btTim;
    }
}