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
    public partial class frmQuanLyChucVu : Form
    {
        string maChucVuCu, tenChucVuCu;
        public frmQuanLyChucVu()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void frmQuanLyChucVu_Load(object sender, EventArgs e)
        {

        }
        void LoadDataGridView()
        {
            dgvDanhSachChucVu.DataSource = BUS_QuanLyChucVu.GetDataTable();
            dgvDanhSachChucVu.Columns[0].Visible=false;
            dgvDanhSachChucVu.Columns[1].HeaderText = "Mã chức vụ";
            dgvDanhSachChucVu.Columns[2].HeaderText = "Tên chức vụ";
            dgvDanhSachChucVu.Columns[3].HeaderText = "Ghi chú";
            ShowKetQua("Kết nối thành công !!", true);
        }
        void UpdateDataGridView()
        {
            ClearInputs();
            dgvDanhSachChucVu.DataSource = BUS_QuanLyChucVu.GetDataTable();
            dgvDanhSachChucVu.Sort(dgvDanhSachChucVu.Columns["STT"], System.ComponentModel.ListSortDirection.Descending);
        }
        void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaChucVu.Text = txtTenChucVu.Text =txtGhiChu.Text= "";
        }

        void ShowKetQua(string skq, bool kq)
        {

            lblKetQua.Text = skq;
            if (kq) lblKetQua.ForeColor = Color.Green;
            else lblKetQua.ForeColor = Color.Red;
        }
        #region Them, sua , xoa
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaChucVu.Text=="" || txtTenChucVu.Text == "" )
            {
                ShowKetQua("Thêm thất bại, vui lòng nhập đầy đủ thông tin.",false);
                return;
            }
            DTO_ChucVu chucVu = new DTO_ChucVu(txtMaChucVu.Text, txtTenChucVu.Text,txtGhiChu.Text);
            if (maChucVuCu != chucVu.MaCV)
            {
                if (BUS_QuanLyChucVu.MaCVIsExistInChucVu(chucVu.MaCV))
                {
                    ShowKetQua("Thêm thất bại, chức vụ mã '" + chucVu.MaCV + "' đã tồn tại.", false);
                    return;
                }
            }
            if (tenChucVuCu != chucVu.TenChucVu)
            {
                if (BUS_QuanLyChucVu.TenCVIsExistInChucVu(chucVu.TenChucVu))
                {
                    ShowKetQua("Thêm thất bại, chức vụ tên'" + chucVu.TenChucVu + "' đã tồn tại.", false);
                    return;
                }
            }
            if (BUS_QuanLyChucVu.InsertChucVu(chucVu))
            {
                ShowKetQua("Thêm thành công chức vụ mã '" +chucVu.MaCV+ "' !!", true);
                ClearInputs();
                UpdateDataGridView();
            }
        }

        void ShowDataCell(int row)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaChucVu.Text = dgvDanhSachChucVu[1, row].Value.ToString();
            maChucVuCu = dgvDanhSachChucVu[1, row].Value.ToString();
            txtTenChucVu.Text= dgvDanhSachChucVu[2, row].Value.ToString();
            tenChucVuCu= dgvDanhSachChucVu[2, row].Value.ToString();
            txtGhiChu.Text= dgvDanhSachChucVu[3, row].Value.ToString();

        }
        private void dgvDanhSachChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
            }
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            //verified infor 
            if (txtMaChucVu.Text == "" || txtTenChucVu.Text == "")
            {
                ShowKetQua("Thêm thất bại, vui lòng nhập đầy đủ thông tin.", false);
                return;
            }

            DTO_ChucVu chucVu = new DTO_ChucVu(txtMaChucVu.Text, txtTenChucVu.Text, txtGhiChu.Text);

            if (maChucVuCu != chucVu.MaCV)
            {
                if (BUS_QuanLyChucVu.MaCVIsExistInChucVu(chucVu.MaCV))
                {
                    ShowKetQua("Sửa thất bại, chức vụ mã '" + chucVu.MaCV + "' đã tồn tại.", false);
                    return;
                }
            }
            if (tenChucVuCu != chucVu.TenChucVu)
            {
                if (BUS_QuanLyChucVu.TenCVIsExistInChucVu(chucVu.TenChucVu))
                {
                    ShowKetQua("Sửa thất bại, chức vụ tên '" + chucVu.TenChucVu + "' đã tồn tại.", false);
                    return;
                }
            }
            BUS_QuanLyChucVu.DeleteChucVu(maChucVuCu);
            if (BUS_QuanLyChucVu.InsertChucVu(chucVu))
            {
                UpdateDataGridView();
                ShowKetQua("Cập nhật thành công chức vụ '" + chucVu.MaCV + "' !!", true);
            }
            else
                ShowKetQua("Cập nhật thất bại, vui lòng kiểm tra lại.", false);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_QuanLyChucVu.DeleteChucVu(maChucVuCu);
            ShowKetQua("Xóa thành công chức vụ '" + maChucVuCu + "' !!", true);
            UpdateDataGridView();

        }

        #endregion


    }
}
