using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_MonAn
    {
        public static bool mIsMonAnDataEmpty;
        private static List<string> mListTenMonAn;
        public static DataTable GetDataTableMonAn()
        {
            return DAO_MonAn.GetDataTableMonAn();
        }

        public static void GetListMonAn(string loaiMonAn)
        {
            DataTable dt = SearchMonAnTheoLoai(loaiMonAn);
            if (dt.Rows.Count == 0)
            {
                mIsMonAnDataEmpty = true;
                return;
            }
            mIsMonAnDataEmpty = false;
            mListTenMonAn = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                mListTenMonAn.Add(item[0].ToString());
            }
        }
        public static List<string> GetListMonAnTheoLoai(string loaiMonAn)
        {
            GetListMonAn(loaiMonAn);
            return mListTenMonAn;
        }
        public static string GetDonGia(string tenMonAn)
        {
            return DAO_MonAn.GetDonGia(tenMonAn);
        }
        public static string GetHinhAnh(string tenMonAn)
        {
            return DAO_MonAn.GetHinhAnh(tenMonAn);
        }
        public static DataTable SearchMonAn(string tenMonAn, string loaiMonAn)
        {
            return DAO_MonAn.SearchMonAn(tenMonAn,loaiMonAn);
        }
        public static DataTable SearchMonAnTheoLoai(string loaiMonAn)
        {
            return DAO_MonAn.SearchMonAnTheoLoai(loaiMonAn);
        }
        public static bool InsertMonAn(DTO_MonAn monAn)
        {
            if (!TenMonAnIsExistInMonAn(monAn.TenMonAn))
                return DAO_MonAn.InsertMonAn(monAn);
            return false;
        }
        public static bool UpdateMonAn(DTO_MonAn monAn, string tenMonAnCu)
        {
            if (monAn.TenMonAn==tenMonAnCu) return DAO_MonAn.UpdateMonAn(monAn);
            if (!TenMonAnIsExistInMonAn(tenMonAnCu))
                return DAO_MonAn.UpdateMonAn(monAn);
            return false;
        }
        public static bool DeleteMonAn(DTO_MonAn monAn)
        {
            return DAO_MonAn.DeleteMonAn(monAn);
        }
        public static bool TenMonAnIsExistInMonAn(string tenMonAn)
        {
            return DAO_MonAn.TenMonAnIsExistInMonAn(tenMonAn);
        }
        //public static int LastIndex()
        //{
        //    return DAO_MonAn.LastIndex();
        //}
    }
}