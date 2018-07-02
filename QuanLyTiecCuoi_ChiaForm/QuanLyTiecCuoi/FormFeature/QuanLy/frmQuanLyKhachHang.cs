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

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyKhachHang : Form
    {

        private string IDTable = "KH";

        private DataTable ResultTable;




        //Convert Number to string for index

        private string ConvertNumber(int state)
        {
            if (state <= 9) return '0' + state.ToString();
            else
                return state.ToString();
        }

        //Get next index in table
        private string GetNextID(DataTable result)
        {
            try
            {
                return IDTable + (ConvertNumber(Int32.Parse(result.Rows[ResultTable.Rows.Count - 1].ItemArray[0].ToString().Substring(2)) + 1));
            }
            catch
            {
                return IDTable + "01";
            }
        }
        //public frmQuanLyKhachHang(string TableID)
        //{
        //    InitializeComponent();
        //    IDTable = TableID;
        //    ResultTable = BUS_KhachHang.GetDataTable();
        //}


        //Khoi tao
        public frmQuanLyKhachHang()
        {
            InitializeComponent();

            LoadDataGridView();

            lblThongTinMaKhachHang.Text = GetNextID(ResultTable);
            ShowKetQua("Kết nối thành công !!", true);
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {

            //LoadDataGridView();
            //btnThem.Focus();

        }

        //Load DatagridView
        private void LoadDataGridView()
        {

            ResultTable = BUS_KhachHang.GetDataTable();
            dgvDanhSachKhachHang.DataSource = ResultTable;
            dgvDanhSachKhachHang.Columns[0].HeaderText = "Mã KH";
            dgvDanhSachKhachHang.Columns[1].HeaderText = "Tên chú rể";
            dgvDanhSachKhachHang.Columns[2].HeaderText = "Năm sinh";
            dgvDanhSachKhachHang.Columns[3].HeaderText = "Tên cô dâu";
            dgvDanhSachKhachHang.Columns[4].HeaderText = "Năm sinh";
            dgvDanhSachKhachHang.Columns[5].HeaderText = "Điện thoại";
            dgvDanhSachKhachHang.Columns[6].HeaderText = "Địa chỉ";


            //dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachKhachHang.ReadOnly = true;
            dgvDanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachKhachHang.MultiSelect = false;
        }

        //Update datagridview
        private void UpDateDataGridView()
        {
            ResultTable = BUS_KhachHang.GetDataTable();
            dgvDanhSachKhachHang.DataSource = ResultTable;
        }

        void ClearDuLieuNhap()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtTenChuRe.Text = "";
            txtTenCoDau.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtNamSinhCoDau.Text = "";
            txtTenChuRe.Text = "";
        }

        void ShowKetQua(string skq, bool kq)
        {
            lbKetQua.Text = skq;
            if (kq) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

        #region Kiem tra giu lieu nhap
        //Chỉ nhập số
        private void txtNamSinhChuRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNamSinhCoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Them, Sua, Xoa

        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //Load ma khach hang
            lblThongTinMaKhachHang.Text = GetNextID(ResultTable);

            ClearDuLieuNhap();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
                 
            //Them

            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }
            if (!BUS_KiemTraThongTin.KiemTraDienThoai(txtDienThoai.Text))
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }
            if (!BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhChuRe.Text) || !BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhCoDau.Text))
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }
            DTO_KhachHang khachhang = new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text, txtNamSinhChuRe.Text, txtTenCoDau.Text, txtNamSinhCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);
            if (BUS_KhachHang.InsertKhachHang(khachhang))
            {
                 UpDateDataGridView();
                 dgvDanhSachKhachHang.ClearSelection();
                 ShowKetQua("Thêm thành công khách hàng '" + khachhang.MaKH + "' !!", true);
            }
                else
                ShowKetQua("Thêm thất bại, vui lòng kiểm tra lại.", false);
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {


            //Cap nhat
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Cập nhật thất bại, thông tin còn trống.", false);
                return;
            }
            DTO_KhachHang khachhang = new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text, txtNamSinhChuRe.Text, txtTenCoDau.Text, txtNamSinhCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);

            if (BUS_KhachHang.UpdateKhachHang(khachhang))
            {
                UpDateDataGridView(); 
                ShowKetQua("Cập nhật thành công khách hàng '" +khachhang.MaKH+ "' !!",true);
            }
            else
                ShowKetQua("Cập nhật thất bại, vui lòng kiểm tra lại.", false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            DTO_KhachHang khachhang =  new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text,txtNamSinhChuRe.Text, txtTenCoDau.Text,txtNamSinhCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);
            
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa dữ liệu khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                if (BUS_KhachHang.DeleteKhachHang(khachhang.MaKH))
                {
                    UpDateDataGridView();
                    ShowKetQua("Xóa thành công khách hàng '" +khachhang.MaKH+ "' !!",true);
                }
                else
                    ShowKetQua("Xóa khách hàng '" + khachhang.MaKH + "' thất bại, vui lòng thử lại.", false);
            }

        }
        //Chon hang tren data 
        private void ShowDataCell(int row)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            lblThongTinMaKhachHang.Text = dgvDanhSachKhachHang[0, row].Value.ToString();
            txtTenChuRe.Text = dgvDanhSachKhachHang[1, row].Value.ToString();
            txtNamSinhChuRe.Text = dgvDanhSachKhachHang[2, row].Value.ToString();
            txtTenCoDau.Text = dgvDanhSachKhachHang[3, row].Value.ToString();
            txtNamSinhCoDau.Text = dgvDanhSachKhachHang[4, row].Value.ToString();
            txtDienThoai.Text = dgvDanhSachKhachHang[5, row].Value.ToString();
            txtDiaChi.Text = dgvDanhSachKhachHang[6, row].Value.ToString();
        }
        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= dgvDanhSachKhachHang.RowCount - 1)
            {
                ClearDuLieuNhap();
            }
            else if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
            }
        }

        #endregion

        #region Tim kiem
        private void txbMaKhachHang_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //Khong cho phep dien ten co dau, chu re
            txbTenChuRe_TimKiem.Text = "";
            txbTenCoDau_TimKiem.Text = "";

            if (txbMaKhachHang_TimKiem.Text == " ")
            {
                txbMaKhachHang_TimKiem.Text = "";
                return;
            }

            dgvDanhSachKhachHang.DataSource = BUS_KhachHang.SearchKhachHangTheoMa(txbMaKhachHang_TimKiem.Text);
        }

        private void txbTenChuRe_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //Khong cho phep dien ma
            txbMaKhachHang_TimKiem.Text = "";

            if (txbTenChuRe_TimKiem.Text == " ")
            {
                txbTenChuRe_TimKiem.Text = "";
                return;
            }
            dgvDanhSachKhachHang.DataSource = BUS_KhachHang.SearchKhachHangTheoTen(txbTenChuRe_TimKiem.Text, txbTenCoDau_TimKiem.Text);
        }
        private void txbTenCoDau_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //Khong cho phep dien ma
            txbMaKhachHang_TimKiem.Text = "";

            if (txbTenCoDau_TimKiem.Text == " ")
            {
                txbTenCoDau_TimKiem.Text = "";
                return;
            }
            dgvDanhSachKhachHang.DataSource = BUS_KhachHang.SearchKhachHangTheoTen(txbTenChuRe_TimKiem.Text, txbTenCoDau_TimKiem.Text);
        }
        #endregion

        #region Kiem tra du lieu nhap
        private void txtTenChuRe_TextChanged(object sender, EventArgs e)
        {
            if (txtTenChuRe.Text == " ") txtTenChuRe.Text = "";
        }

        private void txtTenCoDau_TextChanged(object sender, EventArgs e)
        {
            if (txtTenCoDau.Text == " ") txtTenCoDau.Text = "";
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == " ") txtDienThoai.Text = "";

            if (txtDienThoai.Text != "")
            {
                if (BUS_KiemTraThongTin.KiemTraDienThoai(txtDienThoai.Text))
                    txtDienThoai.ForeColor = Color.Black;
                else txtDienThoai.ForeColor = Color.Red;
            }
 
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == " ") txtDiaChi.Text = "";
            
        }

        private void txtNamSinhChuRe_TextChanged(object sender, EventArgs e)
        {
            if (txtNamSinhChuRe.Text == " ") txtNamSinhChuRe.Text = "";
            if (txtNamSinhChuRe.Text != "")
            {
                if (BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhChuRe.Text))
                    txtNamSinhChuRe.ForeColor = Color.Black;
                else txtNamSinhChuRe.ForeColor = Color.Red;
            }


        }

        private void txtNamSinhCoDau_TextChanged(object sender, EventArgs e)
        {
            if (txtNamSinhCoDau.Text == " ") txtNamSinhCoDau.Text = "";
            if (txtNamSinhCoDau.Text != "")
            {
                if (BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhCoDau.Text))
                    txtNamSinhCoDau.ForeColor = Color.Black;
                else txtNamSinhCoDau.ForeColor = Color.Red;
            }
            else txtNamSinhCoDau.ForeColor = Color.Black;

        }




        #endregion

        private void frmQuanLyKhachHang_Load_1(object sender, EventArgs e)
        {

        }
    }
}

