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

namespace QuanLyTiecCuoiUI
{
    enum STATEBUTTON
    {
        INSERT,
        UPDATE,
        DELETE,
        DEFAULT,
    }
    public partial class frmQuanLyNhanVien : Form
    {
        #region parameters 
        private DataTable dtChucVu;
        private STATEBUTTON StateButton;
        private string DuongDanToiAnh;
        private string TenAnhInsert;
        private bool flag;
        private int indexSeLect = -1;
        #endregion

        #region load form and state, load data combobox, event gridview

        private void LoadChucVu()
        {
            try
            {
                dtChucVu = BUS_QuanLyNhanVien.LoadChucVu();
                cboChucVuNhanVien.DataSource = dtChucVu;
                cboChucVuNhanVien.DisplayMember = dtChucVu.Columns["TenChucVu"].ToString();
                cboChucVuNhanVien.ValueMember = dtChucVu.Columns["MaChucVu"].ToString();
                cboChucVuNhanVien.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                return;
            }
        }
        private void LoadDataGridView()
        {
            try
            {
                dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.LoadDanhSachNhanVien();
                dgvDanhSachNhanVien.Columns[0].Visible = false;
                dgvDanhSachNhanVien.Columns[1].HeaderText = "Họ và tên";
                dgvDanhSachNhanVien.Columns[2].HeaderText = "Địa chỉ";
                dgvDanhSachNhanVien.Columns[3].HeaderText = "Điện thoại";
                dgvDanhSachNhanVien.Columns[4].HeaderText = "Username";
                dgvDanhSachNhanVien.Columns[5].HeaderText = "Password";
                dgvDanhSachNhanVien.Columns[6].Visible = false;
                dgvDanhSachNhanVien.Columns[7].HeaderText = "Tình trạng";
                dgvDanhSachNhanVien.Columns[8].Visible = false;
                dgvDanhSachNhanVien.Columns[9].Visible = false;
                dgvDanhSachNhanVien.Columns[10].HeaderText = "Chức vụ";
                dgvDanhSachNhanVien.Columns[11].Visible = false;
                dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachNhanVien.ReadOnly = true;
                dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //load nhân viên đầu tiên 
                //nội dung tab thông tin 
                int rowselect = 0;
                lblHoTenNhanVien.Text = dgvDanhSachNhanVien[1, rowselect].Value.ToString().ToUpper();
                lblChucVuNhanVien.Text = dgvDanhSachNhanVien[10, rowselect].Value.ToString();
                lblSoDienThoai.Text = dgvDanhSachNhanVien[3, rowselect].Value.ToString();
                lblDiaChiNhanVien.Text = dgvDanhSachNhanVien[2, rowselect].Value.ToString();
                if (dgvDanhSachNhanVien[7, rowselect].Value.ToString() == "1")
                    lblTinhTrang.Text = "Đang làm việc";
                else
                    lblTinhTrang.Text = "Đã nghỉ việc";
                ptrThongTinAnhNhanVien.Image = Image.FromFile(@"DanhSachNhanVien\" + dgvDanhSachNhanVien[8, rowselect].Value.ToString());

                //nội dung tab thao tác
                //nội dung tab thao tác
                txtHoTenNhanVien.Text = dgvDanhSachNhanVien[1, rowselect].Value.ToString();
                txtDienThoaiNhanVien.Text = dgvDanhSachNhanVien[3, rowselect].Value.ToString();
                txttDiaChiNhanVien.Text = dgvDanhSachNhanVien[2, rowselect].Value.ToString();
                txtUserNameNhanVien.Text = dgvDanhSachNhanVien[4, rowselect].Value.ToString();
                txtPasswordNhanVien.Text = dgvDanhSachNhanVien[5, rowselect].Value.ToString();
                if (dgvDanhSachNhanVien[7, rowselect].Value.ToString() == "1")
                    chkDangLamViec.Checked = true;
                else
                    chkDangLamViec.Checked = false;
                ptrAnhDaiDien.Image = Image.FromFile(@"DanhSachNhanVien\" + dgvDanhSachNhanVien[8, rowselect].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load danh sách nhân viên thất bại");
            }
        }
        private void SetStateForThaoTac(bool state)
        {
            txtHoTenNhanVien.ReadOnly = txtPasswordNhanVien.ReadOnly = txttDiaChiNhanVien.ReadOnly = txtDienThoaiNhanVien.ReadOnly = txtUserNameNhanVien.ReadOnly = state;
            cboChucVuNhanVien.Enabled = !state;
            chkDangLamViec.Enabled = !state;
            btnTimKiem.Enabled = !state;
            ptrAnhDaiDien.Enabled = !state;
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

            //Load state
            LoadDefaultState();
            LoadChucVu();
            LoadDataGridView();
            SetStateForThaoTac(true);
            StateButton = STATEBUTTON.DEFAULT;
            flag = true;
        }
        private void RefreshThongTin()
        {
            lblChucVuNhanVien.Text = lblDiaChiNhanVien.Text = lblHoTenNhanVien.Text = lblSoDienThoai.Text = lblTinhTrang.Text = string.Empty;
            ptrThongTinAnhNhanVien.Image = null;
        }
        private void LoadDefaultState()
        {
            pnlThaoTacNhanVien.Visible = false;
            btnThongTinNhanVien.BackColor = Color.Teal;
            btnThaoTacQuanLy.BackColor = Color.FromArgb(0, 64, 64);
            btnThemNhanVien.Enabled = btnLuu.Enabled = btnSuaNhanVien.Enabled = btnHuy.Enabled = btnXoaNhanVien.Enabled = false;
        }

        private void LoadDefaultStateForButton()
        {
            btnLuu.Enabled = btnSuaNhanVien.Enabled = btnHuy.Enabled = btnXoaNhanVien.Enabled = false;
            btnThemNhanVien.Enabled = true;
        }
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StateButton == STATEBUTTON.INSERT || StateButton == STATEBUTTON.UPDATE)
                return;
            int rowselect = e.RowIndex;
            indexSeLect = e.RowIndex;
            if (rowselect < 0)
                return;
            try
            {
                //load ảnh tab 1
                try
                {
                    ptrThongTinAnhNhanVien.Image = Image.FromFile(@"DanhSachNhanVien\" + dgvDanhSachNhanVien[8, rowselect].Value.ToString());

                }
                catch (FileNotFoundException ex)
                {
                    ptrThongTinAnhNhanVien.Image = Image.FromFile(@"DanhSachNhanVien\unknow.png");
                }

                //load ảnh tab 2
                try
                {
                    ptrAnhDaiDien.Image = Image.FromFile(@"DanhSachNhanVien\" + dgvDanhSachNhanVien[8, rowselect].Value.ToString());
                }
                catch (FileNotFoundException ex)
                {
                    ptrAnhDaiDien.Image = Image.FromFile(@"DanhSachNhanVien\unknow.png");
                }

                //nội dung tab thông tin 
                lblHoTenNhanVien.Text = dgvDanhSachNhanVien[1, rowselect].Value.ToString().ToUpper();
                lblChucVuNhanVien.Text = dgvDanhSachNhanVien[10, rowselect].Value.ToString();
                lblSoDienThoai.Text = dgvDanhSachNhanVien[3, rowselect].Value.ToString();
                lblDiaChiNhanVien.Text = dgvDanhSachNhanVien[2, rowselect].Value.ToString();
                if (dgvDanhSachNhanVien[7, rowselect].Value.ToString() == "1")
                    lblTinhTrang.Text = "Đang làm việc";
                else
                    lblTinhTrang.Text = "Đã nghỉ việc";


                //nội dung tab thao tác
                txtHoTenNhanVien.Text = dgvDanhSachNhanVien[1, rowselect].Value.ToString();
                txtDienThoaiNhanVien.Text = dgvDanhSachNhanVien[3, rowselect].Value.ToString();
                txttDiaChiNhanVien.Text = dgvDanhSachNhanVien[2, rowselect].Value.ToString();
                txtUserNameNhanVien.Text = dgvDanhSachNhanVien[4, rowselect].Value.ToString();
                txtPasswordNhanVien.Text = dgvDanhSachNhanVien[5, rowselect].Value.ToString();
                if (dgvDanhSachNhanVien[7, rowselect].Value.ToString() == "1")
                    chkDangLamViec.Checked = true;
                else
                    chkDangLamViec.Checked = false;
                cboChucVuNhanVien.SelectedValue = Int32.Parse(dgvDanhSachNhanVien[9, rowselect].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            }

            //state button 
            btnThemNhanVien.Enabled = false;
            btnSuaNhanVien.Enabled = btnXoaNhanVien.Enabled = btnHuy.Enabled = true;
        }
        #endregion

        #region Click tab menu
        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            pnlThaoTacNhanVien.Visible = false;
            btnThongTinNhanVien.BackColor = Color.Teal;
            btnThaoTacQuanLy.BackColor = Color.FromArgb(0, 64, 64);
            LoadDefaultState();
            SetStateForThaoTac(true);
            flag = true;
        }

        private void btnThaoTacQuanLy_Click(object sender, EventArgs e)
        {
            pnlThaoTacNhanVien.Visible = true;
            btnThaoTacQuanLy.BackColor = Color.Teal;
            btnThongTinNhanVien.BackColor = Color.FromArgb(0, 64, 64);
            LoadDefaultStateForButton();
            flag = false;
        }


        #endregion

        #region Quản lý sự kiện ràng buộc control 

        private void txtHoTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txtHoTenNhanVien.Text[txtHoTenNhanVien.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            //Ngăn ký tự bắt đầu
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            //Ngăn ký tự số
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttDiaChiNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txttDiaChiNhanVien.Text[txttDiaChiNhanVien.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                
            }
            //Ngăn ký tự bắt đầu
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
        }

        private void txtDienThoaiNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chiều dài số điện thoại, quá 11 thì xóa
            if (txtDienThoaiNhanVien.Text.Length > 10)
            {
                e.KeyChar = (char)Keys.Back;
                return;
            }

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
            //check state not char
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUserNameNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txtUserNameNhanVien.Text[txtUserNameNhanVien.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            //Ngăn ký tự bắt đầu
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
        }

        private void txtPasswordNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txtPasswordNhanVien.Text[txtPasswordNhanVien.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            //Ngăn ký tự bắt đầu
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
        }
        #endregion

        #region Quản lý trạng thái tab thao tác

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            dialog.DefaultExt = ".png";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DuongDanToiAnh = dialog.FileName;
                TenAnhInsert= dialog.SafeFileName;
                ptrAnhDaiDien.Image = Image.FromFile(DuongDanToiAnh);
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Mời bạn chọn sang thẻ Thao tác để thực hiện thao tác", "Thông báo");
                return;
            }
            //Thay đổi state
            txtHoTenNhanVien.Text = txttDiaChiNhanVien.Text = txtDienThoaiNhanVien.Text = txtPasswordNhanVien.Text = txtUserNameNhanVien.Text = string.Empty;
            cboChucVuNhanVien.SelectedIndex = 0;
            chkDangLamViec.Checked = false;
            ptrAnhDaiDien.Image = null;
            SetStateForThaoTac(false);
            StateButton = STATEBUTTON.INSERT;
            btnThemNhanVien.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            DuongDanToiAnh = TenAnhInsert = string.Empty;
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Mời bạn chọn sang thẻ Thao tác để thực hiện thao tác", "Thông báo");
                return;
            }
            StateButton = STATEBUTTON.UPDATE;
            SetStateForThaoTac(false);
            btnTimKiem.Enabled = false;
            txtUserNameNhanVien.ReadOnly = txtPasswordNhanVien.ReadOnly = true;
            btnSuaNhanVien.Enabled = false;
            btnLuu.Enabled = true;
            btnXoaNhanVien.Enabled = false;
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Mời bạn chọn sang thẻ Thao tác để thực hiện thao tác", "Thông báo");
                return;
            }

            StateButton = STATEBUTTON.DELETE;
            DialogResult r = MessageBox.Show("Bạn muốn xóa nhân viên ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    DTO_NhanVien nhanvienxoa = new DTO_NhanVien();
                    nhanvienxoa.MaNV = Int32.Parse(dgvDanhSachNhanVien[0, dgvDanhSachNhanVien.CurrentCell.RowIndex].Value.ToString());
                    
                    //kiểm tra xem có lập tiệc cưới nào không 
                    if (!BUS_QuanLyNhanVien.CheckNhanVienKhongLapHopDong(nhanvienxoa.MaNV.ToString()))
                    {
                        MessageBox.Show("Nhân viên này đang lập hợp đồng cho tiệc cưới chưa thanh toán nên không thể xóa được ", "Thông báo");
                        return;
                    }

                    //kiểm tra có phải tài khoản admin hay tài khoản đang đăng nhập hay không
                    if (nhanvienxoa.MaNV == frmMain.NhanVienLogin.MaNV)
                    {
                        MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập ", "Thông báo");
                        return;
                    }

                    //Xóa nhân viên 
                    bool stateRemove = BUS_QuanLyNhanVien.DeleteNhanVien(nhanvienxoa);
                    if (stateRemove)
                    {
                        //Kiểm tra hình ảnh được sử dụng bao nhiêu lần 
                        if (!BUS_QuanLyNhanVien.CheckRowEffectLargerThanOnce(dgvDanhSachNhanVien[8, dgvDanhSachNhanVien.CurrentCell.RowIndex].Value.ToString()))
                        {
                            try
                            {
                                string path = @"DanhSachNhanVien\" + dgvDanhSachNhanVien[8, dgvDanhSachNhanVien.CurrentCell.RowIndex].Value.ToString();
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                if (dgvDanhSachNhanVien[8, dgvDanhSachNhanVien.CurrentCell.RowIndex].Value.ToString() != "unknow.png")
                                {

                                    ptrAnhDaiDien.Image.Dispose();
                                        ptrThongTinAnhNhanVien.Image.Dispose();
                                    File.Delete(path);
                                }
                            }
                            catch(Exception ex)
                            {

                            }
                        }
                        MessageBox.Show("Xóa thành công");
                        dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.LoadDanhSachNhanVien();
                    }
                    else
                        MessageBox.Show("Xóa thất bại ");
                    txtHoTenNhanVien.Text = txttDiaChiNhanVien.Text = txtDienThoaiNhanVien.Text = txtPasswordNhanVien.Text = txtUserNameNhanVien.Text = string.Empty;
                    cboChucVuNhanVien.SelectedIndex = 0;
                    chkDangLamViec.Checked = false;
                    ptrAnhDaiDien.Image = null;
                    SetStateForThaoTac(true);
                    StateButton = STATEBUTTON.DEFAULT;
                    btnThemNhanVien.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnXoaNhanVien.Enabled = btnSuaNhanVien.Enabled = false;
                    DuongDanToiAnh = TenAnhInsert = string.Empty;
                }
                catch(Exception ex)
                {
                    return;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Mời bạn chọn sang thẻ Thao tác để thực hiện thao tác", "Thông báo");
                return;
            }
            DTO_NhanVien nhanvien = new DTO_NhanVien();
            nhanvien.Username = txtUserNameNhanVien.Text;
            //Kiểm tra thông tin ban đầu 
            if (txtHoTenNhanVien.Text == "" || txtDienThoaiNhanVien.Text == "" || txtPasswordNhanVien.Text == "" || txttDiaChiNhanVien.Text == "" || txtUserNameNhanVien.Text == "")
            {
                MessageBox.Show("Thông tin nhân viên cần phải được nhập đầy đủ ", "Thông báo");
                return;
            }

            
            //Kiểm tra chiều dài số điện thoại
            if (txtDienThoaiNhanVien.Text.Length < 6 || txtDienThoaiNhanVien.Text.Length > 12)
            {
                MessageBox.Show("Số điện thoại nhập chưa đúng định dạng từ 6 - 12 ký tự", "Thông báo");
                return;
            }

            if (StateButton == STATEBUTTON.INSERT)
            {
                //Kiểm tra username đã nhập tồn tại chưa

                bool state = BUS_QuanLyNhanVien.CheckUserNameNotExists(nhanvien);
                if (!state)
                {
                    MessageBox.Show("Username đã tồn tại, đề nghị đặt tên khác ", "Thông báo");
                    return;
                }

                nhanvien.HoTen = txtHoTenNhanVien.Text;
                nhanvien.DiaChi = txttDiaChiNhanVien.Text;
                nhanvien.DienThoai = txtDienThoaiNhanVien.Text;
                nhanvien.Username = txtUserNameNhanVien.Text;
                nhanvien.Password = txtPasswordNhanVien.Text;
                nhanvien.MaChucVu = Convert.ToInt32(dtChucVu.Rows[cboChucVuNhanVien.SelectedIndex][0].ToString());

                //Kiểm tra ảnh nếu không có thì gán null không thì gán tên ảnh;
                //Kiểm tra ảnh đã tồn tại trong Folder
                bool stateSaveImage = true;
                string pathImage = DuongDanToiAnh;
                try
                {
                    if (TenAnhInsert == string.Empty)
                    {
                        TenAnhInsert = "unknow.png";
                        ptrAnhDaiDien.Image = Image.FromFile(@"DanhSachNhanVien\unknow.png");
                    }
                    if (File.Exists(@"DanhSachNhanVien\" + TenAnhInsert))
                    {
                        stateSaveImage = false;
                    }
                }
                catch (Exception ex)
                {
                    TenAnhInsert = "unknow.png";
                }
                //Thêm tên ảnh cho nhân viên
                nhanvien.AnhDaiDien = TenAnhInsert;

                //Kiểm tra đã check hay chưa 
                if (chkDangLamViec.Checked) nhanvien.TinhTrang = "1";
                else
                    nhanvien.TinhTrang = "0";

                DialogResult r = MessageBox.Show("Bạn muốn thêm nhân viên? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    bool stateInsert = BUS_QuanLyNhanVien.InsertNhanVien(nhanvien);
                    if (stateInsert)
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        //Copy ảnh mới 
                        if (stateSaveImage)
                        {
                            try
                            {
                                string pathFolderProject = @"DanhSachNhanVien\";
                                var path = Path.Combine(pathFolderProject, Path.GetFileName(pathImage));
                                File.Copy(pathImage, path);
                                DuongDanToiAnh = string.Empty;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Thao tác thêm ảnh vào CSDL thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        //Trả trạng thái mặc định
                        txtHoTenNhanVien.Text = txttDiaChiNhanVien.Text = txtDienThoaiNhanVien.Text = txtPasswordNhanVien.Text = txtUserNameNhanVien.Text = string.Empty;
                        cboChucVuNhanVien.SelectedIndex = 0;
                        chkDangLamViec.Checked = false;
                        ptrAnhDaiDien.Image = null;
                        SetStateForThaoTac(true);
                        StateButton = STATEBUTTON.DEFAULT;
                        btnThemNhanVien.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnXoaNhanVien.Enabled = btnSuaNhanVien.Enabled = false;
                        DuongDanToiAnh = TenAnhInsert = string.Empty;
                        dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.LoadDanhSachNhanVien();
                    }
                    else
                        MessageBox.Show("Thêm nhân viên thất bại");

                   
                }
            }
            else
                if (StateButton == STATEBUTTON.UPDATE)
            {
                nhanvien.MaNV = Int32.Parse(dgvDanhSachNhanVien[0, indexSeLect].Value.ToString());
                nhanvien.HoTen = txtHoTenNhanVien.Text;
                nhanvien.DiaChi = txttDiaChiNhanVien.Text;
                nhanvien.DienThoai = txtDienThoaiNhanVien.Text;
                nhanvien.Username = txtUserNameNhanVien.Text;
                nhanvien.Password = txtPasswordNhanVien.Text;
                nhanvien.MaChucVu = Convert.ToInt32(dtChucVu.Rows[indexSeLect][0].ToString());
                if (chkDangLamViec.Checked) nhanvien.TinhTrang = "1";
                else
                    nhanvien.TinhTrang = "0";
                DialogResult r = MessageBox.Show("Bạn muốn cập nhật thông tin nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    bool state = BUS_QuanLyNhanVien.UpdateNhanVien(nhanvien);
                    if (state)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        txtHoTenNhanVien.Text = txttDiaChiNhanVien.Text = txtDienThoaiNhanVien.Text = txtPasswordNhanVien.Text = txtUserNameNhanVien.Text = string.Empty;
                        cboChucVuNhanVien.SelectedIndex = 0;
                        chkDangLamViec.Checked = false;
                        ptrAnhDaiDien.Image = null;
                        SetStateForThaoTac(true);
                        StateButton = STATEBUTTON.DEFAULT;
                        btnThemNhanVien.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnXoaNhanVien.Enabled = btnSuaNhanVien.Enabled = false;
                        DuongDanToiAnh = TenAnhInsert = string.Empty;
                        dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.LoadDanhSachNhanVien();
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại");
                }            
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Mời bạn chọn sang thẻ Thao tác để thực hiện thao tác", "Thông báo");
                return;
            }
            txtHoTenNhanVien.Text = txttDiaChiNhanVien.Text = txtDienThoaiNhanVien.Text = txtPasswordNhanVien.Text = txtUserNameNhanVien.Text = string.Empty;
            cboChucVuNhanVien.SelectedIndex = 0;
            chkDangLamViec.Checked = false;
            ptrAnhDaiDien.Image = null;
            SetStateForThaoTac(true);
            StateButton = STATEBUTTON.DEFAULT;
            btnThemNhanVien.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoaNhanVien.Enabled = btnSuaNhanVien.Enabled = false;
            DuongDanToiAnh = TenAnhInsert = string.Empty;
        }

        #endregion


    }
}
