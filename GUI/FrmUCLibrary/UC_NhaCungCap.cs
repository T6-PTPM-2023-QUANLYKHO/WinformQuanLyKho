using _BLL;
using _DTO;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUCLibrary
{
    public partial class UC_NhaCungCap : UserControl
    {
        DataGridView dataGridViewNCC;
        NhaCungCapModel model = new NhaCungCapModel();
        XuLyNhaCungCapModel _xuLyNCC = new XuLyNhaCungCapModel();
        public UC_NhaCungCap()
        {
            InitializeComponent();
            init();
        }
        public async void init()
        {
            txt_Ma.ReadOnly = true;
            taoDataGridView();
            List<NhaCungCapModel> listNhaCungCap =await _xuLyNCC.getAllDanhSach();
            themDuLieuDataGridView(listNhaCungCap);         
        }
        private async Task LoadDataGridViewAsync()
        {
            List<NhaCungCapModel> _list = await _xuLyNCC.getAllDanhSach();
            taoDataGridView();
            themDuLieuDataGridView(_list);
        }
        private void LoadDataTextBox(NhaCungCapModel ncc)
        {
            if(ncc != null)
            {
                txt_Ma.Text = ncc.ma_NCC;
                txt_Ten.Text = ncc.ten_NCC;
                txt_DiaChi.Text= ncc.diaChi_NCC;
                txt_SDT.Text = ncc.sdt;
            }
        }
        private NhaCungCapModel getDataTextBox()
        {
            try
            {
                if (txt_Ma.Text == "" || txt_DiaChi.Text == "" || txt_Ten.Text == "") { return null; }
                else if (String.IsNullOrEmpty(txt_Ma.Text) || String.IsNullOrEmpty(txt_DiaChi.Text) || String.IsNullOrEmpty(txt_Ten.Text)) { return null; }
                NhaCungCapModel ncc = new NhaCungCapModel(txt_Ma.Text, txt_Ten.Text, txt_DiaChi.Text,txt_SDT.Text);
                return ncc;
            }
            catch { return null; }
        }
        private NhaCungCapModel getValueRowDataGridView(int rowIndex) {
            try
            {
                int endRout = dataGridViewNCC.Rows.Count;
                if(rowIndex != endRout - 1)
                {
                    string mancc = dataGridViewNCC.Rows[rowIndex].Cells["MA_NCC"].Value.ToString();
                    string tenncc = dataGridViewNCC.Rows[rowIndex].Cells["TEN_NCC"].Value.ToString();
                    string diachi = dataGridViewNCC.Rows[rowIndex].Cells["DIACHI_NCC"].Value.ToString();
                    string sdt = dataGridViewNCC.Rows[rowIndex].Cells["SDT_NCC"].Value.ToString();
                    NhaCungCapModel ncc = new NhaCungCapModel(mancc, tenncc, diachi, sdt);
                    return ncc;
                }
                return null;
            }
            catch { return null; }
        }
        private void DataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if(rowindex >= 0)
            {
                NhaCungCapModel ncc = getValueRowDataGridView(rowindex);
                LoadDataTextBox(ncc);
            }
        }

        private DialogResult ThongBaoYesNo(string text, string title)
        {
            DialogResult result = MessageBox.Show(text,title,MessageBoxButtons
                .YesNo,MessageBoxIcon.Question);
            return result;
        }
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
        private void themDuLieuDataGridView(List<NhaCungCapModel> listNCC)
        {
            if(listNCC != null)
            {
                int stt = 1;

                foreach (NhaCungCapModel ncc in listNCC)
                {
                    int rowIndex = dataGridViewNCC.Rows.Add();
                    dataGridViewNCC.Rows[rowIndex].Cells["STT"].Value = stt.ToString();
                    dataGridViewNCC.Rows[rowIndex].Cells["MA_NCC"].Value = ncc.ma_NCC;
                    dataGridViewNCC.Rows[rowIndex].Cells["TEN_NCC"].Value = ncc.ten_NCC;
                    dataGridViewNCC.Rows[rowIndex].Cells["DIACHI_NCC"].Value = ncc.diaChi_NCC;
                    dataGridViewNCC.Rows[rowIndex].Cells["SDT_NCC"].Value = ncc.sdt;
                    stt++;
                }
            }
            else { Console.Write("Lõi Thêm dữ liệu vào form function themDuLieuDataGridView"); }
            
        }
        private void themDuLieuDataGridView(NhaCungCapModel ncc)
        {
            int stt = 1;            
            int rowIndex = dataGridViewNCC.Rows.Add();
            dataGridViewNCC.Rows[rowIndex].Cells["STT"].Value = stt.ToString();
            dataGridViewNCC.Rows[rowIndex].Cells["MA_NCC"].Value = ncc.ma_NCC;
            dataGridViewNCC.Rows[rowIndex].Cells["TEN_NCC"].Value = ncc.ten_NCC;
            dataGridViewNCC.Rows[rowIndex].Cells["DIACHI_NCC"].Value = ncc.diaChi_NCC;
            dataGridViewNCC.Rows[rowIndex].Cells["SDT_NCC"].Value = ncc.sdt;
        }
        public void taoDataGridView()
        {
            panel_DataGridViewNCC.Controls.Clear();            
            int width = panel_DataGridViewNCC.Width-200;
            int height = panel_DataGridViewNCC.Height;
            dataGridViewNCC = new DataGridView();
            dataGridViewNCC.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridViewNCC.Width = width;
            dataGridViewNCC.Height = height;
            DataGridViewTextBoxColumn Sttcolumn =new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn MaNCCColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TenNCCColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DiaChiColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SDTColumn = new DataGridViewTextBoxColumn();
            Sttcolumn.HeaderText = "STT";
            Sttcolumn.Name = "STT";
            //MaNCCColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Sttcolumn.Width = 5 * width / 100;

            MaNCCColumn.HeaderText = "Mã Số";
            MaNCCColumn.Name = "MA_NCC";
            //MaNCCColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNCCColumn.Width = 10 * width / 100;

            TenNCCColumn.HeaderText = "Tên";
            //TenNCCColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenNCCColumn.Name = "TEN_NCC";
            TenNCCColumn.Width = 20 * width / 100;

            DiaChiColumn.HeaderText = "Địa chỉ";
            //DiaChiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiaChiColumn.Name = "DIACHI_NCC";
            DiaChiColumn.Width = 40 * width / 100;

            SDTColumn.Name = "SDT_NCC";
            SDTColumn.Width = 15 * width / 100;
            //
            dataGridViewNCC.Columns.Add(Sttcolumn);
            dataGridViewNCC.Columns.Add(MaNCCColumn);
            dataGridViewNCC.Columns.Add(TenNCCColumn);         
            dataGridViewNCC.Columns.Add(DiaChiColumn);
            dataGridViewNCC.Columns.Add(SDTColumn);
            dataGridViewNCC.CellClick += DataGridViewNCC_CellClick;
            panel_DataGridViewNCC.Controls.Add(dataGridViewNCC);
        }

        private async void btn_Them_Click(object sender, EventArgs e)
        {
            NhaCungCapModel ncc = getDataTextBox();
            if(ncc == null || KT_TonTaiMaNCC(ncc.ma_NCC)==true) { ThongBao("Kiểm tra lại thông tin nhà cung cấp");return; }
            DialogResult r = ThongBaoYesNo("Thêm nhà cung cấp","Thông báo");
            if (r == DialogResult.Yes)
            {
                int kq =await _xuLyNCC.ThemNCC(ncc);
                if(kq == 1) { ThongBao("Thêm thành công."); LoadDataGridViewAsync(); }
                else { ThongBao("Thêm thất bại"); }
            }
        }
        private bool KT_TonTaiMaNCC(string maNCC)
        {
            for (int i = 0; i < dataGridViewNCC.Rows.Count - 1; i++) {
                string ma = dataGridViewNCC.Rows[i].Cells["MA_NCC"].Value.ToString();
                if (maNCC.Equals(ma)) { return true; }
            }
            return false;

        }
        private async void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNCC = txt_Ma.Text;
            if (maNCC == "" || String.IsNullOrEmpty(maNCC)) { ThongBao("Mã nhà cung cấp bị sai"); return; }
            if (KT_TonTaiMaNCC(maNCC) == false) { ThongBao("Mã nhà cung cấp không tồn tại"); return; }
            if (await _xuLyNCC.KT_MaNCCTonTaiSanPham(maNCC) == true) { ThongBao("Không thể xóa nhà cung"); return; }
            DialogResult r = ThongBaoYesNo("Xác nhận xóa nhà cung cấp","Thông báo");
            if (r == DialogResult.Yes)
            {
                int kq =await _xuLyNCC.xoaNhaCungCap(maNCC);
                if(kq == 1) { ThongBao("Xóa thành công"); LoadDataGridViewAsync(); }
                else { ThongBao("Xoá thất bại"); }
            }
        }

        private async void btn_Sua_Click(object sender, EventArgs e)
        {
            NhaCungCapModel ncc = getDataTextBox();
            if (KT_TonTaiMaNCC(ncc.ma_NCC) == false)
            {
                ThongBao("Nhà cung cấp không tồn tại");
                return;
            }
            DialogResult r = ThongBaoYesNo("Xác nhận cập nhật","Thông báo");
            if (r == DialogResult.Yes)
            {
                int kq = await _xuLyNCC.CapNhatNCC(ncc);
                if (kq == 1)
                {
                    ThongBao("Thành Công"); LoadDataGridViewAsync();
                }
                else { ThongBao("Cập nhật nhà cung cấp thất bại"); }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {           
            clearTextBox();
            txt_Ma.Text = Helper.createMaNCC();
        }
        private void clearTextBox()
        {
            foreach (Control ctr in panelTT_NCC.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox t = (TextBox)ctr;
                    t.Clear();
                }
            }
        }

        private async void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sdtNCC = txt_SDT.Text;
            if(sdtNCC=="" || String.IsNullOrEmpty(sdtNCC))
            {
                ThongBao("Kiểm tra lại thông tin nhà cung cấp");
                return;
            }
            NhaCungCapModel ncc =await _xuLyNCC.TimKiemNCCBySDT(sdtNCC);
            if (ncc == null)
            {
                ThongBao("Không tìm thấy nhà cung cấp theo số điện thoại");
            }
            else
            {
                taoDataGridView();
                themDuLieuDataGridView(ncc);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDataGridViewAsync();
        }
    }
}