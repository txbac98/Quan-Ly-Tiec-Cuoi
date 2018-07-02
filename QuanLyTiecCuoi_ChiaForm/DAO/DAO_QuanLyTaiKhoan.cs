using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_QuanLyTaiKhoan
    {
        public static DataTable GetData()
        {
            string sTruyVan = @"Select * from TaiKhoan";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static bool ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            string sTruyVan = string.Format(@"INSERT INTO TAIKHOAN(TaiKhoan, MatKhau, MaNV, TenNhanVien) VALUES ('{0}', '{1}', '{2}',N'{3}')", taiKhoan.TaiKhoan, taiKhoan.MatKhau, taiKhoan.MaNV, taiKhoan.TenNhanVien);
            if (DatabaseHelper.ExcuteSql(sTruyVan) == 1) return true;
            return false;
        }
        public static void DeleteTaiKhoan(string taiKhoan)
        {
            string sTruyVan = string.Format(@"Delete from TaiKhoan where TaiKhoan='{0}'", taiKhoan);
            DatabaseHelper.ExcuteSql(sTruyVan);
        }
        public static bool DoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            string sTruyVan = string.Format(@"Update TaiKhoan set MatKhau='{0}' where TaiKhoan='{1}'",matKhauMoi, taiKhoan);
            if (DatabaseHelper.ExcuteSql(sTruyVan) == 1) return true;
            return false;
        }
        public static DataTable GetPhanQuyen(DTO_DangNhap dangnhap)
        {
            string sTruyVan = string.Format(@"Select * from NHANVIEN,CHUCVU where (Username='{0}') and (Password='{1}') and (NhanVien.MaChucVu = Chucvu.MaChucVu)", dangnhap.Username, dangnhap.Password);
            DataTable state = DatabaseHelper.GetData(sTruyVan);
            return state;
        }
        public static string GetMaNV(DTO_DangNhap dangnhap)
        {
            string sTruyVan = string.Format(@"Select MaNV from TaiKhoan where (TaiKhoan='{0}') and (MatKhau='{1}') ", dangnhap.Username, dangnhap.Password);
            DataTable state = DatabaseHelper.GetData(sTruyVan);
            return state.Rows[0][0].ToString();
        }
        public static string GetTenNV(DTO_DangNhap dangnhap)
        {
            string sTruyVan = string.Format(@"Select TenNhanVien from TaiKhoan where (TaiKhoan='{0}') and (MatKhau='{1}') ", dangnhap.Username, dangnhap.Password);
            DataTable state = DatabaseHelper.GetData(sTruyVan);
            return state.Rows[0][0].ToString();
        }
        public static bool KiemTraDangNhap(DTO_DangNhap dangnhap)
        {
            string sTruyVan = string.Format(@"Select * from TAIKHOAN where (TaiKhoan='{0}') and (MatKhau='{1}')", dangnhap.Username, dangnhap.Password);
            try
            {
                DataTable state = DatabaseHelper.GetData(sTruyVan);
                if (state.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}
