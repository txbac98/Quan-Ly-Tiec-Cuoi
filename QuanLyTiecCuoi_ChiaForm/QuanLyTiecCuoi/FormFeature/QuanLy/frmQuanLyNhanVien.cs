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
using BUS;
using DTO;

namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmQuanLyNhanVien : Form
    {
        bool thayDoiAnh = false;
        public string IDTable = "NV";

        private DataTable ResultTable;

        //Duoi file hinh anh
        private string ImageLocationPath = string.Empty;

        //Ten file hinh anh
        private string ImageInstance = string.Empty;

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

        //Khoi tao
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            BUS_QuanLyChucVu.Init();
            
            LoadDataGridView();
            ClearDuLieuNhap();
            rbtNam.Checked = true;
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);
            ShowKetQua("Kết nối thành công !!", true);
        }
        #region Data
        private void LoadDataGridView()
        {
            cbbChucVu.DataSource = BUS_QuanLyChucVu.GetListChucVu();
            cbbChucVu_TimKiem.DataSource= BUS_QuanLyChucVu.GetListChucVu_TimKiem();
            //cbbChucVu_TimKiem.Items.Add("");
            ResultTable = BUS_QuanLyNhanVien.GetDataTable();
            dgvDanhSachNhanVien.DataSource = ResultTable;
            dgvDanhSachNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvDanhSachNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvDanhSachNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvDanhSachNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvDanhSachNhanVien.Columns[4].HeaderText = "Chức vụ";
            dgvDanhSachNhanVien.Columns[5].HeaderText = "Số điện thoại";
            dgvDanhSachNhanVien.Columns[6].HeaderText = "Địa chỉ";
            dgvDanhSachNhanVien.Columns[7].Visible = false;


            //Khong cho chinh sua tren dgv, khong cho chon nhieu hang
            dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNhanVien.ReadOnly = true;
            dgvDanhSachNhanVien.MultiSelect = false;
        }

        //Update datagridview
        private void UpDateDataGridView()
        {
            
            cbbChucVu.DataSource = BUS_QuanLyChucVu.GetListChucVu();
            cbbChucVu_TimKiem.DataSource = BUS_QuanLyChucVu.GetListChucVu_TimKiem();
            ResultTable = BUS_QuanLyNhanVien.GetDataTable();
            dgvDanhSachNhanVien.DataSource = ResultTable;
            dgvDanhSachNhanVien.Sort(dgvDanhSachNhanVien.Columns["STT"], System.ComponentModel.ListSortDirection.Descending);
            ClearDuLieuNhap();
        }
        #endregion
        void ClearDuLieuNhap()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);
            txtTenNhanVien.Text = "";
            rbtNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(1998, 2, 2, 0, 0, 0);
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            ptrHinhAnh.ImageLocation = @"DanhSachNhanVien/Unknow.png";
            lbThongTinHinhAnh.Text = "Unknow.png";
            //ptrHinhAnh.Image = QuanLyTiecCuoiUI.Properties.Resources.avatar;

            txtMaNV_TimKiem.Text = txtTenNhanVien_TimKiem.Text = cbbChucVu_TimKiem.Text = "";
            rbtRong.Checked = true;
        }


        void ShowKetQua(string skq, bool kq)
        {

            lbKetQua.Text = skq;
            if (kq) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

        #region Them, Sua, Xoa
        //Chỉ nhập số_Đơn giá
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Load ma nhan vien
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);
            ClearDuLieuNhap();
        }


        //Get Gioi tinh, Ngay sinh
        string GetGioiTinh()
        {
            if (rbtNam.Checked)
            {
                return "Nam";
            }
            else return "Nữ";
        }

        string GetNgaySinh()
        {

            string ngaySinh;

            //Set ngay sinh
            if (dtpNgaySinh.Value.Day < 10)
            {
                ngaySinh = "0" + dtpNgaySinh.Value.Day.ToString();
            }
            else ngaySinh = dtpNgaySinh.Value.Day.ToString();

            ngaySinh += "/";

            if (dtpNgaySinh.Value.Month < 10)
            {
                ngaySinh += "0" + dtpNgaySinh.Value.Month.ToString();
            }
            else ngaySinh += dtpNgaySinh.Value.Month.ToString();

            ngaySinh += "/";

            ngaySinh += dtpNgaySinh.Value.Year.ToString();

            return ngaySinh;
        }

        //Set gioi tinh, ngay sinh
        void SetGioiTinh(string gioiTinh)
        {
            if (gioiTinh == "Nam") rbtNam.Checked = true;
            else rbtNu.Checked = true;
        }

        void SetNgaySinh(string ngaySinh)
        {
            //Set ngay sinh
            int ngay, thang, nam;
            string sNgay, sThang, sNam;

            //Loai bo dau "/"
            sNgay = ngaySinh[0].ToString() + ngaySinh[1].ToString();
            sThang = ngaySinh[3].ToString() + ngaySinh[4].ToString();
            sNam = ngaySinh[6].ToString() + ngaySinh[7].ToString() + ngaySinh[8].ToString() + ngaySinh[9].ToString();

            ngay = int.Parse(sNgay);
            thang = int.Parse(sThang);
            nam = int.Parse(sNam);

            dtpNgaySinh.Value = new DateTime(nam, thang, ngay, 0, 0, 0);
        }

        //Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }

            DTO_NhanVien nhanVien = new DTO_NhanVien(lblThongTinMaNhanVien.Text, txtTenNhanVien.Text,
                    GetGioiTinh(), GetNgaySinh(), cbbChucVu.Text, txtDienThoai.Text, txtDiaChi.Text, lbThongTinHinhAnh.Text);

            if (lbThongTinHinhAnh.Text!="Unknow.png" && thayDoiAnh)
            {
                string newImage = ImageLocationPath;
                string nameOfImage = (lblThongTinMaNhanVien.Text + Path.GetExtension(newImage));

                //Duong dan file                
                string desFileName = Path.Combine(@"DanhSachNhanVien\", nameOfImage);

                //Xoa anh cu neu da ton tai
                if (!System.IO.Directory.Exists(desFileName))
                {
                    System.IO.File.Delete(desFileName);
                }
                //copy file
                File.Copy(newImage, desFileName);
                nhanVien.AnhDaiDien = nameOfImage;
            }

            if (BUS_QuanLyNhanVien.InsertNhanVien(nhanVien))
            {
                ShowKetQua("Thêm thành công nhân viên '" + nhanVien.MaNV + "' !!", true);
                ClearDuLieuNhap();
                UpDateDataGridView();
            }
            else ShowKetQua("Thất bại. Vui lòng kiểm tra lại.", false);


        }

        private void ShowDataCell(int row)
        {
            thayDoiAnh = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            lblThongTinMaNhanVien.Text = dgvDanhSachNhanVien[0, row].Value.ToString();
            txtTenNhanVien.Text = dgvDanhSachNhanVien[1, row].Value.ToString();

            //Lay gia tri gioi tinh, ngay sinh
            SetGioiTinh(dgvDanhSachNhanVien[2, row].Value.ToString());
            SetNgaySinh(dgvDanhSachNhanVien[3, row].Value.ToString());

            cbbChucVu.Text = dgvDanhSachNhanVien[4, row].Value.ToString();
            txtDienThoai.Text = dgvDanhSachNhanVien[5, row].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNhanVien[6, row].Value.ToString();

            lbThongTinHinhAnh.Text = dgvDanhSachNhanVien[7, row].Value.ToString();
            ptrHinhAnh.ImageLocation = @"DanhSachNhanVien/" + dgvDanhSachNhanVien[7, row].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            //Cap nhat
            if (txtTenNhanVien.Text == "" || cbbChucVu.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Cập nhật thất bại, thông tin còn trống.", false);
                return;
            }

            DTO_NhanVien nhanVien;

            if (lbThongTinHinhAnh.Text!="Unknow.png" && thayDoiAnh)
            {
    
                string newImage = ImageLocationPath;
                string nameOfImage = (lblThongTinMaNhanVien.Text + Path.GetExtension(newImage));

                //Duong dan file                
                string desFileName = Path.Combine(@"DanhSachNhanVien\", nameOfImage);

                //Xoa anh cu neu da ton tai
                if (!System.IO.Directory.Exists(desFileName))
                {
                    System.IO.File.Delete(desFileName);
                }
                //copy file
                File.Copy(newImage, desFileName);
                nhanVien = new DTO_NhanVien(lblThongTinMaNhanVien.Text, txtTenNhanVien.Text,
                        GetGioiTinh(), GetNgaySinh(), cbbChucVu.Text, txtDienThoai.Text, txtDiaChi.Text, nameOfImage);
            }         
            else nhanVien = new DTO_NhanVien(lblThongTinMaNhanVien.Text, txtTenNhanVien.Text,
                     GetGioiTinh(), GetNgaySinh(), cbbChucVu.Text, txtDienThoai.Text, txtDiaChi.Text, lbThongTinHinhAnh.Text);

            if (BUS_QuanLyNhanVien.UpdateNhanVien(nhanVien))
            {
                UpDateDataGridView();
                ShowKetQua("Cập nhật thành công nhân viên '" + nhanVien.MaNV + "' !!", true);
            }
            else
                ShowKetQua("Cập nhật thất bại, vui lòng kiểm tra lại.", false);
        }

        //Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa dữ liệu nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                DTO_NhanVien nhanVien = new DTO_NhanVien(lblThongTinMaNhanVien.Text, txtTenNhanVien.Text,
                     GetGioiTinh(), GetNgaySinh(), cbbChucVu.Text, txtDienThoai.Text, txtDiaChi.Text, lbThongTinHinhAnh.Text);
                if (BUS_QuanLyNhanVien.DeleteNhanVien(nhanVien))
                {
                    UpDateDataGridView();
                    ClearDuLieuNhap();
                    ShowKetQua("Xóa thành công nhân viên '" + nhanVien.MaNV + "' !!", true);
                }
                else ShowKetQua("Xóa không thành công. Vui lòng kiểm tra lại.", false);
            }
        }

        //CHon hang tren datagridview
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowDataCell(e.RowIndex);
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
            ptrHinhAnh.ImageLocation = @"DanhSachNhanVien/Unknow.png";

        }





        #endregion


        #region Tim kiem
        private void txtMaNV_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV_TimKiem.Text == " ") txtMaNV_TimKiem.Text = "";

            txtTenNhanVien_TimKiem.Text = "";
            cbbChucVu.Text = "";
            rbtRong.Checked = true;

            dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.SearchNhanVienTheoMa(txtMaNV_TimKiem.Text);
        }
        private void txtTenNhanVien_TimKiem_TextChanged(object sender, EventArgs e)
        {
            txtMaNV_TimKiem.Text = "";
            if (txtTenNhanVien_TimKiem.Text == " ") txtTenNhanVien_TimKiem.Text = "";

            string gioiTinh = "";
            if (rbtNam_TimKiem.Checked == true) gioiTinh = "Nam";
            if (rbtNu_TimKiem.Checked == true) gioiTinh = "Nữ";

            dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.SearchNhanVienTheoThongTin(txtTenNhanVien_TimKiem.Text, gioiTinh, cbbChucVu_TimKiem.Text);
        }
        private void cbbChucVu_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV_TimKiem.Text = "";
            if (cbbChucVu_TimKiem.Text == " ") cbbChucVu_TimKiem.Text = "";

            string gioiTinh = "";
            if (rbtNam_TimKiem.Checked == true) gioiTinh = "Nam";
            if (rbtNu_TimKiem.Checked == true) gioiTinh = "Nữ";

            dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.SearchNhanVienTheoThongTin(txtTenNhanVien_TimKiem.Text, gioiTinh, cbbChucVu_TimKiem.Text);
        }
        private void rbtNam_TimKiem_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.SearchNhanVienTheoThongTin(txtTenNhanVien_TimKiem.Text, "Nam", cbbChucVu_TimKiem.Text);
        }
        private void rbtNu_TimKiem_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.SearchNhanVienTheoThongTin(txtTenNhanVien_TimKiem.Text, "Nữ", cbbChucVu_TimKiem.Text);
        }
        private void rbtRong_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.SearchNhanVienTheoThongTin(txtTenNhanVien_TimKiem.Text, "", cbbChucVu_TimKiem.Text);
        }
        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            txtMaNV_TimKiem.Text = txtTenNhanVien_TimKiem.Text = cbbChucVu_TimKiem.Text = "";
            UpDateDataGridView();
        }

        #endregion

        private void lbKetQua_Click(object sender, EventArgs e)
        {

        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDTable = BUS_QuanLyChucVu.GetMaChucVu(cbbChucVu.Text);
            DataTable ResultChucVu = BUS_QuanLyNhanVien.SearchNhanVienTheoThongTin("", "", cbbChucVu.Text);
            lblThongTinMaNhanVien.Text = GetNextID(ResultChucVu);
        }

        private void lblThongTinMaNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
