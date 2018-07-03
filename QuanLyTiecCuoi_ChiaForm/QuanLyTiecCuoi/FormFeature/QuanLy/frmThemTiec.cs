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
using System.IO;
namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmThemTiec : Form
    {
        string maNV, tenNV;
        public frmThemTiec()
        {
            InitializeComponent();
            BUS_Ca.Init();
            BUS_QuanLySanh.Init();
        }

        private void frmThemTiec_Load(object sender, EventArgs e)
        {
            LoadCa();
            LoadSanh();
        }
        public void SetTaiKhoan(string maNhanVien, string tenNhanVien)
        {
            maNV = maNhanVien;
            tenNV = tenNhanVien;
        }
        private void LoadSanh()
        {
            try
            {
                cbbSanh.DataSource =  BUS_QuanLyTiecCuoi.GetListSanhRanh(dtpNgayDaiTiec.Value.ToShortDateString(),cbbCa.Text);

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

        private void dtpNgayDaiTiec_ValueChanged(object sender, EventArgs e)
        {
            LoadSanh();
        }

        private void cbbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSanh();
        }

        private void btnDatTiec_Click(object sender, EventArgs e)
        {
            frmNhanDatTiecCuoi frmNDTC = new frmNhanDatTiecCuoi();
            frmNDTC.Show();
            frmNDTC.frmSetDataTiec(dtpNgayDaiTiec, cbbCa.Text, cbbSanh.Text);
            frmNDTC.SetTaiKhoan(maNV, tenNV);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
