using _BLL;
using _DTO;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FrmUCLibrary
{
    public partial class UC_QUENMK : Form
    {
        // Tạo một đối tượng của BLL để sử dụng
        private readonly XyLyDangNhapModel xyLyDangNhapModel = new XyLyDangNhapModel();

        public UC_QUENMK()
        {
            InitializeComponent();
        }

        private async void btnQMK_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTK.Text;
                // Gọi phương thức để lấy thông tin tài khoản
                DangNhapModel thongTinTK = await xyLyDangNhapModel.getTKDN(taiKhoan.Trim());

            if (thongTinTK != null)
            {
                // Hiển thị mật khẩu lên Label
                lbmk.Text = thongTinTK.MAT_KHAU;
            }
            else
            {
                // Xử lý trường hợp không tìm thấy tài khoản
                MessageBox.Show("Tài khoản không tồn tại.", "Thông báo");
            }
        }
    }
}
