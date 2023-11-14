namespace WinformQuanLyKho.GUI.FrmKhachHang
{
    partial class MainForm
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
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDSNV = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDSSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContent = new System.Windows.Forms.TableLayoutPanel();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDSHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1634, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.tạoPhiếuXuấtToolStripMenuItem,
            this.thốngKêPhiếuXuấtToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng ";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Danh sách khách hàng";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click_1);
            // 
            // tạoPhiếuXuấtToolStripMenuItem
            // 
            this.tạoPhiếuXuấtToolStripMenuItem.Name = "tạoPhiếuXuấtToolStripMenuItem";
            this.tạoPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.tạoPhiếuXuấtToolStripMenuItem.Text = "Tạo phiếu xuất";
            this.tạoPhiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuXuấtToolStripMenuItem_Click);
            // 
            // thốngKêPhiếuXuấtToolStripMenuItem
            // 
            this.thốngKêPhiếuXuấtToolStripMenuItem.Name = "thốngKêPhiếuXuấtToolStripMenuItem";
            this.thốngKêPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(289, 30);
            this.thốngKêPhiếuXuấtToolStripMenuItem.Text = "Danh sách phiếu xuất ";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhàCungCấpToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // thôngTinNhàCungCấpToolStripMenuItem
            // 
            this.thôngTinNhàCungCấpToolStripMenuItem.Name = "thôngTinNhàCungCấpToolStripMenuItem";
            this.thôngTinNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.thôngTinNhàCungCấpToolStripMenuItem.Text = "Thông tin nhà cung cấp";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDSNV});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // menuItemDSNV
            // 
            this.menuItemDSNV.Name = "menuItemDSNV";
            this.menuItemDSNV.Size = new System.Drawing.Size(274, 30);
            this.menuItemDSNV.Text = "Danh sách nhân viên";
            this.menuItemDSNV.Click += new System.EventHandler(this.menuItemDSNV_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDSSP});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // menuItemDSSP
            // 
            this.menuItemDSSP.Name = "menuItemDSSP";
            this.menuItemDSSP.Size = new System.Drawing.Size(273, 30);
            this.menuItemDSSP.Text = "Danh sách sản phẩm";
            this.menuItemDSSP.Click += new System.EventHandler(this.menuItemDSSP_Click);
            // 
            // mainContent
            // 
            this.mainContent.ColumnCount = 1;
            this.mainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(0, 33);
            this.mainContent.Name = "mainContent";
            this.mainContent.RowCount = 1;
            this.mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 645F));
            this.mainContent.Size = new System.Drawing.Size(1634, 645);
            this.mainContent.TabIndex = 2;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDSHD});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // menuItemDSHD
            // 
            this.menuItemDSHD.Name = "menuItemDSHD";
            this.menuItemDSHD.Size = new System.Drawing.Size(267, 30);
            this.menuItemDSHD.Text = "Danh Sách Hóa Đơn";
            this.menuItemDSHD.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1634, 678);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PhieuXuatHang";
            this.Load += new System.EventHandler(this.Frm_PhieuXuatHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDSNV;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDSSP;
        private System.Windows.Forms.TableLayoutPanel mainContent;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDSHD;
    }
}