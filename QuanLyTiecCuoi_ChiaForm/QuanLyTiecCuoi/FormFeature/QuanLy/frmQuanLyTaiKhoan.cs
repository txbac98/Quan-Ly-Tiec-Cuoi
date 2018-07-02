using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        int row = -1;
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            dgvDanhSachTaiKhoan.ReadOnly = true;
            dgvDanhSachTaiKhoan.MultiSelect = false;

            dgvDanhSachTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text=="" || txtMatKhau
                .Text=="" || txtMaNV.Text=="" || txtHoTen.Text=="")
            {
                MessageBox.Show("Thông tin còn trống, vui lòng nhập.");
                return;
            }
            DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan();
            taiKhoan.TaiKhoan = txtTaiKhoan.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;
            taiKhoan.MaNV = txtMaNV.Text;
            taiKhoan.TenNhanVien = txtHoTen.Text;
            if (BUS_QuanLyTaiKhoan.ThemTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Thêm thành công tài khoản '" + txtTaiKhoan.Text + "' !!");
                UpdateData();
            }
            else MessageBox.Show("Thêm thất bại, vui lòng thử lại.");
        }
        void UpdateData()
        {
            dgvDanhSachTaiKhoan.DataSource = BUS_QuanLyTaiKhoan.GetData();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau
                .Text == "" || txtMaNV.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Thông tin còn trống, vui lòng nhập.");
                return;
            }
            if (dgvDanhSachTaiKhoan[0, row].Value.ToString() == "admin") MessageBox.Show("Không thể xóa tài khoản admin");
            else
            {
                BUS_QuanLyTaiKhoan.DeleteTaiKhoan(dgvDanhSachTaiKhoan[0, row].Value.ToString());
                DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan();
                taiKhoan.TaiKhoan = txtTaiKhoan.Text;
                taiKhoan.MatKhau = txtMatKhau.Text;
                taiKhoan.MaNV = txtMaNV.Text;
                taiKhoan.TenNhanVien = txtHoTen.Text;
                if (BUS_QuanLyTaiKhoan.ThemTaiKhoan(taiKhoan))
                {
                    MessageBox.Show("Thêm thành công tài khoản '" + txtTaiKhoan.Text + "' !!");
                    UpdateData();
                }
                else MessageBox.Show("Thêm thất bại, vui lòng thử lại.");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTaiKhoan[0, row].Value.ToString() == "admin") MessageBox.Show("Không thể xóa tài khoản admin");
            else
            {
                BUS_QuanLyTaiKhoan.DeleteTaiKhoan(dgvDanhSachTaiKhoan[0, row].Value.ToString());
                UpdateData();
            }           
        }

        private void dgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                row = e.RowIndex;
                ShowDataCell();
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        void ShowDataCell()
        {
            txtTaiKhoan.Text = dgvDanhSachTaiKhoan[0, row].Value.ToString();
            txtMatKhau.Text = dgvDanhSachTaiKhoan[1, row].Value.ToString();
            txtMaNV.Text = dgvDanhSachTaiKhoan[2, row].Value.ToString();
            txtHoTen.Text = dgvDanhSachTaiKhoan[3, row].Value.ToString();
        }
    }
}
