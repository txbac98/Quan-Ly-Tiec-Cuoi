using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        public DTO_ChucVu(string maCV, string tenChucVu,string ghiChu)
        {
            MaCV = maCV;
            TenChucVu = tenChucVu;
            GhiChu = ghiChu;
        }

        public string MaCV { get; set; }
        public string TenChucVu { get; set; }
        public string GhiChu { get; set; }

    }

}
