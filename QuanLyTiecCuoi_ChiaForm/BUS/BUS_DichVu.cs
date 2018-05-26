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
                mListTenDichVu.Add(item[0].ToString()+"         "+item[1].ToString());
            }
        }
        public static List<string> GetListDichVu()
        {
            return mListTenDichVu;
        }
        public static bool InsertDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.InsertDichVu(dichVu);
        }
        public static bool UpdateDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.UpdateDichVu(dichVu);
        }
        public static bool DeleteDichVu(DTO_DichVu dichVu)
        {
            return DAO_DichVu.DeleteDichVu(dichVu);
        }
        public static int LastIndex()
        {
            return DAO_DichVu.LastIndex();
        }
    }
}