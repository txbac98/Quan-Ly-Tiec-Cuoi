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
    public partial class frmTraCuuTiecCuoi : Form
    {
        private DTO_TraCuu traCuu = new DTO_TraCuu();
        private SELECTED selected = SELECTED.TenChuRe;
        enum SELECTED
        {
            TenChuRe,
            TenCoDau,
            SoDT,
            Ngay
        }

        public frmTraCuuTiecCuoi()
        {
            InitializeComponent();
            rbTenChuRe.Select();            
        }
        private void frmTraCuuTiecCuoi_Load(object sender, EventArgs e)
        {
            if (txtTuKhoa.CanSelect)
            {
                txtTuKhoa.Select();
            }
        }

        private bool InputIsNull()
        {
            if (this.selected == SELECTED.TenChuRe || this.selected == SELECTED.TenCoDau)
            {
                if (txtTuKhoa.Text == "")
                    return true;
                return false;
            }
            else if (this.selected == SELECTED.SoDT)
            {
                if (txtSoDT.Text == "")
                    return true;
                return false;
            }
            return false;
        }

        //Events
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (InputIsNull())
            {
                MessageBox.Show("Vui lòng nhập từ khóa!");
            }
            else
            {
                if (this.selected == SELECTED.TenChuRe)
                {
                    traCuu.key = txtTuKhoa.Text;
                    dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuTenChuRe(traCuu);
                }
                else if (this.selected == SELECTED.TenCoDau)
                {
                    traCuu.key = txtTuKhoa.Text;
                    dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuTenCoDau(traCuu);
                }
                else if (this.selected == SELECTED.SoDT)
                {
                    traCuu.key = txtSoDT.Text;
                    dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuSoDT(traCuu);
                }
                else if (this.selected == SELECTED.Ngay)
                {
                    traCuu.key = dtpNgay.Value.ToString("MM/dd/yyyy");
                    dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuNgay(traCuu);                    
                }
            }
        }

        #region Radio Button
        private void rbTenChuRe_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.TenChuRe;
            dtpNgay.Visible = txtSoDT.Visible = false;
            txtTuKhoa.Visible = true;
            txtTuKhoa.Focus();
        }

        private void rbTenCoDau_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.TenCoDau;
            dtpNgay.Visible = txtSoDT.Visible = false;
            txtTuKhoa.Visible = true;
            txtTuKhoa.Focus();
        }

        private void rbSoDT_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.SoDT;
            dtpNgay.Visible = txtTuKhoa.Visible = false;
            txtSoDT.Visible = true;
            txtSoDT.Focus();
        }

        private void rbNgay_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.Ngay;
            txtTuKhoa.Visible = txtTuKhoa.Visible = false;
            dtpNgay.Visible = true;
            dtpNgay.Focus();
        }
        #endregion

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chiều dài số điện thoại, quá 11 thì xóa
            if (txtSoDT.Text.Length > 10)
            {
                e.KeyChar = (char)Keys.Back;
                return;
            }

            //first keys
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar != (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            //check state not char
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void txtSoDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTraCuu_Click(sender, e);
            }

        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTraCuu_Click(sender, e);
            }
        }
    }
}