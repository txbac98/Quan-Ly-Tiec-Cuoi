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

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyTiecCuoi : Form
    {
        public string maNV;

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

        void AnForm()
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Visible=false;
            }
            btnKhachHang.Enabled = btnNhanVien.Enabled = true;
            btnKhachHang.BackColor = btnNhanVien.BackColor = Color.FromArgb(0, 64, 64);
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            AnForm();
            btnKhachHang.Enabled = false;
            btnKhachHang.BackColor = Color.Teal;
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
            btnNhanVien.Enabled = false;
            btnNhanVien.BackColor = Color.Teal;
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

        private void mItemDoUong_Click(object sender, EventArgs e)
        {

        }

        private void mItemDichVuKhac_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu frmQLDV = new frmQuanLyDichVu();
            frmQLDV.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

