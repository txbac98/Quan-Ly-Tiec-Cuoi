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
            BUS_QuanLySanh.Init();
            //SetDisplayControls(MODE.NORMAL);

            
            dgvQuanLy.DataSource = BUS_QuanLySanh.GetQLSanhTable();

            dgvQuanLy.Columns[0].Visible = false;
            dgvQuanLy.Columns[1].HeaderText = "Tên sảnh";
            dgvQuanLy.Columns[2].HeaderText = "Loại sảnh";
            dgvQuanLy.Columns[3].HeaderText = "Số lượng bàn tối đa";
            dgvQuanLy.Columns[4].HeaderText = "Đơn giá bàn tối thiểu";
            dgvQuanLy.Columns[5].HeaderText = "Ghi chú";

            if (BUS_QuanLySanh.mIsLoaiSanhDataEmpty)
            {
                MessageBox.Show("Không có dữ liệu loại sảnh, vui lòng kiểm tra");
            }
            else
            {
                
                cbbLoaiSanh.DataSource = BUS_QuanLySanh.GetListTenLoaiSanh();
                cbbDonGiaBanTT.DataSource = BUS_QuanLySanh.GetListDonGiaBanTT();
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
                MessageBox.Show("'Số lượng bàn tối đa' phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int maloaiSanh = int.Parse(BUS_QuanLySanh.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);

                DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);


                if (BUS_QuanLySanh.InsertSanh(sanh))
                {
                    ShowKetQua("Thêm thành công sảnh '" + sanh.tenSanh + "' !!", true);

                }
                else
                {
                    ShowKetQua("Sảnh '" +sanh.tenSanh+ "' đã tồn tại !!", false);
                }
                dgvQuanLy.DataSource = BUS_QuanLySanh.GetQLSanhTable();



                XoaDuLieuNhapSanh();
            }
            else ShowKetQua("Vui lòng nhập đầy đủ thông tin",false);
                
            //SetDisplayControls(MODE.NORMAL);
            
        }

        private void btnSuaSanh_Click(object sender, EventArgs e)
        {
            int maloaiSanh = int.Parse(BUS_QuanLySanh.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);
            DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
            sanh.maSanh = int.Parse(dgvQuanLy.CurrentRow.Cells["MaSanh"].Value.ToString());
            BUS_QuanLySanh.UpdateSanh(sanh);

            dgvQuanLy.DataSource = BUS_QuanLySanh.GetQLSanhTable();

            lbKetQua.Text = "Sửa thành công sảnh '" + sanh.tenSanh + "' !!";
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
                BUS_QuanLySanh.DeleteSanh(sanh);
                dgvQuanLy.DataSource = BUS_QuanLySanh.GetQLSanhTable();
                
                lbKetQua.Text = "Xóa thành công sảnh '" + sanh.tenSanh + "' !!";
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

        void ShowKetQua(string skq, bool kq)
        {
            lbKetQua.Text = skq;
            if (kq == true) lbKetQua.ForeColor = Color.Green;
            else lbKetQua.ForeColor = Color.Red;
        }

        
    }
}
