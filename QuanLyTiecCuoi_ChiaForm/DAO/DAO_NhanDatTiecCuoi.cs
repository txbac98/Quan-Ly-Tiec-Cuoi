using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_NhanDatTiecCuoi
    {
        public static DataTable GetSanh()
        {
            string sTruyVan = "Select TenSanh from Sanh";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetCa()
        {
            string sTruyVan = "Select * from Ca";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static bool CheckStateTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format(@"Select * from TiecCuoi where MaCa={0} and NgayDaiTiec={1}", tieccuoi.Ca, tieccuoi.NgayDaiTiec);
            return DatabaseHelper.CheckIfExists(sTruyVan);
        }
        public static DataTable GetDate(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format(@"Select * from TiecCuoi  where (DAY(NgayDaiTiec) = DAY('{0}')) and (MONTH(NgayDaiTiec) = MONTH('{0}')) and (YEAR(NgayDaiTiec) = YEAR('{0}')) and (MaCa='{1}') and (MaSanh='{2}')", tieccuoi.NgayDaiTiec, tieccuoi.Ca, tieccuoi.Sanh);
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetLastID()
        {
            string struyvan = @"select MaTiecCuoi from TiecCuoi WHERE MaTiecCuoi = (SELECT MAX(MaTiecCuoi)  FROM TiecCuoi)";
            return DatabaseHelper.GetData(struyvan);
        }
        public static bool InsertTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format("Insert into TiecCuoi(MaTC,MaKH,TenChuRe,NamSinhChuRe,TenCoDau,NamSinhCoDau,DienThoai,DiaChi, NgayDatTiec,NgayDaiTiec,Ca,Sanh,SoLuongBan,TongSoTien ,TienCoc,GhiChu, MaNV) values ('{0}','{1}',N'{2}',{3},N'{4}',{5},'{6}',N'{7}', '{8}','{9}',N'{10}',N'{11}',{12},{13},{14},N'{15}', '{16}')",
                tieccuoi.MaTC,tieccuoi.MaKH,tieccuoi.TenChuRe,tieccuoi.NamSinhChuRe, tieccuoi.TenCoDau,tieccuoi.NamSinhCoDau, tieccuoi.DienThoai,tieccuoi.DiaChi, tieccuoi.NgayDatTiec.ToShortDateString(), tieccuoi.NgayDaiTiec.ToShortDateString(), tieccuoi.Ca, tieccuoi.Sanh,tieccuoi.SoBan,tieccuoi.TongSoTien, tieccuoi.TienCoc, tieccuoi.GhiChu, tieccuoi.MaNV);
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
        public static bool InsertPhieuDatBan(DTO_PhieuDatBan phieudatban)
        {
            string sTruyVan = string.Format("Insert into PhieuDatBan(MaTiecCuoi, SoBan,SoBanDuTru,DonGiaBan,GhiChu) values({0},{1},{2},{3},N'{4}')",
                phieudatban.MaTiecCuoi, phieudatban.SoBan, phieudatban.SoBanDuTru, phieudatban.DonGiaBan, phieudatban.GhiChu);
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
        public static void DeletePhieuDatDichVu(string maTiecCuoi)
        {
            string sTruyVan = string.Format("Delete from CT_PHIEUDATDICHVU Where MaTC='{0}'", maTiecCuoi);
            DatabaseHelper.ExcuteSql(sTruyVan);
        }
        public static void DeletePhieuDatMonAn(string maTiecCuoi)
        {
            string sTruyVan = string.Format("Delete from CT_PHIEUDATBAN Where MaTC='{0}'", maTiecCuoi);
            DatabaseHelper.ExcuteSql(sTruyVan);
        }
        public static DataTable GetLastIDPhieu()
        {
            string struyvan = @"select MaPhieuDatBan from PhieuDatBan WHERE MaPhieuDatBan = (SELECT MAX(MaPhieuDatBan)  FROM PhieuDatBan)";
            return DatabaseHelper.GetData(struyvan);
        }
        public static bool InsertChiTietDatBan(DTO_CT_PhieuDatBan ctphieudatban)
        {
            string sTruyVan = string.Format("Insert into CT_PHIEUDATBAN(MaTC,LoaiMonAn, TenMonAn,DonGia, SoLuong, GhiChu) values('{0}',N'{1}',N'{2}',{3},{4},N'{5}')",
                ctphieudatban.MaTiecCuoi,ctphieudatban.LoaiMonAn, ctphieudatban.TenMonAn, ctphieudatban.DonGia, ctphieudatban.SoLuong, ctphieudatban.GhiChu);
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
        public static bool CheckDaLapTiecCuoi(DTO_TiecCuoi tieccuoi)
        {
            string sTruyVan = string.Format(@"select * from TIECCUOI where (DienThoai=N'{0}') and ((TenChuRe=N'{1}') or (TenCoDau=N'{2}')) and ((TinhTrangTiec = 1) or (TinhTrangTiec = 2))",
                tieccuoi.DienThoai, tieccuoi.TenChuRe, tieccuoi.TenCoDau, tieccuoi.TinhTrangTiec);
            try
            {
                DataTable res = DatabaseHelper.GetData(sTruyVan);
                if (res.Rows.Count > 0)
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
        public static bool InsertChiTietDatDichVu(DTO_CT_PhieuDatDichVu ctphieudatdichvu)
        {
            string sTruyVan = string.Format("Insert into CT_PHIEUDATDICHVU(MaTC, TenDichVu, Soluong, DonGia, GhiChu) values('{0}',N'{1}',{2},{3},N'{4}')",
                ctphieudatdichvu.MaTiecCuoi, ctphieudatdichvu.TenDichVu, ctphieudatdichvu.SoLuong, ctphieudatdichvu.DonGia,ctphieudatdichvu.GhiChu);
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
    }
}
