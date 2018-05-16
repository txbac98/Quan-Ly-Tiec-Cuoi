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

namespace QuanLyTiecCuoiUI
{
    public partial class frmLapBaoCaoThang : Form
    {
        private List<int> mThangs = new List<int>();
        private List<int> mNams = new List<int>();

        private List<List<string>> mListMonths;

        private int mThang;
        private int mNam;
        public frmLapBaoCaoThang()
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                mThangs.Add(i);
            }

            for (int i = 2010; i < 2020; i++)
            {
                mNams.Add(i);
            }
        }

        private void frmLapBaoCaoThang_Load(object sender, EventArgs e)
        {
           
            
            cbbNam.DataSource = mNams;
            cbbThang.DataSource = mThangs;

            DateTime toDay = DateTime.Now;
            int mounth = toDay.Month;
            int year = toDay.Year;

            cbbThang.SelectedIndex = mounth - 1;
            cbbNam.SelectedIndex = year - mNams[0];

        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbbThang_SelectedIndexChanged");
            mThang = int.Parse(cbbThang.Text);
            if (!btnLapBaoCao.Enabled)
                btnLapBaoCao.Enabled = true;
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnLapBaoCao.Enabled)
                btnLapBaoCao.Enabled = true;
            Console.WriteLine("cbbNam_SelectedIndexChanged");
            mNam = int.Parse(cbbNam.Text);
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            btnLapBaoCao.Enabled = false;
            if (dgvBaoCaoChiTiet.DataSource != null)
                dgvBaoCaoChiTiet.DataSource = new DataTable();
            if (BUS.BUS_BaoCaoThang.CheckExistBaoCaoThang(mThang, mNam))
            {
                int maBCT = BUS.BUS_BaoCaoThang.GetMaBCT(mThang, mNam);
                decimal tongDoanhThu = BUS.BUS_BaoCaoThang.GetDoanhThuThang(maBCT);
                lblTongDoanhThu.Text = ConvertStringToCurrency(tongDoanhThu);
                int tongSoLuongTiecCuoi = BUS.BUS_BaoCaoThang.GetTongSoTiecCuoi(maBCT);
                lblTongSoTiecCuoi.Text = tongSoLuongTiecCuoi.ToString();
                dgvBaoCaoChiTiet.DataSource = BUS.BUS_BaoCaoNgay.GetAllBaoCaoNgay(maBCT);
                DTO.DTO_BaoCaoThang baoCaoThang = new DTO.DTO_BaoCaoThang();
                baoCaoThang.MaBCT = maBCT;
                baoCaoThang.Thang = mThang;
                baoCaoThang.Nam = mNam;
                baoCaoThang.TongSoLuongTiecCuoi = tongSoLuongTiecCuoi;
                baoCaoThang.TongDoanhThu = tongDoanhThu;
                BUS.BUS_BaoCaoThang.UpdateBaoCaoThang(baoCaoThang);

                dgvBaoCaoChiTiet.Columns["Ngay"].HeaderText = "Ngày";
                dgvBaoCaoChiTiet.Columns["SoLuongTiecCuoi"].HeaderText = "Số lượng tiệc cưới";
                dgvBaoCaoChiTiet.Columns["DoanhThu"].HeaderText = "Doanh thu";
                dgvBaoCaoChiTiet.Columns["TiLe"].HeaderText = "Tỉ lệ";
                
            }
            else
            {
                lblTongSoTiecCuoi.Text = "0";
                lblTongDoanhThu.Text = "0";
            }  
        }


        private string ConvertStringToCurrency(decimal value)
        {
            //return String.Format("{0:c}", value);
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(info, "{0:c}", value);
        }

       
    }
}
