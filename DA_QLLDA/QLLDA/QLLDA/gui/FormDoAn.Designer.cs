namespace QLLDA.gui
{
    partial class FormDoAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoAn));
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvDA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbKhoiLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbNCP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTenDA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMaDA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbTenLDA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvDA);
            this.panel8.Location = new System.Drawing.Point(23, 253);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(772, 193);
            this.panel8.TabIndex = 5;
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
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDA.Location = new System.Drawing.Point(13, 9);
            this.dgvDA.Name = "dgvDA";
            this.dgvDA.ReadOnly = true;
            this.dgvDA.Size = new System.Drawing.Size(746, 179);
            this.dgvDA.TabIndex = 10;
            this.dgvDA.SelectionChanged += new System.EventHandler(this.dgvDA_SelectionChanged);
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
            this.Column2.DataPropertyName = "TenDA";
            this.Column2.HeaderText = "Tên đồ ăn";
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
            this.Column4.DataPropertyName = "NhaCungCap";
            this.Column4.HeaderText = "Nhà cung cấp";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySX";
            this.Column5.HeaderText = "Ngày sản xuất";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HanSD";
            this.Column6.HeaderText = "Hạn sử dụng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "KhoiLuong";
            this.Column7.HeaderText = "Khối lượng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSua);
            this.panel7.Controls.Add(this.btnXoa);
            this.panel7.Controls.Add(this.btnThem);
            this.panel7.Location = new System.Drawing.Point(408, 198);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(385, 46);
            this.panel7.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(291, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(147, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 192);
            this.panel1.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbKhoiLuong);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(407, 148);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(366, 40);
            this.panel10.TabIndex = 6;
            // 
            // txbKhoiLuong
            // 
            this.txbKhoiLuong.Location = new System.Drawing.Point(131, 10);
            this.txbKhoiLuong.Name = "txbKhoiLuong";
            this.txbKhoiLuong.Size = new System.Drawing.Size(231, 20);
            this.txbKhoiLuong.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khối lượng";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dateHSD);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(407, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(366, 40);
            this.panel9.TabIndex = 3;
            // 
            // dateHSD
            // 
            this.dateHSD.CustomFormat = "dd/mm/yyyy";
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHSD.Location = new System.Drawing.Point(131, 10);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(231, 20);
            this.dateHSD.TabIndex = 1;
            this.dateHSD.Value = new System.DateTime(2022, 12, 8, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hạn sử dụng";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateNSX);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(407, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(366, 40);
            this.panel6.TabIndex = 2;
            // 
            // dateNSX
            // 
            this.dateNSX.CustomFormat = "dd/mm/yyyy";
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNSX.Location = new System.Drawing.Point(131, 10);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(231, 20);
            this.dateNSX.TabIndex = 1;
            this.dateNSX.Value = new System.DateTime(2022, 12, 8, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sản xuất";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbNCP);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(20, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 40);
            this.panel5.TabIndex = 3;
            // 
            // cbNCP
            // 
            this.cbNCP.DisplayMember = "NhaCungCap";
            this.cbNCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCP.FormattingEnabled = true;
            this.cbNCP.Location = new System.Drawing.Point(130, 10);
            this.cbNCP.Name = "cbNCP";
            this.cbNCP.Size = new System.Drawing.Size(231, 21);
            this.cbNCP.TabIndex = 1;
            this.cbNCP.ValueMember = "NhaCungCap";
            this.cbNCP.SelectedIndexChanged += new System.EventHandler(this.cbNCP_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà cung cấp";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbDonGia);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(20, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 40);
            this.panel4.TabIndex = 2;
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(130, 7);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(232, 20);
            this.txbDonGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTenDA);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(20, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 40);
            this.panel3.TabIndex = 1;
            // 
            // txbTenDA
            // 
            this.txbTenDA.Location = new System.Drawing.Point(130, 7);
            this.txbTenDA.Name = "txbTenDA";
            this.txbTenDA.Size = new System.Drawing.Size(232, 20);
            this.txbTenDA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đồ ăn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMaDA);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 40);
            this.panel2.TabIndex = 0;
            // 
            // txbMaDA
            // 
            this.txbMaDA.Location = new System.Drawing.Point(130, 7);
            this.txbMaDA.Name = "txbMaDA";
            this.txbMaDA.Size = new System.Drawing.Size(232, 20);
            this.txbMaDA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đồ ăn";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(1, 197);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(236, 52);
            this.panel11.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Scribble", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đồ Ăn :3  ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txbTenLDA);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(407, 9);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(366, 40);
            this.panel12.TabIndex = 7;
            // 
            // txbTenLDA
            // 
            this.txbTenLDA.Location = new System.Drawing.Point(131, 10);
            this.txbTenLDA.Name = "txbTenLDA";
            this.txbTenLDA.Size = new System.Drawing.Size(231, 20);
            this.txbTenLDA.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên loại đồ ăn";
            // 
            // FormDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "FormDoAn";
            this.Text = "FormDoAn";
            this.Load += new System.EventHandler(this.FormDoAn_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvDA;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTenDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMaDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbKhoiLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.ComboBox cbNCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txbTenLDA;
        private System.Windows.Forms.Label label9;
    }
}