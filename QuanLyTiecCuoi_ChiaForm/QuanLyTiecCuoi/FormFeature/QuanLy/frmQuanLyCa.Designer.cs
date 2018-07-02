namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    partial class frmQuanLyCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyCa));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachCa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbPhutKT = new System.Windows.Forms.ComboBox();
            this.cbbGioKT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.llbThemMoi = new System.Windows.Forms.LinkLabel();
            this.cbbPhutBD = new System.Windows.Forms.ComboBox();
            this.cbbGioBD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSachCa);
            this.groupBox3.Location = new System.Drawing.Point(12, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 151);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ca";
            // 
            // dgvDanhSachCa
            // 
            this.dgvDanhSachCa.AllowUserToAddRows = false;
            this.dgvDanhSachCa.AllowUserToDeleteRows = false;
            this.dgvDanhSachCa.AllowUserToResizeRows = false;
            this.dgvDanhSachCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachCa.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachCa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachCa.Name = "dgvDanhSachCa";
            this.dgvDanhSachCa.ReadOnly = true;
            this.dgvDanhSachCa.RowHeadersVisible = false;
            this.dgvDanhSachCa.Size = new System.Drawing.Size(331, 132);
            this.dgvDanhSachCa.TabIndex = 8;
            this.dgvDanhSachCa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableShow_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(235, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 131);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Actions_insert_horizontal_rule_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 13);
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
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Alarm_Error_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(7, 91);
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
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::QuanLyTiecCuoiUI.Properties.Resources.edit_validated_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(7, 51);
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
            this.groupBox1.Controls.Add(this.cbbPhutKT);
            this.groupBox1.Controls.Add(this.cbbGioKT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaCa);
            this.groupBox1.Controls.Add(this.llbThemMoi);
            this.groupBox1.Controls.Add(this.cbbPhutBD);
            this.groupBox1.Controls.Add(this.cbbGioBD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblThoiGian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ca";
            // 
            // cbbPhutKT
            // 
            this.cbbPhutKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhutKT.FormattingEnabled = true;
            this.cbbPhutKT.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbbPhutKT.Location = new System.Drawing.Point(156, 102);
            this.cbbPhutKT.Name = "cbbPhutKT";
            this.cbbPhutKT.Size = new System.Drawing.Size(49, 21);
            this.cbbPhutKT.TabIndex = 20;
            // 
            // cbbGioKT
            // 
            this.cbbGioKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioKT.FormattingEnabled = true;
            this.cbbGioKT.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbbGioKT.Location = new System.Drawing.Point(82, 102);
            this.cbbGioKT.Name = "cbbGioKT";
            this.cbbGioKT.Size = new System.Drawing.Size(49, 21);
            this.cbbGioKT.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thời gian KT";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(82, 37);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(122, 20);
            this.txtMaCa.TabIndex = 16;
            this.txtMaCa.TextChanged += new System.EventHandler(this.txtMaCa_TextChanged);
            // 
            // llbThemMoi
            // 
            this.llbThemMoi.AutoSize = true;
            this.llbThemMoi.Location = new System.Drawing.Point(139, 15);
            this.llbThemMoi.Name = "llbThemMoi";
            this.llbThemMoi.Size = new System.Drawing.Size(53, 13);
            this.llbThemMoi.TabIndex = 15;
            this.llbThemMoi.TabStop = true;
            this.llbThemMoi.Text = "Thêm mới";
            this.llbThemMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemMoi_LinkClicked);
            // 
            // cbbPhutBD
            // 
            this.cbbPhutBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhutBD.FormattingEnabled = true;
            this.cbbPhutBD.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbbPhutBD.Location = new System.Drawing.Point(156, 67);
            this.cbbPhutBD.Name = "cbbPhutBD";
            this.cbbPhutBD.Size = new System.Drawing.Size(49, 21);
            this.cbbPhutBD.TabIndex = 14;
            // 
            // cbbGioBD
            // 
            this.cbbGioBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioBD.FormattingEnabled = true;
            this.cbbGioBD.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbbGioBD.Location = new System.Drawing.Point(82, 67);
            this.cbbGioBD.Name = "cbbGioBD";
            this.cbbGioBD.Size = new System.Drawing.Size(49, 21);
            this.cbbGioBD.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(7, 70);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(69, 13);
            this.lblThoiGian.TabIndex = 9;
            this.lblThoiGian.Text = "Thời gian BD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(24, 309);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 17;
            this.lblKetQua.Text = "Kết quả";
            // 
            // frmQuanLyCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 331);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyCa";
            this.Text = "Quản lý ca";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhSachCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.LinkLabel llbThemMoi;
        private System.Windows.Forms.ComboBox cbbPhutBD;
        private System.Windows.Forms.ComboBox cbbGioBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.ComboBox cbbPhutKT;
        private System.Windows.Forms.ComboBox cbbGioKT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}