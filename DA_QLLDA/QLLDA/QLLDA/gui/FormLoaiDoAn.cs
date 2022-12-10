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
    using bus;
    using dto;
    public partial class FormLoaiDoAn : Form
    {
        private XuLyLoaiDoAn xuly;
        public FormLoaiDoAn()
        {
            InitializeComponent();
            xuly = new XuLyLoaiDoAn();
        }

        private CLoaiDoAn taoLoaiDoAn()
        {
            return new CLoaiDoAn(txbMaLDA.Text, txbLDA.Text, txbNhaCungCap.Text, txbDiaChi.Text, txbSDT.Text);
        }

        private void clear()
        {
            txbMaLDA.Text = "";
            txbLDA.Text = "";
            txbNhaCungCap.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
            txbMaLDA.Focus();
            dgvLDA.ClearSelection();
        }
        
        private void hienDSLoaiDoAn(List<CLoaiDoAn> dslda)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dslda;
            dgvLDA.DataSource = bs;
            clear();
        }       

        private void FormLoaiDoAn_Load(object sender, EventArgs e)
        {
            hienDSLoaiDoAn(xuly.DSLoaiDoAn);
        }

        private int getSelectedRow()
        {
            if (dgvLDA.SelectedRows.Count > 0)
                return dgvLDA.SelectedRows[0].Index;
            return -1;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaLDA.Text != "" && txbLDA.Text != "" && txbNhaCungCap.Text != "" && txbSDT.Text != "" && txbDiaChi.Text != "")
            {
                xuly.them(taoLoaiDoAn());
                hienDSLoaiDoAn(xuly.DSLoaiDoAn);
            }
            else
                MessageBox.Show("Đừng quên nhập dữ liệu nào của loại đồ ăn nhé !");
        }

        private void dgvLDA_SelectionChanged(object sender, EventArgs e)
        {
            int index = getSelectedRow();
            if (index == -1) return;
            CLoaiDoAn lda = xuly.DSLoaiDoAn[index];
            txbMaLDA.Text = lda.MaLDA;
            txbLDA.Text = lda.LDA;
            txbNhaCungCap.Text = lda.NhaCungCap;
            txbDiaChi.Text = lda.DiaChi;
            txbSDT.Text = lda.SDT;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow();
            if (index == -1) return;
            xuly.xoa(dgvLDA.Rows[index].Cells[0].Value.ToString());
            hienDSLoaiDoAn(xuly.DSLoaiDoAn);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow();
            if (index == -1) return;
            CLoaiDoAn lda = taoLoaiDoAn();
            string malda = dgvLDA.Rows[index].Cells[0].Value.ToString();
            lda.MaLDA = malda;
            xuly.sua(lda);
            hienDSLoaiDoAn(xuly.DSLoaiDoAn);
        }

    }
}
