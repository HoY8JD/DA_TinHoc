using QLLDA.bus;
using QLLDA.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLDA.gui
{
    public partial class FormHoaDon : Form
    {
        private XuLyHoaDon xuly;
        private CHoaDon hd;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void hienHoaDon()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.DSHoaDon;
            dgvHD.DataSource = bs;
        }

        private void AddNewHoaDon()
        {
            hd = new CHoaDon();
            taoAutoMaHD();
            cbTenKH.Text = "";
            dateNgayLapHD.Value = DateTime.Today;
            dgvDA.DataSource = CChiTietHoaDonViewer.GetChiTietHoaDonViewer(hd);
            cbDA.SelectedIndex = 0;
            txbMaHD.Focus();
        }

        private void cbDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            CDoAn da = xuly.DSDoAn[cbDA.SelectedIndex];
            txbMaDA.Text = da.MaDA;
            txbDonGia.Text = da.DonGia.ToString();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            xuly = new XuLyHoaDon();
            hd = new CHoaDon();
            hienHoaDon();
            taoAutoMaHD();

            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.DSDoAn;
            cbDA.DataSource = bs;
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = xuly.DSKhachHang;
            cbTenKH.DataSource = bs2;
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            CDoAn da = xuly.DSDoAn[cbDA.SelectedIndex];
            int soLuong = 0;
            try
            {
                soLuong = int.Parse(txbSoLuong.Text.Trim());
            }
            catch (Exception) { }
            if (soLuong <= 0 ) MessageBox.Show("Ban nen chon lai gia tri hop ly","Error", MessageBoxButtons.OK);
            xuly.xoa(hd, da, da.DonGia, soLuong);
            dgvDA.DataSource = CChiTietHoaDonViewer.GetChiTietHoaDonViewer(hd);
            txbSoLuong.Text = "";
           
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            CDoAn da = xuly.DSDoAn[cbDA.SelectedIndex];
            int soLuong = 0;
            try
            {
                soLuong = int.Parse(txbSoLuong.Text.Trim());
            }
            catch (Exception) { }          
            if (soLuong <= 0) return;
            xuly.them(hd,da,da.DonGia, soLuong);
            dgvDA.DataSource = CChiTietHoaDonViewer.GetChiTietHoaDonViewer(hd);
            txbSoLuong.Text = "";  
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            AddNewHoaDon();
        }


        public string taoAutoMaHD()
        {
            int count = 0;
            count = dgvHD.Rows.Count;
            string chuoi = Convert.ToString(count);
            return txbMaHD.Text = "hd00" + chuoi;
           
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
           
            if (hd.ChiTietHoaDon.Count == 0) return;
            hd.MaHD = txbMaHD.Text;
            hd.NgayLapHD = dateNgayLapHD.Value;
            hd.HoTenKH = xuly.DSKhachHang[cbTenKH.SelectedIndex];
            xuly.them(hd);
            hienHoaDon();

        }

        private void cbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CKhachHang kh = xuly.DSKhachHang[cbTenKH.SelectedIndex];

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            foreach(DataGridViewRow r in dgvHD.SelectedRows)
            {
                string view = r.Cells[0].Value.ToString();
                FormXemBill frm = new FormXemBill();
                frm.view = view;
                frm.ShowDialog();
                break;
            }
        }

        private void btnHuyBill_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgvHD.SelectedRows)
            {
                string view = r.Cells[0].Value.ToString();
                string mahd = view;
                xuly.xoa(mahd);
                hienHoaDon();
                break;
            }
            
        }
    }
}
