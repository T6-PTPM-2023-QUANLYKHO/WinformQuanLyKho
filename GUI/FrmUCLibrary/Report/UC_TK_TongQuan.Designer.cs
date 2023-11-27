namespace FrmUCLibrary.Report
{
    partial class UC_TK_TongQuan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTKXuatHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPhieuNhap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxNgayXuatHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTKXuatHang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTKXuatHang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKXuatHang.Legends.Add(legend1);
            this.chartTKXuatHang.Location = new System.Drawing.Point(0, 65);
            this.chartTKXuatHang.Name = "chartTKXuatHang";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Kỳ trước";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Hiện tại";
            this.chartTKXuatHang.Series.Add(series1);
            this.chartTKXuatHang.Series.Add(series2);
            this.chartTKXuatHang.Size = new System.Drawing.Size(522, 396);
            this.chartTKXuatHang.TabIndex = 1;
            this.chartTKXuatHang.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Biểu Đồ Thống Kê Xuất Hàng";
            this.chartTKXuatHang.Titles.Add(title1);
            // 
            // chartPhieuNhap
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPhieuNhap.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPhieuNhap.Legends.Add(legend2);
            this.chartPhieuNhap.Location = new System.Drawing.Point(555, 65);
            this.chartPhieuNhap.Name = "chartPhieuNhap";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Kỳ trước";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Hiện tại";
            this.chartPhieuNhap.Series.Add(series3);
            this.chartPhieuNhap.Series.Add(series4);
            this.chartPhieuNhap.Size = new System.Drawing.Size(522, 396);
            this.chartPhieuNhap.TabIndex = 2;
            this.chartPhieuNhap.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Biểu Đồ Thống Kê Nhập Hàng";
            this.chartPhieuNhap.Titles.Add(title2);
            // 
            // cbxNgayXuatHang
            // 
            this.cbxNgayXuatHang.BackColor = System.Drawing.Color.White;
            this.cbxNgayXuatHang.FormattingEnabled = true;
            this.cbxNgayXuatHang.Location = new System.Drawing.Point(3, 25);
            this.cbxNgayXuatHang.Name = "cbxNgayXuatHang";
            this.cbxNgayXuatHang.Size = new System.Drawing.Size(184, 21);
            this.cbxNgayXuatHang.TabIndex = 3;
            this.cbxNgayXuatHang.SelectedValueChanged += new System.EventHandler(this.cbxNgayXuatHang_SelectedValueChanged);
            // 
            // UC_TK_TongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxNgayXuatHang);
            this.Controls.Add(this.chartPhieuNhap);
            this.Controls.Add(this.chartTKXuatHang);
            this.Name = "UC_TK_TongQuan";
            this.Size = new System.Drawing.Size(1080, 670);
            this.Load += new System.EventHandler(this.UC_TK_TongQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKXuatHang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhieuNhap;
        private System.Windows.Forms.ComboBox cbxNgayXuatHang;
    }
}
