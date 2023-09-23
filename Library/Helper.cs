using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Helper
    {
        public static string createMaKH()
        {
            string makh = "";
            string ngay= DateTime.Today.Day.ToString();
            string thang = DateTime.Today.Month.ToString();
           // string nam = DateTime.Today.Year.ToString().Substring(2,2);
            string gio = DateTime.Now.Hour.ToString();
            string phut =  DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            makh = "KH" + ngay+thang+phut+giay;
            return makh;
        }
    }
}
