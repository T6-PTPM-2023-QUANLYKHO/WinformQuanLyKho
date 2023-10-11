using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmUCLibrary;
using FrmUCLibrary.Model;
using System.Runtime.InteropServices;
using Library;
using Library.Models;

namespace FrmUCLibrary
{
    public partial class UC_KhachHang : UserControl
    {
        DataGridView dataGridViewKhachHang;
        XuLyKhachHangModel _xuLy = new XuLyKhachHangModel();
        public UC_KhachHang()
        {

            InitializeComponent();
            Init();
            VoHieuHoa();
        }
        private void VoHieuHoa()
        {
            txt_maKH.Enabled = false;
        }
        private void Init()
        {
            cbx_gioiTinh.Items.Clear();
            cbx_gioiTinh.Items.Add("Nam");
            cbx_gioiTinh.Items.Add("Nữ");
            txt_maKH.Text = Helper.createMaKH();
            LoadDataGirdView();
        }
        private async void LoadDataGirdView()
        {           
            List<KhachHangModel> lstKhachHang = await _xuLy.getAllKhachHang();
            if(lstKhachHang == null)
            {
                MessageBox.Show("Không tim thấy thông tin khách hàng");
            }
            else
            {
                LoadDataGirdView(lstKhachHang);
            }
        }
        private void LoadDataGirdView(KhachHangModel kh)
        {
            if (kh == null || kh.MAKH.Equals("") || String.IsNullOrEmpty(kh.MAKH))
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                return;
            }
            CreateDataGridView();
            int rowIndex = dataGridViewKhachHang.Rows.Add();
            dataGridViewKhachHang.Rows[rowIndex].Cells["STT"].Value = 1.ToString();
            dataGridViewKhachHang.Rows[rowIndex].Cells["MAKH"].Value = kh.MAKH;
            dataGridViewKhachHang.Rows[rowIndex].Cells["TEN_KH"].Value = kh.TEN_KH;
            dataGridViewKhachHang.Rows[rowIndex].Cells["DIACHI_KH"].Value = kh.DIACHI_KH.ToString();
            dataGridViewKhachHang.Rows[rowIndex].Cells["GIOITINH_KH"].Value = kh.GIOITINH_KH.ToString();
            dataGridViewKhachHang.Rows[rowIndex].Cells["SDT_KH"].Value = kh.SDT_KH.ToString();
            dataGridViewKhachHang.Rows[rowIndex].Cells["EMAIL_KH"].Value = kh.EMAIL_KH.ToString();
            dataGridViewKhachHang.Rows[rowIndex].Cells["FAX"].Value = kh.FAX.ToString();
        }
        private void LoadDataGirdView(List<KhachHangModel> listKH)
        {
            if (listKH == null) { MessageBox.Show("Không tìm thấy thông tin khách hàng"); }
            else
            {
                CreateDataGridView();
                int stt = 1;
                foreach (var item in listKH)
                {
                    int rowIndex = dataGridViewKhachHang.Rows.Add();
                    dataGridViewKhachHang.Rows[rowIndex].Cells["STT"].Value = stt.ToString();
                    dataGridViewKhachHang.Rows[rowIndex].Cells["MAKH"].Value = item.MAKH;
                    dataGridViewKhachHang.Rows[rowIndex].Cells["TEN_KH"].Value = item.TEN_KH;
                    dataGridViewKhachHang.Rows[rowIndex].Cells["DIACHI_KH"].Value = item.DIACHI_KH.ToString();
                    dataGridViewKhachHang.Rows[rowIndex].Cells["GIOITINH_KH"].Value = item.GIOITINH_KH.ToString();
                    dataGridViewKhachHang.Rows[rowIndex].Cells["SDT_KH"].Value = item.SDT_KH.ToString();
                    dataGridViewKhachHang.Rows[rowIndex].Cells["FAX"].Value = item.FAX.ToString();
                    dataGridViewKhachHang.Rows[rowIndex].Cells["EMAIL_KH"].Value = item.EMAIL_KH.ToString();
                    stt++;
                }
            }           
        }
        private void CreateDataGridView()
        {
            //tạo datagidview 
            dataGridViewKhachHang = new DataGridView();
            dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            dataGridViewKhachHang.Width = 1030;
            dataGridViewKhachHang.Height = 282;
            //tạo các cột 
            DataGridViewTextBoxColumn STTColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn MAKHColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TEN_KHColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DIACHI_KHColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn GIOITINH_KHColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SDT_KHColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn EMAIL_KHColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn FAXColumn = new DataGridViewTextBoxColumn();

            //đặt tiêu đề cho cột
            STTColumn.HeaderText = "STT";
            STTColumn.Name = "STT";
            STTColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            MAKHColumn.HeaderText = "Mã Số";
            MAKHColumn.Name = "MAKH";
            MAKHColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            TEN_KHColumn.HeaderText = "Họ Tên";
            TEN_KHColumn.Name = "TEN_KH";
            TEN_KHColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DIACHI_KHColumn.HeaderText = "Địa chỉ";
            DIACHI_KHColumn.Name = "DIACHI_KH";
            DIACHI_KHColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GIOITINH_KHColumn.HeaderText = "Giới Tính";
            GIOITINH_KHColumn.Name = "GIOITINH_KH";
            GIOITINH_KHColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            SDT_KHColumn.HeaderText = "Số điện thoại";
            SDT_KHColumn.Name = "SDT_KH";
            SDT_KHColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            FAXColumn.HeaderText = "FAX";
            FAXColumn.Name = "FAX";
            FAXColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            EMAIL_KHColumn.HeaderText = "Email";
            EMAIL_KHColumn.Name = "EMAIL_KH";
            EMAIL_KHColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //thêm cột vào datagirdview
            dataGridViewKhachHang.Columns.Add(STTColumn);
            dataGridViewKhachHang.Columns.Add(MAKHColumn);
            dataGridViewKhachHang.Columns.Add(TEN_KHColumn);
            dataGridViewKhachHang.Columns.Add(DIACHI_KHColumn);
            dataGridViewKhachHang.Columns.Add(GIOITINH_KHColumn);
            dataGridViewKhachHang.Columns.Add(SDT_KHColumn);
            dataGridViewKhachHang.Columns.Add(FAXColumn);
            dataGridViewKhachHang.Columns.Add(EMAIL_KHColumn);
            dataGridViewKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKhachHang.CellClick += DataGridViewKhachHang_CellClick; ;
            //add vào panel
            panel_DataGridView.Controls.Clear();
            panel_DataGridView.Controls.Add(dataGridViewKhachHang);
        }

        private void DataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex >= 0)
                {
                    KhachHangModel kh = new KhachHangModel();
                    if (dataGridViewKhachHang.Rows[rowindex].Cells["MAKH"].Value != null)
                    {
                        kh.MAKH = dataGridViewKhachHang.Rows[rowindex].Cells["MAKH"].Value.ToString();
                        kh.TEN_KH = dataGridViewKhachHang.Rows[rowindex].Cells["TEN_KH"].Value.ToString();
                        kh.DIACHI_KH = dataGridViewKhachHang.Rows[rowindex].Cells["DIACHI_KH"].Value.ToString();
                        kh.SDT_KH = dataGridViewKhachHang.Rows[rowindex].Cells["SDT_KH"].Value.ToString();
                        kh.GIOITINH_KH = dataGridViewKhachHang.Rows[rowindex].Cells["GIOITINH_KH"].Value.ToString();
                        kh.FAX = dataGridViewKhachHang.Rows[rowindex].Cells["FAX"].Value.ToString();
                        kh.EMAIL_KH = dataGridViewKhachHang.Rows[rowindex].Cells["EMAIL_KH"].Value.ToString();
                        LoadThongTinKH(kh);
                    }                  
                }
            }catch{
                Console.WriteLine("Lỗi DataGridViewKhachHang_CellClick") ;
            }
        }
        private void LoadThongTinKH(KhachHangModel kh)
        {
            txt_maKH.Text = kh.MAKH;
            txt_tenKH.Text = kh.TEN_KH;
            txt_diaChi.Text = kh.DIACHI_KH.ToString();
            txt_SoDienThoai.Text = kh.SDT_KH;
            txt_fax.Text = kh.FAX;
            txt_Email.Text = kh.EMAIL_KH;
            if (kh.GIOITINH_KH.Equals("nam") || kh.GIOITINH_KH.Equals("Nam") || kh.GIOITINH_KH.Equals("NAM"))
            {
                cbx_gioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbx_gioiTinh.SelectedIndex = 1;
            }
        }
        private void clearControl()
        {
            foreach (var item in panel_ThongTinKH.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cbx = (ComboBox)item;
                    cbx.Text = "";
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            clearControl();
            txt_maKH.Text = Helper.createMaKH();
        }
        private void clearDataGridView()
        {
            //dataGridViewKhachHang.DataSource = null;
            //dataGridViewKhachHang.Rows.Clear();
        }
        private async void btn_search_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_SoDienThoai.Text;
            if (String.IsNullOrEmpty(phoneNumber)) { MessageBox.Show("Bạn quên nhập vào số điện thoại"); }
            else
            {
                KhachHangModel khachHangs = await _xuLy.getKhachHangBySDT(phoneNumber.Trim());
                if (khachHangs == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                }
                else
                {
                    LoadDataGirdView(khachHangs);
                }
            }
        }

        private async void btn_ShowAll_Click(object sender, EventArgs e)
        {
            List<KhachHangModel> listKhachHang = await _xuLy.getAllKhachHang();
            LoadDataGirdView(listKhachHang);
            clearDataGridView();
        }

        private async void btn_Xoa_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã xác nhận xóa hay không
            if (result == DialogResult.Yes)
            {
                string maKH = txt_maKH.Text;
                if (KT_TonTaiMaKH(maKH) == false) { ThongBao("Khách hàng không tồn tại!"); return; }
                if (String.IsNullOrEmpty(maKH)) { MessageBox.Show("Bạn chưa chọn khách hàng!"); }
                else
                {
                    int kq = await _xuLy.deleteKhachHang(maKH);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa khách hàng thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        LoadDataGirdView();
                    }
                }
            }           
           
        }
        private bool KT_TonTaiMaKH(string maKH)
        {
            for(int i =0; i< dataGridViewKhachHang.RowCount-1; i++)
            {
                string _maKH = dataGridViewKhachHang.Rows[i].Cells["MAKH"].Value.ToString();
                if (_maKH.Equals(maKH)) { return true; }
            }
            return false;
        }
        private async void btn__Them_Click(object sender, EventArgs e)
        {
            if (checkTTKhachHang() == false) { MessageBox.Show("Kiểm tra lại thông tin khách hàng"); }
            KhachHangModel kh = getValueThongTinKhachHang();
            if(kh == null) { return; }
            if (KT_TonTaiMaKH(kh.MAKH) == true) {ThongBao("Khách hàng đã tồn tại"); return; }
            else
            {
                if (kh == null) { ThongBao("Thông tin khách hàng trống!");return; }
                int kq = await _xuLy.InsertKhachHang(kh);
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
          
        }
        private bool checkTTKhachHang()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txt_maKH);
            listTextBox.Add(txt_tenKH);
            listTextBox.Add(txt_SoDienThoai);
            listTextBox.Add(txt_diaChi);
            listTextBox.Add(txt_Email);
            listTextBox.Add(txt_fax);
            foreach (TextBox t in listTextBox)
            {
                if (String.IsNullOrEmpty(t.Text)) { return false; }
            }
            string gioitinh = "";
            try
            {
                if (cbx_gioiTinh.SelectedItem != null)
                {
                    gioitinh = cbx_gioiTinh.SelectedItem.ToString();
                }
            }
            catch
            {

            }
            if (String.IsNullOrEmpty(gioitinh)) { return false; }
            return true;
        }

        private async void btn_Sua_Click(object sender, EventArgs e)
        {
          
            KhachHangModel kh = getValueThongTinKhachHang();
            if (KT_ThongTinKH(kh) == false)
            {
                ThongBao("Thông tin khách hàng bị sai");return;
            }
            else if (KT_TonTaiMaKH(kh.MAKH) == false)
            {
                ThongBao("Khách hàng không tồn tại"); return;
            }
           else 
            {
                DialogResult _DialogResult = ThongBaoYesNo("Xác nhận thay đổi", "Thông báo");

                if (_DialogResult == DialogResult.Yes)
                {
                    int kq = await _xuLy.capNhatKH(kh);
                    if (kq == 1)
                    {
                        ThongBao("Thành Công.");
                        LoadDataGirdView();
                    }
                    else { ThongBao("Thất Bại!"); }
                }
            }           
        }
        private KhachHangModel getValueThongTinKhachHang()
        {

            try
            {
                if (checkTTKhachHang() == false) { ThongBao("Thông tin không được trống"); return null; }
                KhachHangModel kh = new KhachHangModel(
             txt_maKH.Text,
             txt_tenKH.Text,
             txt_diaChi.Text,
             cbx_gioiTinh.SelectedItem.ToString(),
             txt_SoDienThoai.Text,
             txt_Email.Text,
             txt_fax.Text)
             ;
                return kh;
            }
            catch { return null; }
        }
        private bool KT_ThongTinKH(KhachHangModel kh)
        {
            if(kh == null) { return false; }
            //kiểm tra tên khách hàng 
            if (kh.TEN_KH.Length > 50 || kh.DIACHI_KH.Length > 50 || kh.GIOITINH_KH.Length > 5 || kh.SDT_KH.Length
                !=10 || kh.EMAIL_KH.Length > 50 || kh.FAX.Length > 12) { return false; }
            if (kh.TEN_KH.Length ==null || kh.DIACHI_KH.Length == null || kh.GIOITINH_KH.Length == null || kh.SDT_KH.Length
                == null || kh.EMAIL_KH.Length == null || kh.FAX.Length == null) { return false; }
            return true;
        }
        private DialogResult ThongBaoYesNo(string text, string title)
        {
            DialogResult _DialogResult = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return _DialogResult;
        }
        private void ThongBao (string text) 
        {
            MessageBox.Show(text,"Thông báo");
        }
    }
}
