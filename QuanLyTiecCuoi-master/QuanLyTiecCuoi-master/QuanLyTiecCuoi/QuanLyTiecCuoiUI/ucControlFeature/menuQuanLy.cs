using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI.ucControlFeature
{
    public partial class menuQuanLy : UserControl
    {
        public menuQuanLy()
        {
            InitializeComponent();
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(btnTiepNhanSanh, "Tiếp nhận sảnh mới");
            myToolTip.SetToolTip(btnQuanLySanh, "Quản lý danh sách sảnh");
            myToolTip.SetToolTip(btnNhanDatTiecCuoi, "Nhận đặt tiệc cưới mới");
            myToolTip.SetToolTip(btnQuanLyTiecCuoi, "Quản lý danh sách tiệc cưới");
            myToolTip.SetToolTip(btnQuanLyMonAn, "Quản lý danh sách món ăn");
            myToolTip.SetToolTip(btnQuanLyDichVu, "Quản lý danh sách dịch vụ");
            myToolTip.SetToolTip(btnLapHoaDonThanhToan, "Lập hóa đơn thanh toán");
            myToolTip.SetToolTip(btnQuanLyLoaiSanh, "Quản lý loại sảnh tiệc cưới");
            myToolTip.SetToolTip(btnQuanLyCa, "Quản lý ca tiệc cưới");
            myToolTip.SetToolTip(btnQuanLyNhanVien, "Quản lý danh sách nhân viên");
        }
        private void menuQuanLy_Load(object sender, EventArgs e)
        {

        }
        public void ResetMenu(int roles)
        {
            if (roles == 1)
            {
                //nhân viên lễ tân - quản lý
                Button temp = new Button();
                temp.Location = btnTiepNhanSanh.Location;
                btnTiepNhanSanh.Location = btnNhanDatTiecCuoi.Location;
                btnNhanDatTiecCuoi.Location = temp.Location;

                temp.Location = btnQuanLySanh.Location;
                btnQuanLySanh.Location = btnQuanLyTiecCuoi.Location;
                btnQuanLyTiecCuoi.Location = temp.Location;
            }
            else
                if (roles == 2)
            {
                //Thu ngân - quản lý
                Button temp = new Button();
                temp.Location = btnTiepNhanSanh.Location;
                btnTiepNhanSanh.Location = btnLapHoaDonThanhToan.Location;
                btnLapHoaDonThanhToan.Location = temp.Location;
            }
            else
                if (roles == 3)
            {
                //Quản lý CSVC - quản lý 
                Button temp = new Button();

                temp.Location = btnNhanDatTiecCuoi.Location;
                btnNhanDatTiecCuoi.Location = btnQuanLyCa.Location;
                btnQuanLyCa.Location = temp.Location;

                temp.Location = btnNhanDatTiecCuoi.Location;
                btnNhanDatTiecCuoi.Location = btnQuanLyMonAn.Location;
                btnQuanLyMonAn.Location = temp.Location;

                temp.Location = btnQuanLyTiecCuoi.Location;
                btnQuanLyTiecCuoi.Location = btnQuanLyDichVu.Location;
                btnQuanLyDichVu.Location = temp.Location;

                temp.Location = btnLapHoaDonThanhToan.Location;
                btnLapHoaDonThanhToan.Location = btnQuanLyLoaiSanh.Location;
                btnQuanLyLoaiSanh.Location = temp.Location;

            }
            else
                if (roles == 4)
            {
                //Trưởng bộ phận nhà hàng - quản lý full options
            }
            else
                if (roles == 5)
            {
                //nhân viên phục vụ - no options choose
            }
        }
        public void LoadRoles(int roles)
        {
            if (roles == 1)
            {
                //nhân viên lễ tân - quản lý
                Button temp = new Button();
                temp.Location = btnTiepNhanSanh.Location;
                btnTiepNhanSanh.Location = btnNhanDatTiecCuoi.Location;
                btnNhanDatTiecCuoi.Location = temp.Location;

                temp.Location = btnQuanLySanh.Location;
                btnQuanLySanh.Location = btnQuanLyTiecCuoi.Location;
                btnQuanLyTiecCuoi.Location = temp.Location;
            }
            else
                if (roles == 2)
            {
                //Thu ngân - quản lý
                Button temp = new Button();
                temp.Location = btnTiepNhanSanh.Location;
                btnTiepNhanSanh.Location = btnLapHoaDonThanhToan.Location;
                btnLapHoaDonThanhToan.Location = temp.Location;
            }
            else
                if (roles == 3)
            {
                //Quản lý CSVC - quản lý 
                Button temp = new Button();
                temp.Location = btnNhanDatTiecCuoi.Location;
                btnNhanDatTiecCuoi.Location = btnQuanLyMonAn.Location;
                btnQuanLyMonAn.Location = temp.Location;

                temp.Location = btnQuanLyTiecCuoi.Location;
                btnQuanLyTiecCuoi.Location = btnQuanLyDichVu.Location;
                btnQuanLyDichVu.Location = temp.Location;

                temp.Location = btnLapHoaDonThanhToan.Location;
                btnLapHoaDonThanhToan.Location = btnQuanLyLoaiSanh.Location;
                btnQuanLyLoaiSanh.Location = temp.Location;

                temp.Location = btnNhanDatTiecCuoi.Location;
                btnNhanDatTiecCuoi.Location = btnQuanLyCa.Location;
                btnQuanLyCa.Location = temp.Location;
            }
            else
                if (roles == 4)
            {
                //Trưởng bộ phận nhà hàng - quản lý full options
            }
            else
                if (roles == 5)
            {
                //nhân viên phục vụ - no options choose
            }
        }

        private void btnTiepNhanSanh_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLySanh_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanDatTiecCuoi_Click(object sender, EventArgs e)
        {
        }

        private void btnQuanLyTiecCuoi_Click(object sender, EventArgs e)
        {
        }
    }
}
