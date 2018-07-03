using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmDanhSachTiec : Form
    {
        string maNV, tenNV;
        int row = -1;
        public frmDanhSachTiec()
        {
            BUS_QuanLySanh.Init();
            BUS_Ca.Init();
            InitializeComponent();
            //LoadData();
        }
        void LoadData()
        {
            List<string> listSanh = new List<string>();
            List<string> listCa = new List<string>();
            listSanh = BUS_QuanLySanh.GetListMaSanh();
            listSanh.Add("");
            cbbSanh.DataSource = listSanh;
            cbbSanh.Text = "";
            listCa= BUS_Ca.GetListCa();
            listCa.Add("");
            cbbCa.DataSource = listCa;
          
            cbbCa.Text = "";
            dgvDanhSachTiec.ReadOnly = true;
            dgvDanhSachTiec.MultiSelect = false;

            dgvDanhSachTiec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachTiec.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
        }
        void UpdateData()
        {
            dgvDanhSachTiec.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
        }
        public void SetTaiKhoan(string maNhanVien, string tenNhanVien)
        {
            maNV = maNhanVien;
            tenNV = tenNhanVien;
        }
        private void btnThemTiec_Click(object sender, EventArgs e)
        {
            frmThemTiec frmTT = new frmThemTiec();
            frmTT.Show();
            frmTT.SetTaiKhoan(maNV, tenNV);
        }

        private void btnXoaTiec_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa tiệc này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                BUS_KhachHang.DeleteKhachHang(dgvDanhSachTiec[1, row].Value.ToString());
                BUS_QuanLyTiecCuoi.DeleteTiecCuoi(dgvDanhSachTiec[0, row].Value.ToString());
                UpdateData();
            }  
        }

        
        private void dgvDanhSachTiec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnXoaTiec.Enabled = true;
                btnSuaTiec.Enabled = true;
                row = e.RowIndex;
            }
            else
            {
                btnXoaTiec.Enabled = false;
                btnSuaTiec.Enabled = false;
            }

        }

        private void cbbCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyTim_Click(object sender, EventArgs e)
        {
            ckbNgayDatTiec.Checked = false;
            cbbCa.Text = cbbSanh.Text = "";
            UpdateData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (ckbNgayDatTiec.Checked) dgvDanhSachTiec.DataSource = BUS_QuanLyTiecCuoi.SearchTiecTheoNgay(dtpNgayDaiTiec.Value.ToShortDateString(), cbbCa.Text, cbbSanh.Text);
            else dgvDanhSachTiec.DataSource = BUS_QuanLyTiecCuoi.SearchTiecKhongTheoNgay(cbbCa.Text, cbbSanh.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            UpdateData();
            LoadData();
        }

        private void frmDanhSachTiec_Load(object sender, EventArgs e)
        {

        }

        private void btnSuaTiec_Click(object sender, EventArgs e)
        {
            DTO_TiecCuoi tiecCuoi = new DTO_TiecCuoi();
            tiecCuoi.MaTC = dgvDanhSachTiec[0, row].Value.ToString();
            tiecCuoi.MaKH = dgvDanhSachTiec[1, row].Value.ToString();
            tiecCuoi.TenChuRe = dgvDanhSachTiec[2, row].Value.ToString();
            tiecCuoi.NamSinhChuRe = int.Parse(dgvDanhSachTiec[3, row].Value.ToString());
            tiecCuoi.TenCoDau = dgvDanhSachTiec[4, row].Value.ToString();
            tiecCuoi.NamSinhCoDau = int.Parse(dgvDanhSachTiec[5, row].Value.ToString());
            tiecCuoi.DienThoai = dgvDanhSachTiec[6, row].Value.ToString();
            tiecCuoi.DiaChi = dgvDanhSachTiec[7, row].Value.ToString();
            tiecCuoi.NgayDatTiec = DateTime.Parse(dgvDanhSachTiec[8, row].Value.ToString());
            tiecCuoi.NgayDaiTiec = DateTime.Parse(dgvDanhSachTiec[9, row].Value.ToString());
            tiecCuoi.Ca = dgvDanhSachTiec[10, row].Value.ToString();
            tiecCuoi.Sanh = dgvDanhSachTiec[11, row].Value.ToString();
            tiecCuoi.SoBan = int.Parse(dgvDanhSachTiec[12, row].Value.ToString());
            tiecCuoi.TongSoTien = decimal.Parse(dgvDanhSachTiec[13, row].Value.ToString());
            tiecCuoi.TienCoc = decimal.Parse(dgvDanhSachTiec[14, row].Value.ToString());
            tiecCuoi.GhiChu = dgvDanhSachTiec[15, row].Value.ToString();
            tiecCuoi.MaNV = dgvDanhSachTiec[16, row].Value.ToString();
            frmNhanDatTiecCuoi frmSTC = new frmNhanDatTiecCuoi();
            frmSTC.Show();
            frmSTC.frmSetDataSua(tiecCuoi);
        }
    }
}
