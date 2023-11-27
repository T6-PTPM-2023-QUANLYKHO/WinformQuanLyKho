using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using FrmUCLibrary;

namespace WinformQuanLyKho.GUI.FrmKhachHang
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Frm_PhieuXuatHang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int chieurong = Screen.PrimaryScreen.WorkingArea.Width;
            int chieudai = Screen.PrimaryScreen.WorkingArea.Height;
            mainContent.Width = chieurong;
            mainContent.Height = chieudai-menuStrip1.Height;
        }
        private void tạoPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            mainContent.Controls.Clear();
            UC_PhieuXuatHang ucPhieuXuatHang = new UC_PhieuXuatHang();
            mainContent.Controls.Add(ucPhieuXuatHang);
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainContent.Controls.Clear();
            UC_KhachHang ucKH = new UC_KhachHang();
            mainContent.Controls.Add(ucKH);
        }

        private void menuItemDSNV_Click(object sender, EventArgs e)
        {
            mainContent.Controls.Clear();
            UC_NhanVien ucNV = new UC_NhanVien();
            ucNV.Dock = DockStyle.Fill;
            mainContent.Controls.Add(ucNV);
        }

        private void menuItemDSSP_Click(object sender, EventArgs e)
        {
            mainContent.Controls.Clear();
            UC_SanPham ucSP = new UC_SanPham();
            ucSP.Dock = DockStyle.Fill;
            mainContent.Controls.Add(ucSP);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainContent.Controls.Clear();
            UC_HoaDon ucHD = new UC_HoaDon();
            ucHD.Dock = DockStyle.Fill;
            mainContent.Controls.Add(ucHD);
        }
    }
}
