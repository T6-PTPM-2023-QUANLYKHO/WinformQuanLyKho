using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using _BLL;
using _DTO;

namespace FrmUCLibrary.Report
{
    public partial class UC_TK_TongQuan : UserControl
    {
        XuLyPhieuXuatModel xulyPX = new XuLyPhieuXuatModel();
        XuLyThongKeModel xuLyPN = new XuLyThongKeModel();
        string[] listDay = { "Hôm nay", "Hôm qua", "7 ngày trước", "28 ngày trước" };
        public UC_TK_TongQuan()
        {
            InitializeComponent();
        }
        private void loadCombobox()
        {
            cbxNgayXuatHang.DataSource = listDay;
        }
        private async void LoadBieuDoPhieuXuat(int soNgay)
        {
            List<PhieuXuatModel> phieuXuatS = await xulyPX.getPhieuXuatTheoSoNgay(soNgay);
            phieuXuatS = phieuXuatS.OrderBy(p => p.ngaY_XH).ToList();
            //làm mới thông tin
            chartTKXuatHang.Series[0].Points.Clear();
            chartTKXuatHang.Series[1].Points.Clear();
            List<PhieuXuatModel> listHienTai = xulyPX.getHienTai(phieuXuatS);
            List<PhieuXuatModel> listKiTruoc = xulyPX.getKyTruoc(phieuXuatS);
            foreach (PhieuXuatModel item in listHienTai)
            {
                chartTKXuatHang.Series["Hiện tại"].Points.AddXY(DateTime.Parse(item.ngaY_XH).Day + "/" + DateTime.Parse(item.ngaY_XH).Month + "/" + DateTime.Parse(item.ngaY_XH).Year, item.tongtieN_XH);
            }
            foreach (PhieuXuatModel item in listKiTruoc)
            {
                chartTKXuatHang.Series["Kỳ trước"].Points.AddXY(DateTime.Parse(item.ngaY_XH).Day + "/" + DateTime.Parse(item.ngaY_XH).Month + "/" + DateTime.Parse(item.ngaY_XH).Year, item.tongtieN_XH);
            }
        }
        private async Task LoadBieuDoPhieuNhapAsync(int soNgay)
        {
            List<PhieuNhap> phieuNhapS= await xuLyPN.GetPhieuNhapSoNgayAsync(soNgay);
            phieuNhapS = phieuNhapS.OrderBy(p => p.ngayNhap).ToList();
            //làm mới thông tin
            chartPhieuNhap.Series[0].Points.Clear();
            chartPhieuNhap.Series[1].Points.Clear();
            List<PhieuNhap> listHienTai = xuLyPN.getHienTai(phieuNhapS);
            List<PhieuNhap> listKiTruoc = xuLyPN.getKyTruoc(phieuNhapS);
            foreach (PhieuNhap item in listHienTai)
            {
                chartPhieuNhap.Series["Hiện tại"].Points.AddXY(DateTime.Parse(item.ngayNhap).Day + "/" + DateTime.Parse(item.ngayNhap).Month + "/" + DateTime.Parse(item.ngayNhap).Year, item.tongTien);
            }
            foreach (PhieuNhap item in listKiTruoc)
            {
                chartPhieuNhap.Series["Kỳ trước"].Points.AddXY(DateTime.Parse(item.ngayNhap).Day + "/" + DateTime.Parse(item.ngayNhap).Month + "/" + DateTime.Parse(item.ngayNhap).Year, item.tongTien);
            }
        }
        private void UC_TK_TongQuan_Load(object sender, EventArgs e)
        {
            loadCombobox();
            LoadBieuDoPhieuXuat(7);
        }

        private void cbxNgayXuatHang_SelectedValueChanged(object sender, EventArgs e)
        {
            string codeSelect = cbxNgayXuatHang.SelectedValue.ToString();
            switch (codeSelect)
            {
                case "Hôm nay":
                    {
                        LoadBieuDoPhieuXuat(2);
                        LoadBieuDoPhieuNhapAsync(2);
                        break;
                    }
                case "7 ngày trước":
                    {
                        LoadBieuDoPhieuXuat(14);
                        LoadBieuDoPhieuNhapAsync(14);
                        break;
                    }
                case "28 ngày trước":
                    {
                        LoadBieuDoPhieuXuat(56);
                        LoadBieuDoPhieuNhapAsync(56);
                        break;
                    }
            }
        }

        private void cbxNgayNhapHang_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
