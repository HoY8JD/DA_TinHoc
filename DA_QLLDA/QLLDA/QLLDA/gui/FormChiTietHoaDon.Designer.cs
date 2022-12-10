namespace QLLDA.gui
{
    partial class FormChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvDA_CTHD = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA_CTHD)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 449);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvDA_CTHD);
            this.panel8.Location = new System.Drawing.Point(584, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(557, 445);
            this.panel8.TabIndex = 2;
            // 
            // dgvDA_CTHD
            // 
            this.dgvDA_CTHD.AllowUserToAddRows = false;
            this.dgvDA_CTHD.AllowUserToDeleteRows = false;
            this.dgvDA_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDA_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDA_CTHD.Location = new System.Drawing.Point(4, 4);
            this.dgvDA_CTHD.Name = "dgvDA_CTHD";
            this.dgvDA_CTHD.ReadOnly = true;
            this.dgvDA_CTHD.Size = new System.Drawing.Size(546, 438);
            this.dgvDA_CTHD.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaDA";
            this.Column5.HeaderText = "Mã đồ ăn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DA";
            this.Column6.HeaderText = "Tên đồ ăn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DonGia";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SoLuong";
            this.Column8.HeaderText = "Số lượng";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TongTien";
            this.Column9.HeaderText = "Thành tiền";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(8, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 155);
            this.panel3.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Refresh";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLoc);
            this.panel7.Controls.Add(this.btnShow);
            this.panel7.Controls.Add(this.btnSearch);
            this.panel7.Location = new System.Drawing.Point(340, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(102, 117);
            this.panel7.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(14, 83);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(14, 44);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Xem bill";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateNgayLapHD);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(6, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(327, 34);
            this.panel6.TabIndex = 2;
            // 
            // dateNgayLapHD
            // 
            this.dateNgayLapHD.CustomFormat = "dd/mm/yyyy";
            this.dateNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLapHD.Location = new System.Drawing.Point(111, 6);
            this.dateNgayLapHD.Name = "dateNgayLapHD";
            this.dateNgayLapHD.Size = new System.Drawing.Size(200, 20);
            this.dateNgayLapHD.TabIndex = 1;
            this.dateNgayLapHD.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbTenKH);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(6, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 34);
            this.panel5.TabIndex = 1;
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(111, 7);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(201, 20);
            this.txbTenKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMaHD);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(6, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 34);
            this.panel4.TabIndex = 0;
            // 
            // txbMaHD
            // 
            this.txbMaHD.Location = new System.Drawing.Point(111, 7);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(201, 20);
            this.txbMaHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCTHD);
            this.panel2.Location = new System.Drawing.Point(4, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 273);
            this.panel2.TabIndex = 0;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCTHD.Location = new System.Drawing.Point(4, 3);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.Size = new System.Drawing.Size(443, 264);
            this.dgvCTHD.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTenKH";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayLapHD";
            this.Column3.HeaderText = "Ngày lập hóa đơn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThanhTien";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormChiTietHoaDon";
            this.Text = "FormChiTietHoaDon";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA_CTHD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvDA_CTHD;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateNgayLapHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnReset;
    }
}