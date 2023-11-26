using _BLL;
using _DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUCLibrary
{
    public partial class UC_PhanQuyenNguoiDung : UserControl
    {
        private XyLyDangNhapModel xyDangNhapModel;
        private XyLyManHinhModel xyLyManHinhModel;
        private XuLyNhomNguoiDung xuLyNhomNguoiDung;
        private XuLyPhanQuyen xuLyPhanQuyen;
        private XuLyTaiKhoanNhanVien xuLyTaiKhoanNhanVien;
        public UC_PhanQuyenNguoiDung()
        {
            InitializeComponent();
        }

        private void UC_PhanQuyenNguoiDung_Load(object sender, EventArgs e)
        {
            xyDangNhapModel = new XyLyDangNhapModel();
            xyLyManHinhModel = new XyLyManHinhModel();
            xuLyNhomNguoiDung = new XuLyNhomNguoiDung();
            xuLyPhanQuyen = new XuLyPhanQuyen();
            xuLyTaiKhoanNhanVien = new XuLyTaiKhoanNhanVien();
            LoadDangNhap();
            LoadManHinh();
            LoadNhomNguoiDung();
            LoadPhanQuyen();
            LoadTaiKhoanNV();
            LoadMaManHinh();
            LoadMaNhom();

            //taikhoan
            LoadTaiKhoan();
            LoadMaNhanVien();
            LoadNhomNgDung();

            //XuLyDatagirdview
            XulyDataGirdViewDN();
            XulyDataGirdViewMH();
            XulyDataGirdViewNND();
            XulyDataGirdViewPQ();
            XulyDataGirdViewTK();
        }
        private async void LoadDangNhap()
        {
            List<DangNhapModel> listdn = await xyDangNhapModel.GetALlDangNhap();
            if (listdn == null)
            {
                MessageBox.Show("Không tim thấy thông tin Đăng nhập");
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Tài Khoản", typeof(string));
                dataTable.Columns.Add("Mật Khẩu", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (DangNhapModel dn in listdn)
                {
                    DataRow row = dataTable.NewRow();
                    row["Tài Khoản"] = dn.TAI_KHOAN;
                    row["Mật Khẩu"] = dn.MAT_KHAU;
                    dataTable.Rows.Add(row);
                }
                dataDN.DataSource = dataTable;
            }
        }
        private async void LoadManHinh()
        {
            List<ManHinhModel> listmh = await xyLyManHinhModel.GetALlMH();
            if (listmh == null)
            {
                MessageBox.Show("Không tim thấy thông tin màn hình");
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã Màn Hình", typeof(string));
                dataTable.Columns.Add("Tên Màn Hình", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (ManHinhModel mh in listmh)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã Màn Hình"] = mh.MA_MAN_HINH;
                    row["Tên Màn Hình"] = mh.TEN_MAN_HINH;
                    dataTable.Rows.Add(row);
                }
                dataMH.DataSource = dataTable;
            }
        }
        private async void LoadNhomNguoiDung()
        {
            List<NhomNguoiDungModel> listnnd = await xuLyNhomNguoiDung.GetALlNND();
            if (listnnd == null)
            {
                MessageBox.Show("Không tim thấy thông tin nhóm người dùng");
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã Nhóm", typeof(string));
                dataTable.Columns.Add("Tên Nhóm", typeof(string));
                dataTable.Columns.Add("Ghi Chú", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (NhomNguoiDungModel nd in listnnd)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã Nhóm"] = nd.MA_NHOM;
                    row["Tên Nhóm"] = nd.TEN_NHOM;
                    row["Ghi Chú"] = nd.GHI_CHU;
                    dataTable.Rows.Add(row);
                }
                dataNND.DataSource = dataTable;
            }
        }
        private async void LoadPhanQuyen()
        {
            List<PhanQuyenModel> listpq = await xuLyPhanQuyen.GetALlPQ();
            if (listpq == null)
            {
                MessageBox.Show("Không tim thấy thông tin phân quyền");
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã Nhóm Người Dùng", typeof(string));
                dataTable.Columns.Add("Mã Màn Hình", typeof(string));
                dataTable.Columns.Add("Quyền", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (PhanQuyenModel pq in listpq)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã Nhóm Người Dùng"] = pq.MA_NHOM_NGUOI_DUNG;
                    row["Mã Màn Hình"] = pq.MA_MAN_HINH;
                    row["Quyền"] = pq.COQUYEN;
                    dataTable.Rows.Add(row);
                }
                dataQ.DataSource = dataTable;
            }
        }
        private async void LoadTaiKhoanNV()
        {
            List<TaiKhoanNVModel> listtk = await xuLyTaiKhoanNhanVien.GetALlTK();
            if (listtk == null)
            {
                MessageBox.Show("Không tim thấy thông tin tài khoản nhân viên ");
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Tài Khoản", typeof(string));
                dataTable.Columns.Add("Mã Nhân Viên", typeof(string));
                dataTable.Columns.Add("Mã Nhóm Người Dùng", typeof(string));
                dataTable.Columns.Add("Ghi Chú", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (TaiKhoanNVModel tk in listtk)
                {
                    DataRow row = dataTable.NewRow();
                    row["Tài Khoản"] = tk.TAI_KHOAN;
                    row["Mã Nhân Viên"] = tk.MA_NV;
                    row["Mã Nhóm Người Dùng"] = tk.MA_NHOM_NGUOI_DUNG;
                    row["Ghi Chú"] = tk.GHI_CHU;
                    dataTable.Rows.Add(row);
                }
                dataTK.DataSource = dataTable;
            }
        }
        private bool checkttDN()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtTK);
            listTextBox.Add(txtMk);
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            return true;
        }
        private bool checkttMH()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtMH);
            listTextBox.Add(txtTenMH);
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            return true;
        }
        private bool checkttNND()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtMaNhom);
            listTextBox.Add(txtTenNhom);
            listTextBox.Add(txtGhiChu);
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            return true;
        }
        private bool CheckThongTinPhanQuyen()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            string manhom = "";
            string mamanhinh = "";
            try
            {
                if (comboNhom.SelectedItem != null)
                {
                    manhom = comboNhom.SelectedItem.ToString();
                }
                if (comManHinh.SelectedItem != null)
                {
                    mamanhinh = comManHinh.SelectedItem.ToString();
                }
            }
            catch
            {

            }
            List<CheckBox> listCheckBox = new List<CheckBox>
    {
        checkBox1,
        checkBox2
    };

            // Kiểm tra xem chỉ một CheckBox có được chọn không
            if (listCheckBox.Count(cb => cb.Checked) != 1)
            {
                MessageBox.Show("Chọn chính xác một trong hai CheckBox.");
                return false;
            }
            if (listTextBox.Any(t => String.IsNullOrEmpty(t.Text)) || String.IsNullOrEmpty(manhom) || String.IsNullOrEmpty(mamanhinh))
            {
                MessageBox.Show("Điền đầy đủ thông tin và chọn giá trị cho Nhóm và Màn hình.");
                return false;
            }

            return true;
        }
        private bool checkttTK()
        {
            List<TextBox> listTextBox = new List<TextBox>
    {
        txtGCTTK
    };

            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }

            string taiKhoan = "";
            string maNV = "";
            string maNhom = "";

            try
            {
                taiKhoan = comboTK.SelectedItem?.ToString();
                maNV = combomanv.SelectedItem?.ToString();
                maNhom = combonhomngdung.SelectedItem?.ToString();
            }
            catch { }

            if (String.IsNullOrEmpty(taiKhoan) || String.IsNullOrEmpty(maNV) || String.IsNullOrEmpty(maNhom)) { return false; }

            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }

            return true;
        }

        private DangNhapModel GetValueDN()
        {
            try
            {
                if (checkttDN() == false)
                {
                    MessageBox.Show("Thông tin không được trống"); return null;
                }
                DangNhapModel dn = new DangNhapModel(
             txtTK.Text,
             txtMk.Text)
             ;
                return dn;
            }
            catch { return null; }
        }
        private ManHinhModel GetValueMH()
        {
            try
            {
                if (checkttMH() == false)
                {
                    MessageBox.Show("Thông tin không được trống"); return null;
                }
                ManHinhModel mh = new ManHinhModel(
             txtMH.Text,
             txtTenMH.Text)
             ;
                return mh;
            }
            catch { return null; }
        }
        private NhomNguoiDungModel GetValueNND()
        {
            try
            {
                if (checkttNND() == false)
                {
                    MessageBox.Show("Thông tin không được trống"); return null;
                }
                NhomNguoiDungModel nd = new NhomNguoiDungModel(
             txtMaNhom.Text,
             txtTenMH.Text,
             txtGhiChu.Text)
             ;
                return nd;
            }
            catch { return null; }
        }
        private PhanQuyenModel GetValuePQ()
        {
            try
            {
                if (CheckThongTinPhanQuyen() == false)
                {
                    MessageBox.Show("Thông tin không được trống");
                    return null;
                }

                bool checkValue = checkBox1.Checked;

                PhanQuyenModel pq = new PhanQuyenModel(
                    comboNhom.Text,
                    comManHinh.Text,
                    checkValue
                );

                return pq;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        private TaiKhoanNVModel GetValueTK()
        {
            try
            {
                if (checkttTK() == false)
                {
                    MessageBox.Show("Thông tin không được trống"); return null;
                }
                TaiKhoanNVModel nd = new TaiKhoanNVModel(
             comboTK.Text,
             combomanv.Text,
             combonhomngdung.Text,
             txtGCTTK.Text)
             ;
                return nd;
            }
            catch { return null; }
        }


        private bool KtraTonTaiDN(string taikhoan)
        {
            for (int i = 0; i < dataDN.RowCount - 1; i++)
            {
                string _taikhoan = dataDN.Rows[i].Cells["Tài Khoản"].Value.ToString();
                if (_taikhoan.Equals(taikhoan)) { return true; }
            }
            return false;
        }
        private bool KtraTonTaiMH(string mamnahinh)
        {
            for (int i = 0; i < dataMH.RowCount - 1; i++)
            {
                string _mamnahinh = dataMH.Rows[i].Cells["Mã Màn Hình"].Value.ToString();
                if (_mamnahinh.Equals(mamnahinh)) { return true; }
            }
            return false;
        }
        private bool KtraTonTaiNND(string manhom)
        {
            for (int i = 0; i < dataNND.RowCount - 1; i++)
            {
                string _manhom = dataNND.Rows[i].Cells["Mã Nhóm"].Value.ToString();
                if (_manhom.Equals(manhom)) { return true; }
            }
            return false;
        }
        private bool KtraTonTaiPQ(string manhom)
        {
            for (int i = 0; i < dataQ.RowCount - 1; i++)
            {
                string _manhom = dataQ.Rows[i].Cells["Mã Nhóm Người Dùng"].Value.ToString();
                if (_manhom.Equals(manhom)) { return true; }
            }
            return false;
        }
        private bool KtraTonTaiTK(string taikhoan)
        {
            for (int i = 0; i < dataTK.RowCount - 1; i++)
            {
                string _taikhoan = dataTK.Rows[i].Cells["Tài Khoản"].Value.ToString();
                if (_taikhoan.Equals(taikhoan)) { return true; }
            }
            return false;
        }
        private async void btnThemDN_Click(object sender, EventArgs e)
        {
            if (checkttDN() == false) { MessageBox.Show("Kiểm tra lại thông tin tài khoản"); }
            DangNhapModel dn = GetValueDN();
            if (dn == null) { return; }
            if (KtraTonTaiDN(dn.TAI_KHOAN) == true) { MessageBox.Show("Tài khoản đã tồn tại"); return; }
            else
            {
                if (dn == null) { MessageBox.Show("Thông tin tài khoản trống!"); return; }
                int kq = await xyDangNhapModel.InsertDN(dn);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadDangNhap();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }

        }

        private async void btnXoaDN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string madn = txtTK.Text;
                if (KtraTonTaiDN(madn) == false) { MessageBox.Show("Tài khoản không tồn tại!"); return; }
                if (String.IsNullOrEmpty(madn)) { MessageBox.Show("Bạn chưa chọn tài khoản!"); }
                else
                {
                    int kq = await xyDangNhapModel.DeleteDN(madn);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa tài khoản thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                        LoadDangNhap();
                    }
                }
            }
        }
        private bool KT_ThongTinDN(DangNhapModel dn)
        {
            if (dn == null) { return false; }
            if (dn.TAI_KHOAN.Length > 50 || dn.MAT_KHAU.Length > 50) { return false; }
            if (dn.TAI_KHOAN.Length == null || dn.MAT_KHAU.Length == null) { return false; }
            return true;
        }
        private bool KT_ThongTinMH(ManHinhModel mh)
        {
            if (mh == null) { return false; }
            if (mh.MA_MAN_HINH.Length > 50 || mh.TEN_MAN_HINH.Length > 50) { return false; }
            if (mh.MA_MAN_HINH.Length == null || mh.TEN_MAN_HINH.Length == null) { return false; }
            return true;
        }
        private bool KT_ThongTinNND(NhomNguoiDungModel nnd)
        {
            if (nnd == null) { return false; }
            if (nnd.MA_NHOM.Length > 50 || nnd.TEN_NHOM.Length > 50 || nnd.GHI_CHU.Length > 50) { return false; }
            if (nnd.MA_NHOM.Length == null || nnd.TEN_NHOM.Length == null || nnd.GHI_CHU.Length == null) { return false; }
            return true;
        }
        private bool KT_ThongTinPQ(PhanQuyenModel pq)
        {
            if (pq == null) { return false; }
            if (pq.MA_NHOM_NGUOI_DUNG.Length > 50 || pq.MA_MAN_HINH.Length > 50) { return false; }
                     if (string.IsNullOrEmpty(pq.MA_NHOM_NGUOI_DUNG) || string.IsNullOrEmpty(pq.MA_MAN_HINH)) { return false; }
            return true;
        }
        private bool KT_ThongTinTK(TaiKhoanNVModel tk)
        {
            if (tk == null) { return false; }
            if (tk.TAI_KHOAN.Length > 50 || tk.MA_NV.Length > 50 || tk.MA_NHOM_NGUOI_DUNG.Length > 50 || tk.GHI_CHU.Length > 50) { return false; }
            if (tk.TAI_KHOAN.Length == null || tk.MA_NV.Length == null || tk.MA_NHOM_NGUOI_DUNG.Length == null || tk.GHI_CHU.Length == null) { return false; }
            return true;
        }
        private async void btnSuaDN_Click(object sender, EventArgs e)
        {
            DangNhapModel dn = GetValueDN();
            if (KT_ThongTinDN(dn) == false)
            {
                MessageBox.Show("Thông tin tài khoản bị sai"); return;
            }
            else if (KtraTonTaiDN(dn.TAI_KHOAN) == false)
            {
                MessageBox.Show("Tài khoản không tồn tại"); return;
            }
            else
            {
                DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xyDangNhapModel.RepairDN(dn);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadDangNhap();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }

        private void dataDN_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataDN.SelectedRows[0];
                txtTK.Text = selectedRow.Cells["Tài Khoản"].Value.ToString();
                txtMk.Text = selectedRow.Cells["Mật Khẩu"].Value.ToString();
            }
        }

        private async void btnThemMH_Click(object sender, EventArgs e)
        {
            if (checkttMH() == false) { MessageBox.Show("Kiểm tra lại thông tin màn hình"); }
            ManHinhModel mh = GetValueMH();
            if (mh == null) { return; }
            if (KtraTonTaiMH(mh.MA_MAN_HINH) == true) { MessageBox.Show("Mã màn hình đã tồn tại"); return; }
            else
            {
                if (mh == null) { MessageBox.Show("Thông tin màn hình trống!"); return; }
                int kq = await xyLyManHinhModel.InsertMH(mh);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadManHinh();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }
        }

        private async void btnXoaMH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string mamh = txtMH.Text;
                if (KtraTonTaiMH(mamh) == false) { MessageBox.Show("Màn hình không tồn tại!"); return; }
                if (String.IsNullOrEmpty(mamh)) { MessageBox.Show("Bạn chưa chọn Màn hình!"); }
                else
                {
                    int kq = await xyLyManHinhModel.DeleteMH(mamh);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa Màn hình thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Màn hình thành công");
                        LoadManHinh();
                    }
                }
            }
        }

        private async void btnSuaMH_Click(object sender, EventArgs e)
        {
            ManHinhModel mh = GetValueMH();
            if (KT_ThongTinMH(mh) == false)
            {
                MessageBox.Show("Thông tin màn hình bị sai"); return;
            }
            else if (KtraTonTaiMH(mh.MA_MAN_HINH) == false)
            {
                MessageBox.Show("Màn hình không tồn tại"); return;
            }
            else
            {
                DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xyLyManHinhModel.RepairMH(mh);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadManHinh();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }

        private void dataMH_SelectionChanged(object sender, EventArgs e)
        {
            if (dataMH.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataMH.SelectedRows[0];
                txtMH.Text = selectedRow.Cells["Mã Màn Hình"].Value.ToString();
                txtTenMH.Text = selectedRow.Cells["Tên Màn Hình"].Value.ToString();
            }
        }

        private async void btnThemNND_Click(object sender, EventArgs e)
        {
            if (checkttNND() == false) { MessageBox.Show("Kiểm tra lại thông tin nhóm người dùng"); }
            NhomNguoiDungModel nnd = GetValueNND();
            if (nnd == null) { return; }
            if (KtraTonTaiNND(nnd.MA_NHOM) == true) { MessageBox.Show("Mã nhóm đã tồn tại"); return; }
            else
            {
                if (nnd == null) { MessageBox.Show("Thông tin nhóm người dùng trống!"); return; }
                int kq = await xuLyNhomNguoiDung.InsertNND(nnd);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadNhomNguoiDung();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }
        }

        private void dataNND_SelectionChanged(object sender, EventArgs e)
        {
            if (dataNND.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataNND.SelectedRows[0];
                txtMaNhom.Text = selectedRow.Cells["Mã Nhóm"].Value.ToString();
                txtTenNhom.Text = selectedRow.Cells["Tên Nhóm"].Value.ToString();
                txtGhiChu.Text = selectedRow.Cells["Ghi Chú"].Value.ToString();
            }
        }

        private async void btnXoaNND_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string manhom = txtMaNhom.Text;
                if (KtraTonTaiNND(manhom) == false) { MessageBox.Show("Nhóm người dùng không tồn tại!"); return; }
                if (String.IsNullOrEmpty(manhom)) { MessageBox.Show("Bạn chưa chọn Nhóm người dùng!"); }
                else
                {
                    int kq = await xuLyNhomNguoiDung.DeleteNND(manhom);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa Nhóm người dùng thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Nhóm người dùng thành công");
                        LoadNhomNguoiDung();
                    }
                }
            }
        }

        private async void btnSuaNND_Click(object sender, EventArgs e)
        {
            NhomNguoiDungModel nnd = GetValueNND();
            if (KT_ThongTinNND(nnd) == false)
            {
                MessageBox.Show("Thông tin nhóm người dùng bị sai"); return;
            }
            else if (KtraTonTaiNND(nnd.MA_NHOM) == false)
            {
                MessageBox.Show("Nhóm người dùng không tồn tại"); return;
            }
            else
            {
                DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xuLyNhomNguoiDung.RepairNND(nnd);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadNhomNguoiDung();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }
        ///Phân quyền
        private async void btnThemQ_Click(object sender, EventArgs e)
        {
            if (CheckThongTinPhanQuyen() == false) { MessageBox.Show("Kiểm tra lại thông tin phân quyền"); }
            PhanQuyenModel pq = GetValuePQ();
            if (pq == null) { return; }
            if (KtraTonTaiPQ(pq.MA_NHOM_NGUOI_DUNG) == true) { MessageBox.Show("Mã nhóm người dùng đã tồn tại"); return; }
            else
            {
                if (pq == null) { MessageBox.Show("Thông tin màn hình trống!"); return; }
                int kq = await xuLyPhanQuyen.InsertPQ(pq);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadPhanQuyen();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }
        }
        private async void LoadMaNhom()
        {
            try
            {
                List<string> manhomlist = await xuLyPhanQuyen.GetMaNhom();

                if (manhomlist != null)
                {
                    // Gán danh sách mã sản phẩm cho ComboBox
                    comboNhom.DataSource = manhomlist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private async void LoadMaManHinh()
        {
            try
            {
                List<string> mamanhinhlist = await xuLyPhanQuyen.GetMaManHinh();

                if (mamanhinhlist != null)
                {
                    comManHinh.DataSource = mamanhinhlist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMaManHinh();
            LoadMaNhom();
        }

        private async void btnXoaQ_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string pq = comboNhom.Text;
                if (KtraTonTaiPQ(pq) == false) { MessageBox.Show("Phân quyền không tồn tại!"); return; }
                if (String.IsNullOrEmpty(pq)) { MessageBox.Show("Bạn chưa chọn phân quyền!"); }
                else
                {
                    int kq = await xuLyPhanQuyen.DeletePQ(pq);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa phân quyền thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa phân quyền thành công");
                        LoadPhanQuyen();
                    }
                }
            }
        }

        private void dataQ_SelectionChanged(object sender, EventArgs e)
        {
            if (dataQ.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataQ.SelectedRows[0];
                comboNhom.Text = selectedRow.Cells["Mã Nhóm Người Dùng"].Value.ToString();
                comManHinh.Text = selectedRow.Cells["Mã Màn Hình"].Value.ToString();
                if (bool.TryParse(selectedRow.Cells["Quyền"].Value.ToString(), out bool quyenValue))
                {
                    checkBox1.Checked = quyenValue;
                    checkBox2.Checked = !quyenValue;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ trong cột 'Quyền'.");
                }
            }
        }

        private async void btnSuaQ_Click(object sender, EventArgs e)
        {
            PhanQuyenModel pq = GetValuePQ();
            if (KT_ThongTinPQ(pq) == false)
            {
                MessageBox.Show("Thông tin phân quyền bị sai"); return;
            }
            else if (KtraTonTaiPQ(pq.MA_NHOM_NGUOI_DUNG) == false)
            {
                MessageBox.Show("Phân quyền không tồn tại"); return;
            }
            else
            {
                DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xuLyPhanQuyen.RepairPQ(pq);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadPhanQuyen();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }
        //Taikhoannv
        private async void LoadTaiKhoan()
        {
            try
            {
                List<string> taikhoan = await xuLyTaiKhoanNhanVien.GetTaiKhoan();

                if (taikhoan != null)
                {
                    comboTK.DataSource = taikhoan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private async void LoadMaNhanVien()
        {
            try
            {
                List<string> manv = await xuLyTaiKhoanNhanVien.GetNhanVien();

                if (manv != null)
                {
                    combomanv.DataSource = manv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private async void LoadNhomNgDung()
        {
            try
            {
                List<string> manhom = await xuLyTaiKhoanNhanVien.GetMaNhom();

                if (manhom != null)
                {
                    combonhomngdung.DataSource = manhom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private async void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (checkttTK() == false) { MessageBox.Show("Kiểm tra lại thông tin tài khoản"); }
            TaiKhoanNVModel tk = GetValueTK();
            if (tk == null) { return; }
            if (KtraTonTaiTK(tk.TAI_KHOAN) == true) { MessageBox.Show("Tài khoản đã tồn tại"); return; }
            else
            {
                if (tk == null) { MessageBox.Show("Thông tin tài khoản trống!"); return; }
                int kq = await xuLyTaiKhoanNhanVien.InsertTK(tk);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadTaiKhoanNV();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }
        }

        private void dataTK_SelectionChanged(object sender, EventArgs e)
        {
            if (dataTK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataTK.SelectedRows[0];
                comboTK.Text = selectedRow.Cells["Tài Khoản"].Value.ToString();
                combomanv.Text = selectedRow.Cells["Mã Nhân Viên"].Value.ToString();
                combonhomngdung.Text = selectedRow.Cells["Mã Nhóm Người Dùng"].Value.ToString();
                txtGCTTK.Text = selectedRow.Cells["Ghi Chú"].Value.ToString();
            }
        }

        private async void btnXoaTk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string tk = comboTK.Text;
                if (KtraTonTaiTK(tk) == false) { MessageBox.Show("Tài khoản không tồn tại!"); return; }
                if (String.IsNullOrEmpty(tk)) { MessageBox.Show("Bạn chưa chọn tài khoản!"); }
                else
                {
                    int kq = await xuLyTaiKhoanNhanVien.DeleteTK(tk);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa Tài khoản thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Tài khoản thành công");
                        LoadTaiKhoanNV();
                    }
                }
            }
        }

        private async void btnSuaTk_Click(object sender, EventArgs e)
        {
            TaiKhoanNVModel tk = GetValueTK();
            if (KT_ThongTinTK(tk) == false)
            {
                MessageBox.Show("Thông tin tài khoản bị sai"); return;
            }
            else if (KtraTonTaiTK(tk.TAI_KHOAN) == false)
            {
                MessageBox.Show("Tài khoản không tồn tại"); return;
            }
            else
            {
                DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xuLyTaiKhoanNhanVien.RepairTK(tk);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadTaiKhoanNV();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }

        public void XulyDataGirdViewDN()
        {
            dataDN.ColumnHeadersVisible = true;
            dataDN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDN.BackgroundColor = Color.LightGray;
            dataDN.CellFormatting += (sender, e) =>
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
            dataDN.ColumnHeadersVisible = true;
            dataDN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDN.BackgroundColor = Color.LightGray;
            dataDN.CellFormatting += (sender, e) =>
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
        public void XulyDataGirdViewMH()
        {
            dataMH.ColumnHeadersVisible = true;
            dataMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMH.BackgroundColor = Color.LightGray;
            dataMH.CellFormatting += (sender, e) =>
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
            dataMH.ColumnHeadersVisible = true;
            dataMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMH.BackgroundColor = Color.LightGray;
            dataMH.CellFormatting += (sender, e) =>
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
        public void XulyDataGirdViewNND()
        {
            dataNND.ColumnHeadersVisible = true;
            dataNND.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataNND.BackgroundColor = Color.LightGray;
            dataNND.CellFormatting += (sender, e) =>
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
            dataNND.ColumnHeadersVisible = true;
            dataNND.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataNND.BackgroundColor = Color.LightGray;
            dataNND.CellFormatting += (sender, e) =>
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
        public void XulyDataGirdViewPQ()
        {
            dataQ.ColumnHeadersVisible = true;
            dataQ.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataQ.BackgroundColor = Color.LightGray;
            dataQ.CellFormatting += (sender, e) =>
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
            dataQ.ColumnHeadersVisible = true;
            dataQ.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataQ.BackgroundColor = Color.LightGray;
            dataQ.CellFormatting += (sender, e) =>
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
        public void XulyDataGirdViewTK()
        {
            dataTK.ColumnHeadersVisible = true;
            dataTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTK.BackgroundColor = Color.LightGray;
            dataTK.CellFormatting += (sender, e) =>
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
            dataTK.ColumnHeadersVisible = true;
            dataTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTK.BackgroundColor = Color.LightGray;
            dataTK.CellFormatting += (sender, e) =>
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

        private void button2_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            LoadMaNhanVien();
            LoadNhomNgDung();
        }
    }
}
