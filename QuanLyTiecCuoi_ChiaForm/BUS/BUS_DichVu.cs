using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DichVu
    {
        public static bool mIsDichVuDataEmpty;
        private static List<string>  mListTenDichVu;
        public static DataTable GetDataTableDichVu()
        {
            return DAO_DichVu.GetDataTableDichVu();
        }

        public static void Init()
        {
            GetListsInTableDichVu();
        }
        private static void GetListsInTableDichVu()
        {
            DataTable dt = GetDataTableDichVu();
            if (dt.Rows.Count == 0)
            {
                mIsDichVuDataEmpty = true;
                return;
            }
            mIsDichVuDataEmpty = false;
            mListTenDichVu = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                mListTenDichVu.Add(item[1].ToString());
            }
        }
        public static List<string> GetListDichVu()
        {
            return mListTenDichVu;
        }
        public static string GetDonGia(string tenDichVu)
        {
            return DAO_DichVu.GetDonGia(tenDichVu);
        }
        public static string GetHinhAnh(string tenDichVu)
        {
            return DAO_DichVu.GetHinhAnh(tenDichVu);
        }
        public static string GetMaDV(string tenDichVu)
        {
            return DAO_DichVu.GetMaDV(tenDichVu);
        }
        public static DataTable SearchDichVu(string tenDichVu)
        {
            return DAO_DichVu.SearchDichVu(tenDichVu);
        }
        public static bool InsertDichVu(DTO_DichVu dichVu)
        {
            if (!TenDichVuIsExistInDichVu(dichVu.TenDichVu))
                return DAO_DichVu.InsertDichVu(dichVu);
            return false;
        }
        public static bool UpdateDichVu(DTO_DichVu dichVu, string tenDichVuCu)
        {
            if (dichVu.TenDichVu==tenDichVuCu)  return DAO_DichVu.UpdateDichVu(dichVu);
            if (!TenDichVuIsExistInDichVu(dichVu.TenDichVu)) return DAO_DichVu.UpdateDichVu(dichVu);
            return false;
        }
        public static bool DeleteDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.DeleteDichVu(dichVu);
        }
        public static bool TenDichVuIsExistInDichVu(string tenDichVu)
        {
            return DAO_DichVu.TenDichVuIsExistInDichVu(tenDichVu);
        }
        //public static int LastIndex()
        //{
        //    return DAO_DichVu.LastIndex();
        //}
    }
}