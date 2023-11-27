namespace WinformQuanLyKho.GUI.Report
{
    partial class Frm_ThongKe
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
            this.grpb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.btnTKDoanhThu = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.grpb_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_ChucNang
            // 
            this.grpb_ChucNang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpb_ChucNang.Controls.Add(this.btnTongQuan);
            this.grpb_ChucNang.Controls.Add(this.btnTKDoanhThu);
            this.grpb_ChucNang.Location = new System.Drawing.Point(12, 12);
            this.grpb_ChucNang.Name = "grpb_ChucNang";
            this.grpb_ChucNang.Size = new System.Drawing.Size(200, 678);
            this.grpb_ChucNang.TabIndex = 0;
            this.grpb_ChucNang.TabStop = false;
            this.grpb_ChucNang.Text = "Chức Năng";
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.Location = new System.Drawing.Point(6, 22);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(188, 34);
            this.btnTongQuan.TabIndex = 4;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.UseVisualStyleBackColor = false;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // btnTKDoanhThu
            // 
            this.btnTKDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKDoanhThu.Location = new System.Drawing.Point(6, 64);
            this.btnTKDoanhThu.Name = "btnTKDoanhThu";
            this.btnTKDoanhThu.Size = new System.Drawing.Size(188, 34);
            this.btnTKDoanhThu.TabIndex = 1;
            this.btnTKDoanhThu.Text = "Thống kê doanh thu";
            this.btnTKDoanhThu.UseVisualStyleBackColor = false;
            this.btnTKDoanhThu.Click += new System.EventHandler(this.btnTKDoanhThu_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(218, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1085, 678);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 702);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.grpb_ChucNang);
            this.Name = "Frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_ThongKe";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.grpb_ChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_ChucNang;
        private System.Windows.Forms.Button btnTKDoanhThu;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Panel panelMain;
    }
}