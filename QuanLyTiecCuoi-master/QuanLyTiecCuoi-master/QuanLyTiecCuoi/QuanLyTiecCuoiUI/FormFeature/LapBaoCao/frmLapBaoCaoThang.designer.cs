namespace QuanLyTiecCuoiUI
{
    partial class frmLapBaoCaoThang
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
            this.lblThang = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.dgvBaoCaoChiTiet = new System.Windows.Forms.DataGridView();
            this.grpBaoCaoChiTiet = new System.Windows.Forms.GroupBox();
            this.lblTongSoTiecCuoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoChiTiet)).BeginInit();
            this.grpBaoCaoChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(236, 20);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(49, 17);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(284, 17);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(66, 24);
            this.cbbThang.TabIndex = 0;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(391, 17);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(66, 24);
            this.cbbNam.TabIndex = 1;
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(350, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(41, 17);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = " Năm";
            // 
            // dgvBaoCaoChiTiet
            // 
            this.dgvBaoCaoChiTiet.AllowUserToAddRows = false;
            this.dgvBaoCaoChiTiet.AllowUserToDeleteRows = false;
            this.dgvBaoCaoChiTiet.AllowUserToResizeRows = false;
            this.dgvBaoCaoChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoChiTiet.EnableHeadersVisualStyles = false;
            this.dgvBaoCaoChiTiet.Location = new System.Drawing.Point(6, 22);
            this.dgvBaoCaoChiTiet.Name = "dgvBaoCaoChiTiet";
            this.dgvBaoCaoChiTiet.ReadOnly = true;
            this.dgvBaoCaoChiTiet.RowHeadersVisible = false;
            this.dgvBaoCaoChiTiet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvBaoCaoChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCaoChiTiet.Size = new System.Drawing.Size(648, 217);
            this.dgvBaoCaoChiTiet.TabIndex = 2;
            // 
            // grpBaoCaoChiTiet
            // 
            this.grpBaoCaoChiTiet.Controls.Add(this.lblTongSoTiecCuoi);
            this.grpBaoCaoChiTiet.Controls.Add(this.label2);
            this.grpBaoCaoChiTiet.Controls.Add(this.lblTongDoanhThu);
            this.grpBaoCaoChiTiet.Controls.Add(this.lbl1);
            this.grpBaoCaoChiTiet.Controls.Add(this.dgvBaoCaoChiTiet);
            this.grpBaoCaoChiTiet.Location = new System.Drawing.Point(12, 91);
            this.grpBaoCaoChiTiet.Name = "grpBaoCaoChiTiet";
            this.grpBaoCaoChiTiet.Size = new System.Drawing.Size(660, 308);
            this.grpBaoCaoChiTiet.TabIndex = 6;
            this.grpBaoCaoChiTiet.TabStop = false;
            this.grpBaoCaoChiTiet.Text = "Báo cáo doanh thu trong tháng";
            // 
            // lblTongSoTiecCuoi
            // 
            this.lblTongSoTiecCuoi.AutoSize = true;
            this.lblTongSoTiecCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoTiecCuoi.Location = new System.Drawing.Point(151, 273);
            this.lblTongSoTiecCuoi.Name = "lblTongSoTiecCuoi";
            this.lblTongSoTiecCuoi.Size = new System.Drawing.Size(14, 17);
            this.lblTongSoTiecCuoi.TabIndex = 11;
            this.lblTongSoTiecCuoi.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng số tiệc cưới:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(473, 273);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(14, 17);
            this.lblTongDoanhThu.TabIndex = 9;
            this.lblTongDoanhThu.Text = "-";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(354, 273);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 17);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Tổng doanh thu:";
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(302, 55);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(100, 30);
            this.btnLapBaoCao.TabIndex = 8;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // frmLapBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.grpBaoCaoChiTiet);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.lblThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmLapBaoCaoThang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP BÁO CÁO THÁNG";
            this.Load += new System.EventHandler(this.frmLapBaoCaoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoChiTiet)).EndInit();
            this.grpBaoCaoChiTiet.ResumeLayout(false);
            this.grpBaoCaoChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.DataGridView dgvBaoCaoChiTiet;
        private System.Windows.Forms.GroupBox grpBaoCaoChiTiet;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTongSoTiecCuoi;
        private System.Windows.Forms.Label label2;
    }
}