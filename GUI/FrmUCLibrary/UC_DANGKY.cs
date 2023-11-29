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
    public partial class UC_DANGKY : Form
    {
        private XyLyDangNhapModel xyLyDangNhapModel;
        private DangNhapModel tk;

        public UC_DANGKY()
        {
            InitializeComponent();
            xyLyDangNhapModel = new XyLyDangNhapModel();
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTK.Text;
            string matKhau = txtMK.Text;
            string xacNhanMatKhau = txtXT.Text;

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông báo");
                return;
            }

            // Tạo đối tượng DangNhapModel với các thông tin tài khoản và mật khẩu
            DangNhapModel tk = new DangNhapModel(taiKhoan, matKhau);

            // Gọi phương thức đăng ký tài khoản từ BLL
            int ketQua = await xyLyDangNhapModel.PostTKMK(tk);
            if (ketQua == 1)
            {
                MessageBox.Show("Đăng ký thành công.", "Thông báo");
                // Xóa dữ liệu trong các TextBox
                txtTK.Text = string.Empty;
                txtMK.Text = string.Empty;
                txtXT.Text = string.Empty;
            }
            else if (ketQua == 0)
            {
                MessageBox.Show("Đăng ký thất bại. Tài khoản đã tồn tại hoặc có lỗi khác.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi xảy ra trong quá trình đăng ký.", "Thông báo");
            }
        }
    }

 }

