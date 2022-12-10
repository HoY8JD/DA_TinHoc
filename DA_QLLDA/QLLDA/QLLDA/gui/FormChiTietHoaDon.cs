using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLDA.bus;
using QLLDA.dto;

namespace QLLDA.gui
{
    public partial class FormChiTietHoaDon : Form
    {
        private XuLyChiTietHoaDon xuly;
        List<CHoaDon> ds;
        
        private CHoaDon hd;
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void hienChiTietHoaDon()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.DSHoaDon;
            dgvCTHD.DataSource = bs;
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            xuly = new XuLyChiTietHoaDon();
            hd = new CHoaDon();
            hienChiTietHoaDon();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.SelectedRows.Count == 0) return;

            hd = xuly.DSHoaDon[dgvCTHD.SelectedRows[0].Index];
            dgvDA_CTHD.DataSource = CChiTietHoaDonViewer.GetChiTietHoaDonViewer(hd);
        }

        public void LoadGridByKeyWord(string ma , string ten ,DateTime ngay)
        {
            xuly = new XuLyChiTietHoaDon();
            ds = new List<CHoaDon>();
            bool flag = true;
            foreach(CHoaDon hd in xuly.DSHoaDon)
            {
                if(txbMaHD.Text == hd.MaHD && txbTenKH.Text == hd.HoTenKH.TenKH && dateNgayLapHD.Value == hd.NgayLapHD) 
                {
                    ds.Add(hd);
                    flag = false;
                }
                loadGrid(ds);
            }
            if (flag == true)
                MessageBox.Show("DS kh co hoa don nao nhu vay !", " Đọc file", MessageBoxButtons.OK);
        }

        private void loadGrid(List<CHoaDon> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgvCTHD.DataSource = bs;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridByKeyWord(txbMaHD.Text , txbTenKH.Text , dateNgayLapHD.Value);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadKeyWords(txbMaHD.Text, txbTenKH.Text, dateNgayLapHD.Value);
        }
        public void LoadKeyWords(string ma, string ten, DateTime ngay)
        {
            xuly = new XuLyChiTietHoaDon();
            ds = new List<CHoaDon>();
            bool flag = true;
            foreach (CHoaDon hd in xuly.DSHoaDon)
            {
                if (txbMaHD.Text == hd.MaHD || txbTenKH.Text == hd.HoTenKH.TenKH || dateNgayLapHD.Value == hd.NgayLapHD)
                {
                    ds.Add(hd);
                    flag = false;
                }
                loadGrid(ds);
            }
            if (flag == true)
                MessageBox.Show("DS kh co hoa don nao nhu vay !", " Đọc file", MessageBoxButtons.OK);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hienChiTietHoaDon();
        }
    }
}
