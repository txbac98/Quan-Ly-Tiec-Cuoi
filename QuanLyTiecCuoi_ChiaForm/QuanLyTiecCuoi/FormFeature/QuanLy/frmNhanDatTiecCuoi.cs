﻿using System;
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
            
            //Load id khach hang
            KhachHangTable = BUS_KhachHang.GetDataTable();
            TiecTable = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
            maKH = GetNextID(KhachHangTable);
            maTiec = GetNextID(TiecTable);
        }

        private void frmNhanDatTiecCuoi_Load(object sender, EventArgs e)
        {
            SetupDefaultControlState();

            //LoadSanhAndCa();
            LoadCa();
            LoadSanh();
            LoadDichVu();
        }

       

        private void SetupDefaultControlState()
        {
            txtTenChuRe.Text = txtTenCoDau.Text = txtDienThoai.Text=txbNamSinhChuRe.Text=txbNamSinhCoDau.Text=txbDiaChi.Text = string.Empty;
            txtGhiChuThongTinTiecCuoi.Text = txtTienDatCoc.Text = string.Empty;
            lblGiaSanh.Text = string.Empty;
            btnDatTiec.Enabled = false;
            dtpNgayDatTiec.Value = DateTime.Now;
            dtpNgayDaiTiec.Value = DateTime.Now.AddDays(1);
        }

        private void cboCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            soLuongBanToiDa = BUS_QuanLySanh.GetSoLuongBanToiDa(cboSanh.Text);
            donGiaBan = BUS_QuanLySanh.GetDonGiaBanToiThieu(cboSanh.Text);
        }

        //private void LoadMonAn()
        //{
        //    dtMonAn = new DataTable();
        //    dtMonAn = BUS_MonAn.GetDataTableMonAn();
        //    cboDanhSachMonAn.DataSource = dtMonAn;
        //    cboDanhSachMonAn.DisplayMember = dtMonAn.Columns["TenMonAn"].ToString();
        //    cboDanhSachMonAn.ValueMember = dtMonAn.Columns["MaMonAn"].ToString();
        //    try
        //    {
        //        cboDanhSachMonAn.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
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

        //private void LoadSanhAndCa()
        //{
        //    try
        //    {
        //        DataTable result = BUS_NhanDatTiecCuoi.GetSanh();
        //        cboSanh.DataSource = result;
        //        cboSanh.ValueMember = result.Columns["MaSanh"].ToString();
        //        cboSanh.DisplayMember = result.Columns["TenSanh"].ToString();
        //        for (int i = 0; i < result.Rows.Count; i++)
        //        {
        //            lstGiaSanh.Add(Convert.ToDecimal(result.Rows[i][2].ToString()));
        //            lstSoLuongBanToiDaSanh.Add(Convert.ToInt32(result.Rows[i][3].ToString()));
        //        }
        //        result = BUS_NhanDatTiecCuoi.GetCa();
        //        cboCa.DataSource = result;
        //        cboCa.ValueMember = result.Columns["MaCa"].ToString();
        //        cboCa.DisplayMember = result.Columns["TenCa"].ToString();
        //        //Set start selected index and value đơn giá bàn tối thiểu
        //        try
        //        {
        //            cboSanh.SelectedIndex = 0;
        //            cboSanh.SelectedItem = 0;
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        lblGiaSanh.Text = lstGiaSanh[0].ToString();
        //        txtSoLuongBan.Text = lstSoLuongBanToiDaSanh[0].ToString();
        //        SoLuongBanToiDa = lstSoLuongBanToiDaSanh[0];
        //        grpThongTinBanAn.Text = "Đặt số bàn ăn - tối đa: " + SoLuongBanToiDa.ToString() + " bàn";
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        private void LoadSanh()
        {
            try
            {
                cboSanh.DataSource = BUS_QuanLySanh.GetListMaSanh();

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
                cboCa.DataSource = BUS_Ca.GetListCa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu sảnh. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }
    }
}