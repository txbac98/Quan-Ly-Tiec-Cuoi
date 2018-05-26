using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_MonAn
    {
        public static DataTable GetDataTableMonAn()
        {
            string query = @"SELECT * FROM MONAN";
            return DatabaseHelper.GetData(query);
        }
        public static DataTable SearchMonAn(string tenMonAn, string loaiMonAn)
        {
            string sTruyVan = string.Format("Select * from MONAN where TenMonAn like N'%{0}%' and LoaiMonAn like N'%{1}%'", tenMonAn,loaiMonAn);
            return DatabaseHelper.GetData(sTruyVan);

        }
        public static bool InsertMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"INSERT INTO MONAN (MaMonAn,TenMonAn,LoaiMonAn, DonGia, GhiChu, HinhAnh) VALUES ('{0}', N'{1}', N'{2}', {3},N'{4}',N'{5}')",
              monAn.MaMonAn,  monAn.TenMonAn, monAn.LoaiMonAn, monAn.DonGia, monAn.GhiChu, monAn.HinhAnh);
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

        public static bool UpdateMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"UPDATE MONAN SET TenMonAn=N'{0}',LoaiMonAn=N'{1}', DonGia={2}, GhiChu=N'{3}', HinhAnh=N'{4}' WHERE MaMonAn='{5}'",
                monAn.TenMonAn,monAn.LoaiMonAn, monAn.DonGia, monAn.GhiChu, monAn.HinhAnh, monAn.MaMonAn);
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
        public static bool DeleteMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"DELETE FROM MonAn WHERE MaMonAn='{0}'", monAn.MaMonAn);
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
        public static bool TenMonAnIsExistInMonAn(string tenMonAn)
        {
            string sqlCommand = @"SELECT TenMonAn FROM MonAn WHERE TenMonAn=N'" + tenMonAn + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }
        //public static int LastIndex()
        //{
        //    //string query = string.Format(@"SELECT TOP 1 MaMonAn FROM MONAN ORDER BY MaMonAn DESC");
        //    string query = string.Format(@"SELECT IDENT_CURRENT('MONAN')");
        //    return Int32.Parse(DatabaseHelper.GetData(query).Rows[0].ItemArray[0].ToString());
        //}
    }
}