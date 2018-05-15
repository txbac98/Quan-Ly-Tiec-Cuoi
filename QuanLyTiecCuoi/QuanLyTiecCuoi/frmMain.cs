using BUS;
using DTO;
using QuanLyTiecCuoi.DAO;
using QuanLyTiecCuoi.KetNoiCSDL;
using QuanLyTiecCuoi.Nhan_Vien;
using QuanLyTiecCuoi.Tiec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI
{
    
    public partial class frmMain : Form
    {

        ConnectDatabase condb = new ConnectDatabase();

        public frmMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //condb.connect();

            //ShowData(dgvTiec, "Select * from TIECCUOI");

            if (DAO.DatabaseHelper.OpenConnection())
            {
                MessageBox.Show("Ket noi thanh cong");
            }
            else MessageBox.Show("Khong thanh cong");

            
        }

        


        #region DichVu
        void LoadDichVu()
        {

        }

        #endregion

        #region Quan Ly Ca, Sanh

        //Phan chung

        private void tpTimCa_Click(object sender, EventArgs e)
        {

        }

        private void btCa_Click(object sender, EventArgs e)
        {
          
        }

        private void btSanh_Click(object sender, EventArgs e)
        {
            LoadDuLieuSanh();
            tcQuanLySanh.Visible = true;
            
        }

       

        
    


        #region QuanLySanh

        int swich=0;

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1) 
            {
                int numrow;
                numrow = e.RowIndex;
                if (swich == 0)
                {
                    NapDuLieuSanh(numrow);
                }
                else NapDuLieuLoaiSanh(numrow);
            }
            
        }
        void NapDuLieuSanh(int numrow)
        {

                txtTenSanh.Text = dgvQuanLy.Rows[numrow].Cells[1].Value.ToString();
                cbbLoaiSanh.Text = dgvQuanLy.Rows[numrow].Cells[2].Value.ToString();
                cbbDonGiaBanTT.Text = dgvQuanLy.Rows[numrow].Cells[3].Value.ToString();
                txtSoLuongBanTD.Text = dgvQuanLy.Rows[numrow].Cells[4].Value.ToString();
                txtGhiChu.Text = dgvQuanLy.Rows[numrow].Cells[5].Value.ToString();
            
        }
        void NapDuLieuLoaiSanh(int numrow)
        {
            txtTenLoaiSanh.Text = dgvQuanLy.Rows[numrow].Cells[1].Value.ToString();
            txtDonGiaBanTT.Text = dgvQuanLy.Rows[numrow].Cells[2].Value.ToString();
        }

        private void tcQuanLySanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcQuanLySanh.SelectedIndex == 0)
            {
                swich = 0;
                LoadDuLieuSanh();
            }
            else

            {
                swich = 1;
                LoadDuLieuLoaiSanh();
            }
        }


        private const int MaxSLBanToiDa = 300;
        
        void KhoiTao()
        {
            

            //myToolTip.SetToolTip(txtSoLuongBanTD, "Số lượng bàn tối đa từ 1 đến " + MaxSLBanToiDa);
            //myToolTip.SetToolTip(lblSoLuongBanTD, "Số lượng bàn tối đa từ 1 đến " + MaxSLBanToiDa);
            //txtSoLuongBanTD.TextChanged += txtSoLuongBanTD_TextChanged;
            //txtTenSanh.TextChanged += txtTenSanh_TextChanged;
            //txtGhiChu.TextChanged += txtGhiChu_TextChanged;
        }
        void LoadDuLieuSanh()
        {
            BUS_ThongTinKhachHang.Init();
            //SetDisplayControls(MODE.NORMAL);

            
            dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();

            dgvQuanLy.Columns[0].Visible = false;
            dgvQuanLy.Columns[1].HeaderText = "Tên sảnh";
            dgvQuanLy.Columns[2].HeaderText = "Loại sảnh";
            dgvQuanLy.Columns[3].HeaderText = "Số lượng bàn tối đa";
            dgvQuanLy.Columns[4].HeaderText = "Đơn giá bàn tối thiểu";
            dgvQuanLy.Columns[5].HeaderText = "Ghi chú";

            if (BUS_ThongTinKhachHang.mIsLoaiSanhDataEmpty)
            {
                MessageBox.Show("Không có dữ liệu loại sảnh, vui lòng kiểm tra");
            }
            else
            {
                
                cbbLoaiSanh.DataSource = BUS_ThongTinKhachHang.GetListTenLoaiSanh();
                cbbDonGiaBanTT.DataSource = BUS_ThongTinKhachHang.GetListDonGiaBanTT();
            }
            

            
        }

        void XoaDuLieuNhapSanh()
        {
            txtTenSanh.Text = "";
            txtSoLuongBanTD.Text = "";
            txtGhiChu.Text = "";
            cbbLoaiSanh.SelectedIndex = 0;
        }

        private void txtTenSanh_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == " ") txtTenSanh.Text = "";
            else
            {
                //dgvQuanLy.DataSource= BUS_QuanLySanh.SearchSanhTableTheoTen(txtTenSanh.Text);

            }
        }

        bool KiemTraDuLieuNhapSanh()
        {
            if (txtTenSanh.Text == "") return false;
            if (txtSoLuongBanTD.Text == "") return false;
            int temp;
            if (!int.TryParse(txtSoLuongBanTD.Text, out temp))
            {
                MessageBox.Show("'Số lượng bàn tối đa phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongBanTD.Focus();
                txtSoLuongBanTD.SelectAll();
                return false;
            }
            return true;
        }

       
        private void btnThemSanh_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhapSanh())
            {
                int maloaiSanh = int.Parse(BUS_ThongTinKhachHang.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);
                DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
                if (BUS_ThongTinKhachHang.InsertSanh(sanh))
                {
                    ShowKetQua("Thêm thành công sảnh '" + sanh.MaKH + "' !!", true);
                }
                else
                {
                    ShowKetQua("Sảnh '" +sanh.MaKH+ "' đã tồn tại !!", false);
                }
                dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();
                XoaDuLieuNhapSanh();
            }
            else ShowKetQua("Vui lòng nhập đầy đủ thông tin",false);
                
            //SetDisplayControls(MODE.NORMAL);           
        }
        private void btnSuaSanh_Click(object sender, EventArgs e)
        {
            int maloaiSanh = int.Parse(BUS_ThongTinKhachHang.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);
            DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
            sanh.maSanh = int.Parse(dgvQuanLy.CurrentRow.Cells["MaSanh"].Value.ToString());
            BUS_ThongTinKhachHang.UpdateSanh(sanh);
            dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();
            lbKetQua.Text = "Sửa thành công sảnh '" + sanh.MaKH + "' !!";
            lbKetQua.ForeColor = Color.Green;

            XoaDuLieuNhapSanh();
            //SetDisplayControls(MODE.NORMAL);
            //mCurrentMode = MODE.NORMAL;
        }

        private void btnXoaSanh_Click(object sender, EventArgs e)
        {
            dgvQuanLy.Focus();
            string tenSanh = dgvQuanLy.CurrentRow.Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa sảnh '" + tenSanh + "' không?", "Xóa sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int i = dgvQuanLy.CurrentCell.RowIndex;
                DTO_Sanh sanh = new DTO_Sanh();
                sanh.maSanh = int.Parse(dgvQuanLy.CurrentRow.Cells["MaSanh"].Value.ToString());
                BUS_ThongTinKhachHang.DeleteSanh(sanh);
                dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();
                
                lbKetQua.Text = "Xóa thành công sảnh '" + sanh.MaKH + "' !!";
                XoaDuLieuNhapSanh();
            }
        }



        #endregion


        #region QuanLyLoaiSanh

        void LoadDuLieuLoaiSanh()
        {
            //SetDisplayControls(MODE.AT_HOME);
            dgvQuanLy.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            dgvQuanLy.Columns["MaLoaiSanh"].Visible = false;
            dgvQuanLy.Columns["TenLoaiSanh"].HeaderText = "Tên loại sảnh";
            dgvQuanLy.Columns["DonGiaBanToiThieu"].HeaderText = "Đơn giá bàn tối thiểu";
            
        }
        void XoaDuLieuNhapLoaiSanh()
        {
            txtTenLoaiSanh.Text = "";
            txtDonGiaBanTT.Text = "";
        }


        private void txtTenLoaiSanh_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLoaiSanh.Text == " ") txtTenLoaiSanh.Text = "";
            else
            {
                dgvQuanLy.DataSource = BUS_QuanLyLoaiSanh.SearchLoaiSanhTable(txtTenLoaiSanh.Text);

            }
        }

        private void btThemLoaiSanh_Click(object sender, EventArgs e)
        {
            
            DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtTenLoaiSanh.Text, decimal.Parse(txtDonGiaBanTT.Text));
            
            if (BUS_QuanLyLoaiSanh.InsertLoaiSanh(loaiSanh))
            {
                
                dgvQuanLy.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                XoaDuLieuNhapLoaiSanh();
                MessageBox.Show("Thêm loại sảnh '" + loaiSanh.tenLoaiSanh + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //SetDisplayControls(MODE.AT_HOME);
                //mCurrentMode = MODE.AT_HOME;
            }
            else
            {
                MessageBox.Show("Loại sảnh '" + loaiSanh.tenLoaiSanh + "' đã tồn tại. Vui lòng sửa lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiSanh.Focus();
                txtTenLoaiSanh.SelectAll();
            }
        }




        #endregion

        #endregion


        //Hien ket qua
        void ShowKetQua(string skq, bool kq)
        {
            lbKetQua.Text = skq;
            if (kq == true) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

        private void tpQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void btDatTiec_Click(object sender, EventArgs e)
        {

        }

        private void btDanhSachTiec_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tpDichVu_Click(object sender, EventArgs e)
        {

        }

        private void lblMaKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void lbTenDichVu_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDichVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btChucVu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void grpThongTinKhachHang_Enter(object sender, EventArgs e)
        {

        }

        private void tpKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btSuaLoaiSanh_Click(object sender, EventArgs e)
        {

        }

        private void btXoaLoaiSanh_Click(object sender, EventArgs e)
        {

        }

        #region KhachHang
       
    
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
                int numrow;
                numrow = e.RowIndex;
                NapDuLieuKhachHang(numrow);              
        }

        void NapDuLieuKhachHang(int numrow)
        {
            txtMaKhachHang.Text = dgvKhachHang.Rows[numrow].Cells[1].Value.ToString();
            txtTenChuRe.Text = dgvKhachHang.Rows[numrow].Cells[2].Value.ToString();
            txtTenCoDau.Text = dgvKhachHang.Rows[numrow].Cells[3].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[numrow].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[numrow].Cells[5].Value.ToString();
        }

        private void grpThongTinKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        { 
                LoadDuLieuSanh();                   
        }

        void LoadDuLieuKhachHang()
        {
            BUS_ThongTinKhachHang.Init();
            //SetDisplayControls(MODE.NORMAL);


            dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();

            dgvKhachHang.Columns[0].Visible = false;
            dgvKhachHang.Columns[1].HeaderText = "Mã Khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Tên chú rể";
            dgvKhachHang.Columns[3].HeaderText = "Tên cô dâu";
            dgvKhachHang.Columns[4].HeaderText = "Địa chỉ";
           

            if (BUS_ThongTinKhachHang.mIsLoaiSanhDataEmpty)
            {
                MessageBox.Show("Không có dữ liệu khách hàng, vui lòng kiểm tra");
            }
            //else
            //{

            //    cbbLoaiSanh.DataSource = BUS_ThongTinKhachHang.GetListTenLoaiSanh();
            //    cbbDonGiaBanTT.DataSource = BUS_ThongTinKhachHang.GetListDonGiaBanTT();
            //}
        }

        void XoaDuLieuNhapKhachHang()
        {
            txtMaKhachHang.Text = "";
            txtTenChuRe.Text = "";
            txtTenCoDau.Text = "";
            txtDienThoai.Text="";
            txtDiaChi.Text = "";
        }
        bool KiemTraDuLieuNhapKhachHang()
        {
            if (txtMaKhachHang.Text == "") return false;
            if (txtTenChuRe.Text == "") return false;
            if (txtTenCoDau.Text == "") return false;            
            if (txtDiaChi.Text == "") return false;            
            int temp;
            if (!int.TryParse(txtDienThoai.Text, out temp))
            {
                MessageBox.Show("'Số điện thoại phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                txtDienThoai.SelectAll();
                return false;
            }
            return true;
        }


        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == " ") txtMaKhachHang.Text = "";
            else
            {
                //dgvQuanLy.DataSource= BUS_QuanLySanh.SearchSanhTableTheoTen(txtTenSanh.Text);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhapKhachHang())
            {              
                DTO_KhachHang khachhang = new DTO_KhachHang(txtMaKhachHang.Text, txtTenChuRe.Text, txtTenCoDau.Text, txtDienThoai.Text,txtDiaChi.Text);
                if (BUS_ThongTinKhachHang.InsertThongTinKhachHang(khachhang))
                {
                    ShowKetQua("Thêm thành công khách hàng '" + khachhang.MaKH + "' !!", true);
                }
                else
                {
                    ShowKetQua("Mã khách hàng '" + khachhang.MaKH + "' đã tồn tại !!", false);
                }
                dgvKhachHang.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();
                XoaDuLieuNhapSanh();
            }
            else ShowKetQua("Vui lòng nhập đầy đủ thông tin", false);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DTO_KhachHang khachhang = new DTO_KhachHang(txtMaKhachHang.Text, txtTenChuRe.Text, txtTenCoDau.Text, txtDienThoai.Text, txtDiaChi.Text);
            khachhang.MaKH = int.Parse(dgvKhachHang.CurrentRow.Cells["tenSanh"].Value.ToString());
            BUS_ThongTinKhachHang.UpdateKhachHang(khachhang);
            dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();
            lbKetQua.Text = "Sửa thành công khách hàng '" + khachhang.MaKH + "' !!";
            lbKetQua.ForeColor = Color.Green;

            XoaDuLieuNhapKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvKhachHang.Focus();
            string tenSanh = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng '" + tenSanh + "' không?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int i = dgvKhachHang.CurrentCell.RowIndex;
                DTO_KhachHang khachhang = new DTO_Sanh();
                khachhang.MaKH = int.Parse(dgvKhachHang.CurrentRow.Cells["MaSanh"].Value.ToString());
                BUS_ThongTinKhachHang.DeleteSanh(khachhang);
                dgvQuanLy.DataSource = BUS_ThongTinKhachHang.GetQLKhachHangTable();

                lbKetQua.Text = "Xóa thành công sảnh '" + khachhang.MaKH + "' !!";
                XoaDuLieuNhapSanh();
            }
    }
}



        #endregion
       