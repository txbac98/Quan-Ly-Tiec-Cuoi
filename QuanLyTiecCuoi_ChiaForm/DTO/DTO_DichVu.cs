using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DichVu
    {
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGia { get; set; }
        public string GhiChu { get; set; }
        public string HinhAnh { get; set; }

        public DTO_DichVu(string maDichVu, string tenDichVu, string donGia, string ghiChu, string hinhAnh)
        {
            MaDichVu = maDichVu;
            TenDichVu = tenDichVu;
            DonGia = long.Parse(donGia);
            GhiChu = ghiChu;
            HinhAnh = hinhAnh;

        }
    }
}