namespace QLLDA.gui
{
    partial class FormHoaDon
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dateNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvDA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMaDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel7);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(577, 9);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(644, 440);
            this.panel14.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHuyBill);
            this.panel7.Controls.Add(this.btnShow);
            this.panel7.Controls.Add(this.btnBill);
            this.panel7.Controls.Add(this.btnTaoMoi);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(180, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 440);
            this.panel7.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(348, 99);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 41);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Xem Đơn";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(348, 10);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 41);
            this.btnBill.TabIndex = 8;
            this.btnBill.Text = "Lập Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(348, 54);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 41);
            this.btnTaoMoi.TabIndex = 7;
            this.btnTaoMoi.Text = "New bill";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvHD);
            this.panel11.Location = new System.Drawing.Point(3, 170);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(447, 267);
            this.panel11.TabIndex = 6;
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvHD.Location = new System.Drawing.Point(0, 6);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.Size = new System.Drawing.Size(444, 250);
            this.dgvHD.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaHD";
            this.Column6.HeaderText = "Mã hóa đơn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "HoTenKH";
            this.Column7.HeaderText = "Tên khách hàng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayLapHD";
            this.Column8.HeaderText = "Ngày lập hóa đơn";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ThanhTien";
            this.Column9.HeaderText = "Tổng Bill";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dateNgayLapHD);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(6, 95);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(316, 36);
            this.panel10.TabIndex = 5;
            // 
            // dateNgayLapHD
            // 
            this.dateNgayLapHD.CustomFormat = "dd/mm/yyyy";
            this.dateNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLapHD.Location = new System.Drawing.Point(107, 10);
            this.dateNgayLapHD.Name = "dateNgayLapHD";
            this.dateNgayLapHD.Size = new System.Drawing.Size(200, 20);
            this.dateNgayLapHD.TabIndex = 1;
            this.dateNgayLapHD.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày lập hóa đơn";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbTenKH);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(6, 53);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(316, 36);
            this.panel9.TabIndex = 4;
            // 
            // cbTenKH
            // 
            this.cbTenKH.DisplayMember = "TenKH";
            this.cbTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(107, 7);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(147, 21);
            this.cbTenKH.TabIndex = 1;
            this.cbTenKH.ValueMember = "TenKH";
            this.cbTenKH.SelectedIndexChanged += new System.EventHandler(this.cbTenKH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbMaHD);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(6, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(316, 36);
            this.panel8.TabIndex = 3;
            // 
            // txbMaHD
            // 
            this.txbMaHD.Enabled = false;
            this.txbMaHD.Location = new System.Drawing.Point(107, 7);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(147, 20);
            this.txbMaHD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ringfinger", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 89);
            this.label8.TabIndex = 0;
            this.label8.Text = "BILL";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel12.Controls.Add(this.btnBoChon);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.btnChon);
            this.panel12.Location = new System.Drawing.Point(10, 111);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(548, 59);
            this.panel12.TabIndex = 6;
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(371, 9);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(75, 41);
            this.btnBoChon.TabIndex = 2;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Scribble", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(309, 36);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hãy chọn món <3";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(471, 9);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 41);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn món";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbSoLuong);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(326, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 36);
            this.panel6.TabIndex = 4;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(85, 7);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(147, 20);
            this.txbSoLuong.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvDA);
            this.panel5.Location = new System.Drawing.Point(6, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 270);
            this.panel5.TabIndex = 3;
            // 
            // dgvDA
            // 
            this.dgvDA.AllowUserToAddRows = false;
            this.dgvDA.AllowUserToDeleteRows = false;
            this.dgvDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDA.Location = new System.Drawing.Point(4, 11);
            this.dgvDA.Name = "dgvDA";
            this.dgvDA.ReadOnly = true;
            this.dgvDA.Size = new System.Drawing.Size(548, 251);
            this.dgvDA.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDA";
            this.Column1.HeaderText = "Mã đồ ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DA";
            this.Column2.HeaderText = "Đồ ăn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMaDA);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(326, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 36);
            this.panel4.TabIndex = 2;
            // 
            // txbMaDA
            // 
            this.txbMaDA.Location = new System.Drawing.Point(85, 7);
            this.txbMaDA.Name = "txbMaDA";
            this.txbMaDA.Size = new System.Drawing.Size(147, 20);
            this.txbMaDA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đồ ăn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbDonGia);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(10, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 36);
            this.panel3.TabIndex = 1;
            // 
            // txbDonGia
            // 
            this.txbDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txbDonGia.Location = new System.Drawing.Point(97, 7);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(185, 20);
            this.txbDonGia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn giá";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDA);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 36);
            this.panel2.TabIndex = 0;
            // 
            // cbDA
            // 
            this.cbDA.DisplayMember = "TenDA";
            this.cbDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDA.FormattingEnabled = true;
            this.cbDA.Location = new System.Drawing.Point(97, 10);
            this.cbDA.Name = "cbDA";
            this.cbDA.Size = new System.Drawing.Size(185, 21);
            this.cbDA.TabIndex = 1;
            this.cbDA.ValueMember = "TenDA";
            this.cbDA.SelectedIndexChanged += new System.EventHandler(this.cbDA_SelectedIndexChanged);
            this.cbDA.Click += new System.EventHandler(this.cbDA_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đồ ăn";
            // 
            // btnHuyBill
            // 
            this.btnHuyBill.Location = new System.Drawing.Point(6, 129);
            this.btnHuyBill.Name = "btnHuyBill";
            this.btnHuyBill.Size = new System.Drawing.Size(75, 41);
            this.btnHuyBill.TabIndex = 10;
            this.btnHuyBill.Text = "Hủy Bill";
            this.btnHuyBill.UseVisualStyleBackColor = true;
            this.btnHuyBill.Click += new System.EventHandler(this.btnHuyBill_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 469);
            this.Controls.Add(this.panel1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvDA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbMaDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dateNgayLapHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnHuyBill;
    }
}