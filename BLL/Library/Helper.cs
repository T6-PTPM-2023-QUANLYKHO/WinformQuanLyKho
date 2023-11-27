using Microsoft.SqlServer.Server;
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
            makh = "NCC" + ngay + thang + phut + giay;
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
        public static string ConvertNumberToWords(decimal number)
        {
            string[] units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười năm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] currencies = { "đồng", "nghìn", "triệu", "tỷ" };

            string ConvertGroupOfThree(int num)
            {
                if (num == 0)
                    return "";

                if (num <= 19)
                    return units[num];

                int ten = num / 10;
                int unit = num % 10;

                if (unit == 0)
                    return units[ten] + " mươi";
                else
                    return units[ten] + " mươi " + units[unit];
            }

            string result = "";
            int groupIndex = 0;

            while (number > 0)
            {
                int group = (int)(number % 1000);
                number /= 1000;

                if (group > 0)
                {
                    string groupWords = ConvertGroupOfThree(group);
                    if (!string.IsNullOrEmpty(groupWords))
                    {
                        if (groupIndex > 0)
                            result = groupWords + " " + currencies[groupIndex] + " " + result;
                        else
                            result = groupWords + " " + result;
                    }
                }

                groupIndex++;
            }

            if (string.IsNullOrEmpty(result))
                result = "không đồng";

            return result;
        }
    }
}
