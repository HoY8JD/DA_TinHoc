using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.dto
{
    [Serializable]
    internal class CDoAn
    {
        private string da_mada;
        private string da_tenda;
        private double da_dongia;
        private CLoaiDoAn da_nhacungcap;
        private DateTime da_ngaysx;
        private DateTime da_hansd;
        private string da_khoiluong;

        public CDoAn (string da_mada, string da_tenda, double da_dongia, CLoaiDoAn da_nhacungcap, DateTime da_ngaysx, DateTime da_hansd, string da_khoiluong)
        {
            this.da_mada = da_mada;
            this.da_tenda = da_tenda;
            this.da_dongia = da_dongia;
            this.da_nhacungcap = da_nhacungcap;
            this.da_ngaysx = da_ngaysx;
            this.da_hansd = da_hansd;
            this.da_khoiluong = da_khoiluong;
        }
        public CDoAn() : this(null, null, 0, null, DateTime.Today, DateTime.Today, null)
        {

        }
        public string MaDA
        {
            get { return da_mada; }
            set { da_mada = value; }
        }
        public string TenDA
        {
            get { return da_tenda; }
            set { da_tenda = value; }
        }
        public double DonGia
        {
            get { return da_dongia; }
            set { da_dongia = value; }
        }
        public CLoaiDoAn NhaCungCap
        {
            get { return da_nhacungcap; }
            set { da_nhacungcap = value; }
        }
        public DateTime NgaySX
        {
            get { return da_ngaysx; }
            set { da_ngaysx=value; }
        }
        public DateTime HanSD
        {
            get { return da_hansd; }
            set { da_hansd = value; }
        }
        public string KhoiLuong
        {
            get { return da_khoiluong; }
            set { da_khoiluong = value;}
        }
    }
}
