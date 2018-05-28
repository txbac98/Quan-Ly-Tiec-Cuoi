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
            string sqlCommand = @"SELECT * FROM  Sanh ";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static void DeleteSanh(string maSanh)
        {
            string sqlCommand = string.Format(@"DELETE FROM Sanh WHERE MaSanh=N'{0}'", maSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LoaiSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DataTable SearchSanhTableTheoTen(string maSanh)
        {
            string sqlCommand = string.Format(@"SELECT * FROM SANH WHERE MaSanh LIKE N'%{0}%'", maSanh);
            return DatabaseHelper.GetData(sqlCommand);

        }
        public static string GetSoLuongBanToiDa(string maSanh)
        {
            DataTable result;
            string sqlCommand = string.Format(@"SELECT SoLuongBanTD from SANH where MaSanh=N'{0}'", maSanh);
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
            string sqlCommand = string.Format(@"INSERT INTO Sanh (MaSanh, DonGiaBan, SoLuongBanTD, GhiChu) VALUES (N'{0}', {1}, {2},N'{3}')", sanh.MaSanh, sanh.DonGiaBan, sanh.SoLuongBanTD, sanh.GhiChu);

            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
            //return DatabaseHelper.ExecuteNonQuery(sqlCommand);
        }
        public static bool UpdateSanh(DTO_Sanh sanh)
        {
            string sqlCommand = String.Format(@"UPDATE Sanh SET MaSanh=N'{0}', DonGiaBan={1}, SoLuongBanToiDa={2}, GhiChu=N'{3}' WHERE MaSanh=N'{4}'",
                sanh.MaSanh ,sanh.DonGiaBan,sanh.SoLuongBanTD, sanh.GhiChu,sanh.MaSanh);
            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
        }
        public static bool TenSanhIsExistInSanh(string maSanh)
        {
            string sqlCommand = @"SELECT MaSanh FROM Sanh WHERE MaSanh=N'" + maSanh + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
