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
        public DTO_Sanh(string maSanh, string donGiaBan, string soLuongBanTD,  string ghiChu)
        {
            this.MaSanh = maSanh;
            this.DonGiaBan = long.Parse(donGiaBan);
            this.SoLuongBanTD = int.Parse(soLuongBanTD);      
            this.GhiChu = ghiChu;
        }
        public string MaSanh { get; set; }
        public long DonGiaBan { get; set; }
        public int SoLuongBanTD { get; set; }
        public string GhiChu { get; set; }
    }
}
