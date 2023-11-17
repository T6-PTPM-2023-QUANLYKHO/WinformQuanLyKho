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
    public partial class UC_NhanVien : UserControl
    {
        XuLyNhanVienModel _xuLyNhanVien = new XuLyNhanVienModel();
        XuLyChucVuModel _xuLyChucVu = new XuLyChucVuModel();
        public UC_NhanVien()
        {
            InitializeComponent();
            initForm();
        }
        private async void LoadDataGirdView()
        {
            List<NhanVienModel> lstKhachHang = await _xuLyNhanVien.getAllNhanVien();
            dgvNhanVien.DataSource = lstKhachHang;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNV = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenNV = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            string email = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            string ngaySinh = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            string gioiTinh = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            string sdt = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            string diaChi = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            string boPhan = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            string chucVu = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            string luong = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtMaNV.Text = maNV;
            txtTenNV.Text = tenNV;
            txtEmail.Text = email;
            dtpNgaySinh.Text = ngaySinh;
            cboGioiTinh.Text = gioiTinh;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diaChi;
            cboBoPhan.Text = boPhan;
            cboChucVu.Text = chucVu;
            txtLuong.Text = luong;
        }

        private async void loadCboChucVu()
        {
            List<ChucVuModel> lstChucVu = await _xuLyChucVu.getAllChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "TENCHUCVU";
            cboChucVu.ValueMember = "MACHUCVU";
        }

        private void initForm()
        {
            LoadDataGirdView();
            loadCboChucVu();
            cboGioiTinh.SelectedItem = cboGioiTinh.Items[0].ToString();
            cboBoPhan.SelectedItem = cboBoPhan.Items[0].ToString();
            cboLoaiTimKiem.SelectedItem = cboLoaiTimKiem.Items[0].ToString();
            lbLoaiTimKiem.Text = cboLoaiTimKiem.Text;
        }

        private void cboLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLoaiTimKiem.Text = cboLoaiTimKiem.Text;
            txtTenTimKiem.Clear();
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<NhanVienModel> lstNV = new List<NhanVienModel> ();
            if (lbLoaiTimKiem.Text.CompareTo("Mã nhân viên") == 0)
            {
                NhanVienModel khachHang = await _xuLyNhanVien.getNhanVienByID(txtTenTimKiem.Text);
                lstNV.Add(khachHang);
                dgvNhanVien.DataSource = lstNV;
            }
            else if (lbLoaiTimKiem.Text.CompareTo("Số điện thoại") == 0)
            {
                NhanVienModel khachHang = await _xuLyNhanVien.getNhanVienBySDT(txtTenTimKiem.Text);
                lstNV.Add(khachHang);
                dgvNhanVien.DataSource = lstNV;
            }
            else
            {
                List<NhanVienModel> lstKhachHang = await _xuLyNhanVien.getAllNhanVien();
                dgvNhanVien.DataSource = lstKhachHang;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
