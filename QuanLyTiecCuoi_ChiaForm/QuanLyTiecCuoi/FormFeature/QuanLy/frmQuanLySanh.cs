using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;

namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmQuanLySanh : Form
    {
        string maSanhCu;
        public frmQuanLySanh()
        {
            InitializeComponent();
            LoadDataGridView();
            ShowKetQua("Kết nối thành công !!", true);
        }
        private void LoadDataGridView()
        {
            dgvDanhSachSanh.DataSource = BUS_QuanLySanh.GetQLSanhTable();
            dgvDanhSachSanh.Columns[0].Visible=false;
            dgvDanhSachSanh.Columns[1].HeaderText = "Tên sảnh";
            dgvDanhSachSanh.Columns[2].HeaderText = "Đơn giá bàn";
            dgvDanhSachSanh.Columns[3].HeaderText = "Số bàn tối đa";
            dgvDanhSachSanh.Columns[4].HeaderText = "Ghi chú";
            dgvDanhSachSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSanh.ReadOnly = true;
            dgvDanhSachSanh.MultiSelect = false;

        }
        void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSanh.Text =txtSoLuongBanTD.Text=txtDonGiaBan.Text=txtGhiChu.Text= "";
        }
        void ShowKetQua(string skq, bool kq)
        {

            lblKetQua.Text = skq;
            if (kq) lblKetQua.ForeColor = Color.Green;
            else lblKetQua.ForeColor = Color.Red;
        }
        #region Them, sua , xoa
        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ClearInputs();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSanh.Text == "")
            {
                ShowKetQua("Thêm thất bại. Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }
            long donGia;
            if (!long.TryParse(txtDonGiaBan.Text,out donGia))
            {
                ShowKetQua("Thêm thất bại. Đơn giá bàn phải là dạng số.", false);
                return;
            }
            int soLuongBan;
            if (!int.TryParse(txtSoLuongBanTD.Text, out soLuongBan))
            {
                ShowKetQua("Thêm thất bại. Số lượng bàn phải là số tự nhiên.", false);
                return;
            }

            DTO_Sanh sanh = new DTO_Sanh(txtMaSanh.Text,txtDonGiaBan.Text,txtSoLuongBanTD.Text,txtGhiChu.Text);
            //verified infor

            if  (BUS_QuanLySanh.TenSanhIsExistInSanh(sanh.MaSanh))
            {
                ShowKetQua("Thêm thất bại. Sảnh '" + sanh.MaSanh + "' đã tồn tại.", false);
                return;
            }
            if (BUS_QuanLySanh.InsertSanh(sanh))
            {
                dgvDanhSachSanh.DataSource = BUS_QuanLySanh.GetQLSanhTable();
                ShowKetQua("Thêm thành công sảnh '" + sanh.MaSanh + "' !!", true);
                ClearInputs();
            }
            else
                ShowKetQua("Thêm thất bại, vui lòng kiểm tra lại.", false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            //verified infor 
            if (txtMaSanh.Text == "")
            {
                ShowKetQua("Cập nhật thất bại. Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }
            long donGia;
            if (!long.TryParse(txtDonGiaBan.Text, out donGia))
            {
                ShowKetQua("Cập nhật thất bại. Đơn giá bàn phải là dạng số.", false);
                return;
            }
            int soLuongBan;
            if (!int.TryParse(txtSoLuongBanTD.Text, out soLuongBan))
            {
                ShowKetQua("Cập nhật thất bại. Số lượng bàn phải là số tự nhiên.", false);
                return;
            }

            DTO_Sanh sanh = new DTO_Sanh(txtMaSanh.Text, txtDonGiaBan.Text, txtSoLuongBanTD.Text, txtGhiChu.Text);
            
            BUS_QuanLySanh.DeleteSanh(maSanhCu);
            if (BUS_QuanLySanh.InsertSanh(sanh)) 
            {
                dgvDanhSachSanh.DataSource = BUS_QuanLySanh.GetQLSanhTable(); ;
                ShowKetQua("Cập nhật thành công sảnh '" + sanh.MaSanh + "' !!", true);
            }
            else
                ShowKetQua("Cập nhật thất bại, vui lòng kiểm tra lại.", false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa món ăn này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    BUS_QuanLySanh.DeleteSanh(maSanhCu);

                    {
                        ShowKetQua("Xóa thành công sảnh '" + maSanhCu + "' !!", true);
                        LoadDataGridView();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    ShowKetQua("Xóa thất bại, vui lòng kiểm tra lại.", false);
                }
            }
        }
        #endregion

        void ShowDataCell(int row)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaSanh.Text = dgvDanhSachSanh[1, row].Value.ToString();
            maSanhCu= dgvDanhSachSanh[1, row].Value.ToString();
            txtDonGiaBan.Text = dgvDanhSachSanh[2, row].Value.ToString();
            txtSoLuongBanTD.Text = dgvDanhSachSanh[3, row].Value.ToString();
            txtGhiChu.Text = dgvDanhSachSanh[4, row].Value.ToString();

        }
        private void dgvDanhSachSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
            }
        }


        #region Kiem tra nhap
        private void txtMaSanh_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSanh.Text == " ") txtMaSanh.Text = "";
        }
        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaBan.Text == "0") txtDonGiaBan.Text = "";
        }
        private void txtSoLuongBanTD_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBanTD.Text == "0") txtSoLuongBanTD.Text = "";
        }
        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == " ") txtGhiChu.Text = "";
        }
        //Chỉ nhập số_Don gia ban, so luong ban
        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoBanToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        
    }
}
