using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class EXPhieuXuatModel
    {
        public EXPhieuXuatModel() { }
        public string MaKH { get; set; } 
        public string MaPhieuXuat { get; set; }
        public string HoTenKH { get; set; } 
        public string DiaChiKH { get; set; } 
        public string Sdt { get; set; }
        public string TongTien { get; set; }
        public string HoTenNV { get; set; }
        public string SoDienThoaiNV { get; set; }
        public string TongTienBangChu { get; set; }
        
    }
    public class CT_TT_PhieuXuatExport
    {
        public string STT { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        public string ThanhTien { get; set; }
    }
}
