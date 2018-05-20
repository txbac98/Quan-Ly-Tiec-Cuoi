using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string AnhDaiDien { get; set; }

        public DTO_NhanVien(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            MaNV = text1;
            HoTen = text2;
            GioiTinh = text3;
            NgaySinh = text4;
            ChucVu = text5;
            DienThoai = text6;
            DiaChi = text7;
            AnhDaiDien = text8;
        }

    }
}
