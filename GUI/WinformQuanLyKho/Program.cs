﻿using FrmUCLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformQuanLyKho.GUI.FrmKhachHang;

namespace WinformQuanLyKho
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
<<<<<<< HEAD
            Application.Run(new UC_DN());            
=======
            Application.Run(new UC_DN());  
           
>>>>>>> tuan
        }
    }
}
