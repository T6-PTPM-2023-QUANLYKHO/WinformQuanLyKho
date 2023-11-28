﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
        public static string chuyenNgayThangSangUrl(string datetime)
        {
            //định dạng input 26/2/2023
            // Kết quả sẽ là "1%2F1%2F2023"
            string encodedString = HttpUtility.UrlEncode(datetime);
            return encodedString;
        }
        public static string chuyenDinhDangTien(double money)
        {
            return money.ToString("#,##0") + "đ";
        }
        public static string createMaNCC()
        {
            string makh = "";
            string ngay = DateTime.Today.Day.ToString();
            string thang = DateTime.Today.Month.ToString();
            // string nam = DateTime.Today.Year.ToString().Substring(2,2);
            string gio = DateTime.Now.Hour.ToString();
            string phut = DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            makh = "CC" + ngay + thang + phut + giay;
            return makh;
        }
        public static string createMaPhieuXuat()
        {
            string ma = "";
            string ngay = DateTime.Today.Day.ToString();
            string thang = DateTime.Today.Month.ToString();
            string gio = DateTime.Now.Hour.ToString();
            string phut = DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            ma = "PX" + ngay + thang + phut + giay;
            return ma;
        }
    }
}
