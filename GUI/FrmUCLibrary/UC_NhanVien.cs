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
            try
            {
                string maNV = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenNV = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string email = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                string ngaySinh = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                string gioiTinh = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                string sdt = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                string diaChi = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                string luong = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                string boPhan = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                string chucVu = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
                
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
            catch {
                MessageBox.Show("Dòng này không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private NhanVienModel getInfoEmp()
        {
            string dateString = dtpNgaySinh.Text;
            DateTime date = DateTime.Parse(dateString);
            string formattedDate = date.ToString("yyyy-MM-dd");
            NhanVienModel nv = new NhanVienModel();
            nv.MaNhanVien = txtMaNV.Text;
            nv.TenNhanVien = txtTenNV.Text;
            nv.Email = txtEmail.Text;
            nv.NgaySinh = formattedDate;
            nv.GioiTinh = cboGioiTinh.Text;
            nv.Sdt = txtSDT.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Luong = int.Parse(txtLuong.Text.Trim());
            nv.BoPhan = cboBoPhan.Text;
            nv.MaChucVu = cboChucVu.SelectedValue.ToString();
            return nv;
        }

        private void cboLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLoaiTimKiem.Text = cboLoaiTimKiem.Text;
            txtTenTimKiem.Clear();
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<NhanVienModel> lstNV = new List<NhanVienModel>();
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
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienModel nv = getInfoEmp();
                int kq = await _xuLyNhanVien.addNhanVien(nv);
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
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNV.Text;
                int kq = await _xuLyNhanVien.deleteNhanVien(maNV);
                if (kq == 0)
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    LoadDataGirdView();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienModel nv = getInfoEmp();
                int kq = await _xuLyNhanVien.updateNhanVien(nv);
                if (kq == 1)
                {
                    MessageBox.Show("Thành Công.");
                    LoadDataGirdView();
                }
                else { MessageBox.Show("Thất Bại!"); }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
