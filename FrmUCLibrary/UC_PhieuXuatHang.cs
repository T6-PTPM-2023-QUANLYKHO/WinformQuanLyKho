using FrmUCLibrary.Model;
using Library;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUCLibrary
{
    public partial class UC_PhieuXuatHang : UserControl
    {
        XuLyKhachHangModel _xuLyKhachHang = new XuLyKhachHangModel();
        XuLyLoaiSanPhamModel _xyLyLoaiSP = new XuLyLoaiSanPhamModel();
        XuLySanPhamModel _xuLySanPham = new XuLySanPhamModel();
        XuLyChiTietPhieuXuatModel _xuLyChiTietPhieuXuat = new XuLyChiTietPhieuXuatModel();
        XuLyPhieuXuatModel _xuLyPhieuXuat = new XuLyPhieuXuatModel();
        List<KhachHangModel> _listKhachHang;
        List<SanPhamModel> listSP;
        DataGridView dataGridViewSanPham, dataGridViewCTPX, dataGridViewPX;
        public UC_PhieuXuatHang()
        {
            InitializeComponent();
            init();
        }
        public async void init()
        {
            txtMaPhieuXuat.Text = Helper.createMaPhieuXuat();
            txtMaNhanVien.Text = "NV01";
            txtSDT.Text = "085147652";
            listSP = await getAllSP();
            LoadComboboxLoaiSP();
            CreateDataGridViewChiTietPhieuXuat();

        }
        public async Task<List<SanPhamModel>> getAllSP()
        {
            return await _xuLySanPham.getAllSP();
        }
        private void UC_PhieuXuatHang_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private async void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sdt = txtSDT.Text;
                KhachHangModel kh =await _xuLyKhachHang.getKhachHangBySDT(sdt);
                if (kh == null)
                {
                    ThongBao("Không tìm thấy khách hàng yêu cầu");
                }
                else {
                    LoadTTKhachHang(kh);
                }
            }
        }
        private DialogResult ThongBaoYesNo(string text, string title)
        {
            DialogResult _DialogResult = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return _DialogResult;
        }
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }        
        private void LoadTTKhachHang(KhachHangModel kh)
        {
            if (kh == null) { return; }
            else
            {
                txtTenKH.Text = kh.TEN_KH;
                txtMaKH.Text = kh.MAKH;
            }
        }
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            KhachHangModel kh =await _xuLyKhachHang.getKhachHangBySDT(sdt);
            if(kh != null)
            {
                LoadTTKhachHang(kh);
                CreateDataGridViewPhieuXuat();
               List<PhieuXuatModel> list =await _xuLyPhieuXuat.getAllPhieuXuatByMaKH(kh.MAKH);
                if(list != null)
                {
                    LoadTTPhieuXuat(list);
                }
            }
            else { ThongBao("Vui lòng tạo mới khách hàng"); }
        }
        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoai = cbxLoaiSP.SelectedValue.ToString();
            List<SanPhamModel> _list = listSP.Where(m => m.mA_LOAI.Equals(maLoai)).ToList();
            if (_list != null)
            {
                LoadTTSanPham(_list);
            }
        }
        private void LoadTTSanPham(List<SanPhamModel> list)
        {
            foreach (SanPhamModel item in list)
            {
                int indexrow = dataGridViewSanPham.Rows.Add();
                dataGridViewSanPham.Rows[indexrow].Cells["mA_SP"].Value = item.mA_SP;
                dataGridViewSanPham.Rows[indexrow].Cells["mA_NCC"].Value = item.mA_NCC;
                dataGridViewSanPham.Rows[indexrow].Cells["teN_SP"].Value = item.teN_SP;
                dataGridViewSanPham.Rows[indexrow].Cells["_ngaysx"].Value = item.ngaysx;
                dataGridViewSanPham.Rows[indexrow].Cells["gia"].Value = item.gia;
            }
        }
        private void CreateDataGridViewSanPham()
        {
            //tạo datagidview 
            dataGridViewSanPham = new DataGridView();
            dataGridViewSanPham.Name = "dataGridViewSanPham";
            //tạo các cột 
            DataGridViewTextBoxColumn _mA_SP = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _mA_NCC = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _teN_SP = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _ngaysx = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _hsd = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _soluong = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _mA_LOAI = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _gia = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _ghichU_SP = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _makho = new DataGridViewTextBoxColumn();

            //đặt tiêu đề cho cột
            _mA_SP.HeaderText = "Mã SP";
            _mA_SP.Name = "mA_SP";
            _mA_SP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            _mA_NCC.HeaderText = "Mã NCC";
            _mA_NCC.Name = "mA_NCC";
            _mA_NCC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            _teN_SP.HeaderText = "Tên SP";
            _teN_SP.Name = "teN_SP";
            _teN_SP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            _ngaysx.HeaderText = "Ngày SX";
            _ngaysx.Name = "_ngaysx";
            _ngaysx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            _gia.HeaderText = "Giá";
            _gia.Name = "gia";
            _gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //thêm cột vào datagirdview
            dataGridViewSanPham.Columns.Add(_mA_SP);
            dataGridViewSanPham.Columns.Add(_mA_NCC);
            dataGridViewSanPham.Columns.Add(_teN_SP);
            dataGridViewSanPham.Columns.Add(_ngaysx);
            dataGridViewSanPham.Columns.Add(_gia);
            //
            dataGridViewSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSanPham.CellClick += DataGridViewSanPham_CellClick;
            //add vào panel
            groupTTSanPham.Controls.Clear();
            groupTTSanPham.Controls.Add(dataGridViewSanPham);
        }

        private void DataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > dataGridViewSanPham.Rows.Count - 2) { return; }

            SanPhamModel item = new SanPhamModel();
            txtMaSP.Text = dataGridViewSanPham.Rows[index].Cells["mA_SP"].Value.ToString();
            txtTenSP.Text = dataGridViewSanPham.Rows[index].Cells["teN_SP"].Value.ToString();
            txtDonGia.Text = dataGridViewSanPham.Rows[index].Cells["gia"].Value.ToString();
            int sl = int.Parse(txtSL.Value.ToString());
            float gia = float.Parse(txtDonGia.Text.ToString());
            float thanhtien = sl * gia;
            txtThanhTien.Text = thanhtien.ToString();
        }
        private void LoadTTPhieuXuat(List<PhieuXuatModel> list)
        {
            foreach(PhieuXuatModel item in list)
            {
                int rowindex = dataGridViewPX.Rows.Add();
                dataGridViewPX.Rows[rowindex].Cells["mapH_XH"].Value = item.mapH_XH;
                dataGridViewPX.Rows[rowindex].Cells["makh"].Value = item.makh;
                dataGridViewPX.Rows[rowindex].Cells["ngaY_XH"].Value = item.ngaY_XH;
                dataGridViewPX.Rows[rowindex].Cells["tongtieN_XH"].Value = item.tongtieN_XH;
                dataGridViewPX.Rows[rowindex].Cells["manv"].Value = item.manv;
            }
        }
        private void CreateDataGridViewPhieuXuat()
        {
            //tạo datagidview 
            int width = groupDSPhieuXuat.Width;
            int height = groupDSPhieuXuat.Height;
            dataGridViewPX = new DataGridView();
            dataGridViewPX.Name = "dataGridViewPX";
            dataGridViewPX.Width = width;
            dataGridViewPX.Height = height;
            //tạo các cột 
            DataGridViewTextBoxColumn mapH_XH = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ngaY_XH = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn makh = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn tongtieN_XH = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn manv = new DataGridViewTextBoxColumn();

            //đ
            mapH_XH.HeaderText = "Mã phiếu xuất";
            mapH_XH.Name = "mapH_XH";
            mapH_XH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            makh.HeaderText = "Mã khách hàng";
            makh.Name = "makh";
            makh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            ngaY_XH.HeaderText = "Ngày xuất";
            ngaY_XH.Name = "ngaY_XH";
            ngaY_XH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            tongtieN_XH.HeaderText = "Tổng tiền";
            tongtieN_XH.Name = "tongtieN_XH";
            tongtieN_XH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            manv.HeaderText = "Mã nhân viên";
            manv.Name = "manv";
            manv.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //thêm cột vào datagirdview;
            dataGridViewPX.Columns.Add(mapH_XH);
            dataGridViewPX.Columns.Add(makh);
            dataGridViewPX.Columns.Add(ngaY_XH);
            dataGridViewPX.Columns.Add(tongtieN_XH);
            dataGridViewPX.Columns.Add(manv);
            dataGridViewPX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPX.CellClick += DataGridViewPX_CellClick;
            //add vào panel
            groupDSPhieuXuat.Controls.Clear();
            groupDSPhieuXuat.Controls.Add(dataGridViewPX);
        }

        private async void DataGridViewPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index < dataGridViewPX.RowCount - 2)
                {
                    txtMaPhieuXuat.Text = dataGridViewPX.Rows[index].Cells["mapH_XH"].Value.ToString();
                    txtMaKH.Text = dataGridViewPX.Rows[index].Cells["makh"].Value.ToString();
                    dateTimePicker_NgayXuatPhieu.Value = DateTime.Parse(dataGridViewPX.Rows[index].Cells["ngaY_XH"].Value.ToString());
                    txtTongTien.Text = dataGridViewPX.Rows[index].Cells["tongtieN_XH"].Value.ToString();
                    txtMaNhanVien.Text = dataGridViewPX.Rows[index].Cells["manv"].Value.ToString();
                    List<CTPhieuXuatModel> chiTietPhieuXuats =await _xuLyChiTietPhieuXuat.getCTPhieuXuatByMaPhieu(txtMaPhieuXuat.Text.ToString());
                    if(chiTietPhieuXuats != null)
                    {
                        CreateDataGridViewChiTietPhieuXuat();
                        ThemDuLieuRowDataGridViewCTPhieuXuat(chiTietPhieuXuats);
                    }
                }
            }
            catch { }
           
        }

        private void CreateDataGridViewChiTietPhieuXuat()
        {
            //tạo datagidview 
            int w = grpTTCTPhieuXuat.Width;
            int h = grpTTCTPhieuXuat.Height;
            dataGridViewCTPX = new DataGridView();
            dataGridViewCTPX.Name = "dataGridViewChitietPhieuNhap";
            dataGridViewCTPX.Width = w;
            dataGridViewCTPX.Height = h;
            //tạo các cột 
            DataGridViewTextBoxColumn STT = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn mapH_XH = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn mA_SP = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn soluong = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn thanhtien = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn gia = new DataGridViewTextBoxColumn();

        //đặt tiêu đề cho cột
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            mapH_XH.HeaderText = "Mã phiếu xuất";
            mapH_XH.Name = "maPhieuXH";
            mapH_XH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            mA_SP.HeaderText = "Mã sản phẩm";
            mA_SP.Name = "maSP";
            mA_SP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            soluong.HeaderText = "Số lượng";
            soluong.Name = "soLuong";
            soluong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            thanhtien.HeaderText = "Thành tiền";
            thanhtien.Name = "thanhTien";
            thanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            gia.HeaderText = "Giá";
            gia.Name = "gia";
            gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //thêm cột vào datagirdview
            dataGridViewCTPX.Columns.Add(STT);
            dataGridViewCTPX.Columns.Add(mapH_XH);
            dataGridViewCTPX.Columns.Add(mA_SP);
            dataGridViewCTPX.Columns.Add(soluong);
            dataGridViewCTPX.Columns.Add(thanhtien);
            dataGridViewCTPX.Columns.Add(gia);
            dataGridViewCTPX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCTPX.CellClick += DataGridViewCTPX_CellClick;
            //add vào panel
            grpTTCTPhieuXuat.Controls.Clear();
            grpTTCTPhieuXuat.Controls.Add(dataGridViewCTPX);
        }

        private void DataGridViewCTPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < dataGridViewCTPX.RowCount - 2)
            {
                txtMaPhieuXuat.Text = dataGridViewCTPX.Rows[index].Cells["maPhieuXH"].Value.ToString();
                txtMaSP.Text = dataGridViewCTPX.Rows[index].Cells["maSP"].Value.ToString();
                txtSL.Value = int.Parse(dataGridViewCTPX.Rows[index].Cells["soLuong"].Value.ToString());
                txtThanhTien.Text = dataGridViewCTPX.Rows[index].Cells["thanhTien"].Value.ToString();
                txtDonGia.Text = dataGridViewCTPX.Rows[index].Cells["gia"].Value.ToString();
            }
        }

        private async void LoadComboboxLoaiSP()
        {
            List<LoaiSanPhamModel> list = await _xyLyLoaiSP.getAllLoaiSP();
            if (list != null)
            {
                cbxLoaiSP.DataSource = list;
                cbxLoaiSP.DisplayMember = "teN_LOAI";
                cbxLoaiSP.ValueMember = "mA_LOAI";
            }
            CreateDataGridViewSanPham(); 
        }
        private bool KT_ThongTinSanPham()
        {
            foreach (Control item in grpTTCTPhieuXuat.Controls)
            {
                if(item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    if(t.Text=="" || String.IsNullOrEmpty(t.Text) ) { return false; }
                }
            }
            return true;
        }
        private CTPhieuXuatModel getTT_CTPhieuXuat()
        {
            CTPhieuXuatModel ctpx = new CTPhieuXuatModel();
            ctpx.mapH_XH = txtMaPhieuXuat.Text.ToString();
            ctpx.mA_SP = txtMaSP.Text.ToString();
            ctpx.soluong = txtSL.Value.ToString();
            ctpx.thanhtien = txtThanhTien.Text.ToString();
            ctpx.gia =txtDonGia.Text.ToString();
            return ctpx;
        }
        private void ThemDuLieuRowDataGridViewCTPhieuXuat(CTPhieuXuatModel ctpx) 
        { 
            int index = dataGridViewCTPX.Rows.Add();
            dataGridViewCTPX.Rows[index].Cells["maPhieuXH"].Value = ctpx.mapH_XH;
            dataGridViewCTPX.Rows[index].Cells["maSP"].Value = ctpx.mA_SP;
            dataGridViewCTPX.Rows[index].Cells["soLuong"].Value = ctpx.soluong;
            if (ctpx.thanhtien == "" || String.IsNullOrEmpty(ctpx.thanhtien))
            {
                dataGridViewCTPX.Rows[index].Cells["thanhTien"].Value = "0";
            }
            else
            {
                dataGridViewCTPX.Rows[index].Cells["thanhTien"].Value = ctpx.thanhtien;
            }
            dataGridViewCTPX.Rows[index].Cells["gia"].Value = ctpx.gia;
        }
        private void ThemDuLieuRowDataGridViewCTPhieuXuat(List<CTPhieuXuatModel> ctpxs)
        {
            foreach(CTPhieuXuatModel item in ctpxs)
            {
                int index = dataGridViewCTPX.Rows.Add();
                dataGridViewCTPX.Rows[index].Cells["maPhieuXH"].Value = item.mapH_XH;
                dataGridViewCTPX.Rows[index].Cells["maSP"].Value = item.mA_SP;
                dataGridViewCTPX.Rows[index].Cells["soLuong"].Value = item.soluong;
                if(item.thanhtien =="" || String.IsNullOrEmpty(item.thanhtien))
                {
                    dataGridViewCTPX.Rows[index].Cells["thanhTien"].Value = "0";
                }
                else
                {
                    dataGridViewCTPX.Rows[index].Cells["thanhTien"].Value = item.thanhtien;
                }
                dataGridViewCTPX.Rows[index].Cells["gia"].Value = item.gia;
            }
           
        }
        private bool KT_TrungMaSPvaMaPhieu(string masp, string maphieu)
        {
            if (dataGridViewCTPX.RowCount <= 1) { return false; }
            for (int i = 0; i < dataGridViewCTPX.RowCount-1; i++)
            {
                string _masp = dataGridViewCTPX.Rows[i].Cells["maSP"].Value.ToString();
                string _maphieu = dataGridViewCTPX.Rows[i].Cells["maPhieuXH"].Value.ToString(); 
                if (_maphieu.Equals(maphieu)
                    && _masp.Equals(masp))
                {
                    return true;
                }
            }
            return false;
        }
        private void CapNhatSLCTPhieuXuat(string maPhXuat, string maSP, int sl)
        {
            for (int i = 0; i < dataGridViewCTPX.RowCount-1; i++)
            {
                if (dataGridViewCTPX.Rows[i].Cells["maPhieuXH"].Value.ToString().Equals(maPhXuat)
                    && dataGridViewCTPX.Rows[i].Cells["maSP"].Value.ToString().Equals(maSP))
                {
                    int slHT = int.Parse(dataGridViewCTPX.Rows[i].Cells["soLuong"].Value.ToString());
                    int slMoi = slHT + sl;
                    float tt = slMoi * float.Parse(txtDonGia.Text.ToString());
                    dataGridViewCTPX.Rows[i].Cells["soLuong"].Value = slMoi;
                    dataGridViewCTPX.Rows[i].Cells["thanhTien"].Value = tt;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KT_ThongTinSanPham() == false)
            {
                ThongBao("Kiểm tra lại thông tin sản phẩm !");
                return;                
            }
            CTPhieuXuatModel ct = getTT_CTPhieuXuat();
            if (KT_TrungMaSPvaMaPhieu(ct.mA_SP, ct.mapH_XH)==true)
            {
                CapNhatSLCTPhieuXuat(ct.mapH_XH, ct.mA_SP,int.Parse( ct.soluong));
                txtTongTien.Text = tinhTongCTPhieuXuat().ToString();
                return;
            }          
            if(ct != null)
            {
                ThemDuLieuRowDataGridViewCTPhieuXuat(ct);
            }
           txtTongTien.Text =  tinhTongCTPhieuXuat().ToString();
        }
        private float tinhTongCTPhieuXuat()
        {
            float tongTien = 0;
            if (dataGridViewCTPX.RowCount == 2) { return 0; }
            for(int i =0; i< dataGridViewCTPX.RowCount-1; i++)
            {
                float TTSP =float.Parse( dataGridViewCTPX.Rows[i].Cells["thanhTien"].Value.ToString());
                tongTien += TTSP;
            }
            return tongTien;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTPhieuXuatModel ct = getTT_CTPhieuXuat();
            if (ct == null)
            {
                ThongBao("Thông tin phiếu xuất không đúng");
                return;
            }
            int dem = 0;
            for (int i = 0; i < dataGridViewCTPX.RowCount-1; i++)
            {
                if (
                dataGridViewCTPX.Rows[i].Cells["maPhieuXH"].Value.ToString().Equals(ct.mapH_XH) &&
                dataGridViewCTPX.Rows[i].Cells["maSP"].Value.ToString().Equals(ct.mA_SP))
                {
                    dataGridViewCTPX.Rows.RemoveAt(i);
                    dem++;
                    break;
                }
            }
            if (dem == 0) { ThongBao("Sản phẩm cần xóa không tồn tại!"); }
        }
        private PhieuXuatModel getTTPhieuXuat()
        {
            if (KT_ThongTinPhieuXuat() == false) {return null; }
            PhieuXuatModel phieu = new PhieuXuatModel();
            phieu.mapH_XH = txtMaPhieuXuat.Text.ToString();
            phieu.ngaY_XH = dateTimePicker_NgayXuatPhieu.Value.ToString();
            phieu.makh = txtMaKH.Text.ToString();
            phieu.tongtieN_XH = txtTongTien.Text.ToString();
            phieu.manv = txtMaNhanVien.Text.ToString();
            return phieu;
        }
        private Boolean KT_ThongTinPhieuXuat()
        {
            foreach (Control ctr in grp_TT_PhieuXuat.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox tb = (TextBox)ctr;
                    if(tb.Text=="" || String.IsNullOrEmpty(tb.Text.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //B1 kiểm tra mã phiếu xuất tồn tại chưa
                string maPHXuat = txtMaPhieuXuat.Text;
                bool ktTonTaiPhieu =await _xuLyPhieuXuat.KT_TonTaiMaPhieuXuat(maPHXuat);
                if(ktTonTaiPhieu == false) { ThongBao("Bạn chưa tạo phiếu xuất");return; }
                List<CTPhieuXuatModel> listCT = await _xuLyChiTietPhieuXuat.getCTPhieuXuatByMaPhieu(maPHXuat);
                if (listCT != null)
                {
                    _xuLyChiTietPhieuXuat.xoaChiTietPhieuXuatByMaPX(maPHXuat);
                }
                DialogResult r = ThongBaoYesNo("Xác nhận lưu ?", "Thông báo");
                if (r == DialogResult.No) { return; }
                for (int i = 0; i < dataGridViewCTPX.RowCount - 1; i++)
                {
                    CTPhieuXuatModel ct = new CTPhieuXuatModel();
                    ct.mapH_XH = dataGridViewCTPX.Rows[i].Cells["maPhieuXH"].Value.ToString();
                    ct.mA_SP = dataGridViewCTPX.Rows[i].Cells["maSP"].Value.ToString();
                    ct.soluong = dataGridViewCTPX.Rows[i].Cells["soLuong"].Value.ToString();
                    ct.thanhtien = dataGridViewCTPX.Rows[i].Cells["thanhTien"].Value.ToString();
                    ct.gia = dataGridViewCTPX.Rows[i].Cells["gia"].Value.ToString();
                    int kq = await _xuLyChiTietPhieuXuat.ThemCTPhieuXuat(ct);
                }
                ThongBao("Thêm thành cônng");
            }
            catch { ThongBao("Xảy ra lỗi"); }
           
        }

        private async void btnLuuPhieuXuat_Click(object sender, EventArgs e)
        {
            PhieuXuatModel phieu = new PhieuXuatModel();
            DialogResult r = ThongBaoYesNo("Xác nhận tạo mới?","Thông báo");
            if(r == DialogResult.No) { return; }
            phieu = getTTPhieuXuat();
            if (phieu == null || phieu.mapH_XH == null) { ThongBao("Thông tin phiếu xuất bị sai"); }
            else
            {
               int kq =await  _xuLyPhieuXuat.themPhieuXuat(phieu);
                if(kq == 1)
                {
                    ThongBao("Thành công");
                    btnLuuPhieuXuat.Enabled = false;
                }
                else
                {
                    ThongBao("Thêm phiếu xuất thất bại");
                }
            }
        }

        private async void btnXoaPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                //xóa chi tiết phiếu xuất trước
                string maphieuxuat = txtMaPhieuXuat.Text.ToString();
                if (String.IsNullOrEmpty(maphieuxuat)) { ThongBao("Không thể xóa phiếu xuất!");return; }
                //xóa chi tiết phiếu xuất trước
               int kqxoa =await _xuLyChiTietPhieuXuat.xoaChiTietPhieuXuatByMaPX(maphieuxuat);
                if (kqxoa == 1)
                {
                    DialogResult r = ThongBaoYesNo("Xác nhận xóa?", "Thông báo");
                    if (DialogResult.No == r) { return; }
                    //xóa phiếu xuất
                    int kq = await _xuLyPhieuXuat.deletePhieuXuat(maphieuxuat);
                    if (kq == 0) { ThongBao("Xóa phiếu xuất thất bại"); }
                    else { ThongBao("Xóa thành công"); }
                }
                else { ThongBao("Xóa thất bại"); }
            }
            catch { ThongBao("Xóa thất bại"); }
        }

        private void txtSL_ValueChanged(object sender, EventArgs e)
        {
            if(txtDonGia.Text=="" || String.IsNullOrEmpty(txtDonGia.Text.ToString())) { return; }
            txtThanhTien.Text = (float.Parse(txtDonGia.Text) * int.Parse( txtSL.Value.ToString())).ToString();
        }

        private void btnTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            btnLuuPhieuXuat.Enabled = true;
            txtMaPhieuXuat.Text = Helper.createMaPhieuXuat();
            txtTongTien.Text = "0";
            CreateDataGridViewChiTietPhieuXuat();
        }
    }
}
