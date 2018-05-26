using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QuanLySanh
    {
        public static DataTable GetQLSanhTable()
        {
            string sqlCommand = @"SELECT MaSanh, TenSanh, SoLuongBanToiDa, DonGiaBan, GhiChu FROM  Sanh ";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static void DeleteSanh(DTO_Sanh sanh)
        {
            string sqlCommand = string.Format(@"DELETE FROM Sanh WHERE MaSanh={0}", sanh.maSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LoaiSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable SearchSanhTableTheoTen(string tenSanh)
        {
            string sqlCommand = string.Format(@"SELECT * FROM SANH WHERE TenSanh LIKE N'%{0}%'", tenSanh);
            return DatabaseHelper.GetData(sqlCommand);

        }
        public static string GetSoLuongBanToiDa(string maSanh)
        {
            DataTable result;
            string sqlCommand = string.Format(@"SELECT SoLuongBanToiDa from SANH where MaSanh=N'{0}'", maSanh);
            result = DatabaseHelper.GetData(sqlCommand);
            return result.Rows[0][0].ToString();
        }
        public static string GetDonGiaBanToiThieu(string maSanh)
        {
            DataTable result;
            string sqlCommand = string.Format(@"SELECT DonGiaBan from SANH where MaSanh=N'{0}'", maSanh);
            result = DatabaseHelper.GetData(sqlCommand);
            return result.Rows[0][0].ToString();
        }
        public static bool InsertSanh(DTO_Sanh sanh)
        {
            //string sqlCommand = @"SELECT * FROM LoaiSanh";
            string sqlCommand = string.Format(@"INSERT INTO Sanh (TenSanh, MaLoaiSanh, SoLuongBanToiDa,DonGiaBan, GhiChu) VALUES (N'{0}', N'{1}', {2}, {3},N'{4}')", sanh.tenSanh, sanh.soLuongBanToiDa, sanh.donGiaBan, sanh.ghiChu);

            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
            //return DatabaseHelper.ExecuteNonQuery(sqlCommand);
        }
        public static int UpdateSanh(DTO_Sanh sanh)
        {
            string sqlCommand = String.Format(@"UPDATE Sanh SET TenSanh=N'{0}', SoLuongBanToiDa={2},DonGiaBan={3}, GhiChu=N'{4}' WHERE MaSanh=N'{4}'",
                sanh.tenSanh ,sanh.soLuongBanToiDa,sanh.donGiaBan, sanh.ghiChu, sanh.maSanh);
            return DatabaseHelper.ExcuteSql(sqlCommand);
        }
    }
}
