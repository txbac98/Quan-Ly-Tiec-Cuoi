using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_QuanLyTaiKhoan
    {
        public static DataTable GetData()
        {
            return DAO_QuanLyTaiKhoan.GetData();
        }
        public static bool ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            return DAO_QuanLyTaiKhoan.ThemTaiKhoan(taiKhoan);
        }
        public static void DeleteTaiKhoan(string taiKhoan)
        {
            DAO_QuanLyTaiKhoan.DeleteTaiKhoan(taiKhoan);
        }
        public static bool KiemTraDangNhap(DTO_DangNhap dangnhap)
        {
            return DAO_QuanLyTaiKhoan.KiemTraDangNhap(dangnhap);
        }
        public static bool DoiMatKhau(string taiKhoan,string matKhauMoi)
        {
            return DAO_QuanLyTaiKhoan.DoiMatKhau(taiKhoan,matKhauMoi);
        }
        public static DataTable GetPhanQuyen(DTO_DangNhap dangnhap)
        {
            return DAO_QuanLyTaiKhoan.GetPhanQuyen(dangnhap);
        }
        public static string GetMaNV(DTO_DangNhap dangnhap)
        {
            return DAO_QuanLyTaiKhoan.GetMaNV(dangnhap);
        }
        public static string GetTenNV(DTO_DangNhap dangnhap)
        {
            return DAO_QuanLyTaiKhoan.GetTenNV(dangnhap);
        }
    }
}
