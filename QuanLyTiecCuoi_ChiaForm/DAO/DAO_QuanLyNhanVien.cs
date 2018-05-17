using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_QuanLyNhanVien
    {

        public static DataTable GetDataTable()
        {
            string sTruyVan = "Select * from NHANVIEN";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable LoadChucVu()
        {
            string sTruyVan = "Select * from CHUCVU";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable LoadDanhSachNhanVien()
        {
            string sTruyVan = "Select * from NHANVIEN, CHUCVU where NHANVIEN.MaChucVu = CHUCVU.MaChucVu";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static bool CheckUserNameNotExists(DTO_NhanVien nhanvien)
        {
            string sTruyVan = string.Format(@"Select * from NHANVIEN where UserName=N'{0}'", nhanvien.Username);
            try
            {
                DataTable state = DatabaseHelper.GetData(sTruyVan);
                if (state.Rows.Count > 0)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool InsertNhanVien(DTO_NhanVien nhanvien)
        {
            string sTruyVan = string.Format(@"Insert into NhanVien(MaNV, HoTen, GioiTinh, NgaySinh, ChucVu, DienThoai, DiaChi, AnhDaiDien) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5},N'{6}', N'{7}',N'{8}')",
                nhanvien.MaNV,nhanvien.HoTen, nhanvien.GioiTinh, nhanvien.NgaySinh, nhanvien.ChucVu, nhanvien.DienThoai, nhanvien.DiaChi, nhanvien.AnhDaiDien);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool UpdateNhanVien(DTO_NhanVien nhanvien)
        {
            string sTruyVan = string.Format(@"Update NHANVIEN set HoTen=N'{0}', GioiTinh=N'{1}', NgaySinh=N'{2}', ChucVu={3}, DienThoai=N'{4}',DiaChi=N'{5}', AnhDaiDien=N'{6}' WHERE MaNV ={7}",
                nhanvien.HoTen, nhanvien.GioiTinh, nhanvien.NgaySinh, nhanvien.ChucVu, nhanvien.DienThoai,nhanvien.DiaChi,nhanvien.AnhDaiDien, nhanvien.MaNV);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool DeleteNhanVien(DTO_NhanVien nhanvien)
        {
            string sTruyVan = string.Format(@"Delete NHANVIEN where MaNV='{0}'", nhanvien.MaNV);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool CheckRowEffectLargerThanOnce(string anhdaidien)
        {
            string sTruyVan = string.Format(@"Select * from NHANVIEN where AnhDaiDien = N'{0}'", anhdaidien);
            try
            {
                DataTable state = DatabaseHelper.GetData(sTruyVan);
                if (state.Rows.Count > 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public static bool CheckNhanVienKhongLapHopDong(string manhanvien)
        {
            string sTruyVan = string.Format(@"Select * from TIECCUOI where (MaNV= N'{0}') AND (TinhTrangTiec = 0)", manhanvien);
            try
            {
                DataTable state = DatabaseHelper.GetData(sTruyVan);
                if (state.Rows.Count > 0)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
