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
            this.mainContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
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
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng ";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Danh sách khách hàng";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click_1);
            // 
            // tạoPhiếuXuấtToolStripMenuItem
            // 
            this.tạoPhiếuXuấtToolStripMenuItem.Name = "tạoPhiếuXuấtToolStripMenuItem";
            this.tạoPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.tạoPhiếuXuấtToolStripMenuItem.Text = "Tạo phiếu xuất";
            this.tạoPhiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuXuấtToolStripMenuItem_Click);
            // 
            // thốngKêPhiếuXuấtToolStripMenuItem
            // 
            this.thốngKêPhiếuXuấtToolStripMenuItem.Name = "thốngKêPhiếuXuấtToolStripMenuItem";
            this.thốngKêPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.thốngKêPhiếuXuấtToolStripMenuItem.Text = "Danh sách phiếu xuất ";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhàCungCấpToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // thôngTinNhàCungCấpToolStripMenuItem
            // 
            this.thôngTinNhàCungCấpToolStripMenuItem.Name = "thôngTinNhàCungCấpToolStripMenuItem";
            this.thôngTinNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.thôngTinNhàCungCấpToolStripMenuItem.Text = "Thông tin nhà cung cấp";
            // 
            // mainContent
            // 
            this.mainContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainContent.Location = new System.Drawing.Point(12, 31);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(1229, 518);
            this.mainContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1253, 551);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.ToolStripMenuItem thốngKêPhiếuXuấtToolStripMenuItem;
    }
}