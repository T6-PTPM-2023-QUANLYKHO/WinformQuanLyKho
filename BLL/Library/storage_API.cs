using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class storage_API
    {
        public const string host = @"https://localhost:7202";
        public class API_KhachHang
        {
            private static string host = @"https://localhost:7202";
            //khách hàng
            private string _getAllKH = host + @"/api/khach-hang/get-all";
            private string _getKHBySDT = host + @"/api/khach-hang/get-by-sdt/";
            private string _deleteKhachHang = host + @"/api/khach-hang/remove-by-ma-khach-hang";
            private string _insertKhachHang = host + "/api/khach-hang/add-item";
            private string _updateKhachHang = host + @"/api/khach-hang/update";
            //Nhà cung cấp
            private string _getAllNhaCungCap = host + @"/api/nha-cung-cap/get-all";
            private string _insertNhaCungCap = host + @"/api/nha-cung-cap/add-item";
            private string _deleteNhaCungCap = host + @"/api/nha-cung-cap/remove-by-maphieu";
            private string _updateNhaCungCap = host + @"/api/nha-cung-cap/update";
            private string _timKiemNhaCungCapSDT = host + @"/api/nha-cung-cap/get-by-sdt";
            //sản phẩm
            private string _getAllSanPham = host + @"/api/San-pham/get-all";
            private string _getSPById = host + @"/api/San-pham/get-by-id/";
            //Loại sản phẩm
            private string _getAllLoaiSP = host + @"/api/loai-sp/get-all";
            //Phiếu Xuất Hàng
            private string _getAllPhieuXuat = host + @"/api/phieu-xuat-hang/get-all";
            private string _addPhieuXuat = host + @"/api/phieu-xuat-hang/add-item";
            private string _deletePhieuXuat = host + @"/api/phieu-xuat-hang/remove-by-maphieuxh";
            private string _getPhieuXuatSoNgay = host + @"/api/phieu-xuat-hang/thong-ke-so-ngay";
            //Chi tiết xuất hàng
            private string _insertCTXuatHang = host + @"/api/chi-tiet-xuat-hang/add-item";
            private string _deleteCTPhieuXuatMaPh = host + @"/api/chi-tiet-xuat-hang/remove";
            private string _getCTPhieuXuatByMaPhieu = host + @"/api/chi-tiet-xuat-hang/get-by-id/";
            //phiêu nhập hàng Hiền
            private string _getPhieuNhapSoNgay = host + @"/api/phieu-nhap-hang/get-phieu-nhap-so-ngay/";
           
            public string getPhieuNhapSoNgay
            {
                get { return _getPhieuNhapSoNgay; }
                set { _getPhieuNhapSoNgay = value; }
            }
            public string getPhieuXuatSoNgay
            {
                get { return _getPhieuXuatSoNgay; }
                set { _getPhieuXuatSoNgay = value; }
            }
            public string getCTPhieuXuatByMaPhieu
            {
                get { return _getCTPhieuXuatByMaPhieu; }
                set { _getCTPhieuXuatByMaPhieu = value; }
            }
            public string getAllPhieuXuat
            {
                get { return _getAllPhieuXuat; }
                set { _getAllPhieuXuat = value; }
            }
            public string deleteCTPhieuXuatMaPh
            {
                get { return _deleteCTPhieuXuatMaPh; }
                set { _deleteCTPhieuXuatMaPh = value; }
            }
            public string deletePhieuXuat
            {
                get { return _deletePhieuXuat; }
                set { _deletePhieuXuat = value; }
            }
            public string addPhieuXuat
            {
                get { return _addPhieuXuat; }
                set { _addPhieuXuat = value; }
            }
            public string insertCTXuatHang
            {
                get { return _insertCTXuatHang; }
                set { _insertCTXuatHang = value; }
            }
            public string getSPById
            {
                get { return _getSPById; }
                set { _getSPById = value; }
            }
            public string getAllLoaiSP
            {
                get { return _getAllLoaiSP; }
                set { _getAllLoaiSP = value; }
            }
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
                get { return _getAllNhaCungCap; }
                set { _getAllNhaCungCap = value; }
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
        public class thongke
        {
            //thống kê 
            private string _thongKePhieuNhap = host + @"/api/thong-ke/get-phieu-nhap-theo-ngay/";
            private string _thongkePhieuXuat = host + @"/api/thong-ke/get-phieu-xuat-theo-ngay/";
            public string thongkePhieuXuat
            {
                get { return _thongkePhieuXuat; }
                set { _thongkePhieuXuat = value; }
            }
            public string thongKePhieuNhap
            {
                get { return _thongKePhieuNhap; }
                set { _thongKePhieuNhap = value; }
            }
        }
    }
}