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
    public partial class FormXemBill : Form
    {
        private XuLyHoaDon xuly;
        public string view;
        public FormXemBill()
        {
            InitializeComponent();
        }

        private void hienHoaDon(CHoaDon hoaDon)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = CChiTietHoaDonViewer.GetChiTietHoaDonViewer(hoaDon);
            dgvBillDA.DataSource = bs;

        }

        private void FormXemBill_Load(object sender, EventArgs e)
        {
            xuly = new XuLyHoaDon();
            CHoaDon hoaDon = xuly.tim(view);
            hienHoaDon(hoaDon);       
        }
    }
}
