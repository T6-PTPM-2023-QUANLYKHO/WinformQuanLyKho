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
            private string _getAllKH = @"https://localhost:7202/api/khach-hang/get-all";
            private string _getKHBySDT = @"https://localhost:7202/api/khach-hang/get-by-sdt/";
            private string _deleteKhachHang = @"https://localhost:7202/api/khach-hang/remove-by-ma-khach-hang";
            private string _insertKhachHang = "https://localhost:7202/api/khach-hang/add-item";
            private string _updateKhachHang = @"https://localhost:7202/api/khach-hang/update";
            //
            private string _getAllNhaCungCap = @"https://localhost:7202/api/nha-cung-cap/get-all";
            private string _insertNhaCungCap = @"https://localhost:7202/api/nha-cung-cap/add-item";
            private string _deleteNhaCungCap = @"https://localhost:7202/api/nha-cung-cap/remove-by-maphieu";
            private string _updateNhaCungCap = @"https://localhost:7202/api/nha-cung-cap/update";
            private string _timKiemNhaCungCapSDT = @"https://localhost:7202/api/nha-cung-cap/get-by-sdt";
            //
            private string _getAllSanPham = @"https://localhost:7202/api/San-pham/get-all";
            public string getAllSanPham
            {
                get { return _getAllSanPham; }
                set { _getAllSanPham = value; }
            }
            public string timKiemNhaCungCapSDT
            {
                get { return _timKiemNhaCungCapSDT; }
                set { _timKiemNhaCungCapSDT = value; }
            }
            public string updateNhaCungCap
            {
                get { return _updateNhaCungCap; }
                set { _updateNhaCungCap = value; }
            }
            public string deleteNhaCungCap
            {
                get { return _deleteNhaCungCap; }
                set { _deleteNhaCungCap = value; }
            }
            public string insertNhaCungCap
            {
                get { return _insertNhaCungCap; }
                set { _insertNhaCungCap = value; }
            }
            public string getAllNhaCungCap
            {
                get { return _getAllNhaCungCap;}
                set {  _getAllNhaCungCap = value;}
            }
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