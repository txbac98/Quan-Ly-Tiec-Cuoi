using BUS;
using DTO;
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
    public partial class frmTraCuuDichVu : Form
    {
        public string mTenDichVuSelected = "-";
        public string mMaDichVuSelected;
        private DTO_TraCuu traCuu = new DTO_TraCuu();

        public frmTraCuuDichVu()
        {
            InitializeComponent();
            tcTraCuuDichVu.SelectedTab = tabPage1;
            ptrHinh.ImageLocation = @"DanhSachDichVu\Unknow.png";
        }

        public frmTraCuuDichVu(bool flagBtnChon)
        {
            InitializeComponent();
            tcTraCuuDichVu.SelectedTab = tabPage1;
            ptrHinh.ImageLocation = @"DanhSachDichVu\Unknow.png";
            btnChon.Visible = flagBtnChon;
        }

        private void frmTraCuuDichVu_Load(object sender, EventArgs e)
        {
            dgvDanhSachDichVu.DataSource = BUS_DichVu.GetDataTableDichVu();
        }

        #region Function
        private bool InputIsNull()
        {
            if (txtTuKhoa.Text == "")
                return true;
            return false;
        }

        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Set tabIndex
            tcTraCuuDichVu.SelectedTab = tabPage2;
            if (InputIsNull())
            {
                MessageBox.Show("Từ khóa không hợp lệ!");
            }
            else
            {
                traCuu.key = txtTuKhoa.Text;
                dgvKetQuaTimKiem.DataSource = BUS_TraCuu.TraCuuDichVu(traCuu);
            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        #region dgvDanhSachDichVu
        private void dgvDanhSachDichVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachDichVu.ClearSelection();
            dgvDanhSachDichVu.Columns["MaDichVu"].Visible = false;
            dgvDanhSachDichVu.Columns["HinhAnh"].Visible = false;
            dgvDanhSachDichVu.Columns["GhiChu"].Visible = false;
            dgvDanhSachDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDanhSachDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
        }

        private void dgvDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int row = e.RowIndex;
            lbTenDichVu.Text = dgvDanhSachDichVu["TenDichVu", row].Value.ToString();
            lbDonGia.Text = dgvDanhSachDichVu["DonGia", row].Value.ToString() + " VNĐ";
            ptrHinh.ImageLocation = @"DanhSachDichVu\" + dgvDanhSachDichVu["HinhAnh", row].Value.ToString();
            lbGhiChu.Text = dgvDanhSachDichVu["GhiChu", row].Value.ToString();
            this.mMaDichVuSelected = dgvDanhSachDichVu["MaDichVu", row].Value.ToString();
        }

        #endregion

        #region dgvKetQuaTimKiem
        private void dgvKetQuaTimKiem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKetQuaTimKiem.ClearSelection();
            dgvKetQuaTimKiem.Columns["MaDichVu"].Visible = false;
            dgvKetQuaTimKiem.Columns["HinhAnh"].Visible = false;
            dgvKetQuaTimKiem.Columns["GhiChu"].Visible = false;
            dgvKetQuaTimKiem.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvKetQuaTimKiem.Columns["DonGia"].HeaderText = "Đơn giá";
        }
        private void dgvKetQuaTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int row = e.RowIndex;
            lbTenDichVu.Text = dgvKetQuaTimKiem["TenDichVu", row].Value.ToString();
            lbDonGia.Text = dgvKetQuaTimKiem["DonGia", row].Value.ToString() + " VNĐ";
            ptrHinh.ImageLocation = @"DanhSachDichVu\" + dgvKetQuaTimKiem["HinhAnh", row].Value.ToString();
            lbGhiChu.Text = dgvKetQuaTimKiem["GhiChu", row].Value.ToString();
            this.mMaDichVuSelected = dgvKetQuaTimKiem["MaDichVu", row].Value.ToString();
        }

        #endregion

        private void btnChon_Click(object sender, EventArgs e)
        {
            //this.mMaDichVuSelected (trên dgvDanhSachDichVu và dgvKetQuaTimKiem)
            this.mTenDichVuSelected = lbTenDichVu.Text;
            this.Close();
        }
    }
}