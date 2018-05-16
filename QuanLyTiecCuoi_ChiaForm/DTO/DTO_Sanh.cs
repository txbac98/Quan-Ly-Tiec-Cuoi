using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanh
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

        public DTO_Sanh() { }
        public DTO_Sanh(string tenSanh, int maLoaiSanh, int soLuongBanToiDa, string ghiChu)
        {
            this.MaKH = tenSanh;
            this.maLoaiSanh = maLoaiSanh;
            this.soLuongBanToiDa = soLuongBanToiDa;
            this.ghiChu = ghiChu;
        }

        public DTO_Sanh(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
        }

        public int maSanh { get; set; }
        public string MaKH { get; set; }
        public int maLoaiSanh { get; set; }
        public int soLuongBanToiDa { get; set; }
        public string ghiChu { get; set; }
    }
}
