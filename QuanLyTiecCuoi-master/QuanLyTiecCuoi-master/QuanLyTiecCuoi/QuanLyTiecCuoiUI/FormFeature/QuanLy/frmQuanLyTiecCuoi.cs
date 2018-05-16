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
    public partial class frmQuanLyTiecCuoi : Form
    {
        private List<string> mListCa = new List<string>();
        private List<string> mListSanh = new List<string>();
        private Size NORMAL_SIZE = new Size(773, 586);
        private Size EXTEND_SIZE = new Size(1081, 586);
        private const string MONAN_FOLDER_NAME = "DanhSachMonAn";
        private const string DICHVU_FOLDER_NAME = "DanhSachDichVu";
        private bool mPanelBanAnIsOpen = false;
        private bool mPanelDichVuIsOpen = false;
        private bool mPhieuBanAnIsEdited = false;
        private bool mPhieuDichVuIsEdited = false;
        private int mRowClickedMonAn = 0;
        private int mRowClickedDichVu = 0;
        private string mMaMonAn = "";
        private string mMaDichVu = "";
        private const decimal PHANTRAM_TIENCOC = 0.3M;
        private int mThemOrSuaMonAn = 0; // Them=1, Sua=2
        private int mThemOrSuaDichVu = 0; // Them=1, Sua=2

        public frmQuanLyTiecCuoi()
        {
            InitializeComponent();
        }
        private void EnableAllInputs(bool yes)
        {
            txtTenChuRe.ReadOnly = txtTenCoDau.ReadOnly = txtDienThoai.ReadOnly
                = txtTienDatCoc.ReadOnly = txtGhiChuThongTinTiecCuoi.ReadOnly = !yes;

            dtpNgayDaiTiec.Enabled = cboCa.Enabled = cboSanh.Enabled = yes;
        }
        private void ClearAllInputs()
        {
            txtTenChuRe.Text = txtTenCoDau.Text = txtDienThoai.Text = txtTienDatCoc.Text = txtGhiChuThongTinTiecCuoi.Text = "";
            cboCa.SelectedItem = cboSanh.SelectedItem = null;
            lblDonGiaBanTT.Text = lblTenNhanVien.Text = "-";
        }
        private void frmQuanLyTiecCuoi_Load(object sender, EventArgs e)
        {
            // Khoi tao BUS
            BUS_QuanLyTiecCuoi.Init();

            // Dong right panel
            this.Size = NORMAL_SIZE;

            // Dong cac input
            EnableAllInputs(false);

            // Cai dat hien thi datagridview Danh sach tiec cuoi
            dgvDanhSachTiecCuoi.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
            dgvDanhSachTiecCuoi.Columns["TenChuRe"].HeaderText = "Tên chú rể";
            dgvDanhSachTiecCuoi.Columns["TenCoDau"].HeaderText = "Tên cô dâu";
            dgvDanhSachTiecCuoi.Columns["TenSanh"].HeaderText = "Sảnh";
            dgvDanhSachTiecCuoi.Columns["NgayDaiTiec"].HeaderText = "Ngày đãi tiệc";
            dgvDanhSachTiecCuoi.Columns["NgayDaiTiec"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDanhSachTiecCuoi.Columns["SoBan"].HeaderText = "Số bàn";
            dgvDanhSachTiecCuoi.Columns["MaTiecCuoi"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["DienThoai"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["NgayDatTiec"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["TenCa"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["DonGiaBanToiThieu"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["TienCoc"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["GhiChu"].Visible = false;
            dgvDanhSachTiecCuoi.Columns["TenNV"].Visible = false;

            // Dong cac button
            btnSuaTiec.Enabled = btnLuuTiec.Enabled = btnHuy.Enabled = btnXoaTiec.Enabled
                = linkSuaPhieuBanAn.Enabled = linkSuaPhieuDichVu.Enabled = false;

            // Load data vao cac combobox: Ca, Sanh, Mon an, Dich vu
            cboCa.DataSource = BUS_QuanLyTiecCuoi._ListTenCa;
            cboSanh.DataSource = BUS_QuanLyTiecCuoi._ListTenSanh;
            //cboDanhSachMonAn.DataSource = BUS_QuanLyTiecCuoi._ListTenMonAn;
            //cboDanhSachDichVu.DataSource = BUS_QuanLyTiecCuoi._ListTenDichVu;
            //cboDanhSachMonAn.SelectedItem = cboDanhSachDichVu.SelectedItem = 
            cboCa.SelectedItem = cboSanh.SelectedItem = null;
        }

        private void linkSuaPhieuBanAn_Click(object sender, EventArgs e)
        {
            //if (mPanelBanAnIsOpen)
            //{
            //    mPanelBanAnIsOpen = false;
            //    this.Size = NORMAL_SIZE;
            //    //linkSuaPhieuBanAn.Text = "Sửa >>";
            //    return;
            //}

            //if (!mPanelBanAnIsOpen && !mPanelDichVuIsOpen)
            //{
            //    this.Size = EXTEND_SIZE;
            //    pnlPhieuBanAn.Visible = true;
            //    pnlPhieuDichVu.Visible = false;
            //    //linkSuaPhieuBanAn.Text = "Sửa <<";
            //}
            //else if (mPanelDichVuIsOpen)
            //{
            //    this.Size = EXTEND_SIZE;
            //    pnlPhieuBanAn.Visible = true;
            //    pnlPhieuDichVu.Visible = false;
            //    //linkSuaPhieuBanAn.Text = "Sửa <<";
            //    //linkSuaPhieuDichVu.Text = "Sửa >>";
            //}
            this.Size = EXTEND_SIZE;
            pnlPhieuBanAn.Visible = true;
            pnlPhieuDichVu.Visible = false;
            mPanelBanAnIsOpen = true;
            mPanelDichVuIsOpen = false;
            pnlLeft.Enabled = false;
        }

        private void linkSuaPhieuDichVu_Click(object sender, EventArgs e)
        {
            //if (mPanelDichVuIsOpen)
            //{
            //    mPanelDichVuIsOpen = false;
            //    this.Size = NORMAL_SIZE;
            //    //linkSuaPhieuDichVu.Text = "Sửa >>";
            //    return;
            //}

            //if (!mPanelBanAnIsOpen && !mPanelDichVuIsOpen)
            //{
            //    this.Size = EXTEND_SIZE;
            //    pnlPhieuDichVu.Visible = true;
            //    pnlPhieuBanAn.Visible = false;
            //    //linkSuaPhieuDichVu.Text = "Sửa <<";
            //}
            //else if (mPanelBanAnIsOpen)
            //{
            //    this.Size = EXTEND_SIZE;
            //    pnlPhieuDichVu.Visible = true;
            //    pnlPhieuBanAn.Visible = false;
            //    //linkSuaPhieuDichVu.Text = "Sửa <<";
            //    //linkSuaPhieuBanAn.Text = "Sửa >>";
            //}
            this.Size = EXTEND_SIZE;
            pnlPhieuDichVu.Visible = true;
            pnlPhieuBanAn.Visible = false;
            mPanelDichVuIsOpen = true;
            mPanelBanAnIsOpen = false;
            pnlLeft.Enabled = false;
        }

        private void dgvDanhSachTiecCuoi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachTiecCuoi.ClearSelection();
        }

        private void dgvDanhSachTiecCuoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Load data vao cac input
            int selectedRow = e.RowIndex;
            if (selectedRow == -1) return;
            txtTenChuRe.Text = dgvDanhSachTiecCuoi["TenChuRe", selectedRow].Value.ToString();
            txtTenCoDau.Text = dgvDanhSachTiecCuoi["TenCoDau", selectedRow].Value.ToString();
            txtDienThoai.Text = dgvDanhSachTiecCuoi["DienThoai", selectedRow].Value.ToString();
            lblDonGiaBanTT.Text = dgvDanhSachTiecCuoi["DonGiaBanToiThieu", selectedRow].Value.ToString();
            txtTienDatCoc.Text = dgvDanhSachTiecCuoi["TienCoc", selectedRow].Value.ToString();
            txtGhiChuThongTinTiecCuoi.Text = dgvDanhSachTiecCuoi["GhiChu", selectedRow].Value.ToString();
            dtpNgayDatTiec.Value = DateTime.Parse(dgvDanhSachTiecCuoi["NgayDatTiec", selectedRow].Value.ToString());
            dtpNgayDaiTiec.Value = DateTime.Parse(dgvDanhSachTiecCuoi["NgayDaiTiec", selectedRow].Value.ToString());
            cboCa.SelectedIndex = cboCa.Items.IndexOf(dgvDanhSachTiecCuoi.CurrentRow.Cells["TenCa"].Value.ToString());
            cboSanh.SelectedIndex = cboSanh.Items.IndexOf(dgvDanhSachTiecCuoi.CurrentRow.Cells["TenSanh"].Value.ToString());
            lblTenNhanVien.Text = dgvDanhSachTiecCuoi["TenNV", selectedRow].Value.ToString();

            // Load data vao Phieu ban an
            string maTiecCuoi = dgvDanhSachTiecCuoi["MaTiecCuoi", selectedRow].Value.ToString();
            string soLuongBan, soLuongBanDuTru;
            DataTable danhSachMonAn;
            BUS_QuanLyTiecCuoi.GetDataPhieuBanAn(maTiecCuoi, out soLuongBan, out soLuongBanDuTru, out danhSachMonAn);
            txtSoLuongBan.Text = soLuongBan;
            txtSoLuongBanDuTru.Text = soLuongBanDuTru;
            dgvDanhSachMonAn.DataSource = danhSachMonAn;
            dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDanhSachMonAn.Columns["DonGiaTT"].HeaderText = "Đơn giá thực tế";
            dgvDanhSachMonAn.Columns["MaMonAn"].Visible = false;
            lblSoMonAn.Text = dgvDanhSachMonAn.RowCount.ToString();

            // Load data vao Phieu dich vu
            dgvDanhSachDichVu.DataSource = BUS_QuanLyTiecCuoi.GetDataPhieuDichVu(maTiecCuoi);
            dgvDanhSachDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDanhSachDichVu.Columns["DonGiaTT"].HeaderText = "Đơn giá thực tế";
            dgvDanhSachDichVu.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachDichVu.Columns["MaDichVu"].Visible = false;
            lblSoDichVu.Text = dgvDanhSachDichVu.RowCount.ToString();


            // Mo cac button Sua Tiec, Xoa Tiec
            btnSuaTiec.Enabled = btnXoaTiec.Enabled = true;
        }

        private void btnSuaTiec_Click(object sender, EventArgs e)
        {
            // Mo cac input
            EnableAllInputs(true);

            // Dong, mo cac button, link
            btnSuaTiec.Enabled = btnXoaTiec.Enabled = false;
            btnLuuTiec.Enabled = btnHuy.Enabled = true;
            linkSuaPhieuBanAn.Enabled = linkSuaPhieuDichVu.Enabled = true;
            dgvDanhSachTiecCuoi.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hoi xac nhan co muon huy khong
            DialogResult dr = MessageBox.Show("Dữ liệu sẽ không được lưu, bạn có muốn hủy không?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            // Da xac nhan, tien hanh Huy
            ClearAllInputs();
            EnableAllInputs(false);
            btnLuuTiec.Enabled = btnHuy.Enabled = linkSuaPhieuBanAn.Enabled = linkSuaPhieuDichVu.Enabled = false;
            dgvDanhSachTiecCuoi.Enabled = true;
            dgvDanhSachTiecCuoi.ClearSelection();
            lblSoMonAn.Text = lblSoDichVu.Text = "--";

            this.Size = NORMAL_SIZE;
            //linkSuaPhieuBanAn.Text = linkSuaPhieuDichVu.Text = "Sửa >>";
        }

        private bool CheckEmptyTextBoxAndFocus()
        {
            if (txtTenChuRe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục (*).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuRe.Focus();
                return false;
            }
            if (txtTenCoDau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục (*).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCoDau.Focus();
                return false;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục (*).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }
            if (txtTienDatCoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục (*).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienDatCoc.Focus();
                return false;
            }

            return true;
        }

        private void btnLuuTiec_Click(object sender, EventArgs e)
        {
            // Kiem tra dieu kien truoc khi luu tiec cuoi
            // 1. Kiem tra textbox rong va focus
            if (!CheckEmptyTextBoxAndFocus())
                return;
            // 2. Kiem tra thoi gian dai tiec
            if (dtpNgayDaiTiec.Value <= dtpNgayDatTiec.Value)
            {
                MessageBox.Show("Vui lòng chọn Ngày đãi tiệc sau Ngày đặt tiệc.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayDaiTiec.Focus();
                return;
            }
            // 3. Kiem tra thoi gian, dia diem dat tiec co trung ko
            string ngayDaiTiecSqlFormat = dtpNgayDaiTiec.Value.Month + "/" + dtpNgayDaiTiec.Value.Day + "/" + dtpNgayDaiTiec.Value.Year;
            int rowIndex = dgvDanhSachTiecCuoi.CurrentCell.RowIndex;
            string maTiecCuoi = dgvDanhSachTiecCuoi.Rows[rowIndex].Cells["MaTiecCuoi"].Value.ToString();
            string maCa = BUS_QuanLyTiecCuoi._ListMaCa[cboCa.SelectedIndex];
            string maSanh = BUS_QuanLyTiecCuoi._ListMaSanh[cboSanh.SelectedIndex];
            if (BUS_QuanLyTiecCuoi.CheckTiecCuoiExist(maTiecCuoi, ngayDaiTiecSqlFormat, maCa, maSanh))
            {
                MessageBox.Show("Đã có tiệc cưới tổ chức vào ngày " + dtpNgayDaiTiec.Value.ToShortDateString() + ", tại sảnh " + cboSanh.Text
                    + ", ca " + cboCa.Text + ". Vui lòng chọn Ngày đãi tiệc/Ca/Sảnh khác."
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayDaiTiec.Focus();
                return;
            }
            // 4. Kiem tra tien dat coc
            decimal tienDatCocMin = PHANTRAM_TIENCOC * (SumDonGiaBanTT() + SumDonGiaDichVuTT());
            if (decimal.Parse(txtTienDatCoc.Text) < tienDatCocMin)
            {
                MessageBox.Show("Tiền đặt ít nhất phải là " + tienDatCocMin + " VND ("+PHANTRAM_TIENCOC*100+"% tổng tiền của phiếu đặt bàn và phiếu đặt dịch vụ)."
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienDatCoc.Focus();
                return;
            }

            // Hoi xac nhan co muon luu khong
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn lưu lại tiệc cưới không?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            // Luu lai tiec cuoi khi da xac nhan:
            // 1. Luu Tiec cuoi
            DTO_TiecCuoi tiecCuoi = new DTO_TiecCuoi();
            tiecCuoi.MaTiecCuoi = int.Parse(dgvDanhSachTiecCuoi.Rows[rowIndex].Cells["MaTiecCuoi"].Value.ToString());
            tiecCuoi.TenChuRe = txtTenChuRe.Text;
            tiecCuoi.TenCoDau = txtTenCoDau.Text;
            tiecCuoi.DienThoai = txtDienThoai.Text;
            tiecCuoi.NgayDaiTiec = dtpNgayDaiTiec.Value.Month + "/" + dtpNgayDaiTiec.Value.Day + "/" + dtpNgayDaiTiec.Value.Year;
            tiecCuoi.MaCa = int.Parse(BUS_QuanLyTiecCuoi._ListMaCa[cboCa.SelectedIndex]);
            tiecCuoi.MaSanh = int.Parse(BUS_QuanLyTiecCuoi._ListMaSanh[cboSanh.SelectedIndex]);
            tiecCuoi.TienCoc = decimal.Parse(txtTienDatCoc.Text);
            tiecCuoi.GhiChu = txtGhiChuThongTinTiecCuoi.Text;
            BUS_QuanLyTiecCuoi.UpdateTiecCuoi(tiecCuoi);

            if (mPhieuBanAnIsEdited)
            {
                // 2. Luu Phieu dat ban an
                // 2.1 Xoa cac mon an cu
                BUS_QuanLyTiecCuoi.DeleteMonAn(tiecCuoi.MaTiecCuoi);
                
                // 2.2 Them cac mon an moi
                BUS_QuanLyTiecCuoi.UpdatePhieuDatBan(tiecCuoi.MaTiecCuoi, txtSoLuongBan.Text, txtSoLuongBanDuTru.Text, SumDonGiaBanTT());
                int maPhieuDatBan = BUS_QuanLyTiecCuoi.GetMaPhieuDatBan(tiecCuoi.MaTiecCuoi);
                foreach (DataGridViewRow row in dgvDanhSachMonAn.Rows)
                {
                    BUS_QuanLyTiecCuoi.InsertMonAn(maPhieuDatBan, row.Cells["MaMonAn"].Value.ToString(), row.Cells["DonGiaTT"].Value.ToString());
                }
            }

            if (mPhieuDichVuIsEdited)
            {
                // 3. Luu Phieu dat dich vu
                // 3.1 Xoa phieu dich vu cu
                BUS_QuanLyTiecCuoi.DeleteDichVu(tiecCuoi.MaTiecCuoi);

                // 3.2 Them phieu dich vu moi
                if (dgvDanhSachDichVu.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvDanhSachDichVu.Rows)
                    {
                        BUS_QuanLyTiecCuoi.InsertDichVu(tiecCuoi.MaTiecCuoi, row.Cells["MaDichVu"].Value.ToString(), row.Cells["DonGiaTT"].Value.ToString(), row.Cells["SoLuong"].Value.ToString());
                    }
                }
            }

            EnableAllInputs(false);
            ClearAllInputs();
            btnLuuTiec.Enabled = btnHuy.Enabled = false;
            dgvDanhSachTiecCuoi.Enabled = true;
            dgvDanhSachTiecCuoi.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
            this.Size = NORMAL_SIZE;
            lblSoMonAn.Text = lblSoDichVu.Text = "--";
            linkSuaPhieuBanAn.Enabled = linkSuaPhieuDichVu.Enabled = false;
            //linkSuaPhieuBanAn.Text = linkSuaPhieuDichVu.Text = "Sửa >>";
        }

        private void btnXoaTiec_Click(object sender, EventArgs e)
        {
            // Hoi xac nhan co muon xoa khong
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa tiệc cưới này không, bạn sẽ không thể khôi phục lại?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;

            // Xoa tiec sau khi da xac nhan
            string maTiecCuoi = dgvDanhSachTiecCuoi.CurrentRow.Cells["MaTiecCuoi"].Value.ToString();
            if (BUS_QuanLyTiecCuoi.DeleteTiecCuoi(maTiecCuoi))
            {
                MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reload dgv, clear selection, dong tat ca button
                dgvDanhSachTiecCuoi.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
                btnSuaTiec.Enabled = btnXoaTiec.Enabled = false;
                lblSoMonAn.Text = lblSoDichVu.Text = "--";
            }
            else
            {
                MessageBox.Show("Xóa không thành công, không tìm thấy tiệc cưới này!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private decimal SumDonGiaBanTT()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvDanhSachMonAn.Rows)
            {
                sum += decimal.Parse(row.Cells["DonGiaTT"].Value.ToString());
            }
            return sum;
        }

        private decimal SumDonGiaDichVuTT()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvDanhSachDichVu.Rows)
            {
                sum += decimal.Parse(row.Cells["DonGiaTT"].Value.ToString());
            }
            return sum;
        }

        private void btnLuuPhieuDatBan_Click(object sender, EventArgs e)
        {
            // Kiem tra dieu kien: So luong ban toi da, Don gia ban toi thieu
            int soLuongBanTD = BUS_QuanLyTiecCuoi._ListSoLuongBanToiDa[cboSanh.SelectedIndex];
            if (int.Parse(txtSoLuongBan.Text) > soLuongBanTD)
            {
                MessageBox.Show("Số lượng bàn vượt quá tối đa (" + soLuongBanTD + ") của sảnh " + cboSanh.Text
                    + "\nVui lòng chỉnh lại!", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongBan.Focus();
                return;
            }
            decimal tongDonGiaBanTT = SumDonGiaBanTT();
            if (tongDonGiaBanTT < int.Parse(lblDonGiaBanTT.Text))
            {
                MessageBox.Show("Tổng giá bàn (" + tongDonGiaBanTT + ") chưa đủ đơn giá bàn tối thiểu là " + lblDonGiaBanTT.Text
                    +"\nVui lòng chọn thêm món!"
                    , "" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongBan.Focus();
                return;
            }
            if (dgvDanhSachMonAn.RowCount == 0)
            {
                MessageBox.Show("Danh sách món ăn trống. Vui lòng chọn ít nhất một món ăn."
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnChonMon.Focus();
                //linkChonMon.Focus();
                return;
            }

            // Hoi co muon luu phieu ban an ko
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu phiếu bàn ăn không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Neu co thi, Dong panel lai, bat co` mPhieuBanAnIsEdited
                mPhieuBanAnIsEdited = true;
                mPanelBanAnIsOpen = false;
                lblSoMonAn.Text = dgvDanhSachMonAn.RowCount.ToString();
                this.Size = NORMAL_SIZE;
                lblDonGiaMonAnMacDinh.Text = lblTenMonAn.Text = "-";
                txtDonGiaDatMonAn.Text = "";
                ptrMonAn.Image = null;
                pnlLeft.Enabled = true;
            }
        }

        private void btnHuyPhieuDatBan_Click(object sender, EventArgs e)
        {
            // Hoi co muon huy khong
            DialogResult dr = MessageBox.Show("Dữ liệu bàn ăn thay đổi sẽ không lưu lại, bạn có muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                // Neu co thi, Dong panel lai, bat co` mPhieuBanAnIsEdited
                mPhieuBanAnIsEdited = false;
                mPanelBanAnIsOpen = false;
                this.Size = NORMAL_SIZE;
                lblDonGiaMonAnMacDinh.Text = lblTenMonAn.Text = "-";
                txtDonGiaDatMonAn.Text = "";
                ptrMonAn.Image = null;
                pnlLeft.Enabled = true;

                // Load data vao Phieu ban an
                int selectedRow = dgvDanhSachTiecCuoi.CurrentCell.RowIndex;
                string maTiecCuoi = dgvDanhSachTiecCuoi["MaTiecCuoi", selectedRow].Value.ToString();
                string soLuongBan, soLuongBanDuTru;
                DataTable danhSachMonAn;
                BUS_QuanLyTiecCuoi.GetDataPhieuBanAn(maTiecCuoi, out soLuongBan, out soLuongBanDuTru, out danhSachMonAn);
                txtSoLuongBan.Text = soLuongBan;
                txtSoLuongBanDuTru.Text = soLuongBanDuTru;
                dgvDanhSachMonAn.DataSource = danhSachMonAn;
                dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
                dgvDanhSachMonAn.Columns["DonGiaTT"].HeaderText = "Đơn giá thực tế";
                dgvDanhSachMonAn.Columns["MaMonAn"].Visible = false;
                lblSoMonAn.Text = dgvDanhSachMonAn.RowCount.ToString();
            }
        }

        private void btnLuuPhieuDichVu_Click(object sender, EventArgs e)
        {
            // Kiem tra dieu kien: khong co

            // Hoi co muon luu phieu dich vu ko
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu phiếu đặt dịch vụ không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Neu co thi, Dong panel lai, bat co` mPhieuDichVuIsEdited
                mPhieuDichVuIsEdited = true;
                mPanelDichVuIsOpen = false;
                lblSoDichVu.Text = dgvDanhSachDichVu.RowCount.ToString();
                this.Size = NORMAL_SIZE;
                lblDonGiaDichVuMacDinh.Text = lblTenDichVu.Text = "-";
                txtDonGiaDatDichVu.Text = txtSoLuongDichVuDat.Text = "";
                ptrDichVu.Image = null;
                pnlLeft.Enabled = true;
            }
        }

        private void btnHuyPhieuDichVu_Click(object sender, EventArgs e)
        {
            // Hoi co muon huy khong
            DialogResult dr = MessageBox.Show("Dữ liệu dịch vụ thay đổi sẽ không lưu lại, bạn có muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                // Neu co thi, Dong panel lai, bat co` mPhieuBanAnIsEdited
                mPhieuDichVuIsEdited = false;
                mPanelDichVuIsOpen = false;
                this.Size = NORMAL_SIZE;
                lblDonGiaDichVuMacDinh.Text = lblTenDichVu.Text = "-";
                txtDonGiaDatDichVu.Text = txtSoLuongDichVuDat.Text = "";
                ptrDichVu.Image = null;
                pnlLeft.Enabled = true;

                // Load data vao Phieu dich vu
                int selectedRow = dgvDanhSachTiecCuoi.CurrentCell.RowIndex;
                string maTiecCuoi = dgvDanhSachTiecCuoi["MaTiecCuoi", selectedRow].Value.ToString();
                dgvDanhSachDichVu.DataSource = BUS_QuanLyTiecCuoi.GetDataPhieuDichVu(maTiecCuoi);
                dgvDanhSachDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
                dgvDanhSachDichVu.Columns["DonGiaTT"].HeaderText = "Đơn giá thực tế";
                dgvDanhSachDichVu.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDanhSachDichVu.Columns["MaDichVu"].Visible = false;
                lblSoDichVu.Text = dgvDanhSachDichVu.RowCount.ToString();
            }
        }

        private void dgvDanhSachMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mRowClickedMonAn = dgvDanhSachMonAn.HitTest(e.X, e.Y).RowIndex;
                dgvDanhSachMonAn.CurrentCell = dgvDanhSachMonAn.Rows[mRowClickedMonAn].Cells["TenMonAn"];
                myContextMenu.Show(dgvDanhSachMonAn, e.X, e.Y);
            }
        }

        private void myContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Xóa")
            {
                if (mPanelBanAnIsOpen)
                {
                    DataTable dt = (DataTable)dgvDanhSachMonAn.DataSource;
                    dt.Rows[mRowClickedMonAn].Delete();
                    dgvDanhSachMonAn.DataSource = dt;
                }
                else if (mPanelDichVuIsOpen)
                {
                    DataTable dt = (DataTable)dgvDanhSachDichVu.DataSource;
                    dt.Rows[mRowClickedDichVu].Delete();
                    dgvDanhSachMonAn.DataSource = dt;
                }
            }
        }

        private void cboDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboDanhSachMonAn.SelectedIndex != -1 && !loading)
            //{
            //    ptrMonAn.ImageLocation = MONAN_FOLDER_NAME + "/" + BUS_QuanLyTiecCuoi._ListHinhAnhMonAn[cboDanhSachMonAn.SelectedIndex];
            //    lblDonGiaMonAnMacDinh.Text = BUS_QuanLyTiecCuoi._ListDonGiaMonAn[cboDanhSachMonAn.SelectedIndex];
            //}
        }

        private void lblTenMonAn_TextChanged(object sender, EventArgs e)
        {
            if (lblTenMonAn.Text != "-")
            {
                int index = BUS_QuanLyTiecCuoi._ListMaMonAn.IndexOf(mMaMonAn);
                ptrMonAn.ImageLocation = MONAN_FOLDER_NAME + "/" + BUS_QuanLyTiecCuoi._ListHinhAnhMonAn[index];
                lblDonGiaMonAnMacDinh.Text = BUS_QuanLyTiecCuoi._ListDonGiaMonAn[index] + " VND";
            }
        }

        private void cboDanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboDanhSachDichVu.SelectedIndex != -1 && !loading)
            //{
            //    ptrDichVu.ImageLocation = DICHVU_FOLDER_NAME + "/" + BUS_QuanLyTiecCuoi._ListHinhAnhDichVu[cboDanhSachDichVu.SelectedIndex];
            //    lblDonGiaDichVuMacDinh.Text = BUS_QuanLyTiecCuoi._ListDonGiaDichVu[cboDanhSachDichVu.SelectedIndex];
            //}
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            //if (cboDanhSachMonAn.SelectedIndex == -1) return;
            if (lblTenMonAn.Text == "-") return;

            // Kiem tra nhap nhap day du chua
            if (txtDonGiaDatMonAn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Đơn giá thực tế' cho món.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaDatMonAn.Focus();
                return;
            }
            if (int.Parse(txtDonGiaDatMonAn.Text) < int.Parse(BUS_QuanLyTiecCuoi._ListDonGiaMonAn[BUS_QuanLyTiecCuoi._ListMaMonAn.IndexOf(mMaMonAn)]))
            {
                MessageBox.Show("Đơn giá món ăn phải lớn hơn/bằng đơn giá mặc định (" + lblDonGiaMonAnMacDinh.Text + "). Vui lòng sửa lại.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaDatMonAn.Focus();
                return;
            }

            // Kiem tra mon an co trong dgv khong
            foreach (DataGridViewRow r in dgvDanhSachMonAn.Rows)
            {
                //if (r.Cells["MaMonAn"].Value.ToString() == BUS_QuanLyTiecCuoi._ListMaMonAn[cboDanhSachMonAn.SelectedIndex])
                if (r.Cells["MaMonAn"].Value.ToString() == mMaMonAn)
                {
                    // Neu mon an co roi thi update
                    string message = "";
                    if (mThemOrSuaMonAn == 1)
                        message = "Món này đã có trong phiếu. Bạn có muốn cập nhật lại đơn giá không?";
                    else if (mThemOrSuaMonAn == 2)
                        message = "Bạn có muốn lưu lại đơn giá không?";

                    DialogResult dr = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DataTable dtt = (DataTable)dgvDanhSachMonAn.DataSource;
                        foreach(DataRow roww in dtt.Rows)
                        {
                            if (roww["MaMonAn"].ToString() == mMaMonAn)
                            {
                                roww["DonGiaTT"] = txtDonGiaDatMonAn.Text;
                            }
                        }
                        dgvDanhSachMonAn.DataSource = dtt;

                        txtDonGiaDatMonAn.Text = "";
                        lblTenMonAn.Text = lblDonGiaMonAnMacDinh.Text = "-";
                        ptrMonAn.Image = null;
                        MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }
            }

            DialogResult drr = MessageBox.Show("Bạn có muốn thêm món ăn này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drr == DialogResult.No)
                return;

            // Neu khong co trong dgc thi insert thang vao
            DataTable dt = (DataTable)dgvDanhSachMonAn.DataSource;
            DataRow row = dt.NewRow();
            //row["MaMonAn"] = BUS_QuanLyTiecCuoi._ListMaMonAn[cboDanhSachMonAn.SelectedIndex];
            //row["TenMonAn"] = cboDanhSachMonAn.Text;
            row["MaMonAn"] = mMaMonAn;
            row["TenMonAn"] = lblTenMonAn.Text;
            row["DonGiaTT"] = txtDonGiaDatMonAn.Text;
            dt.Rows.Add(row);
            dgvDanhSachMonAn.DataSource = dt;

            txtDonGiaDatMonAn.Text = "";
            lblTenMonAn.Text = lblDonGiaMonAnMacDinh.Text = "-";
            ptrMonAn.Image = null;
            MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }       

        private void txtSoLuongBan_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBan.Text == "0")
                txtSoLuongBan.Text = "";
        }

        private void txtSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtSoLuongBanDuTru_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBanDuTru.Text == "0")
                txtSoLuongBanDuTru.Text = "";
        }

        private void txtSoLuongBanDuTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDonGiaDatDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaDatDichVu.Text == "0")
                txtDonGiaDatDichVu.Text = "";
        }

        private void txtDonGiaDatDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtSoLuongDichVuDat_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongDichVuDat.Text == "0")
                txtSoLuongDichVuDat.Text = "";
        }

        private void txtSoLuongDichVuDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void lblTenDichVu_TextChanged(object sender, EventArgs e)
        {
            if (lblTenDichVu.Text != "-")
            {
                int index = BUS_QuanLyTiecCuoi._ListMaDichVu.IndexOf(mMaDichVu);
                ptrDichVu.ImageLocation = DICHVU_FOLDER_NAME + "/" + BUS_QuanLyTiecCuoi._ListHinhAnhDichVu[index];
                lblDonGiaDichVuMacDinh.Text = BUS_QuanLyTiecCuoi._ListDonGiaDichVu[index] + " VND";
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            //if (cboDanhSachMonAn.SelectedIndex == -1) return;
            if (lblTenDichVu.Text == "-") return;

            if (txtDonGiaDatDichVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Đơn giá thực tế' cho dịch vụ.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaDatDichVu.Focus();
                return;
            }
            if (txtSoLuongDichVuDat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng  dịch vụ.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongDichVuDat.Focus();
                return;
            }
            if (int.Parse(txtDonGiaDatDichVu.Text) < int.Parse(BUS_QuanLyTiecCuoi._ListDonGiaDichVu[BUS_QuanLyTiecCuoi._ListMaDichVu.IndexOf(mMaDichVu)]))
            {
                MessageBox.Show("Đơn giá dịch vụ phải lớn hơn/bằng đơn giá mặc định (" + lblDonGiaDichVuMacDinh.Text + ").", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaDatDichVu.Focus();
                return;
            }
            //if (int.Parse(txtSoLuongDichVuDat.Text) < 1)
            //{
            //    MessageBox.Show("Số lượng dịch vụ ít nhất là 1. Vui lòng sửa lại.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSoLuongDichVuDat.Focus();
            //    return;
            //}

            //int index = BUS_QuanLyTiecCuoi._ListMaDichVu.IndexOf(mMaDichVu);
            foreach (DataGridViewRow r in dgvDanhSachDichVu.Rows)
            {
                //if (r.Cells["MaMonAn"].Value.ToString() == BUS_QuanLyTiecCuoi._ListMaMonAn[cboDanhSachMonAn.SelectedIndex])
                //if (r.Cells["MaMonAn"].Value.ToString() == BUS_QuanLyTiecCuoi._ListMaMonAn[index])
                if (r.Cells["MaDichVu"].Value.ToString() == mMaDichVu)
                {
                    // Neu dich vu co roi thi update
                    string message = "";
                    if (mThemOrSuaDichVu == 1)
                        message = "Dịch vụ này đã có trong phiếu. Bạn có muốn cập nhật lại đơn giá, số lượng không?";
                    else if (mThemOrSuaDichVu == 2)
                        message = "Bạn có muốn lưu lại đơn giá, số lượng không?";

                    DialogResult dr = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        DataTable dtt = (DataTable)dgvDanhSachDichVu.DataSource;
                        foreach (DataRow roww in dtt.Rows)
                        {
                            if (roww["MaDichVu"].ToString() == mMaDichVu)
                            {
                                roww["DonGiaTT"] = txtDonGiaDatDichVu.Text;
                                roww["SoLuong"] = txtSoLuongDichVuDat.Text;
                            }
                        }
                        dgvDanhSachDichVu.DataSource = dtt;

                        txtDonGiaDatDichVu.Text = txtSoLuongDichVuDat.Text = "";
                        lblTenDichVu.Text = lblDonGiaDichVuMacDinh.Text = "-";
                        ptrDichVu.Image = null;
                        MessageBox.Show("Lưu thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return;
                }
            }

            DialogResult drr = MessageBox.Show("Bạn có muốn thêm dịch vụ này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drr == DialogResult.No)
                return;

            DataTable dt = (DataTable)dgvDanhSachDichVu.DataSource;
            DataRow row = dt.NewRow();
            //row["MaMonAn"] = BUS_QuanLyTiecCuoi._ListMaMonAn[cboDanhSachMonAn.SelectedIndex];
            //row["TenMonAn"] = cboDanhSachMonAn.Text;
            row["MaDichVu"] = mMaDichVu;
            row["TenDichVu"] = lblTenDichVu.Text;
            row["DonGiaTT"] = txtDonGiaDatDichVu.Text;
            row["SoLuong"] = txtSoLuongDichVuDat.Text;
            dt.Rows.Add(row);
            dgvDanhSachDichVu.DataSource = dt;

            txtDonGiaDatDichVu.Text = txtSoLuongDichVuDat.Text = "";
            lblTenDichVu.Text = lblDonGiaDichVuMacDinh.Text = "-";
            ptrDichVu.Image = null;
            MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDanhSachDichVu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mRowClickedDichVu = dgvDanhSachDichVu.HitTest(e.X, e.Y).RowIndex;
                dgvDanhSachDichVu.CurrentCell = dgvDanhSachDichVu.Rows[mRowClickedDichVu].Cells["TenDichVu"];
                myContextMenu.Show(dgvDanhSachDichVu, e.X, e.Y);
            }
        }

        private void txtTenChuRe_TextChanged(object sender, EventArgs e)
        {
            if (txtTenChuRe.Text == " ")
                txtTenChuRe.Text = "";
        }

        private void txtTenCoDau_TextChanged(object sender, EventArgs e)
        {
            if (txtTenCoDau.Text == " ")
                txtTenCoDau.Text = "";
        }

        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTienDatCoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTienDatCoc.Text == "0")
                txtTienDatCoc.Text = "";
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //first keys
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar != (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            mThemOrSuaMonAn = 1;

            // Load new form
            frmTraCuuMonAn formTCMA = new frmTraCuuMonAn();
            formTCMA.ShowDialog();

            if (formTCMA.mTenMonAnSelected != "-")
            {
                // Lay ve MaMonAn
                mMaMonAn = formTCMA.mMaMonAnSelected;

                // Load ten mon an vao label
                lblTenMonAn.Text = formTCMA.mTenMonAnSelected;

                // Load don gia mac dinh
                txtDonGiaDatMonAn.Text = BUS_QuanLyTiecCuoi._ListDonGiaMonAn[BUS_QuanLyTiecCuoi._ListTenMonAn.IndexOf(lblTenMonAn.Text)];
                txtDonGiaDatMonAn.Focus();
                txtDonGiaDatMonAn.SelectAll();
            }
        }

        private void dgvDanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mThemOrSuaMonAn = 2;

            // Hien thi mon an len de chinh sua
            mMaMonAn = dgvDanhSachMonAn.CurrentRow.Cells["MaMonAn"].Value.ToString();
            lblTenMonAn.Text = BUS_QuanLyTiecCuoi._ListTenMonAn[BUS_QuanLyTiecCuoi._ListMaMonAn.IndexOf(mMaMonAn)];
            txtDonGiaDatMonAn.Text = dgvDanhSachMonAn.CurrentRow.Cells["DonGiaTT"].Value.ToString();
            txtDonGiaDatMonAn.Focus();
            dgvDanhSachMonAn.ClearSelection();
        }

        private void dgvDanhSachMonAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachMonAn.ClearSelection();
        }

        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            mThemOrSuaDichVu = 1;

            // Load new form
            frmTraCuuDichVu formTCDV = new frmTraCuuDichVu();
            formTCDV.ShowDialog();

            if (formTCDV.mTenDichVuSelected != "-")
            {
                // Lay ve MaMonAn
                mMaDichVu = formTCDV.mMaDichVuSelected;

                // Load ten mon an vao label
                lblTenDichVu.Text = formTCDV.mTenDichVuSelected;

                // Load don gia mac dinh
                txtDonGiaDatDichVu.Text = BUS_QuanLyTiecCuoi._ListDonGiaDichVu[BUS_QuanLyTiecCuoi._ListTenDichVu.IndexOf(lblTenDichVu.Text)];
                txtDonGiaDatDichVu.Focus();
                txtDonGiaDatDichVu.SelectAll();
            }
        }

        private void dgvDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mThemOrSuaDichVu = 2;

            // Hien thi dich vu len de chinh sua
            mMaDichVu = dgvDanhSachDichVu.CurrentRow.Cells["MaDichVu"].Value.ToString();
            lblTenDichVu.Text = BUS_QuanLyTiecCuoi._ListTenDichVu[BUS_QuanLyTiecCuoi._ListMaDichVu.IndexOf(mMaDichVu)];
            txtDonGiaDatDichVu.Text = dgvDanhSachDichVu.CurrentRow.Cells["DonGiaTT"].Value.ToString();
            txtSoLuongDichVuDat.Text = dgvDanhSachDichVu.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaDatDichVu.Focus();
            dgvDanhSachDichVu.ClearSelection();
        }

        private void dgvDanhSachDichVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachDichVu.ClearSelection();
        }

        private void txtDonGiaDatMonAn_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaDatMonAn.Text == "0")
            {
                txtDonGiaDatMonAn.Text = "";
            }
        }

        private void txtDonGiaDatMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDonGiaDatMonAn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemMonAn_Click(sender, e);
            }
        }
    }
}
