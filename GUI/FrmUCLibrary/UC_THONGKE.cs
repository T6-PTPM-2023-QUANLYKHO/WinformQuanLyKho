using _BLL;
using _DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace FrmUCLibrary
{
    public partial class UC_THONGKE : UserControl
    {
        private XuLySanPhamModel xuLySanPhamModel;
        public UC_THONGKE()
        {
            InitializeComponent();
            xuLySanPhamModel = new XuLySanPhamModel();
            DataThongKE.ColumnHeadersVisible = true;
            DataThongKE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataThongKE.BackgroundColor = Color.LightGray;
            DataThongKE.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
            };
           
        }

        private async void btnThongKeNhap_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateBatDau.Value;
            DateTime ngayKetThuc = dateKetThuc.Value;
            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<ThongKeSpModel> ketQuaThongKe = await xuLySanPhamModel.ThongKeSLNhap(ngayBatDau, ngayKetThuc);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Mã Nhà Cung Cấp", typeof(string));
                dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Ngày Sản Xuất", typeof(string));
                dataTable.Columns.Add("Hạn Sử Dụng", typeof(string));
                dataTable.Columns.Add("Số Lượng", typeof(int));
                dataTable.Columns.Add("Mã Loại", typeof(string));
                dataTable.Columns.Add("Giá", typeof(double));
                dataTable.Columns.Add("Ghi Chú", typeof(string));
                dataTable.Columns.Add("Mã Kho", typeof(string));
                dataTable.Columns.Add("Ảnh", typeof(Image));
                dataTable.Columns.Add("Số Lượng Nhập", typeof(string));
                foreach (ThongKeSpModel sp in ketQuaThongKe)
                {
                    DataRow row = dataTable.NewRow();

                    row["Mã Sản Phẩm"] = sp.SanPham.mA_SP;
                    row["Mã Nhà Cung Cấp"] = sp.SanPham.mA_NCC;
                    row["Tên Sản Phẩm"] = sp.SanPham.teN_SP;
                    row["Ngày Sản Xuất"] = sp.SanPham.ngaysx;
                    row["Hạn Sử Dụng"] = sp.SanPham.hsd;
                    row["Số Lượng"] = sp.SanPham.soluong;
                    row["Mã Loại"] = sp.SanPham.mA_LOAI;
                    row["Giá"] = sp.SanPham.gia;
                    row["Ghi Chú"] = sp.SanPham.ghichU_SP;
                    row["Mã Kho"] = sp.SanPham.makho;
                    if (sp.SanPham.anh != null)
                    {
                        Image image = Base64ToImage(sp.SanPham.anh);
                        row["Ảnh"] = image;
                    }

                    row["Số Lượng Nhập"] = sp.SoLuong;
                    dataTable.Rows.Add(row);
                }
                DataThongKE.DataSource = dataTable;
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            public Image Base64ToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private async void btnhetDate_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateBatDau.Value;
            DateTime ngayKetThuc = dateKetThuc.Value;
            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
<<<<<<< HEAD
                List<SanPhamModel2> ketQuaThongKe = await xuLySanPhamModel.ThongKeDate(ngayBatDau, ngayKetThuc);
=======
                List<SanPhamModel> ketQuaThongKe = await xuLySanPhamModel.ThongKeDate(ngayBatDau, ngayKetThuc);
>>>>>>> tuan

                // Tạo một DataTable mới để lưu trữ dữ liệu
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Thêm cột vào DataTable
                dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Mã Nhà Cung Cấp", typeof(string));
                dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Ngày Sản Xuất", typeof(string));
                dataTable.Columns.Add("Hạn Sử Dụng", typeof(string));
                dataTable.Columns.Add("Số Lượng", typeof(int));
                dataTable.Columns.Add("Mã Loại", typeof(string));
                dataTable.Columns.Add("Giá", typeof(double));
                dataTable.Columns.Add("Ghi Chú", typeof(string));
                dataTable.Columns.Add("Mã Kho", typeof(string));
                dataTable.Columns.Add("Ảnh", typeof(Image));
                // Thêm dòng dữ liệu vào DataTable
<<<<<<< HEAD
                foreach (SanPhamModel2 sp in ketQuaThongKe)
=======
                foreach (SanPhamModel sp in ketQuaThongKe)
>>>>>>> tuan
                {
                    DataRow row = dataTable.NewRow();

                    row["Mã Sản Phẩm"] = sp.mA_SP;
                    row["Mã Nhà Cung Cấp"] = sp.mA_NCC;
                    row["Tên Sản Phẩm"] = sp.teN_SP;
                    row["Ngày Sản Xuất"] = sp.ngaysx;
                    row["Hạn Sử Dụng"] = sp.hsd;
                    row["Số Lượng"] = sp.soluong;
                    row["Mã Loại"] = sp.mA_LOAI;
                    row["Giá"] = sp.gia;
                    row["Ghi Chú"] = sp.ghichU_SP;
                    row["Mã Kho"] = sp.makho;
                    if (sp.anh != null)
                    {
                        Image image = Base64ToImage(sp.anh);
                        row["Ảnh"] = image;
                    }
                    dataTable.Rows.Add(row);
                }
                DataThongKE.DataSource = dataTable;
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBan_Click(object sender, EventArgs e)
        {

            DateTime ngayBatDau = dateBatDau.Value;
            DateTime ngayKetThuc = dateKetThuc.Value;
            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<ThongKeSpModel> ketQuaThongKe = await xuLySanPhamModel.ThongKeBan(ngayBatDau, ngayKetThuc);

                // Tạo một DataTable mới để lưu trữ dữ liệu
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Thêm cột vào DataTable
                dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Mã Nhà Cung Cấp", typeof(string));
                dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Ngày Sản Xuất", typeof(string));
                dataTable.Columns.Add("Hạn Sử Dụng", typeof(string));
                dataTable.Columns.Add("Số Lượng", typeof(int));
                dataTable.Columns.Add("Mã Loại", typeof(string));
                dataTable.Columns.Add("Giá", typeof(double));
                dataTable.Columns.Add("Ghi Chú", typeof(string));
                dataTable.Columns.Add("Mã Kho", typeof(string));
                dataTable.Columns.Add("Ảnh", typeof(Image));
                dataTable.Columns.Add("Số Lượng Bán", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (ThongKeSpModel sp in ketQuaThongKe)
                {
                    DataRow row = dataTable.NewRow();

                    row["Mã Sản Phẩm"] = sp.SanPham.mA_SP;
                    row["Mã Nhà Cung Cấp"] = sp.SanPham.mA_NCC;
                    row["Tên Sản Phẩm"] = sp.SanPham.teN_SP;
                    row["Ngày Sản Xuất"] = sp.SanPham.ngaysx;
                    row["Hạn Sử Dụng"] = sp.SanPham.hsd;
                    row["Số Lượng"] = sp.SanPham.soluong;
                    row["Mã Loại"] = sp.SanPham.mA_LOAI;
                    row["Giá"] = sp.SanPham.gia;
                    row["Ghi Chú"] = sp.SanPham.ghichU_SP;
                    row["Mã Kho"] = sp.SanPham.makho;
                    if (sp.SanPham.anh != null)
                    {
                        Image image = Base64ToImage(sp.SanPham.anh);
                        row["Ảnh"] = image;
                    }

                    row["Số Lượng Bán"] = sp.SoLuong;
                    dataTable.Rows.Add(row);
                }
                DataThongKE.DataSource = dataTable;
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTon_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateBatDau.Value;
            DateTime ngayKetThuc = dateKetThuc.Value;
            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<ThongKeSpModel> ketQuaThongKe = await xuLySanPhamModel.ThongKeTon(ngayBatDau, ngayKetThuc);

                // Tạo một DataTable mới để lưu trữ dữ liệu
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Thêm cột vào DataTable
                dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Mã Nhà Cung Cấp", typeof(string));
                dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
                dataTable.Columns.Add("Ngày Sản Xuất", typeof(string));
                dataTable.Columns.Add("Hạn Sử Dụng", typeof(string));
                dataTable.Columns.Add("Số Lượng", typeof(int));
                dataTable.Columns.Add("Mã Loại", typeof(string));
                dataTable.Columns.Add("Giá", typeof(double));
                dataTable.Columns.Add("Ghi Chú", typeof(string));
                dataTable.Columns.Add("Mã Kho", typeof(string));
                dataTable.Columns.Add("Ảnh", typeof(Image));
                dataTable.Columns.Add("Số Lượng Tồn", typeof(string));

                // Thêm dòng dữ liệu vào DataTable
                foreach (ThongKeSpModel sp in ketQuaThongKe)
                {
                    DataRow row = dataTable.NewRow();

                    row["Mã Sản Phẩm"] = sp.SanPham.mA_SP;
                    row["Mã Nhà Cung Cấp"] = sp.SanPham.mA_NCC;
                    row["Tên Sản Phẩm"] = sp.SanPham.teN_SP;
                    row["Ngày Sản Xuất"] = sp.SanPham.ngaysx;
                    row["Hạn Sử Dụng"] = sp.SanPham.hsd;
                    row["Số Lượng"] = sp.SanPham.soluong;
                    row["Mã Loại"] = sp.SanPham.mA_LOAI;
                    row["Giá"] = sp.SanPham.gia;
                    row["Ghi Chú"] = sp.SanPham.ghichU_SP;
                    row["Mã Kho"] = sp.SanPham.makho;
                    string base64Image = sp.SanPham.anh != null ? Convert.ToBase64String(sp.SanPham.anh) : string.Empty;
                    if (sp.SanPham.anh != null)
                    {
                        Image image = Base64ToImage(sp.SanPham.anh);
                        row["Ảnh"] = image;
                    }

                    row["Số Lượng Tồn"] = sp.SoLuong;
                    dataTable.Rows.Add(row);
                }
                DataThongKE.DataSource = dataTable;
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn = (DataGridViewImageColumn)DataThongKE.Columns[10];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;           
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Lưu File Excel";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = ExcelApp.Workbooks.Add(Type.Missing);
                _Worksheet worksheet = null;

                try
                {
                    worksheet = workbook.ActiveSheet;

                    // Thiết lập tiêu đề
                    worksheet.Cells[1, 6] = "THỐNG KÊ SẢN PHẨM";
                    worksheet.Range["F1"].Font.Size = 16;
                    worksheet.Range["F1"].Font.Color = Color.Blue;
                    worksheet.Range["F1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Thiết lập tiêu đề cột
                    for (int i = 1; i < DataThongKE.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[2, i] = DataThongKE.Columns[i - 1].HeaderText;
                        worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].Font.Size = 14;
                        worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].Font.Color = Color.Black;
                        worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].Interior.Color = Color.Red;
                        worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    }

                    // Xuất dữ liệu
                    for (int i = 0; i < DataThongKE.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataThongKE.Columns.Count; j++)
                        {
                            if (DataThongKE.Columns[j] is DataGridViewImageColumn)
                            {
                                // Xử lý xuất ảnh riêng biệt
                                Image image = (Image)DataThongKE.Rows[i].Cells[j].Value;
                                SaveImageToExcel(worksheet, i + 3, j + 1, image);
                            }
                            else
                            {
                                // Xử lý dữ liệu khác
                                worksheet.Cells[i + 3, j + 1] = DataThongKE.Rows[i].Cells[j].Value;
                                worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].Interior.Color = Color.Aqua;
                                worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].Font.Size = 12;
                                worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].Font.Color = Color.Black;
                                worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            }
                        }
                    }

                    // Lưu file Excel
                    workbook.SaveAs(saveFileDialog1.FileName.ToString());
                    workbook.Close();
                    ExcelApp.Quit();

                    // Giải phóng bộ nhớ
                    ReleaseObject(worksheet);
                    ReleaseObject(workbook);
                    ReleaseObject(ExcelApp);

                    // Thông báo xuất file thành công
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveImageToExcel(_Worksheet worksheet, int row, int col, Image image)
        {
            Clipboard.SetImage(image);
            worksheet.Paste(worksheet.Cells[row, col], Type.Missing);
            Clipboard.Clear();
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi giải phóng đối tượng: {ex.Message}");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
    
    

