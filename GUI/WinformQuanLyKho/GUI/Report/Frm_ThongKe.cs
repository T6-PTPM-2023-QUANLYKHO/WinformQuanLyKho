using FrmUCLibrary.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinformQuanLyKho.GUI.Report
{
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            loadMacDinhMau();
            Screen primaryScreen = Screen.PrimaryScreen;
            int screenWidth = primaryScreen.Bounds.Width;
            int screenHeight = primaryScreen.Bounds.Height;
        }       
        private void loadMacDinhMau()
        {
            // Change the background color of the button to green
            foreach (Button b in grpb_ChucNang.Controls)
            {
                if (b is Button)
                {
                    b.BackColor = ColorTranslator.FromHtml("#62b2ff");
                }
            }
        }
        private void thayDoiMau (object _btn)
        {
            // Change the background color of the button to green
            Button btn = (Button)_btn;
            foreach(Button b in grpb_ChucNang.Controls)
            {
                if(b is Button)
                {
                  b.BackColor =  ColorTranslator.FromHtml("#62b2ff");
                }
            }
            btn.BackColor = ColorTranslator.FromHtml("#11a800");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            thayDoiMau(sender);
            UC_TK_TongQuan uc = new UC_TK_TongQuan();
            HienThiUC(uc);
        }
        private void HienThiUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
        }

        private void btnTKDoanhThu_Click(object sender, EventArgs e)
        {
            thayDoiMau(sender);
            UC_TK_DoanhThu UC = new UC_TK_DoanhThu();
            HienThiUC(UC);
        }

        private void btnTKNhapKho_Click(object sender, EventArgs e)
        {
            thayDoiMau(sender);
        }

        private void btnTKXuatKho_Click(object sender, EventArgs e)
        {
            thayDoiMau(sender);
        }
    }
}
