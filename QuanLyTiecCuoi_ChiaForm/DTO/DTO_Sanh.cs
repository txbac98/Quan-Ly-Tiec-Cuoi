using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanh
    {
        public DTO_Sanh() { }
        public DTO_Sanh(string tenSanh, int soLuongBanToiDa, int donGiaBan, string ghiChu)
        {
            this.tenSanh = tenSanh;
            this.soLuongBanToiDa = soLuongBanToiDa;
            this.donGiaBan = donGiaBan;
            this.ghiChu = ghiChu;
        }
        public string maSanh { get; set; }
        public string tenSanh { get; set; }
        public int donGiaBan { get; set; }
        public int soLuongBanToiDa { get; set; }
        public string ghiChu { get; set; }
    }
}
