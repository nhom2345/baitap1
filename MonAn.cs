
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhaHang
{
    /*vi */
    public class MonAn
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public string LoaiMon { get; set; }
        public decimal Gia { get; set; }
        public string MoTa { get; set; }

        public MonAn(int maMon, string tenMon, string loaiMon, decimal gia, string moTa)
        {
            MaMon = maMon;
            TenMon = tenMon;
            LoaiMon = loaiMon;
            Gia = gia;
            MoTa = moTa;
        }

        public override string ToString()
        {
            return $"{MaMon}: {TenMon} - {LoaiMon} - {Gia:C} - {MoTa}";
        }
    }

    public class QuanLyMonAn
    {
        private List<MonAn> danhSachMonAn = new List<MonAn>();

        public void ThemMonAn(MonAn mon)
        {
            danhSachMonAn.Add(mon);
        }

        public bool XoaMonAn(int maMon)
        {
            var mon = danhSachMonAn.FirstOrDefault(m => m.MaMon == maMon);
            if (mon != null)
            {
                danhSachMonAn.Remove(mon);
                return true;
            }
            return false;
        }

        public MonAn TimMonAn(int maMon)
        {
            return danhSachMonAn.FirstOrDefault(m => m.MaMon == maMon);
        }

        public void HienThiTatCa()
        {
            foreach (var mon in danhSachMonAn)
            {
                Console.WriteLine(mon);
            }
        }
    }
}
