using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLDA.dto
{
    [Serializable]
    internal class CLoaiDoAn
    {
        private string lda_malda;
        private string lda_lda;
        private string lda_nhacungcap;
        private string lda_diachi;
        private string lda_sdt;

        public CLoaiDoAn() : this(null, null, null,null, null)
        {

        }
        public string MaLDA
        {
           get => lda_malda; set =>lda_malda = value; 
        }
        public string LDA
        {
            get => lda_lda; set => lda_lda = value;
        }
        public string NhaCungCap
        {
            get => lda_nhacungcap; set => lda_nhacungcap = value;
        }
        public string DiaChi
        {
            get => lda_diachi;set => lda_diachi = value;
        }
        public string SDT
        {
            get => lda_sdt; set => lda_sdt = value;
        }
        public CLoaiDoAn(string lda_malda, string lda_lda, string lda_nhacungcap, string lda_diachi, string lda_sdt)
        {
            MaLDA= lda_malda;
            LDA = lda_lda;
            NhaCungCap = lda_nhacungcap;
            DiaChi = lda_diachi;
            SDT = lda_sdt;
        }
        public override string ToString()
        {
            return NhaCungCap;
        }
    }
}
