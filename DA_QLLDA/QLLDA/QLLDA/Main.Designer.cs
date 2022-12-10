namespace QLLDA
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LDAFormItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DAFormItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CTHDFormItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KHFormItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formToolStripMenuItem,
            this.billToolStripMenuItem,
            this.KHFormItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghiFileToolStripMenuItem,
            this.docFileToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Scribble", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ghiFileToolStripMenuItem
            // 
            this.ghiFileToolStripMenuItem.Name = "ghiFileToolStripMenuItem";
            this.ghiFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ghiFileToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ghiFileToolStripMenuItem.Text = "Ghi File";
            this.ghiFileToolStripMenuItem.Click += new System.EventHandler(this.ghiFileToolStripMenuItem_Click);
            // 
            // docFileToolStripMenuItem
            // 
            this.docFileToolStripMenuItem.Name = "docFileToolStripMenuItem";
            this.docFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.docFileToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.docFileToolStripMenuItem.Text = "Đọc File";
            this.docFileToolStripMenuItem.Click += new System.EventHandler(this.docFileToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.thoatToolStripMenuItem.ShowShortcutKeys = false;
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LDAFormItem,
            this.DAFormItem});
            this.formToolStripMenuItem.Font = new System.Drawing.Font("Scribble", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // LDAFormItem
            // 
            this.LDAFormItem.Name = "LDAFormItem";
            this.LDAFormItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.LDAFormItem.ShowShortcutKeys = false;
            this.LDAFormItem.Size = new System.Drawing.Size(180, 24);
            this.LDAFormItem.Text = "Loại đồ ăn ";
            this.LDAFormItem.Click += new System.EventHandler(this.LDAFormItem_Click);
            // 
            // DAFormItem
            // 
            this.DAFormItem.Name = "DAFormItem";
            this.DAFormItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.DAFormItem.ShowShortcutKeys = false;
            this.DAFormItem.Size = new System.Drawing.Size(180, 24);
            this.DAFormItem.Text = "Đồ ăn";
            this.DAFormItem.Click += new System.EventHandler(this.DAFormItem_Click);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTHDFormItem,
            this.HDToolStripMenuItem});
            this.billToolStripMenuItem.Font = new System.Drawing.Font("Scribble", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // CTHDFormItem
            // 
            this.CTHDFormItem.Name = "CTHDFormItem";
            this.CTHDFormItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.CTHDFormItem.ShowShortcutKeys = false;
            this.CTHDFormItem.Size = new System.Drawing.Size(223, 24);
            this.CTHDFormItem.Text = "Chi tiết hóa đơn";
            this.CTHDFormItem.Click += new System.EventHandler(this.CTHDFormItem_Click);
            // 
            // HDToolStripMenuItem
            // 
            this.HDToolStripMenuItem.Name = "HDToolStripMenuItem";
            this.HDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.HDToolStripMenuItem.ShowShortcutKeys = false;
            this.HDToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.HDToolStripMenuItem.Text = "Hóa đơn";
            this.HDToolStripMenuItem.Click += new System.EventHandler(this.HDToolStripMenuItem_Click);
            // 
            // KHFormItem
            // 
            this.KHFormItem.Font = new System.Drawing.Font("Scribble", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KHFormItem.Name = "KHFormItem";
            this.KHFormItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.KHFormItem.ShowShortcutKeys = false;
            this.KHFormItem.Size = new System.Drawing.Size(136, 24);
            this.KHFormItem.Text = "Khách hàng";
            this.KHFormItem.Click += new System.EventHandler(this.KHFormItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại đồ ăn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LDAFormItem;
        private System.Windows.Forms.ToolStripMenuItem DAFormItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CTHDFormItem;
        private System.Windows.Forms.ToolStripMenuItem KHFormItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDToolStripMenuItem;
    }
}

