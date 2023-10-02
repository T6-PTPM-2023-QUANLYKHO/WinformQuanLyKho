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
    }
}
