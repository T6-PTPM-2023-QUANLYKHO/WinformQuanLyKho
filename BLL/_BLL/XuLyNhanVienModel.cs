using _DTO;
using Library;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace _BLL
{
    public class XuLyNhanVienModel
    {
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        private Boolean CheckJson(string json)
        {
            if (String.IsNullOrEmpty(json) || json == "" || json.Equals(""))
            {
                return false;
            }
            return true;
        }
        public async Task<List<NhanVienModel>> getAllNhanVien()
        {
            List<NhanVienModel> listNhanVien = new List<NhanVienModel>();
            string url = api._GetAllNV;
            string json = await lib.getData(url); // Lấy dữ liệu từ API
            if (CheckJson(json) == false) { return null; }
            dynamic myObject = JValue.Parse(json); // Chuyển dữ liệu về dạng Object
            foreach (dynamic questions in myObject)
            {
                // Truy xuất đến từng thuộc tính của obj để lấy dữ liệu
                NhanVienModel nv = new NhanVienModel();
                nv.MaNV = questions.maNhanVien.ToString();
                nv.TenNV = questions.tenNhanVien.ToString();
                nv.EmailNV = questions.email.ToString();
                nv.NgaySinh = questions.ngaySinh.ToString();
                nv.GioiTinh = questions.gioiTinh.ToString();
                nv.Sdt = questions.sdt.ToString();
                nv.DiaChi = questions.diaChi.ToString();
                nv.Luong = questions.luong;
                nv.BoPhan = questions.boPhan.ToString();
                nv.MaChucVu = questions.maChucVu.ToString();
                listNhanVien.Add(nv);
            }
            if (listNhanVien != null) return listNhanVien;
            return null;
        }
    }
}
