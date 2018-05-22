namespace QuanLyTiecCuoiUI
{
    partial class frmCa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTableShow = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.llbThemMoi = new System.Windows.Forms.LinkLabel();
            this.lbKetQua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 4;
            // 
            // txtTenCa
            // 
            this.txtTenCa.Location = new System.Drawing.Point(67, 48);
            this.txtTenCa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(231, 20);
            this.txtTenCa.TabIndex = 5;
            this.txtTenCa.TextChanged += new System.EventHandler(this.txtTenCa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên ca";
            // 
            // dgvTableShow
            // 
            this.dgvTableShow.AllowUserToAddRows = false;
            this.dgvTableShow.AllowUserToDeleteRows = false;
            this.dgvTableShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableShow.Location = new System.Drawing.Point(3, 16);
            this.dgvTableShow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTableShow.Name = "dgvTableShow";
            this.dgvTableShow.ReadOnly = true;
            this.dgvTableShow.RowHeadersVisible = false;
            this.dgvTableShow.Size = new System.Drawing.Size(299, 132);
            this.dgvTableShow.TabIndex = 8;
            this.dgvTableShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableShow_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 244);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(7, 109);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(7, 68);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenCa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 87);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ca";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(67, 18);
            this.txtMaCa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(231, 20);
            this.txtMaCa.TabIndex = 8;
            this.txtMaCa.TextChanged += new System.EventHandler(this.txtMaCa_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTableShow);
            this.groupBox3.Location = new System.Drawing.Point(12, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 151);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ca";
         
            // 
            // llbThemMoi
            // 
            this.llbThemMoi.AutoSize = true;
            this.llbThemMoi.Location = new System.Drawing.Point(257, 259);
            this.llbThemMoi.Name = "llbThemMoi";
            this.llbThemMoi.Size = new System.Drawing.Size(53, 14);
            this.llbThemMoi.TabIndex = 11;
            this.llbThemMoi.TabStop = true;
            this.llbThemMoi.Text = "Thêm mới";
            this.llbThemMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemMoi_LinkClicked);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(13, 268);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(74, 14);
            this.lbKetQua.TabIndex = 17;
            this.lbKetQua.Text = "Show ket qua";
            this.lbKetQua.Click += new System.EventHandler(this.lbKetQua_Click);
            // 
            // frmCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 309);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.llbThemMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmCa";
            this.Text = "Quản lí ca";
            this.Load += new System.EventHandler(this.frmCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTableShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel llbThemMoi;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtMaCa;
    }
}