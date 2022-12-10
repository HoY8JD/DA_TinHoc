using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.bus
{
    using dto;
    using dao;
    using Microsoft.SqlServer.Server;

    internal class XuLyDoAn
    {
        private List<CDoAn> dsDoAn;
        private List<CLoaiDoAn> dsLoaiDoAn;
        public List<CDoAn> DSDoAn { get => dsDoAn;set => dsDoAn = value; }
        public List<CLoaiDoAn> DSLoaiDoAn { get => dsLoaiDoAn;set=> dsLoaiDoAn =value; }

        public XuLyDoAn()
        {
            DSDoAn = TruyCapDuLieu.khoitao().DSDoAn;
            DSLoaiDoAn = TruyCapDuLieu.khoitao().DSLoaiDoAn;
        }
        public void them(CDoAn da)
        {
            DSDoAn.Add(da);
        }
        public CDoAn tim(string da_mada)
        {
            foreach (CDoAn da in DSDoAn)
                if (da.MaDA.Equals(da_mada))
                    return da;
            return null;
        }
        public void xoa(string da_mada)
        {
            CDoAn da = tim(da_mada);
            if (da != null)
                DSDoAn.Remove(da);
        }
        public void sua (string da_mada, string da_tenda, double da_dongia, CLoaiDoAn da_nhacungcap, DateTime da_ngaysx, DateTime da_hansd, string da_khoiluong)
        {
            CDoAn da = tim(da_mada);
            if(da != null)
            {
                da.TenDA = da_tenda;
                da.DonGia = da_dongia;
                da.NhaCungCap = da_nhacungcap;
                da.NgaySX = da_ngaysx;
                da.HanSD = da_hansd;
                da.KhoiLuong = da_khoiluong;
            }
        }
        public void sua (CDoAn da)
        {
            CDoAn oldda = tim(da.MaDA);
            if(oldda != null)
            {
                oldda.TenDA = da.TenDA;
                oldda.DonGia = da.DonGia;
                oldda.NhaCungCap = da.NhaCungCap;
                oldda.NgaySX = da.NgaySX;
                oldda.HanSD = da.HanSD;
                oldda.KhoiLuong = da.KhoiLuong;
            }
        }
    }
}
