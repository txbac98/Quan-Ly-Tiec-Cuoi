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


namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyMonAn : Form
    {

        private DataTable ResultTable;
        private string ImageLocationPath = string.Empty;
        //private string ImageInstance = string.Empty;
        private string IDTable = "MA";
        string tenMonAnCu = "";
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

        public frmQuanLyMonAn()
        {
            InitializeComponent();
            LoadDanhSachMonAn();
            ClearInputs();
            ShowKetQua("Kết nối thành công !!", true);
        }
        private void frmQuanLyMonAn_Load(object sender, EventArgs e)
        {
            //Setup UI
            //LoadDanhSachMonAn();
            
        }
        void LoadDanhSachMonAn()
        {
            dgvDanhSachMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachMonAn.ReadOnly = true;
            dgvDanhSachMonAn.MultiSelect = false;
            ResultTable = BUS_MonAn.GetDataTableMonAn();
            dgvDanhSachMonAn.DataSource = ResultTable;
            dgvDanhSachMonAn.Columns[0].HeaderText="Mã MA";
            dgvDanhSachMonAn.Columns[1].HeaderText = "Tên món ăn";
            dgvDanhSachMonAn.Columns[2].HeaderText = "Loại món ăn";
            dgvDanhSachMonAn.Columns[3].HeaderText = "Đơn giá";
            dgvDanhSachMonAn.Columns[4].HeaderText = "Ghi chú";
            dgvDanhSachMonAn.Columns[5].HeaderText="Hình ảnh";
            dgvDanhSachMonAn.Columns[6].Visible = false;
            lblThongTinMaMonAn.Text = GetNextID(ResultTable);
            ShowKetQua("Kết nối thành công.", true);
        }
        void UpdateDanhSachMonAn()
        {
            ResultTable = BUS_MonAn.GetDataTableMonAn();
            dgvDanhSachMonAn.DataSource = ResultTable;
            lblThongTinMaMonAn.Text = GetNextID(ResultTable);
        }
        void ShowKetQua(string skq, bool kq)
        {

            lblKetQua.Text = skq;
            if (kq) lblKetQua.ForeColor = Color.Green;
            else lblKetQua.ForeColor = Color.Red;
        }
        #region Function

        private void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenMonAn_TimKiem.Text= txtDonGia.Text = txtTenMonAn.Text = txtGhiChu.Text = string.Empty;
            ptrHinhAnh.ImageLocation = @"DanhSachMonAn\Unknow.png";
            lbThongTinHinhAnh.Text = "Unknow.png";
            cbbLoaiMonAn.SelectedIndex = 0;
            lblThongTinMaMonAn.Text = GetNextID(ResultTable);
        }
        //Chỉ nhập số_Đơn giá
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Button event

        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearInputs();
            lblThongTinMaMonAn.Text = GetNextID(ResultTable);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Check txtDonGia
            double parsedValue;
            if (!double.TryParse(txtDonGia.Text, out parsedValue))
            {
                ShowKetQua("Đơn giá - chỉ chấp nhận định dạng số!",false);
                txtDonGia.ResetText();
                return;
            }
            else if (txtDonGia.Text.Length > 18)
            {
                ShowKetQua("Đơn giá - không vượt quá 18 chữ số!",false);
                txtDonGia.ResetText();
                return;
            }

            //DTO Information
            DTO_MonAn monAn;
            if (thayDoiAnh)
            {
                string newImage = ImageLocationPath;
                string nameOfImage = (lblThongTinMaMonAn.Text + Path.GetExtension(newImage));

                //Duong dan file                
                string desFileName = Path.Combine(@"DanhSachMonAn\", nameOfImage);

                //Xoa anh cu neu da ton tai
                if (!System.IO.Directory.Exists(desFileName))
                {
                    System.IO.File.Delete(desFileName);
                }
                //copy file
                File.Copy(newImage, desFileName);
                monAn = new DTO_MonAn(lblThongTinMaMonAn.Text, txtTenMonAn.Text, cbbLoaiMonAn.Text, txtDonGia.Text, txtGhiChu.Text, nameOfImage);
            }
            else monAn = new DTO_MonAn(lblThongTinMaMonAn.Text, txtTenMonAn.Text, cbbLoaiMonAn.Text, txtDonGia.Text, txtGhiChu.Text, lbThongTinHinhAnh.Text);

            //INSERT

            if (BUS_MonAn.InsertMonAn(monAn))
            {
                //lstHinhAnh.Refresh();
                ClearInputs();
                UpdateDanhSachMonAn();
                ShowKetQua("Thêm thành công món ăn '" +txtTenMonAn.Text+"' !!",true);
            }
            else
                ShowKetQua("Thêm thất bại. Vui lòng kiểm tra lại.",false);

            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            //Check txtDonGia - Number only
            long parsedValue;
            if (!long.TryParse(txtDonGia.Text, out parsedValue))
            {
                ShowKetQua("Đơn giá - chỉ chấp nhận định dạng số!",false);
                txtDonGia.ResetText();
                return;
            }
            else if (txtDonGia.Text.Length > 18)
            {
                ShowKetQua("Đơn giá - không vượt quá 18 chữ số!",false);
                txtDonGia.ResetText();
                return;
            }

            //NewImage
            string NewImage = ImageLocationPath;

            //DTO Information                
            DTO_MonAn monAn;
                if (thayDoiAnh)
                {
                    string newImage = ImageLocationPath;
                    string nameOfImage = (lblThongTinMaMonAn.Text + Path.GetExtension(newImage));

                    //Duong dan file                
                    string desFileName = Path.Combine(@"DanhSachMonAn\", nameOfImage);

                    //Xoa anh cu neu da ton tai
                    if (!System.IO.Directory.Exists(desFileName))
                    {
                        System.IO.File.Delete(desFileName);
                    }
                    //copy file
                    File.Copy(newImage, desFileName);
                    monAn = new DTO_MonAn(lblThongTinMaMonAn.Text, txtTenMonAn.Text, cbbLoaiMonAn.Text, txtDonGia.Text, txtGhiChu.Text, nameOfImage);
                }
                else monAn = new DTO_MonAn(lblThongTinMaMonAn.Text, txtTenMonAn.Text, cbbLoaiMonAn.Text, txtDonGia.Text, txtGhiChu.Text, lbThongTinHinhAnh.Text);

            //Update
            if (BUS_MonAn.UpdateMonAn(monAn,tenMonAnCu))
            {
         
                UpdateDanhSachMonAn();
                ShowKetQua("Cập nhật thành công món ăn '" + monAn.MaMonAn + "' !!", true);
                ClearInputs();     
            }
            else
            {
                ShowKetQua("Cập nhật thất bại. Vui lòng kiểm tra lại.", false);
            }
    }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa món ăn này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    DTO_MonAn monAn = new DTO_MonAn(lblThongTinMaMonAn.Text, txtTenMonAn.Text, cbbLoaiMonAn.Text, txtDonGia.Text, txtGhiChu.Text, lbThongTinHinhAnh.Text);

                    //Check State of Image
                    if (BUS_MonAn.DeleteMonAn(monAn))
                    { 
                        ShowKetQua("Xóa thành công món ăn '"+monAn.TenMonAn+ "' !!",true);
                        UpdateDanhSachMonAn();
                        ClearInputs();
                    }
                    else
                    {
                        ShowKetQua("Xóa thất bại, Item vẫn đang được sử dụng ở PhieuDatBan, vui lòng kiểm tra lại.",false);
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
       

        void ShowDataCell(int row)
        {
            thayDoiAnh = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            lblThongTinMaMonAn.Text = dgvDanhSachMonAn[0, row].Value.ToString();
            txtTenMonAn.Text = dgvDanhSachMonAn[1, row].Value.ToString();
            tenMonAnCu= dgvDanhSachMonAn[1, row].Value.ToString();
            cbbLoaiMonAn.Text = dgvDanhSachMonAn[2, row].Value.ToString();
            txtDonGia.Text = dgvDanhSachMonAn[3, row].Value.ToString();
            txtGhiChu.Text = dgvDanhSachMonAn[4, row].Value.ToString();

            lbThongTinHinhAnh.Text = dgvDanhSachMonAn[5, row].Value.ToString();
            ptrHinhAnh.ImageLocation = @"DanhSachMonAn/" + lbThongTinHinhAnh.Text;
        }
        private void dgvDanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
            }
        }

        

        #region Tim Kiem
        private void txtTenMonAn_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTenMonAn_TimKiem.Text == " ") txtTenMonAn_TimKiem.Text = "";
            else    dgvDanhSachMonAn.DataSource = BUS_MonAn.SearchMonAn(txtTenMonAn_TimKiem.Text, cbbLoaiMonAn_TimKiem.Text);           
        }
        private void cbbLoaiMonAn_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDanhSachMonAn.DataSource = BUS_MonAn.SearchMonAn(txtTenMonAn_TimKiem.Text, cbbLoaiMonAn_TimKiem.Text);
        }

        #endregion

        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            txtTenMonAn_TimKiem.Text = "";
            cbbLoaiMonAn_TimKiem.Text = "";
            UpdateDanhSachMonAn();
        }

        #region Xoa dau cach
        private void txtTenMonAn_TextChanged(object sender, EventArgs e)
        {
            if (txtTenMonAn.Text == " ") txtTenMonAn.Text = "";
        }
        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == " ") txtGhiChu.Text = "";
        }
        #endregion


    }
}