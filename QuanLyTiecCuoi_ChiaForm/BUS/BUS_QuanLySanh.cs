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
    public class BUS_QuanLySanh
    {

        private static List<string> mListMaSanh;
        public static bool mIsSanhDataEmpty;
        public static void Init()
        {
            GetListsInTableSanh();
        }
        public static DataTable GetQLSanhTable()
        {
            return DAO_QuanLySanh.GetQLSanhTable();
        }
        public static void DeleteSanh(DTO_Sanh sanh)
        {
            DAO_QuanLySanh.DeleteSanh(sanh);
        }
        private static void GetListsInTableSanh()
        {
            DataTable dt = GetQLSanhTable();
            if (dt.Rows.Count == 0)
            {
                mIsSanhDataEmpty = true;
                return;
            }
            mIsSanhDataEmpty = false;
            mListMaSanh = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                mListMaSanh.Add(item[0].ToString());
            }
        }
        public static List<string> GetListMaSanh()
        {
            return mListMaSanh;
        }

        public static string GetSoLuongBanToiDa(string maSanh)
        {
            return DAO_QuanLySanh.GetSoLuongBanToiDa(maSanh);
        }
        public static string GetDonGiaBanToiThieu(string maSanh)
        {
            return DAO_QuanLySanh.GetDonGiaBanToiThieu(maSanh);
        }

        public static bool InsertSanh(DTO_Sanh sanh)
        {
            return DAO_QuanLySanh.InsertSanh(sanh);
        }
        public static int UpdateSanh(DTO_Sanh sanh)
        {
            return DAO_QuanLySanh.UpdateSanh(sanh);
        }
    }
}
