using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class storage_API
    {
        public class API_KhachHang
        {
            private string _getAllKH = @"https://localhost:44327/api/khach-hang/get-all";
            private string _getKHBySDT = @"https://localhost:44327/api/khach-hang/get-by-sdt/";
            private string _deleteKhachHang = @"https://localhost:44327/api/khach-hang/remove-by-ma-khach-hang";
            private string _insertKhachHang = "https://localhost:44327/api/khach-hang/add-item";
            private string _updateKhachHang = @"https://localhost:44327/api/khach-hang/update";
            public string getAllKH
            {
                get { return _getAllKH; }
                set { }
            }
            public string getKHBySDT
            {
                get { return _getKHBySDT; }
                set { }
            }
            public string deleteKhachHang
            {
                get { return _deleteKhachHang; }
                set { }
            }
            public string insertKhachHang
            {
                get { return _insertKhachHang; }
                set { }
            }
            public string updateKhachHang
            {
                get { return _updateKhachHang; }
                set { }
            }
            
        }
    }
}