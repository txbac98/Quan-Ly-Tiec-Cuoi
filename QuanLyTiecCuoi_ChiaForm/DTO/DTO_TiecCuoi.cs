using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TiecCuoi
    {
        public string MaTC { get; set; }
        public string MaKH { get; set; }
        public string TenChuRe { get; set; }
        public int NamSinhChuRe { get; set; }
        public string TenCoDau { get; set; }
        public int NamSinhCoDau { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayDatTiec { get; set; }
        public DateTime NgayDaiTiec { get; set; }
        public string Ca { get; set; }
        public string Sanh { get; set; }
        public int SoBan { get; set; }
        public decimal TongSoTien { get; set; }
        public decimal TienCoc { get; set; }
        public string GhiChu { get; set; }
        public string MaNV { get; set; }
        public string TinhTrangTiec { get; set; }
    }
}