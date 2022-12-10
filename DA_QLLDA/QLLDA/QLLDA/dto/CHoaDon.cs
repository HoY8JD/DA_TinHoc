using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.dto
{
    [Serializable]
    internal class CHoaDon
    {
        private CKhachHang tenkh;
        public string MaHD { get ; set; }
        public DateTime NgayLapHD { get; set; }
        public CKhachHang HoTenKH { get => tenkh; set =>tenkh = value; }
        internal List<CChiTietHoaDon> ChiTietHoaDon { get; set; }
        
        public CHoaDon(string maHD, DateTime ngayLapHD, CKhachHang hoTenKH, List<CChiTietHoaDon> chiTietHoaDon )
        {
            MaHD = maHD;
            NgayLapHD = ngayLapHD;
            HoTenKH = hoTenKH;
            ChiTietHoaDon = chiTietHoaDon;
        }
        public CHoaDon():this(null, DateTime.Today , null,new List<CChiTietHoaDon>())
        {

        }
        public double ThanhTien
        {
            get
            {
                double tt = 0;
                foreach (CChiTietHoaDon chitiet in ChiTietHoaDon)
                    tt += chitiet.TongTien;
                return tt;
            }
        }
    }
}
