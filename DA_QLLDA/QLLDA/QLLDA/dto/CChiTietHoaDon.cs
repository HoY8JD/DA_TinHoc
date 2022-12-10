using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.dto
{
    [Serializable]
    internal class CChiTietHoaDon
    {
        private string mahd;
        private CDoAn da;
        private double dongia;
        private int soluong;

        public string MaHD { get => mahd; set => mahd = value; }
        public CDoAn DoAn { get => da; set => da = value; }
        public double DonGia { get => dongia; set => dongia = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
        public CChiTietHoaDon() : this(null, null, 0, 0) { }
        public double TongTien { get => SoLuong * DonGia; }
        public CChiTietHoaDon(string mahd, CDoAn da, double dongia, int soluong)
        {
            MaHD = mahd;
            DoAn = da;
            DonGia = dongia;
            SoLuong = soluong;
        }
    }
}
