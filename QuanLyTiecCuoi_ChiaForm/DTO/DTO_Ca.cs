using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Ca
    {


        public DTO_Ca(string maCa, string thoiGianBD, string thoiGianKT)
        {
            MaCa = maCa;
            ThoiGianBD = thoiGianBD;
            ThoiGianKT = thoiGianKT;
        }
      
        public string MaCa { get; set; }
        public string ThoiGianBD { get; set; }
        public string ThoiGianKT { get; set; }
    }
   
}
