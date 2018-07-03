using QuanLyTiecCuoiUI.FormFeature.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BUS;
namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyTiecCuoi : Form
    {

        public string maNV, tenNV,taiKhoan,matKhau;
        bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        void ActiveChildForm (string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Visible=true;
                    frm.Location = new Point(80, 0);
                    break;
                }
            }
        }
        public frmQuanLyTiecCuoi()
        {
            InitializeComponent();
           
        }
        public void DangNhap(DTO_DangNhap dangNhap)
        {
            taiKhoan = dangNhap.Username;
            matKhau = dangNhap.Password;
            tenNV = BUS_QuanLyTaiKhoan.GetTenNV(dangNhap);
            maNV = BUS_QuanLyTaiKhoan.GetMaNV(dangNhap);
            lblTenNhanVien.Text = tenNV;
        }
        
        void AnForm()
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Visible=false;
            }
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            AnForm();
            if (!CheckExistForm("frmQuanLyKhachHang"))
            {
                frmQuanLyKhachHang frmQLKH = new frmQuanLyKhachHang();
                frmQLKH.MdiParent = this;
                frmQLKH.Show();
                frmQLKH.Location = new Point(80, 0);
            }
            else
            {
                ActiveChildForm("frmQuanLyKhachHang");
            }           
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AnForm();
            if (!CheckExistForm("frmQuanLyNhanVien"))
            {
                frmQuanLyNhanVien frmQLNV = new frmQuanLyNhanVien();
                frmQLNV.MdiParent = this;
                frmQLNV.Show();
                frmQLNV.Location = new Point(80, 0);
            }
            else ActiveChildForm("frmQuanLyNhanVien");
        }

        private void mItemQuanLyChucVu_Click(object sender, EventArgs e)
        {
            frmQuanLyChucVu frmQLCV = new frmQuanLyChucVu();
            frmQLCV.Show();
        }

        private void mItemQuanLyCa_Click(object sender, EventArgs e)
        {
            frmQuanLyCa frmQLC = new frmQuanLyCa();
            frmQLC.Show();
        }

        private void mItemQuanLySanh_Click(object sender, EventArgs e)
        {
            frmQuanLySanh frmQLS = new frmQuanLySanh();
            frmQLS.Show();
        }

        private void mItemQuanLyThucDon_Click(object sender, EventArgs e)
        {

        }

        private void mItemMonAn_Click(object sender, EventArgs e)
        {
            frmQuanLyMonAn frmQLMA = new frmQuanLyMonAn();
            frmQLMA.Show();
        }


        private void btnTiecCuoi_Click(object sender, EventArgs e)
        {
            frmNhanDatTiecCuoi frmNDTC = new frmNhanDatTiecCuoi();
            frmNDTC.Show();
            frmNDTC.SetTaiKhoan(maNV, tenNV);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AnForm();
            if (!CheckExistForm("frmDanhSachTiec"))
            {
                frmDanhSachTiec frmDSTC = new frmDanhSachTiec();
                frmDSTC.MdiParent = this;
                frmDSTC.Show();
                frmDSTC.Location = new Point(80, 0);
                frmDSTC.SetTaiKhoan(maNV, tenNV);
            }
            else ActiveChildForm("frmDanhSachTiec");
        }

        private void frmQuanLyTiecCuoi_Load(object sender, EventArgs e)
        {
            AnForm();
            if (!CheckExistForm("frmDanhSachTiec"))
            {
                frmDanhSachTiec frmDSTC = new frmDanhSachTiec();
                frmDSTC.MdiParent = this;
                frmDSTC.Show();
                frmDSTC.Location = new Point(80, 0);
                frmDSTC.SetTaiKhoan(maNV, tenNV);
            }
            else ActiveChildForm("frmDanhSachTiec");
        }

        private void mItemQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (tenNV == "admin")
            {
                frmQuanLyTaiKhoan frmQLTK = new frmQuanLyTaiKhoan();
                frmQLTK.Show();
            }
            else MessageBox.Show("Chức năng chỉ dành cho admin");
        }

        private void llbDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.Show();
            frmDMK.DangNhap(taiKhoan, matKhau);
        }

        private void mItemDichVuKhac_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu frmQLDV = new frmQuanLyDichVu();
            frmQLDV.Show();
        }
    }
}

