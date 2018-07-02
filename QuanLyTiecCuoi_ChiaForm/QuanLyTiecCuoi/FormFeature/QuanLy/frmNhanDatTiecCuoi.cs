using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTiecCuoiUI
{
    public partial class frmNhanDatTiecCuoi : Form
    {
        
        private string IDTable = "KH";

        private string maKH, maTiec;

        private DataTable KhachHangTable, TiecTable;

        private List<Decimal> lstGiaSanh = new List<decimal>();
        private List<int> lstSoLuongBanToiDaSanh = new List<int>();

        private string soLuongBanToiDa , donGiaBan;

        string maDV;

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
                return IDTable + (ConvertNumber(Int32.Parse(result.Rows[result.Rows.Count - 1].ItemArray[0].ToString().Substring(2)) + 1));
            }
            catch
            {
                return IDTable + "01";
            }
        }
        public frmNhanDatTiecCuoi()
        {
            InitializeComponent();

            BUS_Ca.Init();
            BUS_QuanLySanh.Init();
            BUS_DichVu.Init();

            LoadCa();
            LoadSanh();
            //Load id khach hang
            LoadData();
            ShowKetQua("Kết nối thành công", true);
            
        }
        public void SetTaiKhoan(string maNV, string tenNV)
        {
            lblThongTinMaNhanVien.Text = maNV;
            lblNhanVienLapTiec.Text = tenNV;
        }
        public void frmSetDataSua(DTO_TiecCuoi tiecCuoi)
        {
            btnDatTiec.Enabled = false;
            btnSuaTiec.Enabled = true;
            lblThongTinMaTiec.Text = tiecCuoi.MaTC;
            lblThongTinMaKhachHang.Text = tiecCuoi.MaKH;
            txtTenChuRe.Text = tiecCuoi.TenChuRe;
            txtNamSinhChuRe.Text = tiecCuoi.NamSinhChuRe.ToString();
            txtTenCoDau.Text = tiecCuoi.TenCoDau;
            txtNamSinhCoDau.Text = tiecCuoi.NamSinhCoDau.ToString();
            txtDienThoai.Text = tiecCuoi.DienThoai;
            txtDiaChi.Text = tiecCuoi.DiaChi;
            dtpNgayDaiTiec.Value = tiecCuoi.NgayDaiTiec;
            dtpNgayDatTiec.Value = tiecCuoi.NgayDatTiec;
            cbbCa.Text = tiecCuoi.Ca;
            cbbSanh.Text = tiecCuoi.Sanh;
            lblSoBanToiDa.Text = BUS_QuanLySanh.GetSoLuongBanToiDa(cbbSanh.Text);
            lblDonGiaBan.Text = BUS_QuanLySanh.GetDonGiaBanToiThieu(cbbSanh.Text);
            txtSoLuongBanDat.Text = tiecCuoi.SoBan.ToString();
            txtTienDatCoc.Text = tiecCuoi.TienCoc.ToString();
            lblTongTienTamTinh.Text = tiecCuoi.TongSoTien.ToString();
            txtGhiChuThongTinTiecCuoi.Text = tiecCuoi.GhiChu;
            lblThongTinMaNhanVien.Text = tiecCuoi.MaNV;
            GetDataPhieuDatMon();
            GetPhieuDatDichVu();
        }
        void GetDataPhieuDatMon()
        {
            DataTable dataPhieuMonAn = BUS_QuanLyTiecCuoi.GetDataPhieuDatMon(lblThongTinMaTiec.Text);
            foreach (DataRow row in dataPhieuMonAn.Rows)
            {
                int num = lsvMonAn.Items.Count;
                lsvMonAn.Items.Add((num + 1).ToString());
                lsvMonAn.Items[num].SubItems.Add(row[1].ToString());
                lsvMonAn.Items[num].SubItems.Add(row[2].ToString());
                lsvMonAn.Items[num].SubItems.Add(row[3].ToString());
                lsvMonAn.Items[num].SubItems.Add(row[4].ToString());
                lsvMonAn.Items[num].SubItems.Add(row[5].ToString());
            }    
        }
        void GetPhieuDatDichVu()
        {
            DataTable dataPhieuDichVu = BUS_QuanLyTiecCuoi.GetDataPhieuDichVu(lblThongTinMaTiec.Text);
            foreach (DataRow row in dataPhieuDichVu.Rows)
            {
                int num = lsvDichVu.Items.Count;
                lsvDichVu.Items.Add((num + 1).ToString());
                lsvDichVu.Items[num].SubItems.Add(row[1].ToString());
                lsvDichVu.Items[num].SubItems.Add(row[2].ToString());
                lsvDichVu.Items[num].SubItems.Add(row[3].ToString());
                lsvDichVu.Items[num].SubItems.Add(row[4].ToString());
            }
                
        }
        public void frmSetDataTiec(DateTimePicker ngayDaiTiec, string ca, string sanh)
        {
            dtpNgayDaiTiec = ngayDaiTiec;
            LoadCa();
            LoadSanh();
            cbbCa.Text = ca;
            cbbSanh.Text = sanh;
            //Load id khach hang
            LoadData();
            ShowKetQua("Kết nối thành công", true);
        }
        private void frmNhanDatTiecCuoi_Load(object sender, EventArgs e)
        {
            ClearInputs();
            //LoadSanhAndCa();
            cbbLoaiMonAn.SelectedIndex = 0;
            
            LoadDichVu();
            LoadMonAn();
        }
        void LoadData()
        {
            KhachHangTable = BUS_KhachHang.GetDataTable();
            TiecTable = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
            IDTable = "KH";
            lblThongTinMaKhachHang.Text = GetNextID(KhachHangTable);
            IDTable = "TC";
            lblThongTinMaTiec.Text = GetNextID(TiecTable);
        }
        private void ClearInputs()
        {
            txtTenChuRe.Text = txtTenCoDau.Text = txtDienThoai.Text=txtNamSinhChuRe.Text=txtNamSinhCoDau.Text=txtDiaChi.Text = string.Empty;
            txtGhiChuThongTinTiecCuoi.Text = txtTienDatCoc.Text = string.Empty;
            lblDonGiaBan.Text = string.Empty;
            dtpNgayDatTiec.Value = DateTime.Now;
            dtpNgayDaiTiec.Value = DateTime.Now.AddDays(1);
        }
        private void cboCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbbSanh.DataSource = BUS_QuanLyTiecCuoi.GetListSanhRanh(dtpNgayDaiTiec.Value.ToShortDateString(), cbbCa.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu sảnh. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }

        private void cboSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
           lblSoBanToiDa.Text = BUS_QuanLySanh.GetSoLuongBanToiDa(cbbSanh.Text);
            lblDonGiaBan.Text = BUS_QuanLySanh.GetDonGiaBanToiThieu(cbbSanh.Text);
            
        }
        

        private void LoadMonAn()
        {
            try
            {
                cbbMonAn.DataSource = BUS_MonAn.GetListMonAnTheoLoai(cbbLoaiMonAn.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách món ăn. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }
        private void LoadDichVu()
        {
            try
            {
                cbbDichVu.DataSource = BUS_DichVu.GetListDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách dịch vụ. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }
  
        private void LoadSanh()
        {
            try
            {
                cbbSanh.DataSource = BUS_QuanLySanh.GetListMaSanh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu sảnh. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }

        private void LoadCa()
        {
            try
            {
                cbbCa.DataSource = BUS_Ca.GetListCa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu sảnh. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }

        void TinhTongTien()
        {
            int tongTien = 0;
            tongTien += int.Parse(lblDonGiaBan.Text) * int.Parse(txtSoLuongBanDat.Text);
            for (int i = 0; i < lsvDichVu.Items.Count; i++)
            {
                tongTien += int.Parse(lsvDichVu.Items[i].SubItems[2].Text) * int.Parse(lsvDichVu.Items[i].SubItems[3].Text);             
            }
            for (int i = 0; i < lsvMonAn.Items.Count; i++)
            {
                tongTien += int.Parse(lsvMonAn.Items[i].SubItems[3].Text) * int.Parse(lsvMonAn.Items[i].SubItems[3].Text);
            }
            lblTongTienTamTinh.Text = tongTien.ToString();
        }

        #region Phieu dich vu

        #region Them dich vu
        private void btnChonDV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvDichVu.Items.Count; i++)
            {
                if (lsvDichVu.Items[i].SubItems[1].Text == cbbDichVu.Text)
                {
                    MessageBox.Show("Dịch vụ '" +cbbDichVu.Text+"' đã được chọn.");
                    return;
                }
            }
            int num= lsvDichVu.Items.Count;
            lsvDichVu.Items.Add((num+1).ToString());
            lsvDichVu.Items[num].SubItems.Add(cbbDichVu.Text);
            lsvDichVu.Items[num].SubItems.Add(lblDonGiaDichVu.Text);
            lsvDichVu.Items[num].SubItems.Add(txtSoLuong_DichVu.Text);
            lsvDichVu.Items[num].SubItems.Add(txtGhiChuDichVu.Text);
        }

        private void btnPhieuDatBan_Click(object sender, EventArgs e)
        {
            btnPhieuDatDichVu.Enabled = true;
            btnPhieuDatMonAn.Enabled = false;
            pnlPhieuDichVu.Visible = false;
        }
        private void btnPhieuDatDichVu_Click(object sender, EventArgs e)
        {
            btnPhieuDatMonAn.Enabled = true;
            btnPhieuDatDichVu.Enabled = false;
            pnlPhieuDichVu.Visible = true;
        }

        private void llbBangSoBan_DichVu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSoLuong_DichVu.Text = txtSoLuongBanDat.Text;
        }

        //Mon an
        private void llbDonGiaChuan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llbBangSoBan_MonAn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvMonAn.Items.Count; i++)
            {
                if (lsvMonAn.Items[i].SubItems[1].Text == cbbMonAn.Text)
                {
                    MessageBox.Show("Món ăn '" + cbbMonAn.Text + "' đã được chọn.");
                    return;
                }
            }
            int num = lsvMonAn.Items.Count;
            lsvMonAn.Items.Add((num + 1).ToString());
            lsvMonAn.Items[num].SubItems.Add(cbbLoaiMonAn.Text);
            lsvMonAn.Items[num].SubItems.Add(cbbMonAn.Text);
            lsvMonAn.Items[num].SubItems.Add(txtDonGiaMonAn_YeuCau.Text);
            lsvMonAn.Items[num].SubItems.Add(txtSoBanDungMon.Text);
            lsvMonAn.Items[num].SubItems.Add(txtGhiChuMonAn.Text);
        }
        private void cbbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDonGiaDichVu.Text = BUS_DichVu.GetDonGia(cbbDichVu.Text);
            ptrDichVu.ImageLocation = @"DanhSachDichVu\" + BUS_DichVu.GetHinhAnh(cbbDichVu.Text);
            maDV = BUS_DichVu.GetMaDV(cbbDichVu.Text);
        }


        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonAn();
        }

        private void cbbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDonGiaMacDinh.Text = BUS_MonAn.GetDonGia(cbbMonAn.Text);
            ptrMonAn.ImageLocation = @"DanhSachMonAn\" + BUS_MonAn.GetHinhAnh(cbbMonAn.Text);
        }
        private void btnHuyPhieuDatBan_Click(object sender, EventArgs e)
        {
            lsvMonAn.Items.Clear();
        }

        private void btnHuyPhieuDichVu_Click(object sender, EventArgs e)
        {
            lsvDichVu.Items.Clear();
        }

        private void btnDatTiec_Click(object sender, EventArgs e)
        {
            if (lsvMonAn.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng lập danh sách món ăn");
                return;
            }
            if (lsvDichVu.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng lập danh sách dịch vụ");
                return;
            }
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin khách hàng.", false);
                return;
            }
            if (!BUS_KiemTraThongTin.KiemTraDienThoai(txtDienThoai.Text))
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra số điện thoại.", false);
                return;
            }
            if (!BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhChuRe.Text) || !BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhCoDau.Text))
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra năm sinh.", false);
                return;
            }


            if (txtTienDatCoc.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng thêm tiền đặt cọc.", false);
                return;
            }
            TinhTongTien();
            LapDanhSachDichVu();
            LapDanhSachMonAn();
            ThemKhachHang();
            ThemTiec();         
        }
        private void btnSuaTiec_Click(object sender, EventArgs e)
        {
            if (lsvMonAn.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng lập danh sách món ăn");
                return;
            }
            if (lsvDichVu.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng lập danh sách dịch vụ");
                return;
            }
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra thông tin khách hàng.", false);
                return;
            }
            if (!BUS_KiemTraThongTin.KiemTraDienThoai(txtDienThoai.Text))
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra số điện thoại.", false);
                return;
            }
            if (!BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhChuRe.Text) || !BUS_KiemTraThongTin.KiemTraNamSinh(txtNamSinhCoDau.Text))
            {
                ShowKetQua("Không thể thực hiện, vui lòng kiểm tra năm sinh.", false);
                return;
            }
            if (txtTienDatCoc.Text == "")
            {
                ShowKetQua("Không thể thực hiện, vui lòng thêm tiền đặt cọc.", false);
                return;
            }
            TinhTongTien();
            XoaTiec();
            LapDanhSachDichVu();
            LapDanhSachMonAn();
            ThemKhachHang();
            ThemTiec();
            
        }

        void XoaTiec()
        {
            BUS_KhachHang.DeleteKhachHang(lblThongTinMaKhachHang.Text);
            BUS_QuanLyTiecCuoi.DeleteTiecCuoi(lblThongTinMaTiec.Text);
        }

        void ThemKhachHang()
        {
            //Them
           
            DTO_KhachHang khachhang = new DTO_KhachHang(lblThongTinMaKhachHang.Text, txtTenChuRe.Text, txtNamSinhChuRe.Text, txtTenCoDau.Text, txtNamSinhCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);
            if (BUS_KhachHang.InsertKhachHang(khachhang))
            {
                //UpDateDataGridView();
                //dgvDanhSachKhachHang.ClearSelection();
                ShowKetQua("Thêm thành công khách hàng '" + khachhang.MaKH + "' !!", true);
            }
            else
                ShowKetQua("Thêm thất bại, vui lòng kiểm tra lại.", false);
        }

        void ThemTiec()
        {
            DTO_TiecCuoi tiecCuoi = new DTO_TiecCuoi();
            tiecCuoi.MaTC = lblThongTinMaTiec.Text;
            tiecCuoi.MaKH = lblThongTinMaKhachHang.Text;
            tiecCuoi.TenChuRe = txtTenChuRe.Text;
            tiecCuoi.NamSinhChuRe = int.Parse(txtNamSinhChuRe.Text);
            tiecCuoi.TenCoDau = txtTenCoDau.Text;
            tiecCuoi.NamSinhCoDau = int.Parse(txtNamSinhCoDau.Text);
            tiecCuoi.DienThoai = txtDienThoai.Text;
            tiecCuoi.DiaChi = txtDiaChi.Text;
            tiecCuoi.NgayDatTiec = dtpNgayDatTiec.Value;
            tiecCuoi.NgayDaiTiec = dtpNgayDatTiec.Value;       
            tiecCuoi.Ca = cbbCa.Text;
            tiecCuoi.Sanh = cbbSanh.Text;
            tiecCuoi.SoBan = int.Parse(txtSoLuongBanDat.Text);
            tiecCuoi.TongSoTien = decimal.Parse(lblTongTienTamTinh.Text);
            tiecCuoi.TienCoc = decimal.Parse(txtTienDatCoc.Text);
            tiecCuoi.GhiChu = txtGhiChuThongTinTiecCuoi.Text;
            tiecCuoi.MaNV = "NV01";

            if (BUS_NhanDatTiecCuoi.InsertTiecCuoi(tiecCuoi))
                ShowKetQua("Thêm thành công tiệc '"+lblThongTinMaTiec.Text+"' !!",true);
        }

        void LapDanhSachDichVu()
        {
            BUS_NhanDatTiecCuoi.DeletePhieuDatDichVu(lblThongTinMaTiec.Text);
            for (int i = 0; i < lsvDichVu.Items.Count; i++)
            {
                DTO_CT_PhieuDatDichVu ctDichVu = new DTO_CT_PhieuDatDichVu();
                ctDichVu.MaTiecCuoi = lblThongTinMaTiec.Text;
                ctDichVu.TenDichVu = lsvDichVu.Items[i].SubItems[1].Text;
                ctDichVu.DonGia = decimal.Parse(lsvDichVu.Items[i].SubItems[2].Text);
                ctDichVu.SoLuong = int.Parse(lsvDichVu.Items[i].SubItems[3].Text);
                ctDichVu.GhiChu = lsvDichVu.Items[i].SubItems[4].Text;
                BUS_NhanDatTiecCuoi.InsertChiTietDatDichVu(ctDichVu);

            }
        }

        void LapDanhSachMonAn()
        {
            //BUS_NhanDatTiecCuoi.DeletePhieuDatDichVu(lblThongTinMaTiec.Text);
            for (int i = 0; i < lsvMonAn.Items.Count; i++)
            {
                DTO_CT_PhieuDatBan ctMonAn = new DTO_CT_PhieuDatBan();
                ctMonAn.MaTiecCuoi = lblThongTinMaTiec.Text;
                ctMonAn.LoaiMonAn = lsvMonAn.Items[i].SubItems[1].Text;
                ctMonAn.TenMonAn = lsvMonAn.Items[i].SubItems[2].Text;
                ctMonAn.DonGia = decimal.Parse(lsvMonAn.Items[i].SubItems[3].Text);
                ctMonAn.SoLuong = int.Parse(lsvMonAn.Items[i].SubItems[4].Text);
                ctMonAn.GhiChu = "";
                BUS_NhanDatTiecCuoi.InsertChiTietDatBan(ctMonAn);
            }
        }

        #endregion

        

        void ShowKetQua(string skq, bool kq)
        {
            lbKetQua.Text = skq;
            if (kq) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

        private void btnLapPhieuDichVu_Click(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btnLapPhieuMonAn_Click(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtNamSinhChuRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamSinhCoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBanDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpNgayDaiTiec_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                cbbSanh.DataSource = BUS_QuanLyTiecCuoi.GetListSanhRanh(dtpNgayDaiTiec.Value.ToShortDateString(), cbbCa.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu sảnh. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }

        private void btnHuyTatCa_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Kiem tra nhap
        private void txtSoLuongDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoLuongDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong_DichVu.Text == "0") txtSoLuong_DichVu.Text = "";
        }
        private void txtSoLuongBanDat_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBanDat.Text == "0") txtSoLuongBanDat.Text = "";

            if (txtSoLuongBanDat.Text != "")
            {
                if (int.Parse(txtSoLuongBanDat.Text) > int.Parse(lblSoBanToiDa.Text))
                    txtSoLuongBanDat.Text = lblSoBanToiDa.Text;
                TinhTongTien();
            }
        }
        #endregion

        #endregion
    }
}