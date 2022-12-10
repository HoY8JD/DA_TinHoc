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
    using dto;
    using bus;
    using QLLDA.dao;

    public partial class FormKhachHang : Form
    {
        private XuLyKhachHang xuly;
        public FormKhachHang()
        {
            InitializeComponent();
            xuly = new XuLyKhachHang();
        }

        private CKhachHang taoKhachHang()
        {
            return new CKhachHang(txbMaKH.Text, txbTenKH.Text, txbSDT.Text, radioNam.Checked, dateNgaySinh.Value);
        }

        private void clear()
        {
            txbMaKH.Text = "";
            txbTenKH.Text = "";
            txbSDT.Text = "";
            radioNam.Checked = true;
            dateNgaySinh.Value = DateTime.Today;
            txbMaKH.Focus();
            dgvKH.ClearSelection();
        }

        private void hienDSKhachHang(List<CKhachHang> dskh)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dskh;
            dgvKH.DataSource = bs;
            clear();
        }

        private void dgvKH_Load(object sender, EventArgs e)
        {
            hienDSKhachHang(xuly.DSKhachHang);
        }

        private int getSelectedRow()
        {
            if (dgvKH.SelectedRows.Count > 0)
                return dgvKH.SelectedRows[0].Index;
            return -1;
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            int index = getSelectedRow();
            if (index == -1) return;
            CKhachHang kh = xuly.DSKhachHang[index];
            txbMaKH.Text = kh.MaKH;
            txbTenKH.Text = kh.TenKH;
            txbSDT.Text = kh.SDT;
            if (kh.GioiTinh)
                radioNam.Checked = true;
            else
                radioNu.Checked = true;
            dateNgaySinh.Value = kh.NgaySinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txbMaKH.Text != "" || txbTenKH.Text != "" || txbSDT.Text !="")
            {
                xuly.them(taoKhachHang());
                hienDSKhachHang(xuly.DSKhachHang);
            }
            else
            {
                MessageBox.Show("Đừng quên dữ liệu nào của khách hàng nhé !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow();
            if(index == -1) return;
            xuly.xoa(dgvKH.Rows[index].Cells[0].Value.ToString());
            hienDSKhachHang(xuly.DSKhachHang);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow();
            if(index == -1) return;
            CKhachHang kh = taoKhachHang();
            string makh = dgvKH.Rows[index].Cells[0].Value.ToString();
            kh.MaKH = makh; ;
            xuly.sua(kh);
            hienDSKhachHang(xuly.DSKhachHang);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn ghi dữ liệu không ?", "Ghi dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapDuLieu.ghiFile("khachhang.bin"))
                    MessageBox.Show("Ghi dữ liệu thành công !");
                else
                    MessageBox.Show("Ghi dữ liệu thất bại !");
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đọc dữ liệu không ?", " Đọc file", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapDuLieu.docFile("khachhang.bin"))
                {  
                    MessageBox.Show("Đọc dữ liệu thành công !");
                }
                else
                    MessageBox.Show("Đọc dữ liệu thất bại!");
            }
        }
    }
}
