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

namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmQuanLyCa : Form
    {
        string maCaCu;
        public frmQuanLyCa()
        {
            InitializeComponent();
            LoadDataGridView();
            ClearInputs();
            ShowKetQua("Kết nối thành công !!", true);
        }
        private void LoadDataGridView()
        {
            dgvDanhSachCa.DataSource = BUS_Ca.GetDataTable();
            dgvDanhSachCa.Columns[0].HeaderText = "Mã ca";
            dgvDanhSachCa.Columns[1].HeaderText = "Thời gian BD";
            dgvDanhSachCa.Columns[2].HeaderText = "Thời gian KT";
            dgvDanhSachCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachCa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachCa.ReadOnly = true;
            dgvDanhSachCa.MultiSelect = false;

        }
        void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaCa.Text = "";

            cbbGioBD.SelectedIndex = 0;
            cbbPhutBD.SelectedIndex = 0;
            cbbGioKT.SelectedIndex = 0;
            cbbPhutKT.SelectedIndex = 0;
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
            if (txtMaCa.Text=="")
            {
                ShowKetQua("Thêm thất bại. Vui lòng nhập đầy đủ thông tin.", false);
                return;
            }
            string thoiGianBD = "",thoiGianKT="";
            thoiGianBD = cbbGioBD.Text + ":" + cbbPhutBD.Text;
            thoiGianKT = cbbGioKT.Text + ":" + cbbPhutKT.Text;
            DTO_Ca ca = new DTO_Ca(txtMaCa.Text,thoiGianBD,thoiGianKT);
            //verified infor

            if (BUS_Ca.TenCaIsExistInCa(ca.MaCa))
            {
                ShowKetQua("Thêm thất bại, ca '" + ca.MaCa + "' đã tồn tại.", false);
                return;
            }
                
            if (BUS_Ca.InsertCa(ca))
            {
                dgvDanhSachCa.DataSource = BUS_Ca.GetDataTable();
                ShowKetQua("Thêm thành công ca '" +ca.MaCa+ "' !!",true);
                ClearInputs();

            }
            else
                ShowKetQua("Thêm thất bại, vui lòng kiểm tra lại.",false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            //verified infor 
            if (txtMaCa.Text == "")
            {
                ShowKetQua("Sửa thất bại, vui lòng nhập đầy đủ thông tin.", false);
                return;
            }
            string thoiGianBD = "",thoiGianKT="";
            thoiGianBD = cbbGioBD.Text + ":" + cbbPhutBD.Text;
            thoiGianKT = cbbGioKT.Text + ":" + cbbPhutKT.Text;

            DTO_Ca ca = new DTO_Ca(txtMaCa.Text,thoiGianBD,thoiGianKT);

            if (maCaCu != ca.MaCa)
            {
                if (BUS_Ca.TenCaIsExistInCa(ca.MaCa))
                {
                    ShowKetQua("Sửa thất bại, ca '" + ca.MaCa + "' đã tồn tại.", false);
                    return;
                }
            }       
            BUS_Ca.DeleteCa(maCaCu);
            if (BUS_Ca.InsertCa(ca))
            {
                dgvDanhSachCa.DataSource = BUS_Ca.GetDataTable(); ;
                ShowKetQua("Cập nhật thành công ca '" + ca.MaCa + "' !!", true);
            }
            else
                ShowKetQua("Cập nhật thất bại, vui lòng kiểm tra lại.", false);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_Ca.DeleteCa(maCaCu);
            ShowKetQua("Xóa thành công ca '" + maCaCu + "' !!", true);
            ClearInputs();
            LoadDataGridView();
        }

        #endregion

        void ShowDataCell(int row)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaCa.Text = dgvDanhSachCa[0, row].Value.ToString();
            maCaCu= dgvDanhSachCa[0, row].Value.ToString();
            string thoiGianBD= dgvDanhSachCa[1, row].Value.ToString();
            string thoiGianKT = dgvDanhSachCa[2, row].Value.ToString();
            //Lay thoi gian
            cbbGioBD.Text = thoiGianBD[0].ToString() + thoiGianBD[1].ToString();
            cbbPhutBD.Text = thoiGianBD[3].ToString() + thoiGianBD[4].ToString();

            cbbGioKT.Text = thoiGianKT[0].ToString() + thoiGianKT[1].ToString();
            cbbPhutKT.Text = thoiGianKT[3].ToString() + thoiGianKT[4].ToString();

        }
        private void dgvTableShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDanhSachCa.RowCount )
            {
                ClearInputs();
            }
            else if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
            }
        }

        private void txtMaCa_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCa.Text == " ") txtMaCa.Text = "";
        }

        private void frmQuanLyCa_Load(object sender, EventArgs e)
        {

        }
    }
}
