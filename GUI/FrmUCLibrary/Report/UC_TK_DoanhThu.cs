using _BLL;
using _DTO;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUCLibrary.Report
{
    public partial class UC_TK_DoanhThu : UserControl
    {
        XuLyThongKeModel _xuLyThongKe = new XuLyThongKeModel();
        XuLyLoaiSanPhamModel _xuLyLoaiSanPham = new XuLyLoaiSanPhamModel();
        public UC_TK_DoanhThu()
        {
            InitializeComponent();
        }
        private async void LoadThongKeNhapHangTheoNgay(DateTime startDay, DateTime endDate)
        {
            List<TK_NhapHangModel> list = await _xuLyThongKe.getTK_NhapHang_TheoNgay(startDay, endDate);
            if (list != null)
            {
                DGV_TK_NhapHang.DataSource = list;
            }
            txtTongDoanhThuNhapHang.Text = Helper.chuyenDinhDangTien(_xuLyThongKe.TongDoanhThuNhapHang(list));
        }
        private void LoadDGVNhapHang(List<TK_NhapHangModel> list)
        {
            DGV_TK_NhapHang.DataSource = list;
            txtTongDoanhThuNhapHang.Text = Helper.chuyenDinhDangTien(_xuLyThongKe.TongDoanhThuNhapHang(list));
        }
        private void UC_TK_DoanhThu_Load(object sender, EventArgs e)
        {
            LoadComboboxLoaiSPNhapHang();
            LoadComboboxLoaiSPXuatHang();
        }
        private async void LoadComboboxLoaiSPNhapHang()
        {
            List<LoaiSanPhamModel> lst = await _xuLyLoaiSanPham.getAllLoaiSP();
            cbxLoaiSP_NH.DataSource = lst;
            cbxLoaiSP_NH.DisplayMember = "teN_LOAI";
            cbxLoaiSP_NH.ValueMember = "mA_LOAI";
        }
        private async void LoadComboboxLoaiSPXuatHang()
        {
            List<LoaiSanPhamModel> lst = await _xuLyLoaiSanPham.getAllLoaiSP();
            cbxLoaiSP_XH.DataSource = lst;
            cbxLoaiSP_XH.DisplayMember = "teN_LOAI";
            cbxLoaiSP_XH.ValueMember = "mA_LOAI";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDay = txtNgayBD.Value;
            DateTime endDay = txtNgayKT.Value;
            if (startDay > endDay) { MessageBox.Show("Ngày không hợp lệ"); return; }
            LoadThongKeNhapHangTheoNgay(startDay, endDay);
            LoadThongKeXuatHangTheoNgay(startDay, endDay);
        }
        private async void LoadThongKeXuatHangTheoNgay(DateTime startDay, DateTime endDay)
        {
         List<TK_XuatHangModel> list = await   _xuLyThongKe.getTK_XuatHang_TheoNgay(startDay,endDay);
            if(list != null)
            {
                LoadDGVXuatHang(list);
            }
        }
        private void LoadDGVXuatHang(List<TK_XuatHangModel> list)
        {
            DGVTKXuatHang.DataSource = list;
            txtTongNhapHangXuatHang.Text = Helper.chuyenDinhDangTien(_xuLyThongKe.TongDoanhThuXuatHang(list));
        }

        private async void cbxLoaiSP_XH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDay = txtNgayBD.Value;
                DateTime endDay = txtNgayKT.Value;
                if (startDay == endDay) { MessageBox.Show("Ngày không hợp lê"); }
                List<TK_NhapHangModel> list = await _xuLyThongKe.getTK_NhapHang_TheoNgay(startDay, endDay);
                string maLoai = cbxLoaiSP_NH.SelectedValue.ToString();
                List<TK_NhapHangModel> result = list.Where(m => m.MALOAI.Trim().Equals(maLoai.Trim())).ToList();
                if (result != null)
                {
                    LoadDGVNhapHang(result);
                }
            }
            catch
            {
                DateTime startDay = txtNgayBD.Value;
                DateTime endDay = txtNgayKT.Value;
                List<TK_NhapHangModel> list = await _xuLyThongKe.getTK_NhapHang_TheoNgay(startDay, endDay);
                string maLoai = cbxLoaiSP_NH.SelectedValue.ToString();
                List<TK_NhapHangModel> result = list.Where(m => m.MALOAI.Trim().Equals(maLoai.Trim())).ToList();
                if (result != null)
                {
                    LoadDGVNhapHang(result);
                }
            }
                   
        }

        private async void cbxLoaiSP_NH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string maLoai = cbxLoaiSP_XH.SelectedValue.ToString();
                DateTime ngayBD = txtNgayBD.Value;
                DateTime ngayKT = txtNgayKT.Value;
                if (ngayBD > ngayKT) { MessageBox.Show("Ngày không hợp lệ"); }
                List<TK_XuatHangModel> lstTam = await getXHTheoNgay(ngayBD, ngayKT);
                List<TK_XuatHangModel> result = lstTam.Where(m => m.MALOAI.Equals(maLoai)).ToList();
                LoadDGVXuatHang(result);
            }
            catch { } 
        }
        private async Task<List<TK_XuatHangModel>> getXHTheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            List<TK_XuatHangModel> list = await _xuLyThongKe.getTK_XuatHang_TheoNgay(ngayBD, ngayKT);
            if (list != null)
            {
                return list;
            }
            return null;
        }
    }
}
