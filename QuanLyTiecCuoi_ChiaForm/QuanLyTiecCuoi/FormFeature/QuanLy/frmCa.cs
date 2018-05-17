﻿using System;
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

            dgvTableShow.Columns["MaCa"].HeaderText = "Mã ca";
            dgvTableShow.Columns["TenCa"].HeaderText = "Tên ca";
            dgvTableShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        #region Them, Sua, Xoa
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                DTO_Ca ca = new DTO_Ca(txtMaCa.Text, txtTenCa.Text);
                if (BUS_Ca.InsertCa(ca))
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    ClearAllInputs();
                    ShowKetQua("Thêm ca '" + ca.MaCa + "' thành công!", true);
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                DTO_Ca ca = new DTO_Ca(decimal.Parse(txtMaCa.Text), txtTenCa.Text);
                ca.MaCa = int.Parse(dgvTableShow.CurrentRow.Cells["MaCa"].Value.ToString());
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
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            dgvTableShow.Focus();

            DTO_Ca ca = new DTO_Ca();
            ca.MaCa = int.Parse(dgvTableShow.CurrentRow.Cells["MaCa"].Value.ToString());
            ca.TenCa = dgvTableShow.CurrentRow.Cells["TenCa"].Value.ToString();
            

            DialogResult dr = MessageBox.Show(string.Format("Bạn có muốn xóa ca '{0}' không?", ca.MaCa), "Xóa ca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;
            if (BUS_Ca.DeleteCa(ca))
            {
                dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                ShowKetQua("Xóa ca '" + ca.MaCa + "' thành công!", true);
                ClearAllInputs();
            }
            else
                ShowKetQua(string.Format("Không thể xóa, vui lòng xóa dữ liệu liên qua đến ca '{0}' trong bảng 'Ca' trước.", ca.MaCa), false);
        }
        #endregion

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
        private void txtMaCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
        private void dgvTableShow_CellClick(object sender, DataGridViewCellEventArgs e)
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


        private void llbThemMoi_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Xoa du lieu
            ClearAllInputs();

            //Hien thi button Them
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = true;
        }


    }
}
