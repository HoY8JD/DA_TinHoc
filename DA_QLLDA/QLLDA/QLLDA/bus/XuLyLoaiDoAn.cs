using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.bus
{
    using dto;
    using dao;
    internal class XuLyLoaiDoAn
    {
        private List<CLoaiDoAn> dsLoaiDoAn;
        private List<CDoAn> dsDoAn;
        public List<CLoaiDoAn> DSLoaiDoAn { get => dsLoaiDoAn; set => dsLoaiDoAn = value; }
        public List<CDoAn> DSDoAn { get => dsDoAn;set => dsDoAn = value; }
        public XuLyLoaiDoAn()
        {
            DSLoaiDoAn = TruyCapDuLieu.khoitao().DSLoaiDoAn;
        }
        public void them(CLoaiDoAn lda)
        {
            DSLoaiDoAn.Add(lda);
        }
        public CLoaiDoAn tim(string lda_malda)
        {
            foreach (CLoaiDoAn lda in DSLoaiDoAn)
                if (lda.MaLDA.Equals(lda_malda))
                    return lda;
            return null;
        }
        public void xoa (string lda_malda)
        {
           CLoaiDoAn lda = tim(lda_malda);
            if (lda != null)
                DSLoaiDoAn.Remove(lda);
        }
        public void sua(string lda_malda, string lda_lda, string lda_nhacungcap, string lda_diachi, string lda_sdt)
        {
            CLoaiDoAn lda = tim(lda_malda);
            if(lda!= null)
            {
                lda.LDA = lda_lda;
                lda.NhaCungCap = lda_nhacungcap;
                lda.DiaChi = lda_diachi;
                lda.SDT = lda_sdt;
            }
        }
        public void sua(CLoaiDoAn lda)
        {
            CLoaiDoAn oldlda = tim(lda.MaLDA);
            if(oldlda != null)
            {
                oldlda.LDA = lda.LDA;
                oldlda.NhaCungCap = lda.NhaCungCap;
                oldlda.DiaChi = lda.DiaChi;
                oldlda.SDT = lda.SDT;
            }
        }
    }
}
