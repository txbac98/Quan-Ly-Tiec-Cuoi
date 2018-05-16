using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiecCuoiUI.ucControlFeature;
using QuanLyTiecCuoiUI.FormFeature.QuyDinh;
using DTO;
using BUS;

namespace QuanLyTiecCuoiUI
{
    public partial class frmMain : Form
    {
        #region parameters
        private bool MiniumMenu;
        private bool IsChange = false;
        private menuQuanLy quanly = new menuQuanLy();
        private menuTraCuu tracuu = new menuTraCuu();
        private menuBaoCao baocao = new menuBaoCao();
        private menuQuyDinh quydinh = new menuQuyDinh();
        private int MenuClickIndex = -1;
        private List<int> RolesSize;
        private List<int> SpaceSice;
        private bool flag = false;
        public static DTO_NhanVien NhanVienLogin = new DTO_NhanVien();
        private int MaPhanQuyen = -1;
        #endregion

        #region Khởi tạo form
        public frmMain()
        {
            InitializeComponent();

            //Set state and load event
            SetStartStateForm();
            LoadEventSubItem();
            pnlThongTinTaiKhoan.Visible = false;
            pnlThongTinNhanVien.Visible = false;
        }
        public void LoadDefautState()
        {
            IsChange = false;
            btnCapNhatThongTinNguoiDung.Enabled = false;
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            pnlThongTinTaiKhoan.Visible = false;

            pnlThongTinTaiKhoan.Hide();
            MenuClickIndex = -1;
            flag = false;
            btnThongTinNhanVien.BackColor = Color.FromArgb(44, 62, 80);
            btnQuanLy.BackColor = btnTraCuu.BackColor = btnLapBaoCao.BackColor = btnThayDoiQuyDinh.BackColor = Color.FromArgb(44, 62, 80);
        }
        public void SetStartStateForm()
        {
            MiniumMenu = false;
            pnlRight.Size = new Size(235, base.Height);
            tlpMenuItem.RowStyles[0].Height = 10;
            tlpMenuItem.RowStyles[1].Height = 0;
            tlpMenuItem.RowStyles[2].Height = 10;
            tlpMenuItem.RowStyles[3].Height = 0;
            tlpMenuItem.RowStyles[4].Height = 10;
            tlpMenuItem.RowStyles[5].Height = 0;
            tlpMenuItem.RowStyles[6].Height = 10;
            tlpMenuItem.RowStyles[7].Height = 0;
            tlpMenuItem.RowStyles[8].Height = 60;
        }
        private void SetSizeMenuDefault()
        {
            tlpMenuItem.RowStyles[0].Height = 10;
            tlpMenuItem.RowStyles[1].Height = 0;
            tlpMenuItem.RowStyles[2].Height = 10;
            tlpMenuItem.RowStyles[3].Height = 0;
            tlpMenuItem.RowStyles[4].Height = 10;
            tlpMenuItem.RowStyles[5].Height = 0;
            tlpMenuItem.RowStyles[6].Height = 10;
            tlpMenuItem.RowStyles[7].Height = 0;
            tlpMenuItem.RowStyles[8].Height = 60;
        }
        private void SetColorButton()
        {
            btnQuanLy.BackColor = btnTraCuu.BackColor = btnLapBaoCao.BackColor = btnThayDoiQuyDinh.BackColor = Color.FromArgb(44, 62, 80);
        }
        #endregion

        #region phân quyền ứng dụng

        public void SetRolesForUser(DTO_NhanVien nhanvien, int maPhanQuyen)
        {
            NhanVienLogin = nhanvien;
            MaPhanQuyen = maPhanQuyen;
            StartRoles(maPhanQuyen);
            ResetStateForPnlThongTinNhanVien();
            LoadThongTinNhanVienHienTai();
        }
        private void RolesUser(int valueRoles)
        {
            RolesSize = new List<int>();
            SpaceSice = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                RolesSize.Add(0);
                SpaceSice.Add(60);
            }

            if (valueRoles == 1)
            {
                //nhân viên lễ tân
                RolesSize[1] = 14;
                RolesSize[3] = 18;
                RolesSize[5] = 0;
                RolesSize[7] = 0;

                SpaceSice[1] = 50;
                SpaceSice[3] = 42;
                SpaceSice[5] = 60;
                SpaceSice[7] = 60;
            }
            else
                if (valueRoles == 2)
            {
                //thu ngân
                RolesSize[1] = 8;
                RolesSize[3] = 18;
                RolesSize[5] = 8;
                RolesSize[7] = 0;

                SpaceSice[1] = 53;
                SpaceSice[3] = 42;
                SpaceSice[5] = 52;
                SpaceSice[7] = 60;
            }
            else
                if (valueRoles == 3)
            {
                //quản lý csvc
                RolesSize[1] = 35; //35 33
                RolesSize[3] = 18;
                RolesSize[5] = 0;
                RolesSize[7] = 0;

                SpaceSice[1] = 26; //25 27 30
                SpaceSice[3] = 42;
                SpaceSice[5] = 60;
                SpaceSice[7] = 60;
            }
            else
                if (valueRoles == 4)
            {
                //Trưởng bộ phận nhà hàng
                RolesSize[1] = 61;
                RolesSize[3] = 18;
                RolesSize[5] = 8;
                RolesSize[7] = 60;

                SpaceSice[1] = 0;
                SpaceSice[3] = 42;
                SpaceSice[5] = 52;
                SpaceSice[7] = 0;
            }
            else
                if (valueRoles == 5)
            {
                //nhân viên phục vụ
                RolesSize[1] = 0;
                RolesSize[3] = 18;
                RolesSize[5] = 0;
                RolesSize[7] = 0;

                SpaceSice[1] = 60;
                SpaceSice[3] = 42;
                SpaceSice[5] = 60;
                SpaceSice[7] = 60;
            }
        }

        public void StartRoles(int roles)
        {
            RolesUser(roles);
            quanly.LoadRoles(roles);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sự kiện button menu
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (!MiniumMenu)
            {
                pnlRight.Size = new Size(60, base.Height);
                MiniumMenu = true;
            }
            else
            {
                pnlRight.Size = new Size(235, base.Height);
                MiniumMenu = false;
            }
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            SetColorButton();
            if (MenuClickIndex == -1)
            {
                tlpMenuItem.RowStyles[1].Height = RolesSize[1];
                tlpMenuItem.RowStyles[8].Height = SpaceSice[1];

                MenuClickIndex = 1;
                tlpMenuItem.Controls.Add(quanly, 0, 1);
                btnQuanLy.BackColor = Color.FromArgb(0, 64, 64);
                return;
            }
            if (MenuClickIndex == 1)
            {
                tlpMenuItem.RowStyles[1].Height = 0;
                tlpMenuItem.RowStyles[8].Height = 60;
                btnQuanLy.BackColor = Color.FromArgb(44, 62, 80);
                MenuClickIndex = -1;
                return;
            }
            //Another click

            tlpMenuItem.RowStyles[MenuClickIndex].Height = 0;
            tlpMenuItem.RowStyles[8].Height = SpaceSice[1];
            tlpMenuItem.RowStyles[1].Height = RolesSize[1];
            tlpMenuItem.Controls.Add(quanly, 0, 1);
            btnQuanLy.BackColor = Color.FromArgb(0, 64, 64);
            MenuClickIndex = 1;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            SetColorButton();
            if (MenuClickIndex == -1)
            {
                tlpMenuItem.RowStyles[3].Height = RolesSize[3];
                tlpMenuItem.RowStyles[8].Height = SpaceSice[3];
                tlpMenuItem.Controls.Add(tracuu, 0, 3);

                MenuClickIndex = 3;
                btnTraCuu.BackColor = Color.FromArgb(0, 64, 64);
                return;
            }
            if (MenuClickIndex == 3)
            {
                tlpMenuItem.RowStyles[3].Height = 0;
                tlpMenuItem.RowStyles[8].Height = 60;
                btnTraCuu.BackColor = Color.FromArgb(44, 62, 80);
                MenuClickIndex = -1;
                return;
            }
            //Another click

            tlpMenuItem.RowStyles[MenuClickIndex].Height = 0;
            tlpMenuItem.RowStyles[8].Height = SpaceSice[3];
            tlpMenuItem.RowStyles[3].Height = RolesSize[3];
            tlpMenuItem.Controls.Add(tracuu, 0, 3);
            btnTraCuu.BackColor = Color.FromArgb(0, 64, 64);
            MenuClickIndex = 3;

        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            SetColorButton();
            if (MenuClickIndex == -1)
            {
                tlpMenuItem.RowStyles[5].Height = RolesSize[5];
                tlpMenuItem.RowStyles[8].Height = SpaceSice[5];
                tlpMenuItem.Controls.Add(baocao, 0, 5);

                MenuClickIndex = 5;
                btnLapBaoCao.BackColor = Color.FromArgb(0, 64, 64);
                return;
            }
            if (MenuClickIndex == 5)
            {
                tlpMenuItem.RowStyles[5].Height = 0;
                tlpMenuItem.RowStyles[8].Height = 60;
                btnLapBaoCao.BackColor = Color.FromArgb(44, 62, 80);
                MenuClickIndex = -1;
                return;
            }
            //Another click

            tlpMenuItem.RowStyles[MenuClickIndex].Height = 0;
            tlpMenuItem.RowStyles[5].Height = RolesSize[5];
            tlpMenuItem.RowStyles[8].Height = SpaceSice[5];
            tlpMenuItem.Controls.Add(baocao, 0, 5);
            btnLapBaoCao.BackColor = Color.FromArgb(0, 64, 64);
            MenuClickIndex = 5;
            tlpMenuItem.Controls.Add(baocao, 0, 5);
        }

        private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            SetColorButton();
            if (MenuClickIndex == -1)
            {
                tlpMenuItem.RowStyles[7].Height = RolesSize[7];
                tlpMenuItem.RowStyles[8].Height = SpaceSice[7];
                tlpMenuItem.Controls.Add(quydinh, 0, 7);

                MenuClickIndex = 7;
                btnThayDoiQuyDinh.BackColor = Color.FromArgb(0, 64, 64);
                return;
            }
            if (MenuClickIndex == 7)
            {
                tlpMenuItem.RowStyles[7].Height = 0;
                tlpMenuItem.RowStyles[8].Height = 60;
                btnThayDoiQuyDinh.BackColor = Color.FromArgb(44, 62, 80);
                MenuClickIndex = -1;
                return;
            }
            //Another click

            tlpMenuItem.RowStyles[MenuClickIndex].Height = 0;
            tlpMenuItem.RowStyles[7].Height = RolesSize[7];
            tlpMenuItem.RowStyles[8].Height = SpaceSice[7];
            btnThayDoiQuyDinh.BackColor = Color.FromArgb(0, 64, 64);
            MenuClickIndex = 7;
            tlpMenuItem.Controls.Add(quydinh, 0, 7);
        }
        #endregion

        #region Bắt sự kiện cho form 
        //public void ShowFormFromChildForm()
        private void LoadEventSubItem()
        {
            //quản lý containers
            quanly.Controls["btnTiepNhanSanh"].MouseClick += new MouseEventHandler(this.OnbtnTiepNhanSanh_MouseClick);
            quanly.Controls["btnQuanLySanh"].MouseClick += new MouseEventHandler(this.OnbtnQuanLySanh_MouseClick);
            quanly.Controls["btnNhanDatTiecCuoi"].MouseClick += new MouseEventHandler(this.OnbtnNhanDatTiecCuoi_MouseClick);
            quanly.Controls["btnQuanLyTiecCuoi"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyTiecCuoi_MouseClick);
            quanly.Controls["btnLapHoaDonThanhToan"].MouseClick += new MouseEventHandler(this.OnbtnLapHoaDonThanhToan_MouseClick);
            quanly.Controls["btnQuanLyMonAn"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyMonAn_MouseClick);
            quanly.Controls["btnQuanLyDichVu"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyDichVu_MouseClick);
            quanly.Controls["btnQuanLyNhanVien"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyNhanVien_MouseClick);
            quanly.Controls["btnQuanLyCa"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyCa_MouseClick);
            quanly.Controls["btnQuanLyLoaiSanh"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyLoaiSanh_MouseClick);

            //tra cứu container
            tracuu.Controls["btnTraCuuTiecCuoi"].MouseClick += new MouseEventHandler(this.OnbtnTraCuuTiecCuoi_MouseClick);
            tracuu.Controls["btnTraCuuMonAn"].MouseClick += new MouseEventHandler(this.OnbtnTraCuuMonAn_MouseClick);
            tracuu.Controls["btnTraCuuDichVu"].MouseClick += new MouseEventHandler(this.OnbtnTraCuuDichVu_MouseClick);

            //báo cáo conttainer 
            baocao.Controls["btnLapBaoCaoThang"].MouseClick += new MouseEventHandler(this.OnbtnLapBaoCaoThang_MouseClick);
            //quy định container
            quydinh.Controls["btnThayDoiQuyDinhForm"].MouseClick += new MouseEventHandler(this.OnbtnThayDoiQuyDinhForm_MouseClick);
        }
        private bool IsOpened(string name)
        {
            bool check = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void OnbtnTiepNhanSanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmTiepNhanSanh"))
            {
                frmTiepNhanSanh tiepnhansanh = new frmTiepNhanSanh();
                tiepnhansanh.MdiParent = this; tiepnhansanh.Name = "frmTiepNhanSanh";
                tiepnhansanh.Show();
            }
        }

        private void OnbtnQuanLySanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLySanh"))
            {
                frmQuanLySanh quanlysanh = new frmQuanLySanh();
                quanlysanh.MdiParent = this;
                quanlysanh.Name = "frmQuanLySanh";
                quanlysanh.Show();
            }
        }

        private void OnbtnNhanDatTiecCuoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmNhanDatTiecCuoi"))
            {
                frmNhanDatTiecCuoi nhandattieccuoi = new frmNhanDatTiecCuoi();
                nhandattieccuoi.MdiParent = this;
                nhandattieccuoi.Name = "frmNhanDatTiecCuoi";
                nhandattieccuoi.Show();
            }
        }

        private void OnbtnQuanLyTiecCuoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyTiecCuoi"))
            {
                frmQuanLyTiecCuoi quanlytieccuoi = new frmQuanLyTiecCuoi();
                quanlytieccuoi.MdiParent = this;
                quanlytieccuoi.Name = "frmQuanLyTiecCuoi";
                quanlytieccuoi.Show();
            }
        }

        private void OnbtnLapHoaDonThanhToan_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmLapHoaDonThanhToan"))
            {
                frmLapHoaDonThanhToan laphoadonthanhtoan = new frmLapHoaDonThanhToan();
                laphoadonthanhtoan.MdiParent = this;
                laphoadonthanhtoan.Name = "frmLapHoaDonThanhToan";
                laphoadonthanhtoan.Show();
            }
        }

        private void OnbtnQuanLyMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyMonAn"))
            {
                frmQuanLyMonAn quanLyMonAn = new frmQuanLyMonAn();
                quanLyMonAn.MdiParent = this;
                quanLyMonAn.Name = "frmQuanLyMonAn";
                quanLyMonAn.Show();
            }
        }

        private void OnbtnQuanLyDichVu_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyDichVu"))
            {
                frmQuanLyDichVu quanLyDichVu = new frmQuanLyDichVu();
                quanLyDichVu.MdiParent = this;
                quanLyDichVu.Name = "frmQuanLyDichVu";
                quanLyDichVu.Show();
            }
        }

        private void OnbtnQuanLyNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyNhanVien"))
            {
                //frmQuanLyNhanVien quanlynhanvien = new frmQuanLyNhanVien();
                //quanlynhanvien.MdiParent = this;
                //quanlynhanvien.Name = "frmQuanLyNhanVien";
                //quanlynhanvien.Show();
            }
        }

        private void OnbtnQuanLyCa_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmCa"))
            {
                frmCa ca = new frmCa();
                ca.MdiParent = this;
                ca.Name = "frmCa";
                ca.Show();
            }
        }

        private void OnbtnQuanLyLoaiSanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyLoaiSanh"))
            {
                frmQuanLyLoaiSanh quanlyloaisanh = new frmQuanLyLoaiSanh();
                quanlyloaisanh.MdiParent = this;
                quanlyloaisanh.Name = "frmQuanLyLoaiSanh";
                quanlyloaisanh.Show();
            }
        }

        private void OnbtnTraCuuMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmTraCuuMonAn"))
            {
                frmTraCuuMonAn TraCuuMonAn = new frmTraCuuMonAn(false);
                TraCuuMonAn.MdiParent = this;
                TraCuuMonAn.Name = "frmTraCuuMonAn";
                TraCuuMonAn.Show();
            }
        }

        private void OnbtnTraCuuDichVu_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmTraCuuDichVu"))
            {
                frmTraCuuDichVu traCuuDichVu = new frmTraCuuDichVu(false);
                traCuuDichVu.MdiParent = this;
                traCuuDichVu.Name = "frmTraCuuDichVu";
                traCuuDichVu.Show();
            }
        }

        private void OnbtnTraCuuTiecCuoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmTraCuuTiecCuoi"))
            {
                frmTraCuuTiecCuoi traCuuTiecCuoi = new frmTraCuuTiecCuoi();
                traCuuTiecCuoi.MdiParent = this;
                traCuuTiecCuoi.Name = "frmTraCuuTiecCuoi";
                traCuuTiecCuoi.Show();
            }
        }

        private void OnbtnLapBaoCaoThang_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmLapBaoCaoThang"))
            {
                frmLapBaoCaoThang lapbaocaothang = new frmLapBaoCaoThang();
                lapbaocaothang.MdiParent = this;
                lapbaocaothang.Name = "frmLapBaoCaoThang";
                lapbaocaothang.Show();
            }
        }

        private void OnbtnThayDoiQuyDinhForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmThayDoiQuyDinh"))
            {
                frmThayDoiQuyDinh thaydoiquydinh = new frmThayDoiQuyDinh();
                thaydoiquydinh.MdiParent = this;
                thaydoiquydinh.Name = "frmThayDoiQuyDinh";
                thaydoiquydinh.Show();
            }
        }

        #endregion

        #region sự kiện cho người dùng đăng xuất, đăng nhập lại
        private void btnThongTinTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (!flag)
            {
                pnlThongTinTaiKhoan.Show();
                flag = true;
            }
            else
            {
                pnlThongTinTaiKhoan.Hide();
                flag = false;
            }
        }
        #endregion

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            pnlThongTinTaiKhoan.Visible = false;
            pnlThongTinNhanVien.Show();
            flag = false;
            if (!IsChange)
            {
                btnCapNhatThongTinNguoiDung.Enabled = false;
                IsChange = true;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                SetSizeMenuDefault();
                foreach (Form form in this.MdiChildren)
                {
                    form.Hide();
                }
                this.Hide();
                Program.dangnhapform.Dispose();
                Program.manhinhchinh.Dispose();
                Application.Exit();
            }
        }

        private void btnDangNhapLai_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đăng nhập lại ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                SetSizeMenuDefault();
                foreach (Form form in this.MdiChildren)
                {
                    form.Hide();
                }
                this.Hide();
                quanly.ResetMenu(MaPhanQuyen);
                Program.manhinhchinh.Hide();
                Program.dangnhapform.SetStateDefault();
                Program.dangnhapform.Show();                
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetSizeMenuDefault();
            this.Hide();
            Program.dangnhapform.Dispose();
            Program.manhinhchinh.Dispose();
            Application.Exit();
        }

        public void SetAvatar(string path)
        {
            try
            {
                ovalAvatar.Image = Image.FromFile(path);
                ovalAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                ovalAvatar.Image = Image.FromFile(@"DanhSachNhanVien\Unknow.png");
            }
        }

        #region Thông tin nhân viên 
        public void ResetStateForPnlThongTinNhanVien()
        {
            txtPasswordNguoiDung.ReadOnly = true;
            pnlThongTinNhanVien.Hide();
        }
        public void LoadThongTinNhanVienHienTai()
        {
            lblHoTenNhanVien.Text = NhanVienLogin.HoTen.ToUpper();
            lblDiaChi.Text = NhanVienLogin.DiaChi;
            lblDienThoai.Text = NhanVienLogin.DienThoai;
            DataTable chucvu = BUS.BUS_QuanLyNhanVien.LoadChucVu();
            for (int i = 0; i < chucvu.Rows.Count; i++)
            {
                if (NhanVienLogin.MaChucVu == Int32.Parse(chucvu.Rows[i][0].ToString()))
                {
                    lblChucVu.Text = chucvu.Rows[i][1].ToString();
                    break;
                }
            }
            txtUsername.Text = NhanVienLogin.Username;
            txtPasswordNguoiDung.Text = NhanVienLogin.Password;
            try
            {
                ptrAvatarNhanVien.Image = Image.FromFile(@"DanhSachNhanVien\" + NhanVienLogin.AnhDaiDien);
            }
            catch (Exception ex)
            {
                ptrAvatarNhanVien.Image = Image.FromFile(@"DanhSachNhanVien\Unknow.png");
            }
        }
        #endregion

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (IsChange || NhanVienLogin.Password == txtPasswordNguoiDung.Text)
            {
                txtPasswordNguoiDung.ReadOnly = false;
                txtPasswordNguoiDung.Text = string.Empty;
                MessageBox.Show("Mời nhập mật khẩu mới", "Thông báo");
                btnCapNhatThongTinNguoiDung.Enabled = true;
            }
        }

        private void btnCapNhatThongTinNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtPasswordNguoiDung.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo");
                return;
            }
            DTO_NhanVien nhanvien = new DTO_NhanVien();
            nhanvien.MaNV = NhanVienLogin.MaNV;
            nhanvien.Password = txtPasswordNguoiDung.Text;
            bool updateState = BUS_DoiMatKhau.DoiMatKhau(nhanvien);
            if (updateState)
            {
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo");
                NhanVienLogin.Password = txtPasswordNguoiDung.Text;
                txtPasswordNguoiDung.ReadOnly = true;
                btnCapNhatThongTinNguoiDung.Enabled = false;
                IsChange = false;
            }
            else
                MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo");
        }

        private void txtPasswordNguoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txtPasswordNguoiDung.Text[txtPasswordNguoiDung.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
        }

        private void btnTattabThongTin_Click(object sender, EventArgs e)
        {
            pnlThongTinNhanVien.Visible = false;
            txtPasswordNguoiDung.ReadOnly = true;
            txtPasswordNguoiDung.Text = NhanVienLogin.Password;
            btnCapNhatThongTinNguoiDung.Enabled = false;
        }
    }
}
