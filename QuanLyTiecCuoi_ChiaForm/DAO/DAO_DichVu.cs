using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_DichVu
    {
        public static DataTable GetDataTableDichVu()
        {
            string query = @"SELECT * FROM DICHVU";
            return DatabaseHelper.GetData(query);
        }
        public static string GetDonGia(string tenDichVu)
        {
            DataTable result;
            string sTruyvan= string.Format("Select DonGia from DICHVU where TenDichVu = N'{0}'", tenDichVu);
            result = DatabaseHelper.GetData(sTruyvan);
            return result.Rows[0][0].ToString();
        }
        public static string GetMaDV(string tenDichVu)
        {
            DataTable result;
            string sTruyvan = string.Format("Select MaDV from DICHVU where TenDichVu = N'{0}'", tenDichVu);
            result = DatabaseHelper.GetData(sTruyvan);
            return result.Rows[0][0].ToString();
        }
        public static string GetHinhAnh(string tenDichVu)
        {
            DataTable result;
            string sTruyvan = string.Format("Select HinhAnh from DICHVU where TenDichVu = N'{0}'", tenDichVu);
            result = DatabaseHelper.GetData(sTruyvan);
            return result.Rows[0][0].ToString();
        }
        public static DataTable SearchDichVu(string tenDichVu)
        {
            string sTruyVan = string.Format("Select * from DICHVU where TenDichVu like N'%{0}%'", tenDichVu);
            return DatabaseHelper.GetData(sTruyVan);

        }
        public static bool InsertDichVu(DTO_DichVu dichVu)
        {
            string query = String.Format(@"INSERT INTO DICHVU (MaDV, TenDichVu, DonGia, GhiChu, HinhAnh) VALUES ('{0}', N'{1}', {2}, N'{3}',N'{4}')",
                dichVu.MaDichVu, dichVu.TenDichVu, dichVu.DonGia, dichVu.GhiChu, dichVu.HinhAnh);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool UpdateDichVu(DTO_DichVu dichVu)
        {
            string query = String.Format(@"UPDATE DICHVU SET TenDichVu=N'{0}', DonGia={1}, GhiChu=N'{2}', HinhAnh=N'{3}' WHERE MaDV='{4}'",
               dichVu.TenDichVu, dichVu.DonGia, dichVu.GhiChu, dichVu.HinhAnh, dichVu.MaDichVu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool DeleteDichVu(DTO_DichVu dichVu)
        {
            string query = String.Format(@"DELETE FROM DICHVU WHERE MaDV='{0}'", dichVu.MaDichVu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool TenDichVuIsExistInDichVu(string tenDichVu)
        {
            string sqlCommand = @"SELECT TenDichVu FROM DichVu WHERE TenDichVu=N'" + tenDichVu + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }
        //public static int LastIndex()
        //{
        //    //string query = string.Format(@"SELECT TOP 1 MaDichVu FROM DICHVU ORDER BY MaDichVu DESC");
        //    string query = string.Format(@"SELECT IDENT_CURRENT('DICHVU')");
        //    return Int32.Parse(DatabaseHelper.GetData(query).Rows[0].ItemArray[0].ToString());
        //}
    }
}