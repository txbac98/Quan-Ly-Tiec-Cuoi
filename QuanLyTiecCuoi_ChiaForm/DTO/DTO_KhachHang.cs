using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {

        public string MaKH { get; set; }
        public string TenChuRe { get; set; }
        public string NamSinhChuRe { get; set; }
        public string TenCoDau { get; set; }
        public string NamSinhCoDau { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public DTO_KhachHang(string maKH, string tenChuRe, string namSinhChuRe, string tenCoDau, string namSinhCoDau,string dienThoai, string diaChi)
        {
            MaKH = maKH;
            TenChuRe = tenChuRe;
            NamSinhChuRe = namSinhChuRe;
            TenCoDau = tenCoDau;
            NamSinhCoDau = namSinhCoDau;
            DienThoai = dienThoai;
            DiaChi = diaChi;
        }

        

        public static implicit operator DTO_KhachHang(DTO_Sanh v)
        {
            throw new NotImplementedException();
        }
    }
}
