using System;
using System.Windows.Forms;

namespace QLLDA
{
    using QLLDA.dao;
    using QLLDA.gui;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ghiFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn ghi dữ liệu không ?", "Ghi dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapDuLieu.ghiFile("qllda1.bin"))
                    MessageBox.Show("Ghi dữ liệu thành công !");
                else
                    MessageBox.Show("Ghi dữ liệu thất bại !");
            }
        }
        private void docFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đọc dữ liệu không ?", " Đọc file", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TruyCapDuLieu.docFile("qllda1.bin"))
                    MessageBox.Show("Đọc dữ liệu thành công !");
                else
                    MessageBox.Show("Đọc dữ liệu thất bại!");
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Có chắc muốn thoát chương trình !","Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                Application.Exit();
            }
        }

        private void LDAFormItem_Click(object sender, EventArgs e)
        {
            FormLoaiDoAn frm = new FormLoaiDoAn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DAFormItem_Click(object sender, EventArgs e)
        {
            FormDoAn frm = new FormDoAn();
            frm.MdiParent= this;
            frm.Show();
        }

        private void KHFormItem_Click(object sender, EventArgs e)
        {
            FormKhachHang frm = new FormKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CTHDFormItem_Click(object sender, EventArgs e)
        {
            FormChiTietHoaDon frm = new FormChiTietHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon frm = new FormHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
