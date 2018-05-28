using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_QuanLyChucVu
    {
        public static bool mIsChucVuDataEmpty;
        private static List<string> mListTenChucVu;
        private static List<string> mListTenChucVu_TimKiem;
        public static void Init()
        {
            GetListsInTableChucVu();
        }
        private static void GetListsInTableChucVu()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0)
            {
                mIsChucVuDataEmpty = true;
                return;
            }
            mIsChucVuDataEmpty = false;
            mListTenChucVu = new List<string>();
            mListTenChucVu_TimKiem = new List<string>();
            mListTenChucVu_TimKiem.Add("");
            foreach (DataRow item in dt.Rows)
            {
                mListTenChucVu.Add(item[2].ToString());
                mListTenChucVu_TimKiem.Add(item[2].ToString());
            }
        }
        public static string GetMaChucVu(string tenChucVu)
        {
            return DAO_QuanLyChucVu.GetMaChucVu(tenChucVu);
        }
        public static List<string> GetListChucVu()
        {
            return mListTenChucVu;
        }
        public static List<string> GetListChucVu_TimKiem()
        {
            return mListTenChucVu_TimKiem;
        }
        public static DataTable GetDataTable()
        {
            return DAO_QuanLyChucVu.GetDataTable();
        }
        public static bool InsertChucVu(DTO_ChucVu chucVu)
        {
            return DAO_QuanLyChucVu.InsertChucVu(chucVu);
        }
        public static bool DeleteChucVu(string maCV)
        {
            return DAO_QuanLyChucVu.DeleteChucVu(maCV);
        }
        public static bool MaCVIsExistInChucVu(string maCV)
        {
            return DAO_QuanLyChucVu.MaCVIsExistInChucVu(maCV);
        }
        public static bool TenCVIsExistInChucVu(string tenCV)
        {
            return DAO_QuanLyChucVu.TenCVIsExistInChucVu(tenCV);
        }
    }
}
