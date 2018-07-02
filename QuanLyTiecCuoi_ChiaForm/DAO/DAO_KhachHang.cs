using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_KhachHang
    {
        public static DataTable GetDataTable()
        {
            DataTable result = DatabaseHelper.GetData(@"Select * from KHACHHANG");
            return result;
        }
        public static bool InsertKhachHang(DTO_KhachHang khachhang)
        {
            string sTruyVan = string.Format("Insert into KHACHHANG(MaKH,TenChuRe,NamSinhChuRe,TenCoDau,NamSinhCoDau,DienThoai,DiaChi) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", khachhang.MaKH, khachhang.TenChuRe,khachhang.NamSinhChuRe, khachhang.TenCoDau,khachhang.NamSinhCoDau, khachhang.DienThoai, khachhang.DiaChi);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch 
            {
                return false;
            }
            return false;
        }
        public static DataTable SearchKhachHangTheoMa(string maKH)
        {
            string sTruyVan = string.Format("Select * from KHACHHANG where MaKH like N'%{0}%'", maKH);
            return DatabaseHelper.GetData(sTruyVan);

        }

        public static DataTable SearchKhachHangTheoTen(string tenChuRe, string tenCoDau)
        {
            string sTruyVan = string.Format("Select * from KHACHHANG where dbo.BoDau(tenChuRe) like N'%{0}%' and dbo.BoDau(TenCoDau) like N'%{1}%'", tenChuRe, tenCoDau);
            return DatabaseHelper.GetData(sTruyVan);

        }
        public static bool UpdateKhachHang(DTO_KhachHang khachhang)
        {
            string sTruyVan = string.Format("Update KhachHang set TenChuRe=N'{0}', NamSinhChuRe=N'{1}', TenCoDau=N'{2}', NamSinhCoDau=N'{3}', DienThoai=N'{4}', DiaChi=N'{5}' where MaKH=N'{6}'", khachhang.TenChuRe,khachhang.NamSinhChuRe, khachhang.TenCoDau,khachhang.NamSinhCoDau, khachhang.DienThoai, khachhang.DiaChi, khachhang.MaKH);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public static bool DeleteKhachHang(string maKH)
        {
            string sTruyVan = string.Format("Delete KhachHang where MaKH=N'{0}'", maKH);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
