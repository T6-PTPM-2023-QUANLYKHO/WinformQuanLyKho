using _BLL;
using _DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUCLibrary
{
    public partial class UC_KE_KHU : UserControl
    {
        private XyLyKeKhuModel xyLyKeKhuModel;
        public UC_KE_KHU()
        {
            InitializeComponent();
            xyLyKeKhuModel = new XyLyKeKhuModel();
            LoadDataGirdView();
            datake.ColumnHeadersVisible = true;
            datake.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datake.BackgroundColor = Color.LightGray;
            datake.CellFormatting += (sender, e) =>
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
            dataKhu.ColumnHeadersVisible = true;
            dataKhu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataKhu.BackgroundColor = Color.LightGray;
            dataKhu.CellFormatting += (sender, e) =>
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
            LoadMaSP();
            LoadMaKhu();
        }
        private async void LoadDataGirdView()
        {
            List<KhuModel> listkhu = await xyLyKeKhuModel.getAllKhu();
            if (listkhu == null)
            {
                MessageBox.Show("Không tim thấy thông tin khu");
            }
            else
            {
                // Tạo một DataTable mới để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                // Thêm cột vào DataTable
                dataTable.Columns.Add("Mã Khu", typeof(string));
                dataTable.Columns.Add("Tên Khu", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (KhuModel khu in listkhu)
                {
                    DataRow row = dataTable.NewRow();

                    row["Mã Khu"] = khu.MA_KHU;
                    row["Tên Khu"] = khu.TEN_KHU;
                    
             
                    dataTable.Rows.Add(row);
                }

                dataKhu.DataSource = dataTable;
            }
        }
        private async void LoadDataGirdViewKe()
        {
            List<KeSPModel> listke = await xyLyKeKhuModel.getAllKE();
            if (listke == null)
            {
                MessageBox.Show("Không tim thấy thông tin kệ");
            }
            else
            {
                // Tạo một DataTable mới để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();
                // Thêm cột vào DataTable
                dataTable.Columns.Add("Mã Kệ", typeof(string));
                dataTable.Columns.Add("Tên Kệ", typeof(string));
                dataTable.Columns.Add("Số Lượng", typeof(string));
                dataTable.Columns.Add("Mã Khu", typeof(string));
                dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));
                // Thêm dòng dữ liệu vào DataTable
                foreach (KeSPModel ke in listke)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã Kệ"] = ke.MA_KE;
                    row["Tên Kệ"] = ke.TEN_KE;
                    row["Số Lượng"] = ke.SOLUONGSP;
                    row["Mã Khu"] = ke.MAKHU;
                    row["Mã Sản Phẩm"] = ke.MASP;
                    dataTable.Rows.Add(row);
                }

                dataKhu.DataSource = dataTable;
            }
        }

        private void dataKhu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataKhu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataKhu.SelectedRows[0];
                string maKhu = selectedRow.Cells["Mã Khu"].Value.ToString();
                string tenKhu = selectedRow.Cells["Tên Khu"].Value.ToString();
                txtMakhu.Text = maKhu;
                txtTenKhu.Text = tenKhu;
                LoadDataGirdViewKeTheoKhu(maKhu);
            }
        }
        private async void LoadDataGirdViewKeTheoKhu(string maKhu)
        {
            List<KeSPModel> listKe = await xyLyKeKhuModel.getAllKe(maKhu);
            if (listKe == null)
            {
                MessageBox.Show("Không tìm thấy thông tin kệ cho mã khu " + maKhu);
            }
            else
            {
                // Tạo một DataTable mới để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                // Thêm cột vào DataTable
                dataTable.Columns.Add("Mã Kệ", typeof(string));
                dataTable.Columns.Add("Tên Kệ", typeof(string));
                dataTable.Columns.Add("Số Lượng", typeof(string));
                dataTable.Columns.Add("Mã Khu", typeof(string));
                dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));

                if (listKe.Count > 0)
                {
                    // Thêm dòng dữ liệu vào DataTable
                    foreach (KeSPModel ke in listKe)
                    {
                        DataRow row = dataTable.NewRow();

                        row["Mã Kệ"] = ke.MA_KE;
                        row["Tên Kệ"] = ke.TEN_KE;
                        row["Số Lượng"] = ke.SOLUONGSP;
                        row["Mã Khu"] = ke.MAKHU;
                        row["Mã Sản Phẩm"] = ke.MASP;
                        dataTable.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin kệ cho mã khu " + maKhu);
                }

                datake.DataSource = dataTable;
            }
        }

        private void datake_SelectionChanged(object sender, EventArgs e)
        {
            if (datake.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datake.SelectedRows[0];
                txtMake.Text = selectedRow.Cells["Mã Kệ"].Value.ToString();
                txtTenKe.Text = selectedRow.Cells["Tên Kệ"].Value.ToString();
                txtsl.Text = selectedRow.Cells["Số Lượng"].Value.ToString();
                comboKhu.Text = selectedRow.Cells["Mã Khu"].Value.ToString();
                comboMaSp.Text = selectedRow.Cells["Mã Sản Phẩm"].Value.ToString();
            }
        }

        private async void btnTk_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            if (String.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã khu");
            }
            else
            {
                KhuModel khu = await xyLyKeKhuModel.GetIDKhu(tk);

                if (khu == null)
                {
                    MessageBox.Show("Không tìm thấy khu vực với mã khu đã nhập");
                }
                else
                {
                    DataTable dataTable = new DataTable();

                    // Thêm cột vào DataTable
                    dataTable.Columns.Add("Mã Khu", typeof(string));
                    dataTable.Columns.Add("Tên Khu", typeof(string));
                    // Thêm dòng dữ liệu vào DataTable
                    DataRow row = dataTable.NewRow();
                    row["Mã Khu"] = khu.MA_KHU;
                    row["Tên Khu"] = khu.TEN_KHU;
                    dataTable.Rows.Add(row);

                    dataKhu.DataSource = dataTable;
                }
            }
        }
        private bool KtraTonTaiKHU(string makhu)
        {
            for (int i = 0; i < dataKhu.RowCount - 1; i++)
            {
                string _maKhu = dataKhu.Rows[i].Cells["Mã Khu"].Value.ToString();
                if (_maKhu.Equals(makhu)) { return true; }
            }
            return false;
        }
        private bool KtraTonTaiKe(string make)
        {
            for (int i = 0; i < datake.RowCount - 1; i++)
            {
                string _make = datake.Rows[i].Cells["Mã Kệ"].Value.ToString();
                if (_make.Equals(make)) { return true; }
            }
            return false;
        }
        private async void LoadMaSP()
        {
            try
            {
                List<string> maSPList = await xyLyKeKhuModel.GetMaSP();

                if (maSPList != null)
                {
                    // Gán danh sách mã sản phẩm cho ComboBox
                    comboMaSp.DataSource = maSPList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private async void LoadMaKhu()
        {
            try
            {
                List<string> makhulist = await xyLyKeKhuModel.GetMaKhu();

                if (makhulist != null)
                {
                    comboKhu.DataSource = makhulist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private bool CheckThongTinKe()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtMake);
            listTextBox.Add(txtTenKe);
            listTextBox.Add(txtsl);
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            string makhu = "";
            string masp = "";
            try
            {
                if (comboKhu.SelectedItem != null)
                {
                    makhu = comboKhu.SelectedItem.ToString();
                }
                if (comboMaSp.SelectedItem != null)
                {
                    masp = comboMaSp.SelectedItem.ToString();
                }
            }
            catch
            {

            }
            if (String.IsNullOrEmpty(makhu) || String.IsNullOrEmpty(masp)) { return false; }
            return true;
        }

        private bool checkttKHu()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtMakhu);
            listTextBox.Add(txtTenKhu);
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            return true;
        }
        private KhuModel GetValueKHu()
        {
            try
            {
                if (checkttKHu() == false) 
                { MessageBox.Show("Thông tin không được trống"); return null; 
                }
                KhuModel kh = new KhuModel(
             txtMakhu.Text,
             txtTenKhu.Text)
             ;
                return kh;
            }
            catch { return null; }
        }
        private KeSPModel GetValueKe()
        {
            try
            {
                if (CheckThongTinKe() == false)
                {
                    MessageBox.Show("Thông tin không được trống"); return null;
                }
                KeSPModel kh = new KeSPModel(
             txtMake.Text,
             txtTenKe.Text,
             txtsl.Text,
             comboKhu.Text,
             comboMaSp.Text)
             ;
                return kh;
            }
            catch { return null; }
        }
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (checkttKHu() == false) { MessageBox.Show("Kiểm tra lại thông tin Khu"); }
            KhuModel khu = GetValueKHu();
            if (khu == null) { return; }
            if (KtraTonTaiKHU(khu.MA_KHU) == true) { MessageBox.Show("Khu đã tồn tại"); return; }
            else
            {
                if (khu == null) { MessageBox.Show("Thông tin Khu trống!"); return; }
                int kq = await  xyLyKeKhuModel.InsertKhu(khu);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadDataGirdView();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }
            LoadMaKhu();


        }

        private async void btnTKke_Click(object sender, EventArgs e)
        {
            string tk = txtTKKe.Text;
            if (String.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã kệ");
            }
            else
            {
                KeSPModel ke = await xyLyKeKhuModel.GetIDMaKe(tk);

                if (ke == null)
                {
                    MessageBox.Show("Không tìm thấy kệ với mã kệ đã nhập");
                }
                else
                {
                    DataTable dataTable = new DataTable();
                    // Thêm cột vào DataTable
                    dataTable.Columns.Add("Mã Kệ", typeof(string));
                    dataTable.Columns.Add("Tên Kệ", typeof(string));
                    dataTable.Columns.Add("Số Lượng", typeof(string));
                    dataTable.Columns.Add("Mã Khu", typeof(string));
                    dataTable.Columns.Add("Mã Sản Phẩm", typeof(string));
                    // Thêm dòng dữ liệu vào DataTable
                    DataRow row = dataTable.NewRow();
                    row["Mã Kệ"] = ke.MA_KE;
                    row["Tên Kệ"] = ke.TEN_KE;
                    row["Số Lượng"] = ke.SOLUONGSP;
                    row["Mã Khu"] = ke.MAKHU;
                    row["Mã Sản Phẩm"] = ke.MASP;
                    dataTable.Rows.Add(row);

                    datake.DataSource = dataTable;
                }
            }
        }
       
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string makhu = txtMakhu.Text;
                if (KtraTonTaiKHU(makhu) == false) { MessageBox.Show("Mã Khu không tồn tại!"); return; }
                if (String.IsNullOrEmpty(makhu)) { MessageBox.Show("Bạn chưa chọn Khu!"); }
                else
                {
                    int kq = await xyLyKeKhuModel.DeleteKhu(makhu);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa Khu thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Khu thành công");
                        LoadDataGirdView();
                    }
                }
            }
        }
        private bool KT_ThongTinKHu(KhuModel khu)
        {
            if (khu == null) { return false; }
            //kiểm tra tên khách hàng 
            if (khu.MA_KHU.Length > 50 || khu.TEN_KHU.Length > 50 ) { return false; }
            if (khu.MA_KHU.Length == null || khu.TEN_KHU.Length == null) { return false; }
            return true;
        }
        private bool KT_ThongTinKe(KeSPModel ke)
        {
            if (ke == null) { return false; }
            //kiểm tra tên khách hàng 
            if (ke.MA_KE.Length > 50 || ke.TEN_KE.Length > 50 || ke.SOLUONGSP.Length > 50 || ke.MAKHU.Length > 50 || ke.MASP.Length > 50) { return false; }
            if (ke.MA_KE.Length == null || ke.TEN_KE.Length == null || ke.SOLUONGSP.Length == null || ke.MAKHU.Length == null || ke.MASP.Length == null) { return false; }
            return true;
        }
        private async void btnSua_Click(object sender, EventArgs e)
        {
            KhuModel khu = GetValueKHu();
            if (KT_ThongTinKHu(khu) == false)
            {
                MessageBox.Show("Thông tin khu bị sai"); return;
            }
            else if (KtraTonTaiKHU(khu.MA_KHU) == false)
            {
                MessageBox.Show("Khu không tồn tại"); return;
            }
            else
            {
                    DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xyLyKeKhuModel.RepairKhu(khu);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadDataGirdView();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }

        private async void btnThemKe_Click(object sender, EventArgs e)
        {
            if (CheckThongTinKe() == false) { MessageBox.Show("Kiểm tra lại thông tin kệ"); }
            KeSPModel ke = GetValueKe();
            if (ke == null) { return; }
            if (KtraTonTaiKe(ke.MA_KE) == true) { MessageBox.Show("Kệ đã tồn tại"); return; }
            else
            {
                if (ke == null) { MessageBox.Show("Thông tin kệ trống!"); return; }
                int kq = await xyLyKeKhuModel.InsertKe(ke);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công");
                    LoadDataGirdViewKe();
                }
                else
                {
                    MessageBox.Show("Thất Bại!");
                }
            }
        }

        private async void btnXoaKe_Click(object sender, EventArgs e)
       {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string make = txtMake.Text;
                if (KtraTonTaiKe(make) == false) { MessageBox.Show("Mã Kệ không tồn tại!"); return; }
                if (String.IsNullOrEmpty(make)) { MessageBox.Show("Bạn chưa chọn kệ!"); }
                else
                {
                    int kq = await xyLyKeKhuModel.DeleteKe(make);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa kệ thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa kệ thành công");
                        LoadDataGirdView();
                    }
                }
            }
        }

        private async void btnSuaKe_Click(object sender, EventArgs e)
        {
            KeSPModel ke = GetValueKe();
            if (KT_ThongTinKe(ke) == false)
            {
                MessageBox.Show("Thông tin khu bị sai"); return;
            }
            else if (KtraTonTaiKe(ke.MA_KE) == false)
            {
                MessageBox.Show("Kệ không tồn tại"); return;
            }
            else
            {
                DialogResult _DialogResult = MessageBox.Show("Xác nhận thay đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await xyLyKeKhuModel.RepairKe(ke);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thành Công.");
                        LoadDataGirdViewKe();
                    }
                    else { MessageBox.Show("Thất Bại!"); }
                }
            }
        }
    }
}
