using QLLDA.dao;
using QLLDA.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.bus
{
    internal class XuLyHoaDon
    {
        public List<CDoAn> DSDoAn { get; set; }
        public List<CHoaDon> DSHoaDon { get; set; }
        public List<CKhachHang> DSKhachHang { get; set; }
        public XuLyHoaDon()
        {
            DSDoAn = TruyCapDuLieu.getInstance().DSDoAn;
            DSHoaDon = TruyCapDuLieu.getInstance().DSHoaDon;
            DSKhachHang = TruyCapDuLieu.getInstance().DSKhachHang;
        }
        public void them(CHoaDon hd)
        {
            DSHoaDon.Add(hd);
        }
        public void them(CHoaDon hd, CDoAn da, double dongia, int soluong)
        {
            CChiTietHoaDon cthd = null;
            foreach (CChiTietHoaDon _cthd in hd.ChiTietHoaDon)
                if (_cthd.DoAn.MaDA.Equals(da.MaDA))
                {
                    cthd = _cthd;
                    break;
                }
            if(cthd == null)
            {
                cthd = new CChiTietHoaDon(hd.MaHD, da, da.DonGia, 0);
                hd.ChiTietHoaDon.Add(cthd);
            }
            cthd.SoLuong += soluong;
        }

        public void xoa(CHoaDon hd, CDoAn da, double dongia, int soluong)
        {
            CChiTietHoaDon cthd = null;
            foreach (CChiTietHoaDon _cthd in hd.ChiTietHoaDon)
                if (_cthd.DoAn.MaDA.Equals(da.MaDA))
                {
                    cthd = _cthd;
                    break;
                }
            if (cthd == null)
            {
                cthd = new CChiTietHoaDon(hd.MaHD, da, da.DonGia, 0);
                hd.ChiTietHoaDon.Remove(cthd);
            }
            if (cthd.SoLuong > 0)
            {
                cthd.SoLuong -= soluong;
                if(cthd.SoLuong <= 0)
                    hd.ChiTietHoaDon.Remove(cthd);
            }
        }

        public CHoaDon tim(string mahd)
        {
            foreach(CHoaDon hd in DSHoaDon)       
                if(hd.MaHD.Equals(mahd))
                    return hd;
                return null;  
        }
        public void xoa(string mahd)
        {
            CHoaDon hd = tim(mahd);
            if (hd != null)
                DSHoaDon.Remove(hd);
        }


    }
}
