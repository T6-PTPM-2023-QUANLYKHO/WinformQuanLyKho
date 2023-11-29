namespace FrmUCLibrary
{
    partial class UC_THONGKE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongKeNhap = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnTon = new System.Windows.Forms.Button();
            this.btnhetDate = new System.Windows.Forms.Button();
            this.DataThongKE = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataThongKE)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBatDau
            // 
            this.dateBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBatDau.Location = new System.Drawing.Point(512, 104);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(200, 26);
            this.dateBatDau.TabIndex = 0;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKetThuc.Location = new System.Drawing.Point(903, 104);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(206, 26);
            this.dateKetThuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(714, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ";
            // 
            // btnThongKeNhap
            // 
            this.btnThongKeNhap.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnThongKeNhap.FlatAppearance.BorderSize = 5;
            this.btnThongKeNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnThongKeNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnThongKeNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNhap.Location = new System.Drawing.Point(127, 499);
            this.btnThongKeNhap.Name = "btnThongKeNhap";
            this.btnThongKeNhap.Size = new System.Drawing.Size(187, 66);
            this.btnThongKeNhap.TabIndex = 4;
            this.btnThongKeNhap.Text = "THỐNG KÊ SỐ LƯỢNG SẢN PHẨM NHẬP";
            this.btnThongKeNhap.UseVisualStyleBackColor = true;
            this.btnThongKeNhap.Click += new System.EventHandler(this.btnThongKeNhap_Click);
            // 
            // btnBan
            // 
            this.btnBan.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnBan.FlatAppearance.BorderSize = 4;
            this.btnBan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.Location = new System.Drawing.Point(715, 501);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(185, 64);
            this.btnBan.TabIndex = 5;
            this.btnBan.Text = "THỐNG KÊ SẢN PHẨM CÓ SỐ LƯỢNG BÁN\r\n";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnTon
            // 
            this.btnTon.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnTon.FlatAppearance.BorderSize = 4;
            this.btnTon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnTon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTon.Location = new System.Drawing.Point(1013, 498);
            this.btnTon.Name = "btnTon";
            this.btnTon.Size = new System.Drawing.Size(184, 66);
            this.btnTon.TabIndex = 6;
            this.btnTon.Text = "THỐNG KÊ SẢN PHẨM TỒN KHO";
            this.btnTon.UseVisualStyleBackColor = true;
            this.btnTon.Click += new System.EventHandler(this.btnTon_Click);
            // 
            // btnhetDate
            // 
            this.btnhetDate.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnhetDate.FlatAppearance.BorderSize = 4;
            this.btnhetDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnhetDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnhetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhetDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhetDate.Location = new System.Drawing.Point(423, 500);
            this.btnhetDate.Name = "btnhetDate";
            this.btnhetDate.Size = new System.Drawing.Size(189, 64);
            this.btnhetDate.TabIndex = 7;
            this.btnhetDate.Text = "THỐNG KÊ SẢN PHẨM HẾT DATE\r\n";
            this.btnhetDate.UseVisualStyleBackColor = true;
            this.btnhetDate.Click += new System.EventHandler(this.btnhetDate_Click);
            // 
            // DataThongKE
            // 
            this.DataThongKE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataThongKE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataThongKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataThongKE.Location = new System.Drawing.Point(103, 175);
            this.DataThongKE.Name = "DataThongKE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataThongKE.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataThongKE.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataThongKE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataThongKE.Size = new System.Drawing.Size(1489, 278);
            this.DataThongKE.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(752, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "NGÀY KẾT THÚC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(364, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "NGÀY BẮT ĐẦU";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnXuatExcel.FlatAppearance.BorderSize = 4;
            this.btnXuatExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnXuatExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(1291, 498);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(184, 66);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "XUẤT EXCEL";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // UC_THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataThongKE);
            this.Controls.Add(this.btnhetDate);
            this.Controls.Add(this.btnTon);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnThongKeNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateKetThuc);
            this.Controls.Add(this.dateBatDau);
            this.Name = "UC_THONGKE";
            this.Size = new System.Drawing.Size(1642, 598);
            ((System.ComponentModel.ISupportInitialize)(this.DataThongKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongKeNhap;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnTon;
        private System.Windows.Forms.Button btnhetDate;
        private System.Windows.Forms.DataGridView DataThongKE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}
