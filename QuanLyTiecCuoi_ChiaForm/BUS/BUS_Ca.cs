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
    public class BUS_Ca
    {
        private static List<string> mListCa;


        public static bool mIsCaDataEmpty;

        public static void Init()
        {
            GetListsInTableCa();
        }
        public static string GetCurrentIndexTable()
        {
            return null;
        }
        private static void GetListsInTableCa()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0)
            {
                mIsCaDataEmpty = true;
                return;
            }
            mIsCaDataEmpty = false;
            mListCa = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                mListCa.Add(item[0].ToString()+ "     ("+item[1].ToString()+" - "+item[2].ToString()+")");
                
                //mListThoiGianBD.Add(item[2].ToString());
                //mListThoiGianKT.Add(item[3].ToString());
                //mListCa.Add(item[0].ToString() + "\t" + item[2].ToString() + " - " + item[3].ToString());
            }
        }
        public static List<string> GetListCa()
        {
            return mListCa;
        }
        public static int CheckCountInCurrentTable()
        {
            return DAO_Ca.CheckCountInCurrentTable();
        }
        public static DataTable GetDataTable()
        {
            return DAO_Ca.GetDataTable();
        }
        public static bool InsertCa(DTO_Ca ca)
        {
            return DAO_Ca.InsertCa(ca);
        }
        public static bool UpdateCa(DTO_Ca ca)
        {
            return DAO_Ca.UpdateCa(ca);
        }
        public static bool DeleteCa(DTO_Ca ca)
        {
            return DAO_Ca.DeleteCa(ca);
        }
    }
}
