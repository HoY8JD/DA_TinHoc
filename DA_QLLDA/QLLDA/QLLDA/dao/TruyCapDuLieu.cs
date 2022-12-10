using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QLLDA.dao
{
    using dto;  
    using System.Windows.Forms;
    [Serializable]
    internal class TruyCapDuLieu
    {
        private static TruyCapDuLieu instance = null;
        private List<CLoaiDoAn> dsLoaiDoAn;
        private List<CDoAn> dsDoAn;
        private List<CKhachHang> dsKhachHang;
        private List<CHoaDon> dsHoaDon;
        private TruyCapDuLieu()
        {
            dsLoaiDoAn = new List<CLoaiDoAn>();
            dsDoAn = new List<CDoAn>();
            dsKhachHang = new List<CKhachHang>();
            dsHoaDon = new List<CHoaDon>();
        }
        public List<CKhachHang> DSKhachHang { get => dsKhachHang; }
        public List<CLoaiDoAn> DSLoaiDoAn { get => dsLoaiDoAn; }
        public List<CDoAn> DSDoAn { get => dsDoAn; }
        public List<CHoaDon> DSHoaDon { get => dsHoaDon; }
        public static TruyCapDuLieu khoitao()
        {
            if (instance == null)
                instance = new TruyCapDuLieu();
            return instance;
        }
        public static bool docFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile , FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                instance = (TruyCapDuLieu)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }
        public static bool ghiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, khoitao());
                fs.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }
        public static TruyCapDuLieu getInstance()
        {
            if (instance == null)
                if (!docFile("qllda.bin"))
                    instance = new TruyCapDuLieu();
            return instance;
        }

    }
}
