using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class DAO_QuanLyChucVu
    {
        public static DataTable GetDataTable()
        {
            DataTable result = DatabaseHelper.GetData(@"Select * from CHUCVU");
            return result;
        }
        public static string GetMaChucVu(string tenChucVu)
        {
            string sTruyVan= string.Format ("Select MaCV from CHUCVU where TenChucVu=N'" +tenChucVu+"'");
            DataTable result = DatabaseHelper.GetData(sTruyVan);
            return result.Rows[0][0].ToString();
        }
        public static bool InsertChucVu(DTO_ChucVu chucVu)
        {
            string sTruyVan = string.Format("Insert into CHUCVU(MaCV, TenChucVu ,GhiChu) values ('{0}',N'{1}',N'{2}')", chucVu.MaCV, chucVu.TenChucVu,chucVu.GhiChu);
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
        public static bool DeleteChucVu(string maCV)
        {
            string sTruyVan = string.Format("Delete ChucVu where MaCV=N'{0}'", maCV);
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
        public static bool MaCVIsExistInChucVu(string maCV)
        {
            string sqlCommand = @"SELECT MaCV FROM ChucVu WHERE MaCV='" + maCV + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }
        public static bool TenCVIsExistInChucVu(string tenCV)
        {
            string sqlCommand = @"SELECT TenChucVu FROM ChucVu WHERE TenChucVu=N'" + tenCV + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }

    }
}
