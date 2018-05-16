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
    public partial class frmTraCuuMonAn : Form
    {
        public string mTenMonAnSelected = "-";
        public string mMaMonAnSelected;
        private DTO_TraCuu traCuu = new DTO_TraCuu();

        public frmTraCuuMonAn()
        {
            InitializeComponent();
            tcTraCuuMonAn.SelectedTab = tabPage1;
            ptrHinh.ImageLocation = @"DanhSachMonAn\Unknow.png";
        }
        public frmTraCuuMonAn(bool flagBtnChon)
        {
            InitializeComponent();
            tcTraCuuMonAn.SelectedTab = tabPage1;
            ptrHinh.ImageLocation = @"DanhSachMonAn\Unknow.png";
            btnChon.Visible = flagBtnChon;
        }

        private void frmTraCuuMonAn_Load(object sender, EventArgs e)
        {
            dgvDanhSachMonAn.DataSource = BUS_MonAn.GetDataTableMonAn();                       
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
            tcTraCuuMonAn.SelectedTab = tabPage2;
            if (InputIsNull())
            {
                MessageBox.Show("Từ khóa không hợp lệ!");
            }
            else
            {
                traCuu.key = txtTuKhoa.Text;
                dgvKetQuaTimKiem.DataSource = BUS_TraCuu.TraCuuMonAn(traCuu);                
            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        #region dgvDanhSachMonAn
        private void dgvDanhSachMonAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachMonAn.ClearSelection();
            dgvDanhSachMonAn.Columns["MaMonAn"].Visible = false;
            dgvDanhSachMonAn.Columns["HinhAnh"].Visible = false;
            dgvDanhSachMonAn.Columns["GhiChu"].Visible = false;
            dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDanhSachMonAn.Columns["DonGia"].HeaderText = "Đơn giá";
        }

        private void dgvDanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int row = e.RowIndex;
            lbTenMonAn.Text = dgvDanhSachMonAn["TenMonAn", row].Value.ToString();
            lbDonGia.Text = dgvDanhSachMonAn["DonGia", row].Value.ToString() + " VNĐ";
            ptrHinh.ImageLocation = @"DanhSachMonAn\" + dgvDanhSachMonAn["HinhAnh", row].Value.ToString();
            lbGhiChu.Text = dgvDanhSachMonAn["GhiChu", row].Value.ToString();
            this.mMaMonAnSelected = dgvDanhSachMonAn["MaMonAn", row].Value.ToString();
        }
        #endregion

        #region dgvKetQuaTimKiem
        private void dgvKetQuaTimKiem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKetQuaTimKiem.ClearSelection();
            dgvKetQuaTimKiem.Columns["MaMonAn"].Visible = false;
            dgvKetQuaTimKiem.Columns["HinhAnh"].Visible = false;
            dgvKetQuaTimKiem.Columns["GhiChu"].Visible = false;
            dgvKetQuaTimKiem.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvKetQuaTimKiem.Columns["DonGia"].HeaderText = "Đơn giá";
        }

        private void dgvKetQuaTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int row = e.RowIndex;
            lbTenMonAn.Text = dgvKetQuaTimKiem["TenMonAn", row].Value.ToString();
            lbDonGia.Text = dgvKetQuaTimKiem["DonGia", row].Value.ToString() + " VNĐ";
            ptrHinh.ImageLocation = @"DanhSachMonAn\" + dgvKetQuaTimKiem["HinhAnh", row].Value.ToString();
            lbGhiChu.Text = dgvKetQuaTimKiem["GhiChu", row].Value.ToString();
            this.mMaMonAnSelected = dgvKetQuaTimKiem["MaMonAn", row].Value.ToString();
        }
        #endregion

        private void btnChon_Click(object sender, EventArgs e)
        {
            //this.mMaMonAnSelected (trên dgvDanhSachMonAn và dgvKetQuaTimKiem)
            this.mTenMonAnSelected = lbTenMonAn.Text;
            this.Close();
        }
    }
}