using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.dto
{
    [Serializable]
    internal class CKhachHang
    {
        private string kh_makh;
        private string kh_tenkh;
        private string kh_sdt;
        private bool kh_gioitinh;
        private DateTime kh_ngaysinh;
        public string MaKH
        { get => kh_makh; set => kh_makh = value; }
        public string TenKH
        { get => kh_tenkh; set => kh_tenkh = value; }
        public string SDT
        { get => kh_sdt; set => kh_sdt = value; }
        public bool GioiTinh
        { get => kh_gioitinh; set => kh_gioitinh = value; }
        public DateTime NgaySinh
        { get => kh_ngaysinh; set => kh_ngaysinh = value; }
        public CKhachHang(string kh_makh, string kh_tenkh, string kh_sdt, bool kh_gioitinh, DateTime kh_ngaysinh)
        {
            MaKH = kh_makh;
            TenKH = kh_tenkh;
            SDT = kh_sdt;
            GioiTinh = kh_gioitinh;
            NgaySinh = kh_ngaysinh;
        }
        public CKhachHang() :this(null , null ,null, true , DateTime.Today)
        {

        }
        public override string ToString()
        {
            return TenKH;
        }
    }
}
