using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class DAO_QuanLyTiecCuoi
    {
        public static DataTable GetTableDanhSachTiecCuoi()
        {
            string sqlCommand = @"SELECT * FROM TIECCUOI";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static DataTable GetTableSanh()
        {
            string sqlCommand = @"SELECT * FROM SANH";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static DataTable GetSanhInCa(string ngayDaiTiec, string ca)
        {
            string sqlCommand = string.Format("SELECT Sanh FROM TIECCUOI Where NgayDaiTiec='{0}' and Ca=N'{1}'",ngayDaiTiec,ca);
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static DataTable GetTableCa()
        {
            string sqlCommand = @"SELECT * FROM CA";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static DataTable SearchTiecTheoNgay(string ngayDaiTiec, string ca, string sanh)
        {
            string sTruyVan = string.Format("SELECT * FROM TIECCUOI WHERE NgayDaiTiec='{0}' and Ca like N'%{1}%' and Sanh like N'%{2}%'", ngayDaiTiec, ca, sanh);
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable SearchTiecKhongTheoNgay( string ca, string sanh)
        {
            string sTruyVan = string.Format("SELECT * FROM TIECCUOI WHERE Ca like N'%{0}%' and Sanh like N'%{1}%'", ca, sanh);
            return DatabaseHelper.GetData(sTruyVan);
        }
        // Tra ve false neu khong tim thay MaTiecCuoi trong TIECCUOI
        public static void DeleteTiecCuoi(string maTiecCuoi)
        {
            //if (DatabaseHelper.CountRecord(@"SELECT COUNT(*) FROM TIECCUOI WHERE MaTiecCuoi=" + maTiecCuoi) == 0)
                //return false;

            //DatabaseHelper.ExcuteSql(@"DELETE FROM CT_PHIEUDATBAN WHERE MaTC=" + maTiecCuoi + ";"
                                   //+ @"DELETE FROM CT_PHIEUDATDICHVU WHERE MaTC=" + maTiecCuoi + ";"
                                    //);
            DatabaseHelper.ExcuteSql(string.Format("DELETE FROM TIECCUOI WHERE MaTC='{0}'", maTiecCuoi));
            DatabaseHelper.ExcuteSql(string.Format("DELETE FROM CT_PHIEUDATBAN WHERE MaTC='{0}'", maTiecCuoi));
            DatabaseHelper.ExcuteSql(string.Format("DELETE FROM CT_PHIEUDATDICHVU WHERE MaTC='{0}'", maTiecCuoi));
        }
        public static DataTable GetDataPhieuDatMon(string maTiecCuoi)
        {
            string sTruyVan = string.Format("SELECT * FROM CT_PHIEUDATBAN  WHERE MaTC='{0}'", maTiecCuoi);
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetTableMonAnDonGiaDGTT(string maTiecCuoi)
        {
            return DatabaseHelper.GetData(@"SELECT M.MaMonAn, M.TenMonAn, C.DonGia AS 'DonGiaTT'
                                            FROM PHIEUDATBAN P JOIN CT_PHIEUDATBAN C ON P.MaPhieuDatBan = C.MaPhieuDatBan
	                                            JOIN MONAN M ON C.MaMonAn = M.MaMonAn
                                            WHERE MaTiecCuoi=" + maTiecCuoi);
        }

        public static DataTable GetTableMonAn()
        {
            return DatabaseHelper.GetData(@"SELECT * FROM MONAN");
        }

        public static DataTable GetTableDichVu()
        {
            return DatabaseHelper.GetData(@"SELECT * FROM DICHVU");
        }

        public static DataTable GetTablePhieuDichVu(string maTiecCuoi)
        {
            return DatabaseHelper.GetData(string.Format("SELECT * FROM CT_PHIEUDATDICHVU WHERE MaTC ='{0}' ", maTiecCuoi));
        }

        public static void UpdateTiecCuoi(DTO_TiecCuoi tiecCuoi)
        {
            DatabaseHelper.ExcuteSql(string.Format(
                "UPDATE TIECCUOI " +
                "SET TenChuRe=N'{0}', TenCoDau=N'{1}', DienThoai='{2}', NgayDaiTiec='{3}', MaCa={4}, MaSanh={5}, TienCoc={6}, GhiChu=N'{7}' " +
                "WHERE MaTiecCuoi={8}",
                tiecCuoi.TenChuRe, tiecCuoi.TenCoDau, tiecCuoi.DienThoai, tiecCuoi.NgayDaiTiec, tiecCuoi.Ca, tiecCuoi.Sanh, tiecCuoi.TienCoc, tiecCuoi.GhiChu,
                tiecCuoi.MaTC
                ));
        }

        public static void DeleteMonAn(int maTiecCuoi)
        {
            DatabaseHelper.ExcuteSql(@"DELETE CT_PHIEUDATBAN 
                                        FROM CT_PHIEUDATBAN c JOIN PHIEUDATBAN p ON c.MaPhieuDatBan=p.MaPhieuDatBan
                                        WHERE MaTiecCuoi=" + maTiecCuoi
                                    );
        }

        public static void UpdatePhieuDatBan(int maTiecCuoi, string soLuongBan, string soLuongBanDT, decimal donGiaBan)
        {
            DatabaseHelper.ExcuteSql(@"UPDATE PHIEUDATBAN SET SoBan=" + soLuongBan +
                ",SoBanDuTru=" + soLuongBanDT + ",DonGiaBan=" + donGiaBan
                + "WHERE MaTiecCuoi=" + maTiecCuoi);
        }

        public static DataTable GetMaPhieuDatBan(int maTiecCuoi)
        {
            return DatabaseHelper.GetData(@"SELECT MaPhieuDatBan FROM PHIEUDATBAN WHERE MaTiecCuoi=" + maTiecCuoi);
        }

        public static void InsertMonAn(int maPhieuDatBan, string maMonAn, string donGiaThucTe)
        {
            DatabaseHelper.ExcuteSql(@"INSERT INTO CT_PHIEUDATBAN (MaPhieuDatBan, MaMonAn, DonGia, SoLuong) VALUES
                                        (" + maPhieuDatBan + "," + maMonAn + "," + donGiaThucTe + ",0)");
        }

        public static void DeleteDichVu(int maTiecCuoi)
        {
            DatabaseHelper.ExcuteSql(@"DELETE CT_PHIEUDATDICHVU WHERE MaTiecCuoi=" + maTiecCuoi);
        }

        public static void InsertDichVu(int maTiecCuoi, string maDichVu, string donGiaTT, string soLuong)
        {
            DatabaseHelper.ExcuteSql(@"INSERT INTO CT_PHIEUDATDICHVU (MaTiecCuoi, MaDichVu, DonGia, SoLuong) VALUES
                                        (" + maTiecCuoi + "," + maDichVu + "," + donGiaTT + "," + soLuong + ")");
        }

        public static int CountTiecCuoi(string maTiecCuoi, string ngayDaiTiecSqlFormat, string maCa, string maSanh)
        {
            return DatabaseHelper.CountRecord(@"SELECT COUNT(*) FROM TIECCUOI WHERE NgayDaiTiec='" + ngayDaiTiecSqlFormat
                                                        + "' AND MaCa=" + maCa + " AND MaSanh=" + maSanh + " AND MaTiecCuoi !=" + maTiecCuoi);
        }
    }
}
