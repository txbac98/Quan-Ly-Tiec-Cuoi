﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonAn
    {
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string LoaiMonAn { get; set; }
        public decimal DonGia { get; set; }
        public string GhiChu { get; set; }
        public string HinhAnh { get; set; }
        public DTO_MonAn(string maMonAn, string tenMonAn, string loaiMonAn, string donGia, string ghiChu, string hinhAnh)
        {
            MaMonAn = maMonAn;
            TenMonAn = tenMonAn;
            LoaiMonAn = loaiMonAn;
            DonGia = long.Parse(donGia);
            GhiChu = ghiChu;
            HinhAnh = hinhAnh;
            
        }
    }
}