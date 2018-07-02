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

namespace QuanLyTiecCuoiUI.FormFeature.QuanLy
{
    public partial class frmDoiMatKhau : Form
    {
        public string taiKhoan, matKhau;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMatKhauHienTai.Text=="" || txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin.");
                return;
            }
            DTO_DangNhap dangNhap = new DTO_DangNhap(taiKhoan,matKhau);
            if (BUS_QuanLyTaiKhoan.KiemTraDangNhap(dangNhap))
            {
                if (BUS_QuanLyTaiKhoan.DoiMatKhau(taiKhoan, txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công.");
                    this.Close();
                }
                    
                else MessageBox.Show("Đổi mật khẩu không thành công");
            }
        }

        public void DangNhap(string TaiKhoan, string MatKhau)
        {
            taiKhoan = TaiKhoan;
            matKhau = MatKhau;
          
        }

    }
}
