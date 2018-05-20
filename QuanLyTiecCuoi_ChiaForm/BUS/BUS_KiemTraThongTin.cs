using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class BUS_KiemTraThongTin
    {
        public static bool KiemTraDienThoai(string dienThoai)
        {
            if (dienThoai[0] != '0') return false;
            if (dienThoai.Length < 10 || dienThoai.Length > 11) return false;
            for (int i=0; i<dienThoai.Length; i++)
            {
                int chuSo;
                if (!int.TryParse(dienThoai[i].ToString(), out chuSo)) return false;
            }
            return true;
        }

        public static bool KiemTraNamSinh(string namSinh)
        {
            int ns;
            if (!int.TryParse(namSinh, out ns)) return false;
            else if (ns > DateTime.Now.Year || ns < 1900) return false;
            return true;
        }


    }
}
