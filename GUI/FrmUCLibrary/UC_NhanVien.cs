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
        XuLyNhanVienModel _xuLy = new XuLyNhanVienModel();
        public UC_NhanVien()
        {
            InitializeComponent();
            LoadDataGirdView();
        }
        private async void LoadDataGirdView()
        {
            List<NhanVienModel> lstKhachHang = await _xuLy.getAllNhanVien();
            dgvNhanVien.DataSource = lstKhachHang;
        }
    }
}
