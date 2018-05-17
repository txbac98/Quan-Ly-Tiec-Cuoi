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
        private string IDTable = "NV";

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

            LoadDataGridView();

            ClearDuLieuNhap();

            rbtNam.Checked = true;
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);
        }
        private void LoadDataGridView()
        {
            ResultTable = BUS_QuanLyNhanVien.GetDataTable();
            dgvDanhSachNhanVien.DataSource = ResultTable;
            dgvDanhSachNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvDanhSachNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvDanhSachNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvDanhSachNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvDanhSachNhanVien.Columns[4].HeaderText = "Chức vụ";
            dgvDanhSachNhanVien.Columns[5].HeaderText = "Số điện thoại";
            dgvDanhSachNhanVien.Columns[6].HeaderText = "Địa chỉ";


            dgvDanhSachNhanVien.ReadOnly = true;
            dgvDanhSachNhanVien.MultiSelect = false;
        }

        //Update datagridview
        private void UpDateDataGridView()
        {
            ResultTable = BUS_QuanLyNhanVien.GetDataTable();
            dgvDanhSachNhanVien.DataSource = ResultTable;
        }

        void ClearDuLieuNhap()
        {
            
            txtTenNhanVien.Text = "";
            rbtNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(1998, 2, 2, 0, 0, 0);
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            ptrHinhAnh.Image = QuanLyTiecCuoiUI.Properties.Resources.avatar;
        }
        void ShowKetQua(string skq, bool kq)
        {

            lbKetQua.Text = skq;
            if (kq) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

        #region Them, Sua, Xoa

        private void llbThemMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnThem.Visible = true;
            btnCapNhat.Visible = false;
            btnXoa.Visible = false;

            //Load ma nhan vien
            lblThongTinMaNhanVien.Text = GetNextID(ResultTable);

            ClearDuLieuNhap();
        }

        //Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "" )
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin nhập.", false);
                return;
            }

            //Set gioi tinh
            string gioiTinh,ngaySinh;
            if (rbtNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else gioiTinh = "Nữ";

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


            DTO_NhanVien nhanVien = new DTO_NhanVien();

            if (lbThongTinHinhAnh.Text != "Unknow.png")
            {
                string newImage = ImageLocationPath;

                string nameOfImage = (lblMaNhanVien.ToString() + Path.GetExtension(newImage));

                //copy file
                string desFileName = Path.Combine(@"DanhSachNhanVien\", nameOfImage);

                File.Copy(newImage, desFileName);
            }
            else nhanVien.AnhDaiDien = "Unknow.png";

            //Set thong tin nhan vien
            nhanVien.MaNV = lblThongTinMaNhanVien.Text;
            nhanVien.HoTen = txtTenNhanVien.Text;
            nhanVien.GioiTinh = gioiTinh;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.DienThoai = txtDienThoai.Text;
            nhanVien.DiaChi = txtDiaChi.Text;

            if (BUS_QuanLyNhanVien.InsertNhanVien(nhanVien))
            {
                ShowKetQua("Thêm thành công nhân viên '" + nhanVien.MaNV + "' !!", true);
                ClearDuLieuNhap();
                UpDateDataGridView();
            }
            else ShowKetQua("Thất bại. Vui lòng kiểm tra lại.", false);



            //DTO_NhanVien nhanVien = new DTO_NhanVien(lblThongTinMaNhanVien.Text, txtTenNhanVien,gioiTinh,ngaySinh,cbbChucVu.Text,txtDienThoai.Text,txtDiaChi.Text);

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
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            lbThongTinHinhAnh.Text = string.Empty;
            ptrHinhAnh.Image= ptrHinhAnh.Image = QuanLyTiecCuoiUI.Properties.Resources.avatar;
            lbThongTinHinhAnh.Text = "Unkonw.png";
        }
        #endregion

        

    }
}
