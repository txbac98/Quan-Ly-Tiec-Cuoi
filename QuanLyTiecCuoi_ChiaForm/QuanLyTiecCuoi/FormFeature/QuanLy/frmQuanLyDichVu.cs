using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmQuanLyDichVu : Form
    {
        private DataTable ResultTable;
        private string ImageLocationPath = string.Empty;
        //private string ImageInstance = string.Empty;
        public string IDTable = "DV";

        //Luu ten dich vu ban dau luc cap nhat
        string tenDichVuCu = "";
        bool thayDoiAnh;

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
        public frmQuanLyDichVu()
        {
            InitializeComponent();
            LoadDanhSachDichVu();
            ClearInputs();
            lblThongTinMaDichVu.Text = GetNextID(ResultTable);
        }
        void LoadDanhSachDichVu()
        {
            dgvDanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachDichVu.ReadOnly = true;
            dgvDanhSachDichVu.MultiSelect = false;
            ResultTable = BUS_DichVu.GetDataTableDichVu();
            dgvDanhSachDichVu.DataSource = ResultTable;
            dgvDanhSachDichVu.Columns[0].HeaderText="Mã DV";
            dgvDanhSachDichVu.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDanhSachDichVu.Columns[2].HeaderText = "Đơn giá";
            dgvDanhSachDichVu.Columns[3].HeaderText = "Ghi chú";
            dgvDanhSachDichVu.Columns[4].HeaderText="Hình ảnh";
            dgvDanhSachDichVu.Columns[5].Visible = false;
            ShowKetQua("Kết nối thành công !!", true);
        }
        void UpdateDanhSachDichVu()
        {
            ResultTable = BUS_DichVu.GetDataTableDichVu();
            dgvDanhSachDichVu.DataSource = ResultTable;
            lblThongTinMaDichVu.Text = GetNextID(ResultTable);
        }
        void ShowKetQua(string skq, bool kq)
        {

            lblKetQua.Text = skq;
            if (kq) lblKetQua.ForeColor = Color.Green;
            else lblKetQua.ForeColor = Color.Red;
        }
        private void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtTenDichVu_TimKiem.Text=txtDonGia.Text = txtTenDichVu.Text = txtGhiChu.Text = string.Empty;
            ptrHinhAnh.ImageLocation = @"DanhSachDichVu\Unknow.png";
            lbThongTinHinhAnh.Text = "Unknow.png";    

        }
        //Chỉ nhập số_Đơn giá
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region Button event

        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearInputs();
            ResultTable = BUS_DichVu.GetDataTableDichVu();
            lblThongTinMaDichVu.Text = GetNextID(ResultTable);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Check txtDonGia
            double parsedValue;
            if (!double.TryParse(txtDonGia.Text, out parsedValue))
            {
                ShowKetQua("Đơn giá - chỉ chấp nhận định dạng số!", false);
                txtDonGia.ResetText();
                return;
            }
            else if (txtDonGia.Text.Length > 18)
            {
                ShowKetQua("Đơn giá - không vượt quá 18 chữ số!", false);
                txtDonGia.ResetText();
                return;
            }

            //DTO Information
            DTO_DichVu dichVu;
            if (thayDoiAnh)
            {
                string newImage = ImageLocationPath;
                string nameOfImage = (lblThongTinMaDichVu.Text + Path.GetExtension(newImage));

                //Duong dan file                
                string desFileName = Path.Combine(@"DanhSachDichVu\", nameOfImage);

                //Xoa anh cu neu da ton tai
                if (!System.IO.Directory.Exists(desFileName))
                {
                    System.IO.File.Delete(desFileName);
                }
                //copy file
                File.Copy(newImage, desFileName);
                dichVu = new DTO_DichVu(lblThongTinMaDichVu.Text, txtTenDichVu.Text, txtDonGia.Text, txtGhiChu.Text, nameOfImage);
            }
            else dichVu = new DTO_DichVu(lblThongTinMaDichVu.Text, txtTenDichVu.Text, txtDonGia.Text, txtGhiChu.Text, lbThongTinHinhAnh.Text);

            //INSERT

            if (BUS_DichVu.InsertDichVu(dichVu))
            {
                //lstHinhAnh.Refresh();
                ClearInputs();
                UpdateDanhSachDichVu();
                ShowKetQua("Thêm thành công dịch vụ '" + dichVu.MaDichVu + "' !!", true);
            }
            else
                ShowKetQua("Thêm thất bại. Vui lòng kiểm tra lại.", false);


        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            //Check txtDonGia - Number only
            long parsedValue;
            if (!long.TryParse(txtDonGia.Text, out parsedValue))
            {
                ShowKetQua("Đơn giá - chỉ chấp nhận định dạng số!", false);
                txtDonGia.ResetText();
                return;
            }
            else if (txtDonGia.Text.Length > 18)
            {
                ShowKetQua("Đơn giá - không vượt quá 18 chữ số!", false);
                txtDonGia.ResetText();
                return;
            }

            //NewImage
            string NewImage = ImageLocationPath;

            //DTO Information                
            DTO_DichVu dichVu;
            if (thayDoiAnh)
            {
                string newImage = ImageLocationPath;
                string nameOfImage = (lblThongTinMaDichVu.Text + Path.GetExtension(newImage));

                //Duong dan file                
                string desFileName = Path.Combine(@"DanhSachDichVu\", nameOfImage);

                //Xoa anh cu neu da ton tai
                if (!System.IO.Directory.Exists(desFileName))
                {
                    System.IO.File.Delete(desFileName);
                }
                //copy file
                File.Copy(newImage, desFileName);
                dichVu = new DTO_DichVu(lblThongTinMaDichVu.Text, txtTenDichVu.Text, txtDonGia.Text, txtGhiChu.Text, nameOfImage);
            }
            else dichVu = new DTO_DichVu(lblThongTinMaDichVu.Text, txtTenDichVu.Text, txtDonGia.Text, txtGhiChu.Text, lbThongTinHinhAnh.Text);

            //Update
            if (BUS_DichVu.UpdateDichVu(dichVu,tenDichVuCu))
            {
                UpdateDanhSachDichVu();
                ShowKetQua("Cập nhật thành công dịch vụ '" + dichVu.MaDichVu + "' !!", true);
                ClearInputs();
            }
            else
            {
                ShowKetQua("Cập nhật thất bại. Vui lòng kiểm tra lại.", false);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    DTO_DichVu dichVu = new DTO_DichVu(lblThongTinMaDichVu.Text, txtTenDichVu.Text, txtDonGia.Text, txtGhiChu.Text, lbThongTinHinhAnh.Text);

                    //Check State of Image
                    if (BUS_DichVu.DeleteDichVu(dichVu))
                    {
                        ShowKetQua("Xóa thành công dịch vụ '" + dichVu.MaDichVu + "' !!", true);
                        UpdateDanhSachDichVu();
                        ClearInputs();
                    }
                    else
                    {
                        ShowKetQua("Xóa thất bại, Item vẫn đang được sử dụng ở PhieuDatDichVu, vui lòng kiểm tra lại.", false);
                    }
                }
                catch (Exception ex)
                {
                    ShowKetQua("Xóa thất bại, vui lòng kiểm tra lại.", false);
                }
            }
        }

        #endregion

        #region Button group HinhAnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            dialog.DefaultExt = ".png";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageLocationPath = dialog.FileName;
                lbThongTinHinhAnh.Text = dialog.SafeFileName;
                ptrHinhAnh.ImageLocation = dialog.FileName;
                thayDoiAnh = true;
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            lbThongTinHinhAnh.Text = "Unknow.png";
            ptrHinhAnh.ImageLocation = @"DanhSachDichVu\Unknow.png";
        }
        #endregion


        #region Cell click data
        void ShowDataCell(int row)
        {
            thayDoiAnh = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            lblThongTinMaDichVu.Text = dgvDanhSachDichVu[0, row].Value.ToString();
            txtTenDichVu.Text = dgvDanhSachDichVu[1, row].Value.ToString();
            tenDichVuCu= dgvDanhSachDichVu[1, row].Value.ToString();
            txtDonGia.Text = dgvDanhSachDichVu[2, row].Value.ToString();
            txtGhiChu.Text = dgvDanhSachDichVu[3, row].Value.ToString();
            lbThongTinHinhAnh.Text = dgvDanhSachDichVu[4, row].Value.ToString();
            ptrHinhAnh.ImageLocation = @"DanhSachDichVu\" + lbThongTinHinhAnh.Text;
        }
        private void dgvDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
            }
        }
        #endregion

        #region Tim kiem
        private void txtTenDichVu_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDichVu_TimKiem.Text == " ") txtTenDichVu_TimKiem.Text = "";
            else dgvDanhSachDichVu.DataSource = BUS_DichVu.SearchDichVu(txtTenDichVu_TimKiem.Text);
        }
        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            txtTenDichVu_TimKiem.Text = "";
            UpdateDanhSachDichVu();
        }

        #endregion

        #region Xoa dau cach
        private void txtTenDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDichVu.Text == " ") txtTenDichVu.Text = "";
        }


        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == " ") txtGhiChu.Text = "";
        }
        #endregion
    }
}
