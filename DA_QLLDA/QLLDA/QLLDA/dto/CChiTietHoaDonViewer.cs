using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.dto
{
    [Serializable]
    internal class CChiTietHoaDonViewer
    {
        public string MaDA { get; set; }
        public string DA { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        public string TongTien { get; set; }
        public static List<CChiTietHoaDonViewer> GetChiTietHoaDonViewer(CHoaDon hd)
        {
            List<CChiTietHoaDonViewer> hdv = new List<CChiTietHoaDonViewer>();
            foreach (CChiTietHoaDon cthd in hd.ChiTietHoaDon)
            {
                CChiTietHoaDonViewer viewItem1 = new CChiTietHoaDonViewer();
                viewItem1.MaDA = cthd.DoAn.MaDA;
                viewItem1.DA = cthd.DoAn.TenDA;
                viewItem1.DonGia = cthd.DoAn.DonGia.ToString();
                viewItem1.SoLuong = cthd.SoLuong.ToString();
                viewItem1.TongTien = cthd.TongTien.ToString();
                hdv.Add(viewItem1);
            }
            return hdv;
        }

        public static List<CChiTietHoaDonViewer> GetChiTietHoaDonViewered(CHoaDon hd)
        {
            List<CChiTietHoaDonViewer> hdv = new List<CChiTietHoaDonViewer>();
            foreach (CChiTietHoaDon cthd in hd.ChiTietHoaDon)
            {
                CChiTietHoaDonViewer viewItem1 = new CChiTietHoaDonViewer();
                viewItem1.MaDA = cthd.DoAn.MaDA;
                viewItem1.DA = cthd.DoAn.TenDA;
                viewItem1.DonGia = cthd.DoAn.DonGia.ToString();
                viewItem1.SoLuong = cthd.SoLuong.ToString();
                viewItem1.TongTien = cthd.TongTien.ToString();
                hdv.Remove(viewItem1);
            }
            return hdv;
        }
    }
}
