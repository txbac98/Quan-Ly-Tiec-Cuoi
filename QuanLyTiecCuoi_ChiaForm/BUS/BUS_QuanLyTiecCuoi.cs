﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_QuanLyTiecCuoi
    {
        public static List<string> _ListSanh;
        public static List<string> _ListSanhRanh;
        public static List<string> _ListMaCa;
        public static List<string> _ListTenCa;
        public static List<string> _ListMaSanh;
        public static List<string> _ListTenSanh;
        public static List<int> _ListSoLuongBanToiDa;

        public static List<string> _ListMaMonAn;
        public static List<string> _ListTenMonAn;
        public static List<string> _ListDonGiaMonAn;
        public static List<string> _ListHinhAnhMonAn;

        public static List<string> _ListMaDichVu;
        public static List<string> _ListTenDichVu;
        public static List<string> _ListDonGiaDichVu;
        public static List<string> _ListHinhAnhDichVu;

        //static public void Init()
        //{
        //    _ListMaCa = new List<string>();
        //    _ListTenCa = new List<string>();
        //    _ListMaSanh = new List<string>();
        //    _ListTenSanh = new List<string>();
        //    _ListSoLuongBanToiDa = new List<int>();

        //    DataTable dtCa = DAO_QuanLyTiecCuoi.GetTableCa();
        //    foreach (DataRow row in dtCa.Rows)
        //    {
        //        _ListMaCa.Add(row["MaCa"].ToString());
        //        _ListTenCa.Add(row["TenCa"].ToString());
        //    }
        //    DataTable dtSanh = DAO_QuanLyTiecCuoi.GetTableSanh();
        //    foreach (DataRow row in dtSanh.Rows)
        //    {
        //        _ListMaSanh.Add(row["MaSanh"].ToString());
        //        _ListSoLuongBanToiDa.Add(int.Parse(row["SoLuongBanToiDa"].ToString()));
        //        _ListTenSanh.Add(row["TenSanh"].ToString());
        //    }

        //    _ListMaMonAn = new List<string>(); _ListTenMonAn = new List<string>();
        //    _ListDonGiaMonAn = new List<string>(); _ListHinhAnhMonAn = new List<string>();
        //    using (DataTable dt = DAO_QuanLyTiecCuoi.GetTableMonAn())
        //    {
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            _ListMaMonAn.Add(row["MaMonAn"].ToString());
        //            _ListTenMonAn.Add(row["TenMonAn"].ToString());
        //            _ListDonGiaMonAn.Add(row["DonGia"].ToString());
        //            _ListHinhAnhMonAn.Add(row["HinhAnh"].ToString());
        //        }
        //    }

        //    _ListMaDichVu = new List<string>(); _ListTenDichVu = new List<string>();
        //    _ListDonGiaDichVu = new List<string>(); _ListHinhAnhDichVu = new List<string>();
        //    using (DataTable dt = DAO_QuanLyTiecCuoi.GetTableDichVu())
        //    {
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            _ListMaDichVu.Add(row["MaDichVu"].ToString());
        //            _ListTenDichVu.Add(row["TenDichVu"].ToString());
        //            _ListDonGiaDichVu.Add(row["DonGia"].ToString());
        //            _ListHinhAnhDichVu.Add(row["HinhAnh"].ToString());
        //        }
        //    }
        //}
        public static List<string> GetListSanhRanh(string ngayDaiTiec, string ca)
        {
            _ListSanhRanh = new List<string>();
            using (DataTable dt = DAO_QuanLyTiecCuoi.GetSanhInCa(ngayDaiTiec,ca))
            {
                DataTable dtSanh = BUS_QuanLySanh.GetQLSanhTable();
                foreach (DataRow rowSanh in dtSanh.Rows)
                {
                    bool bRanh = true;
                    foreach (DataRow row in dt.Rows){
                        if (row["Sanh"].ToString() == rowSanh["MaSanh"].ToString()) bRanh=false;
                    }
                    if (bRanh)_ListSanhRanh.Add(rowSanh["MaSanh"].ToString());

                }
            }
            return _ListSanhRanh;
        }
        public static DataTable GetTableDanhSachTiecCuoi()
        {
            return DAO_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
        }
        public static DataTable GetSanhInCa(string ngayDaiTiec,string ca)
        {
            return DAO_QuanLyTiecCuoi.GetSanhInCa(ngayDaiTiec, ca);
        }

        //public static int GetIndexListMaCa(string maCa)
        //{
        //    return _ListMaCa.IndexOf(maCa);
        //}

        //public static int GetIndexListMaSanh(string maSanh)
        //{
        //    return _ListMaSanh.IndexOf(maSanh);
        //}

        // Tra ve false neu khong tim thay MaTiecCuoi trong TIECCUOI
        public static DataTable SearchTiecTheoNgay(string ngayDaiTiec, string ca, string sanh)
        {
            return DAO_QuanLyTiecCuoi.SearchTiecTheoNgay(ngayDaiTiec, ca, sanh);
        }
        public static DataTable SearchTiecKhongTheoNgay( string ca, string sanh)
        {
            return DAO_QuanLyTiecCuoi.SearchTiecKhongTheoNgay(ca, sanh);
        }
        public static void DeleteTiecCuoi(string maTiecCuoi)
        {
            DAO_QuanLyTiecCuoi.DeleteTiecCuoi(maTiecCuoi);
        }

        public static DataTable GetDataPhieuDatMon(string maTiecCuoi)
        {
            return  DAO_QuanLyTiecCuoi.GetDataPhieuDatMon(maTiecCuoi);
        }
        public static DataTable GetDataPhieuDichVu(string maTiecCuoi)
        {
            return DAO_QuanLyTiecCuoi.GetTablePhieuDichVu(maTiecCuoi);
        }

        public static void UpdateTiecCuoi(DTO_TiecCuoi tiecCuoi)
        {
            DAO_QuanLyTiecCuoi.UpdateTiecCuoi(tiecCuoi);
        }

        public static void DeleteMonAn(int maTiecCuoi)
        {
            DAO_QuanLyTiecCuoi.DeleteMonAn(maTiecCuoi);
        }

        public static void UpdatePhieuDatBan(int maTiecCuoi, string soLuongBan, string soLuongBanDT, decimal donGiaBan)
        {
            DAO_QuanLyTiecCuoi.UpdatePhieuDatBan(maTiecCuoi, soLuongBan, soLuongBanDT, donGiaBan);
        }
        public static int GetMaPhieuDatBan(int maTiecCuoi)
        {
            DataTable dt = DAO_QuanLyTiecCuoi.GetMaPhieuDatBan(maTiecCuoi);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }

        public static void InsertMonAn(int maPhieuDatBan, string maMonAn, string donGiaThucTe)
        {
            DAO_QuanLyTiecCuoi.InsertMonAn(maPhieuDatBan, maMonAn, donGiaThucTe);
        }

        public static void DeleteDichVu(int maTiecCuoi)
        {
            DAO_QuanLyTiecCuoi.DeleteDichVu(maTiecCuoi);
        }
        public static void InsertDichVu(int maTiecCuoi, string maDichVu, string donGiaTT, string soLuong)
        {
            DAO_QuanLyTiecCuoi.InsertDichVu(maTiecCuoi, maDichVu, donGiaTT, soLuong);
        }

        public static bool CheckTiecCuoiExist(string maTiecCuoi, string ngayDaiTiecSqlFormat, string maCa, string maSanh)
        {
            if (DAO_QuanLyTiecCuoi.CountTiecCuoi(maTiecCuoi, ngayDaiTiecSqlFormat, maCa, maSanh) > 0)
                return true;
            return false;
        }
    }
}
