using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.bus
{
    using dto;
    using dao;
    using System.Windows.Forms;

    internal class XuLyChiTietHoaDon
    {
        public List<CDoAn> DSDoAn { get; set; }
        public List<CHoaDon> DSHoaDon { get; set; }
        public List<CKhachHang> DSKachHang { get; set; }
        public XuLyChiTietHoaDon()
        {
            DSDoAn = TruyCapDuLieu.getInstance().DSDoAn;
            DSHoaDon = TruyCapDuLieu.getInstance().DSHoaDon;
            DSKachHang = TruyCapDuLieu.getInstance().DSKhachHang;
        }
        public CHoaDon tim(string ma)
        {
            foreach (CHoaDon hd in DSHoaDon)
                if (hd.MaHD.Equals(ma))
                    return hd;
            return null;
        }
    }
}
