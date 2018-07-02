namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyTiecCuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTiecCuoi));
            this.pnlQuanLy = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnTiecCuoi = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mstChucNang = new System.Windows.Forms.MenuStrip();
            this.mItemRong = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemQuanLyCa = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemQuanLySanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemQuanLyChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemDichVuKhac = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.llbDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlQuanLy.SuspendLayout();
            this.mstChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuanLy
            // 
            this.pnlQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlQuanLy.Controls.Add(this.btnNhanVien);
            this.pnlQuanLy.Controls.Add(this.btnKhachHang);
            this.pnlQuanLy.Controls.Add(this.btnTiecCuoi);
            this.pnlQuanLy.Controls.Add(this.btnHome);
            this.pnlQuanLy.Controls.Add(this.panel2);
            this.pnlQuanLy.Location = new System.Drawing.Point(-1, 0);
            this.pnlQuanLy.Name = "pnlQuanLy";
            this.pnlQuanLy.Size = new System.Drawing.Size(80, 549);
            this.pnlQuanLy.TabIndex = 1;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Teal;
            this.btnNhanVien.BackgroundImage = global::QuanLyTiecCuoiUI.Properties.Resources.Users;
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Location = new System.Drawing.Point(13, 284);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(53, 37);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Teal;
            this.btnKhachHang.BackgroundImage = global::QuanLyTiecCuoiUI.Properties.Resources.user_group_new;
            this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Location = new System.Drawing.Point(13, 216);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(53, 37);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnTiecCuoi
            // 
            this.btnTiecCuoi.BackColor = System.Drawing.Color.Teal;
            this.btnTiecCuoi.BackgroundImage = global::QuanLyTiecCuoiUI.Properties.Resources.CapNhan;
            this.btnTiecCuoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTiecCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiecCuoi.Location = new System.Drawing.Point(13, 145);
            this.btnTiecCuoi.Name = "btnTiecCuoi";
            this.btnTiecCuoi.Size = new System.Drawing.Size(53, 37);
            this.btnTiecCuoi.TabIndex = 1;
            this.btnTiecCuoi.UseVisualStyleBackColor = false;
            this.btnTiecCuoi.Click += new System.EventHandler(this.btnTiecCuoi_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.BackgroundImage = global::QuanLyTiecCuoiUI.Properties.Resources.Home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(13, 74);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 55);
            this.panel2.TabIndex = 0;
            // 
            // mstChucNang
            // 
            this.mstChucNang.AutoSize = false;
            this.mstChucNang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mstChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemRong,
            this.mItemQuanLy,
            this.mItemDichVu,
            this.mItemHelp});
            this.mstChucNang.Location = new System.Drawing.Point(0, 0);
            this.mstChucNang.Name = "mstChucNang";
            this.mstChucNang.Size = new System.Drawing.Size(1014, 25);
            this.mstChucNang.TabIndex = 2;
            this.mstChucNang.Text = "menuChucNang";
            // 
            // mItemRong
            // 
            this.mItemRong.Name = "mItemRong";
            this.mItemRong.Size = new System.Drawing.Size(79, 21);
            this.mItemRong.Text = "                    ";
            // 
            // mItemQuanLy
            // 
            this.mItemQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemQuanLyCa,
            this.mItemQuanLySanh,
            this.mItemQuanLyChucVu,
            this.mItemQuanLyTaiKhoan});
            this.mItemQuanLy.Name = "mItemQuanLy";
            this.mItemQuanLy.Size = new System.Drawing.Size(60, 21);
            this.mItemQuanLy.Text = "Quản lý";
            // 
            // mItemQuanLyCa
            // 
            this.mItemQuanLyCa.Name = "mItemQuanLyCa";
            this.mItemQuanLyCa.Size = new System.Drawing.Size(167, 22);
            this.mItemQuanLyCa.Text = "Quản lý ca";
            this.mItemQuanLyCa.Click += new System.EventHandler(this.mItemQuanLyCa_Click);
            // 
            // mItemQuanLySanh
            // 
            this.mItemQuanLySanh.Name = "mItemQuanLySanh";
            this.mItemQuanLySanh.Size = new System.Drawing.Size(167, 22);
            this.mItemQuanLySanh.Text = "Quản lý sảnh";
            this.mItemQuanLySanh.Click += new System.EventHandler(this.mItemQuanLySanh_Click);
            // 
            // mItemQuanLyChucVu
            // 
            this.mItemQuanLyChucVu.Name = "mItemQuanLyChucVu";
            this.mItemQuanLyChucVu.Size = new System.Drawing.Size(167, 22);
            this.mItemQuanLyChucVu.Text = "Quản lý chức vụ";
            this.mItemQuanLyChucVu.Click += new System.EventHandler(this.mItemQuanLyChucVu_Click);
            // 
            // mItemQuanLyTaiKhoan
            // 
            this.mItemQuanLyTaiKhoan.Name = "mItemQuanLyTaiKhoan";
            this.mItemQuanLyTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.mItemQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.mItemQuanLyTaiKhoan.Click += new System.EventHandler(this.mItemQuanLyTaiKhoan_Click);
            // 
            // mItemDichVu
            // 
            this.mItemDichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemMonAn,
            this.mItemDichVuKhac});
            this.mItemDichVu.Name = "mItemDichVu";
            this.mItemDichVu.Size = new System.Drawing.Size(59, 21);
            this.mItemDichVu.Text = "Dịch vụ";
            // 
            // mItemMonAn
            // 
            this.mItemMonAn.Name = "mItemMonAn";
            this.mItemMonAn.Size = new System.Drawing.Size(115, 22);
            this.mItemMonAn.Text = "Món ăn";
            this.mItemMonAn.Click += new System.EventHandler(this.mItemMonAn_Click);
            // 
            // mItemDichVuKhac
            // 
            this.mItemDichVuKhac.Name = "mItemDichVuKhac";
            this.mItemDichVuKhac.Size = new System.Drawing.Size(115, 22);
            this.mItemDichVuKhac.Text = "Dịch vụ";
            this.mItemDichVuKhac.Click += new System.EventHandler(this.mItemDichVuKhac_Click);
            // 
            // mItemHelp
            // 
            this.mItemHelp.Name = "mItemHelp";
            this.mItemHelp.Size = new System.Drawing.Size(44, 21);
            this.mItemHelp.Text = "Help";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.lblTenNhanVien.Location = new System.Drawing.Point(782, 9);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(82, 13);
            this.lblTenNhanVien.TabIndex = 4;
            this.lblTenNhanVien.Text = "Trần Xuân Bắc,";
            // 
            // llbDoiMatKhau
            // 
            this.llbDoiMatKhau.AutoSize = true;
            this.llbDoiMatKhau.Location = new System.Drawing.Point(923, 9);
            this.llbDoiMatKhau.Name = "llbDoiMatKhau";
            this.llbDoiMatKhau.Size = new System.Drawing.Size(70, 13);
            this.llbDoiMatKhau.TabIndex = 5;
            this.llbDoiMatKhau.TabStop = true;
            this.llbDoiMatKhau.Text = "Đổi mật khẩu";
            this.llbDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDoiMatKhau_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 20);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(995, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 523);
            this.panel3.TabIndex = 8;
            // 
            // frmQuanLyTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llbDoiMatKhau);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.pnlQuanLy);
            this.Controls.Add(this.mstChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstChucNang;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyTiecCuoi";
            this.Text = "Quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.frmQuanLyTiecCuoi_Load);
            this.pnlQuanLy.ResumeLayout(false);
            this.mstChucNang.ResumeLayout(false);
            this.mstChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLy;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mstChucNang;
        private System.Windows.Forms.ToolStripMenuItem mItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mItemQuanLyCa;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnTiecCuoi;
        private System.Windows.Forms.ToolStripMenuItem mItemQuanLySanh;
        private System.Windows.Forms.ToolStripMenuItem mItemDichVu;
        private System.Windows.Forms.ToolStripMenuItem mItemMonAn;
        private System.Windows.Forms.ToolStripMenuItem mItemDichVuKhac;
        private System.Windows.Forms.ToolStripMenuItem mItemHelp;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.LinkLabel llbDoiMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem mItemRong;
        private System.Windows.Forms.ToolStripMenuItem mItemQuanLyChucVu;
        private System.Windows.Forms.ToolStripMenuItem mItemQuanLyTaiKhoan;
    }
}