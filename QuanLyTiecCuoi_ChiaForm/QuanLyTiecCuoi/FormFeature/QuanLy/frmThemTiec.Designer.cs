namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    partial class frmThemTiec
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
            this.dtpNgayDaiTiec = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDaiTiec = new System.Windows.Forms.Label();
            this.cbbSanh = new System.Windows.Forms.ComboBox();
            this.lblSanh = new System.Windows.Forms.Label();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.lblCa = new System.Windows.Forms.Label();
            this.btnDatTiec = new System.Windows.Forms.Button();
            this.grpThongTinTiec = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grpThongTinTiec.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayDaiTiec
            // 
            this.dtpNgayDaiTiec.Location = new System.Drawing.Point(81, 39);
            this.dtpNgayDaiTiec.Name = "dtpNgayDaiTiec";
            this.dtpNgayDaiTiec.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDaiTiec.TabIndex = 0;
            this.dtpNgayDaiTiec.ValueChanged += new System.EventHandler(this.dtpNgayDaiTiec_ValueChanged);
            // 
            // lblNgayDaiTiec
            // 
            this.lblNgayDaiTiec.AutoSize = true;
            this.lblNgayDaiTiec.Location = new System.Drawing.Point(5, 39);
            this.lblNgayDaiTiec.Name = "lblNgayDaiTiec";
            this.lblNgayDaiTiec.Size = new System.Drawing.Size(70, 13);
            this.lblNgayDaiTiec.TabIndex = 1;
            this.lblNgayDaiTiec.Text = "Ngày đãi tiệc";
            // 
            // cbbSanh
            // 
            this.cbbSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanh.FormattingEnabled = true;
            this.cbbSanh.Location = new System.Drawing.Point(534, 39);
            this.cbbSanh.Name = "cbbSanh";
            this.cbbSanh.Size = new System.Drawing.Size(74, 21);
            this.cbbSanh.TabIndex = 11;
            // 
            // lblSanh
            // 
            this.lblSanh.AutoSize = true;
            this.lblSanh.Location = new System.Drawing.Point(496, 42);
            this.lblSanh.Name = "lblSanh";
            this.lblSanh.Size = new System.Drawing.Size(32, 13);
            this.lblSanh.TabIndex = 10;
            this.lblSanh.Text = "Sảnh";
            // 
            // cbbCa
            // 
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(324, 39);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(166, 21);
            this.cbbCa.TabIndex = 9;
            this.cbbCa.SelectedIndexChanged += new System.EventHandler(this.cbbCa_SelectedIndexChanged);
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(298, 39);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(20, 13);
            this.lblCa.TabIndex = 8;
            this.lblCa.Text = "Ca";
            // 
            // btnDatTiec
            // 
            this.btnDatTiec.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Actions_insert_horizontal_rule_icon;
            this.btnDatTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatTiec.Location = new System.Drawing.Point(420, 99);
            this.btnDatTiec.Name = "btnDatTiec";
            this.btnDatTiec.Size = new System.Drawing.Size(91, 28);
            this.btnDatTiec.TabIndex = 12;
            this.btnDatTiec.Text = "       Đặt tiệc";
            this.btnDatTiec.UseVisualStyleBackColor = true;
            this.btnDatTiec.Click += new System.EventHandler(this.btnDatTiec_Click);
            // 
            // grpThongTinTiec
            // 
            this.grpThongTinTiec.Controls.Add(this.cbbCa);
            this.grpThongTinTiec.Controls.Add(this.dtpNgayDaiTiec);
            this.grpThongTinTiec.Controls.Add(this.cbbSanh);
            this.grpThongTinTiec.Controls.Add(this.lblNgayDaiTiec);
            this.grpThongTinTiec.Controls.Add(this.lblSanh);
            this.grpThongTinTiec.Controls.Add(this.lblCa);
            this.grpThongTinTiec.Location = new System.Drawing.Point(12, 12);
            this.grpThongTinTiec.Name = "grpThongTinTiec";
            this.grpThongTinTiec.Size = new System.Drawing.Size(630, 79);
            this.grpThongTinTiec.TabIndex = 13;
            this.grpThongTinTiec.TabStop = false;
            this.grpThongTinTiec.Text = "Thông tin tiệc";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(537, 99);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 28);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "         Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 137);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grpThongTinTiec);
            this.Controls.Add(this.btnDatTiec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmThemTiec";
            this.Text = "Kiểm tra đặt tiệc";
            this.Load += new System.EventHandler(this.frmThemTiec_Load);
            this.grpThongTinTiec.ResumeLayout(false);
            this.grpThongTinTiec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayDaiTiec;
        private System.Windows.Forms.Label lblNgayDaiTiec;
        private System.Windows.Forms.ComboBox cbbSanh;
        private System.Windows.Forms.Label lblSanh;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Button btnDatTiec;
        private System.Windows.Forms.GroupBox grpThongTinTiec;
        private System.Windows.Forms.Button btnHuy;
    }
}