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
        public static DataTable GetDataTableMonAn()
        {
            return DAO_MonAn.GetDataTableMonAn();
        }
        public static DataTable SearchMonAn(string tenMonAn, string loaiMonAn)
        {
            return DAO_MonAn.SearchMonAn(tenMonAn,loaiMonAn);
        }
        public static bool InsertMonAn(DTO_MonAn monAn)
        {
            if (!TenMonAnIsExistInMonAn(monAn.TenMonAn))
                return DAO_MonAn.InsertMonAn(monAn);
            return false;
        }
        public static bool UpdateMonAn(DTO_MonAn monAn)
        {
            if (!TenMonAnIsExistInMonAn(monAn.TenMonAn))
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