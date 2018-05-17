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
    public partial class frmQuanLyLoaiSanh : Form
    {
       
        public frmQuanLyLoaiSanh()
        {
            InitializeComponent();
        }
       
        private void frmQuanLyLoaiSanh_Load(object sender, EventArgs e)
        {
            
            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            dgvQuanLyLoaiSanh.Columns["MaLoaiSanh"].Visible = false;
            dgvQuanLyLoaiSanh.Columns["TenLoaiSanh"].HeaderText = "Tên loại sảnh";
            dgvQuanLyLoaiSanh.Columns["DonGiaBanToiThieu"].HeaderText = "Đơn giá bàn tối thiểu";

        }
        private void DisableAllInputs()
        {
            txtTenLoaiSanh.ReadOnly = true;
            txtDonGiaBanTT.ReadOnly = true;
        }
        private void EnableAllInputs()
        {
            txtTenLoaiSanh.ReadOnly = false;
            txtDonGiaBanTT.ReadOnly = false;
        }
        private void ClearAllInputs()
        {
            txtTenLoaiSanh.Text = "";
            txtDonGiaBanTT.Text = "";
        }

        void ShowKetQua(string skq, bool kq)
        {

            lbKetQua.Text = skq;
            if (kq) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtTenLoaiSanh.Text, decimal.Parse(txtDonGiaBanTT.Text));
                if (BUS_QuanLyLoaiSanh.InsertLoaiSanh(loaiSanh))
                {
                    dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                    ClearAllInputs();
                    ShowKetQua("Thêm loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", true);
                }
                else
                {
                    ShowKetQua("Loại sảnh '" + loaiSanh.tenLoaiSanh + "' đã tồn tại. Vui lòng sửa lại.", false);
                    txtTenLoaiSanh.Focus();
                    txtTenLoaiSanh.SelectAll();
                }

                ClearAllInputs();
                dgvQuanLyLoaiSanh.ClearSelection();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtTenLoaiSanh.Text, decimal.Parse(txtDonGiaBanTT.Text));
                loaiSanh.maLoaiSanh = int.Parse(dgvQuanLyLoaiSanh.CurrentRow.Cells["MaLoaiSanh"].Value.ToString());
                if (BUS_QuanLyLoaiSanh.UpdateLoaiSanh(loaiSanh))
                {
                    dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                    ClearAllInputs();
                    ShowKetQua("Sửa loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", true);

                }
                else
                {
                    ShowKetQua("Loại sảnh '" + loaiSanh.tenLoaiSanh + "' đã tồn tại. Vui lòng sửa lại.", false);
                    txtTenLoaiSanh.Focus();
                    txtTenLoaiSanh.SelectAll();
                }
                ClearAllInputs();
                dgvQuanLyLoaiSanh.ClearSelection();
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvQuanLyLoaiSanh.Focus();
            DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh();
            loaiSanh.tenLoaiSanh = dgvQuanLyLoaiSanh.CurrentRow.Cells["TenLoaiSanh"].Value.ToString();
            loaiSanh.maLoaiSanh = int.Parse(dgvQuanLyLoaiSanh.CurrentRow.Cells["MaLoaiSanh"].Value.ToString());

            DialogResult dr = MessageBox.Show(string.Format("Bạn có muốn xóa loại sảnh '{0}' không?", loaiSanh.tenLoaiSanh), "Xóa loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;
            if (BUS_QuanLyLoaiSanh.DeleteLoaiSanh(loaiSanh))
            {
                dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                ShowKetQua("Xóa loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", true);
                ClearAllInputs();
            }
            else
                ShowKetQua(string.Format("Không thể xóa, vui lòng xóa dữ liệu liên qua đến loại sảnh '{0}' trong bảng 'Sảnh' trước.",
                    loaiSanh.tenLoaiSanh),
                     false);
        }

       
        bool KiemTraThongTin()
        {
            if (txtTenLoaiSanh.Text == "" || txtDonGiaBanTT.Text == "")
            {
                ShowKetQua("Vui lòng nhập đầy đủ thông tin.", false);
                return false;
            }
            int temp;
            if (!int.TryParse(txtDonGiaBanTT.Text, out temp))
            {
                ShowKetQua("'Đơn giá bàn tối đa' phải là số nguyên, vui lòng nhập lại.", false);
                txtDonGiaBanTT.Focus();
                txtDonGiaBanTT.SelectAll();
                return false;
            }
            return true;
        }
        

        private void txtDonGiaBanTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTenLoaiSanh_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLoaiSanh.Text == " ")
                txtTenLoaiSanh.Text = "";
        }

        private void txtDonGiaBanTT_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaBanTT.Text == "0")
                txtDonGiaBanTT.Text = "";
        }

        private void dgvQuanLyLoaiSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Hien thi button Sua, Xoa
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Visible = false;

            if (e.RowIndex == -1)
                return;

            //Lay du lieu
            int row = e.RowIndex;
            txtTenLoaiSanh.Text = dgvQuanLyLoaiSanh[1, row].Value.ToString();
            txtDonGiaBanTT.Text = dgvQuanLyLoaiSanh[2, row].Value.ToString();
        }

        private void dgvQuanLyLoaiSanh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvQuanLyLoaiSanh.ClearSelection();
        }

        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Xoa du lieu
            ClearAllInputs();

            //Hien thi button Them
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = true;
        }

        private void grpTinhNangQuanLy_Enter(object sender, EventArgs e)
        {

        }
    }
}
