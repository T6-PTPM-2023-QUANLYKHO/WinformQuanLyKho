using _BLL;
using _DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformQuanLyKho.GUI.FrmKhachHang;

namespace FrmUCLibrary
{
    public partial class UC_DN : Form
    {
        private XyLyDangNhapModel xyLyDangNhapModel;
        private XyLyManHinhModel xyLyManHinhModel;
        public UC_DN()
        {
            InitializeComponent();
            xyLyDangNhapModel = new XyLyDangNhapModel();
            xyLyManHinhModel = new XyLyManHinhModel();
            txtMK.UseSystemPasswordChar = true;
        }
        private async void btnDN_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTK.Text;
            string matKhau = txtMK.Text;

            try
            {
                DangNhapModel taiKhoanInfo = await xyLyDangNhapModel.getbytk(taiKhoan, matKhau);

                if (taiKhoanInfo != null)
                {
                    List<ManHinhModel> manHinhInfo = await xyLyManHinhModel.GetMaHinh(taiKhoan);

                    if (manHinhInfo != null && manHinhInfo.Count > 0)
                    {
                        ManHinhModel firstManHinh = manHinhInfo[0];

                        if (firstManHinh.MA_MAN_HINH.Equals("a"))
                        {
                            MessageBox.Show($"Đăng nhập thành công cho màn hình {firstManHinh.MA_MAN_HINH}");
                            MainForm a = new MainForm();
                            a.ShowDialog();
                        }
                        else if (firstManHinh.MA_MAN_HINH.Equals("MH002"))
                        {
                            MessageBox.Show($"Đăng nhập thành công cho màn hình {firstManHinh.MA_MAN_HINH}");
                            UC_DANGKY a = new UC_DANGKY();
                            a.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Màn hình không được hỗ trợ hoặc không được phân quyền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy thông tin màn hình hoặc tài khoản không có quyền truy cập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra tài khoản và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show($"Lỗi khi đọc dữ liệu JSON: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Lỗi khi gọi API: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkHienThiMk_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !checkHienThiMk.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_QUENMK QMK = new UC_QUENMK();
            QMK.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_DANGKY DK = new UC_DANGKY();
            DK.ShowDialog();
        }
    }
}


