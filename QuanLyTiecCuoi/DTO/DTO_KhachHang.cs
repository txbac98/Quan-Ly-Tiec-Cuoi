using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

        public DTO_KhachHang(string text1, string text2, string text3, string text4, string text5)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
        }

        public string MaKH { get; set; }
        public string TenChuRe { get; set; }
        public string TenCoDau { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public static implicit operator DTO_KhachHang(DTO_Sanh v)
        {
            throw new NotImplementedException();
        }
    }
}
