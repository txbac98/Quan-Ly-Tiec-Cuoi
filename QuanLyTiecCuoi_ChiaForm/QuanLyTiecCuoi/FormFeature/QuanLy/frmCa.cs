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
    public partial class frmCa : Form
    {

        public frmCa()
        {
            InitializeComponent();
        }

        private void frmCa_Load(object sender, EventArgs e)
        {

            dgvTableShow.DataSource = BUS_Ca.GetDataTable();
           
            dgvTableShow.Columns["MaCa"].HeaderText = "Mã Ca";
            dgvTableShow.Columns["TenCa"].HeaderText = "Tên Ca";

        }
        private void DisableAllInputs()
        {
            txtMaCa.ReadOnly = true;
            txtTenCa.ReadOnly = true;
        }
        private void EnableAllInputs()
        {
            txtMaCa.ReadOnly = false;
            txtTenCa.ReadOnly = false;
        }
        private void ClearAllInputs()
        {
            txtMaCa.Text = "";
            txtTenCa.Text = "";
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
                DTO_Ca ca = new DTO_Ca(txtMaCa.Text,txtTenCa.Text);
                if (BUS_Ca.InsertCa(ca))
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    ClearAllInputs();
                    ShowKetQua("Thêm ca '" + ca.MaCa + "' thành công!", true);
                }
                else
                {
                    ShowKetQua("Ca '" + ca.MaCa+ "' đã tồn tại. Vui lòng sửa lại.", false);
                    txtMaCa.Focus();
                    txtMaCa.SelectAll();
                }

                ClearAllInputs();
                dgvTableShow.ClearSelection();
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                DTO_Ca ca = new DTO_Ca(txtMaCa.Text, txtTenCa.Text);
               
                if (BUS_Ca.UpdateCa(ca))
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    ClearAllInputs();
                    ShowKetQua("Sửa ca '" + ca.MaCa + "' thành công!", true);

                }
                else
                {
                    ShowKetQua("Ca '" + ca.MaCa + "' đã tồn tại. Vui lòng sửa lại.", false);
                    txtMaCa.Focus();
                    txtMaCa.SelectAll();
                }
                ClearAllInputs();
                dgvTableShow.ClearSelection();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_Ca ca = new DTO_Ca(txtMaCa.Text, txtTenCa.Text);

            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa dữ liệu ca", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                if (BUS_Ca.DeleteCa(ca))
                {
                   


                    ShowKetQua("Xóa thành công ca '" + ca.MaCa + "' !!", true);
                }
                else
                    ShowKetQua("Xóa ca '" + ca.MaCa + "' thất bại, vui lòng thử lại.", false);
            }

        }


        bool KiemTraThongTin()
        {
            if (txtMaCa.Text == "" || txtTenCa.Text == "")
            {
                ShowKetQua("Vui lòng nhập đầy đủ thông tin.", false);
                return false;
            }
            int temp;
            if (!int.TryParse(txtMaCa.Text, out temp))
            {
                ShowKetQua("'Mã ca' phải là số nguyên, vui lòng nhập lại.", false);
                txtMaCa.Focus();
                txtMaCa.SelectAll();
                return false;
            }
            return true;

        }


       
        private void txtTenCa_TextChanged(object sender, EventArgs e)
        {
            if (txtTenCa.Text == " ")
                txtTenCa.Text = "";
        }

        private void txtMaCa_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCa.Text == "0")
                txtMaCa.Text = "";
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
            txtMaCa.Text = dgvTableShow[1, row].Value.ToString();
            txtTenCa.Text = dgvTableShow[2, row].Value.ToString();
        }

        private void dgvTableShow_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTableShow.ClearSelection();
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

        private void lbKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
