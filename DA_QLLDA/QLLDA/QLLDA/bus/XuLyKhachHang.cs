using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.bus
{
    using dto;
    using dao;
    using System.Runtime.InteropServices.WindowsRuntime;
    using System.Data.OleDb;

    internal class XuLyKhachHang
    {
        private List<CKhachHang> dsKhachHang;
        public List<CKhachHang> DSKhachHang { get => dsKhachHang; set => dsKhachHang = value; }
        public XuLyKhachHang()
        {
            DSKhachHang = TruyCapDuLieu.khoitao().DSKhachHang;            
        }
        public void them(CKhachHang kh)
        {
            DSKhachHang.Add(kh);
        }
        public CKhachHang tim(string kh_makh)
        {
            foreach (CKhachHang kh in DSKhachHang)
                if (kh.MaKH.Equals(kh_makh))
                    return kh;
            return null;
        }
        public void xoa (string kh_makh)
        {
            CKhachHang kh = tim(kh_makh);
            if(kh != null)
                DSKhachHang.Remove(kh);
        }
        public void sua(string kh_makh, string kh_tenkh, string kh_sdt, bool kh_gioitinh, DateTime kh_ngaysinh)
        {
            CKhachHang kh = tim(kh_makh);
            if(kh != null)
            {
                kh.TenKH = kh_tenkh;
                kh.SDT = kh_sdt;
                kh.GioiTinh = kh_gioitinh;
                kh.NgaySinh = kh_ngaysinh;
            }
        }
        public void sua (CKhachHang kh)
        {
            CKhachHang oldkh = tim(kh.MaKH);
            if(oldkh != null)
            {
                oldkh.TenKH = kh.TenKH;
                oldkh.SDT = kh.SDT;
                oldkh.GioiTinh = kh.GioiTinh;
                oldkh.NgaySinh = kh.NgaySinh;
            }
        }
    }
}
