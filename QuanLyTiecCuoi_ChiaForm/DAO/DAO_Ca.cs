using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Ca
    {
        public static string GetCurrentIndexTable()
        {
            return null;
        }
        public static int CheckCountInCurrentTable()
        {
            DataTable result = DatabaseHelper.GetData(@"Select * from Ca");
            return result.Rows.Count;
        }

        public static DataTable GetDataTable()
        {
            DataTable result = DatabaseHelper.GetData(@"Select * from Ca");
            return result;
        }

        public static bool InsertCa(DTO_Ca ca)
        {
            string sTruyVan = string.Format("Insert into Ca(MaCa, ThoiGianBD, ThoiGianKT) values (N'{0}','{1}','{2}')", ca.MaCa, ca.ThoiGianBD,ca.ThoiGianKT);
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

        public static void DeleteCa(string  maCa)
        {
            string sTruyVan = string.Format("Delete from Ca where MaCa = '{0}'", maCa);
            DatabaseHelper.ExcuteSql(sTruyVan);

        }

        public static bool UpdateCa(DTO_Ca ca)
        {
            string sTruyVan = string.Format("Update Ca set ThoiGianBD='{0}', ThoiGianKT='{1}' where MaCa=N'{2}'", ca.ThoiGianBD,ca.ThoiGianKT, ca.MaCa);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch 
            {

            }
            return false;
        }
        public static bool TenCaIsExistInCa(string maCa)
        {
            string sqlCommand = @"SELECT MaCa FROM Ca WHERE MaCa=N'" + maCa + "'";
            if (DatabaseHelper.GetData(sqlCommand).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
