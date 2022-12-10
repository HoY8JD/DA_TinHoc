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
    public partial class FormDoAn : Form
    {
        private XuLyDoAn xuly;
        public FormDoAn()
        {
            InitializeComponent();
            xuly = new XuLyDoAn();
        }

        private void hienDSDoAn(List<CDoAn> dsda)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsda;
            dgvDA.DataSource = bs;
            dgvDA.ClearSelection();
        }
        private void hienDSLoaiDoAn(List<CLoaiDoAn> dslda)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dslda;
            cbNCP.DataSource = bs;
        }
        private void clear()
        {
            txbMaDA.Text = "";
            txbTenDA.Text = "";
            txbDonGia.Text = String.Empty;
            cbNCP.SelectedIndex = 0;
            dateNSX.Value = DateTime.Today;
            dateHSD.Value = DateTime.Today;
            cbNCP.SelectedIndex = 0;
            txbKhoiLuong.Text = "";
            txbMaDA.Focus();
        }

        
        private void FormDoAn_Load(object sender, EventArgs e)
        {
            hienDSDoAn(xuly.DSDoAn);
            hienDSLoaiDoAn(xuly.DSLoaiDoAn);
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.DSLoaiDoAn;
            cbNCP.DataSource = bs;
            
        }

        private void dgvDA_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDA.SelectedRows.Count == 0) return;
            int index = dgvDA.SelectedRows[0].Index;
            CDoAn da = xuly.DSDoAn[index];
            txbMaDA.Text = da.MaDA;
            txbTenDA.Text = da.TenDA;
            txbDonGia.Text = da.DonGia.ToString();
            cbNCP.SelectedValue = da.NhaCungCap.NhaCungCap;
            CLoaiDoAn lda = xuly.DSLoaiDoAn[cbNCP.SelectedIndex];
            dateNSX.Value = da.NgaySX;
            dateHSD.Value = da.HanSD;
            txbKhoiLuong.Text = da.KhoiLuong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dateNSX.Value < dateHSD.Value)
            {
                if (txbMaDA.Text != "" && txbTenDA.Text != "" && txbDonGia.Text != String.Empty && txbKhoiLuong.Text != "")
                {
                    xuly.them(new CDoAn(txbMaDA.Text, txbTenDA.Text, double.Parse(txbDonGia.Text), xuly.DSLoaiDoAn[cbNCP.SelectedIndex], dateNSX.Value, dateHSD.Value, txbKhoiLuong.Text));
                    hienDSDoAn(xuly.DSDoAn);
                    clear();
                }
                else
                    MessageBox.Show("Đừng quên dữ liệu nào của đồ ăn nhé !");
            }
            else
            {
                MessageBox.Show("Bạn nên kiểm tra lại dữ liệu ngày tháng sử dụng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDA.SelectedRows.Count == 0) return;
            string mada = dgvDA.SelectedRows[0].Cells[0].Value.ToString();
            xuly.xoa(mada);
            hienDSDoAn(xuly.DSDoAn);
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDA.SelectedRows.Count == 0) return;
            string mada = dgvDA.SelectedRows[0].Cells[0].Value.ToString();
            xuly.sua(mada, txbTenDA.Text, double.Parse(txbDonGia.Text.Trim()), xuly.DSLoaiDoAn[cbNCP.SelectedIndex], dateNSX.Value, dateHSD.Value, txbKhoiLuong.Text);
            hienDSDoAn(xuly.DSDoAn);
            clear();
        }

        private void cbNCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLoaiDoAn lda = xuly.DSLoaiDoAn[cbNCP.SelectedIndex];
            txbTenLDA.Text = lda.LDA;
        }
    }
}
