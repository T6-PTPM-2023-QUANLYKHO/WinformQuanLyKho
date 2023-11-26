﻿using System;
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
            private static string host = @"https://localhost:44327";
            //khách hàng
            private string _getAllKH = host+@"/api/khach-hang/get-all";
            private string _getKHBySDT = host+@"/api/khach-hang/get-by-sdt/";
            private string _deleteKhachHang =host+ @"/api/khach-hang/remove-by-ma-khach-hang";
            private string _insertKhachHang = host + "/api/khach-hang/add-item";
            private string _updateKhachHang = host + @"/api/khach-hang/update";
            //Nhà cung cấp
            private string _getAllNhaCungCap = host +@"/api/nha-cung-cap/get-all";
            private string _insertNhaCungCap = host + @"/api/nha-cung-cap/add-item";
            private string _deleteNhaCungCap = host + @"/api/nha-cung-cap/remove-by-maphieu";
            private string _updateNhaCungCap = host + @"/api/nha-cung-cap/update";
            private string _timKiemNhaCungCapSDT = host + @"/api/nha-cung-cap/get-by-sdt";
            //sản phẩm
            private string _getAllSanPham = host + @"/api/San-pham/get-all";
            private string _getSPById = host + @"/api/San-pham/get-by-id/";
            private string _getThongKeNhapHang = host + @"/api/San-pham/thong-ke-sl-nhap";
            private string _getThongKeXuatHang = host + @"/api/San-pham/thong-ke-sl-ban";
            private string _getThongKeTonKho = host + @"/api/San-pham/thong-ke-ton-kho";
            private string _getThongKeDate = host + @"/api/San-pham/thong-ke-date";
            //Loại sản phẩm
            private string _getAllLoaiSP = host + @"/api/loai-sp/get-all";
            //Phiếu Xuất Hàng
            private string _getAllPhieuXuat = host + @"/api/phieu-xuat-hang/get-all";
            private string _addPhieuXuat = host + @"/api/phieu-xuat-hang/add-item";
            private string _deletePhieuXuat = host + @"/api/phieu-xuat-hang/remove-by-maphieuxh/";
            //Chi tiết xuất hàng
            private string _insertCTXuatHang = host + @"/api/chi-tiet-xuat-hang/add-item";
            private string _deleteCTPhieuXuatMaPh = host + @"/api/chi-tiet-xuat-hang/remove/";
            private string _getCTPhieuXuatByMaPhieu = host + @"/api/chi-tiet-xuat-hang/get-by-id/";
            //Đăng nhập   
            private string _getallDN = host + @"/api/tai-khoan-dn/get-all";
            private string _getTK = host + @"/api/tai-khoan-dn/get-by-id/{taikhoan-dn}";
            private string _gettkmk = host +@"api/tai-khoan-dn/get-by-tkmk/{taikhoan-dn}/{matkhau-dn}";
            private string _puttkmk = host + @"/api/tai-khoan-dn/add-item";
            private string _removeDN = host + @"/api/tai-khoan-dn/remove-by-taikhoan-dn";
            private string _repairDN = host + @"/api/tai-khoan-dn/update";
            private string _getManHinh = host + @"/api/man-hinh/man-hinh/"; 

            //Kệ và Khu
            private string _getKhu = host + @"/api/Khu/get-all";
            private string _getKhuID = host + @"/api/Khu/get-by-id/";
            private string _addKhu = host + @"/api/Khu/add-item";
            private string _removeKhu = host + @"/api/Khu/remove-by-ma-khu";
            private string _updateKhu = host + @"/api/Khu/update";
            private string _getMaSP = host + @"/api/San-pham/masp";
            private string _getMaKHucombo = host + @"/api/Khu/makhu";
            //Ke
            private string _getKe = host + @"/api/ke/get-all";
            private string _getKeID = host + @"/api/ke/get-by-id/";
            private string _addKe = host + @"/api/ke/add-item";
            private string _removeKe = host + @"/api/ke/remove-by-ma-ke";
            private string _updateKe = host + @"/api/ke/update";
            private string _getByMakHu = host + @"/api/ke/get-by-makhu/";
            //ManHinh
            private string _getAllMH = host + @"/api/man-hinh/get-all";
            private string _addMH = host + @"/api/man-hinh/add-item";
            private string _removeMH = host + @"/api/man-hinh/remove-by-ma-man-hinh";
            private string _updateMH = host + @"/api/man-hinh/update";

            //Nhóm người dùng
            private string _getAllNND = host + @"/api/nhom-nguoi-dung/get-all";
            private string _addNND = host + @"/api/nhom-nguoi-dung/add-item";
            private string _removeNND = host + @"/api/nhom-nguoi-dung/remove-by-manhom";
            private string _updateNDD = host + @"/api/nhom-nguoi-dung/update";
            //Phân Quyền 
            private string _getAllPQ = host + @"/api/phan-quyen/get-all";
            private string _addPQ = host + @"/api/phan-quyen/add-item";
            private string _removePQ = host + @"/api/phan-quyen/remove-by-manhomnguoidung";
            private string _updatePQ = host + @"/api/phan-quyen/update";
            private string _getByMaNhom= host + @"/api/nhom-nguoi-dung/manhom";
            private string _getByMaManHinh = host + @"/api/man-hinh/mamanhinh";
            //Tài Khoản
            private string _getAllTK = host + @"/api/tai-khoan/get-all";
            private string _addTK = host + @"/api/tai-khoan/add-item";
            private string _removeTK = host + @"/api/tai-khoan/remove-by-taikhoan";
            private string _updateTK = host + @"/api/tai-khoan/update";
            private string _getByTK = host + @"/api/tai-khoan-dn/taikhoan";
            private string _getByNhanVien = host + @"/api/nhan-vien/nhan-vien";
            private string _getByNhomNgDung = host + @"/api/nhom-nguoi-dung/manhom";

            private string REMOVE_BY_TaiKhoanDN = host + @"api/tai-khoan-dn/remove-by-taikhoan-dn/{id}";
            private string REMOVE_ITEM = host + @"api/tai-khoan-dn/remove/{taikhoan-dn}";
            private string UPDATE_ITEM = host + @"api/tai-khoan-dn/update/{taikhoan-dn}";

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
            public string getallDN
            {
                get { return _getallDN; }
                set { _getallDN = value; }
            }
            public string gettkmk
            {
                get { return _gettkmk; }
                set { _gettkmk = value; }
            }
            public string puttkmk
            {
                get { return _puttkmk; }
                set {  }
            }
            public string getTK
            {
                get { return _getTK; }
                set { }
            }
            public string getThongKeNhapHang
            {
                get { return _getThongKeNhapHang; }
                set { _getThongKeNhapHang = value; }
            }
            public string getThongKeXuatHang
            {
                get { return _getThongKeXuatHang; }
                set { _getThongKeXuatHang = value; }
            }
            public string getThongKeTonKho
            {
                get { return _getThongKeTonKho; }
                set { _getThongKeTonKho = value; }
            }
            public string getThongKeDate
            {
                get { return _getThongKeDate; }
                set { _getThongKeDate = value; }
            }
            //Ke và khu
            public string getKhu
            {
                get { return _getKhu; }
                set { }
            }
            public string getKhuID
            {
                get { return _getKhuID; }
                set { }
            }
            public string addKhu
            {
                get { return _addKhu; }
                set { }
            }
            public string removeKhu
            {
                get { return _removeKhu; }
                set { }
            }
            public string updateKhu
            {
                get { return _updateKhu; }
                set { }
            }
            public string getKe
            {
                get { return _getKe; }
                set { }
            }
            public string getKeID
            {
                get { return _getKeID; }
                set { }
            }
            public string addKe
            {
                get { return _addKe; }
                set { }
            }
            public string removeKe
            {
                get { return _removeKe; }
                set { }
            }
            public string updateKe
            {
                get { return _updateKe; }
                set { }
            }
            public string getByMakHu
            {
                get { return _getByMakHu; }
                set { }
            }
            public string getMaSP
            {
                get { return _getMaSP; }
                set { }
            }
            public string getMaKHucombo
            {
                get { return _getMaKHucombo; }
                set { }
            }
            public string repairDN
            {
                get { return _repairDN; }
                set { }
            }
            public string removeDN
            {
                get { return _removeDN; }
                set { }
            }
            public string getAllMH
            {
                get { return _getAllMH; }
                set { }
            }
            public string addMH
            {
                get { return _addMH; }
                set { }
            }
            public string updateMH
            {
                get { return _updateMH; }
                set { }
            }
            public string removeMH
            {
                get { return _removeMH; }
                set { }
            }
            public string getAllNND
            {
                get { return _getAllNND; }
                set { }
            }
            public string addNND
            {
                get { return _addNND; }
                set { }
            }
            public string removeNND
            {
                get { return _removeNND; }
                set { }
            }
            public string updateNDD
            {
                get { return _updateNDD; }
                set { }
            }
            public string getAllPQ
            {
                get { return _getAllPQ; }
                set { }
            }
            public string addPQ
            {
                get { return _addPQ; }
                set { }
            }
            public string removePQ
            {
                get { return _removePQ; }
                set { }
            }
            public string updatePQ
            {
                get { return _updatePQ; }
                set { }
            }
            public string getByMaNhom
            {
                get { return _getByMaNhom; }
                set { }
            }
            public string getByMaManHinh
            {
                get { return _getByMaManHinh; }
                set { }
            }
            public string getAllTK
            {
                get { return _getAllTK; }
                set { }
            }
            public string addTK
            {
                get { return _addTK; }
                set { }
            }
            public string removeTK
            {
                get { return _removeTK; }
                set { }
            }
            public string updateTK
            {
                get { return _updateTK; }
                set { }
            }
            public string getByTK
            {
                get { return _getByTK; }
                set { }
            }
            public string getByNhanVien
            {
                get { return _getByNhanVien; }
                set { }
            }
            public string getByNhomNgDung
            {
                get { return _getByNhomNgDung; }
                set { }
            }
            public string getManHinh
            {
                get { return _getManHinh; }
                set { }
            }
        }
    }
}