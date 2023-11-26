using _DTO;
using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BLL
{
    public class XuLySanPhamModel
    {
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        LibAPI lib = new LibAPI();
        public async Task< List<SanPhamModel>> getAllSP()
        {
            string url = api.getAllSanPham;
            string json = await lib.getData(url);
            List<SanPhamModel> lst = JsonConvert.DeserializeObject<List<SanPhamModel>>(json);
            return lst;
        }
        public async Task<SanPhamModel> getAllSP(string maSP)
        {
            string url = api.getSPById+maSP;
            string json = await lib.getData(url);
            SanPhamModel sp = JsonConvert.DeserializeObject<SanPhamModel>(json);
            return sp;
        }
        public async Task<List<ThongKeSpModel>> ThongKeSLNhap(DateTime ngaybd, DateTime ngaykt)
        {
            // Tạo URL với thông tin ngày bắt đầu và ngày kết thúc
            string url = api.getThongKeNhapHang + "?ngaybd=" + ngaybd.ToString("yyyy-MM-dd") + "&ngaykt=" + ngaykt.ToString("yyyy-MM-dd");
            string json = await lib.getData(url);
            List<ThongKeSpModel> lst = JsonConvert.DeserializeObject<List<ThongKeSpModel>>(json);
            return lst;
        }
        public async Task<List<ThongKeSpModel>> ThongKeTon(DateTime ngaybd, DateTime ngaykt)
        {
            // Tạo URL với thông tin ngày bắt đầu và ngày kết thúc
            string url = api.getThongKeTonKho + "?ngaybd=" + ngaybd.ToString("yyyy-MM-dd") + "&ngaykt=" + ngaykt.ToString("yyyy-MM-dd");
            string json = await lib.getData(url);
            List<ThongKeSpModel> lst = JsonConvert.DeserializeObject<List<ThongKeSpModel>>(json);
            return lst;
        }
        public async Task<List<ThongKeSpModel>> ThongKeBan(DateTime ngaybd, DateTime ngaykt)
        {
            // Tạo URL với thông tin ngày bắt đầu và ngày kết thúc
            string url = api.getThongKeXuatHang + "?ngaybd=" + ngaybd.ToString("yyyy-MM-dd") + "&ngaykt=" + ngaykt.ToString("yyyy-MM-dd");
            string json = await lib.getData(url);
            List<ThongKeSpModel> lst = JsonConvert.DeserializeObject<List<ThongKeSpModel>>(json);
            return lst;
        }
        public async Task<List<SanPhamModel>> ThongKeDate(DateTime ngaybd, DateTime ngaykt)
        {
            // Tạo URL với thông tin ngày bắt đầu và ngày kết thúc
            string url = api.getThongKeDate + "?ngaybd=" + ngaybd.ToString("yyyy-MM-dd") + "&ngaykt=" + ngaykt.ToString("yyyy-MM-dd");
            string json = await lib.getData(url);
            List<SanPhamModel> lst = JsonConvert.DeserializeObject<List<SanPhamModel>>(json);
            return lst;
        }

    }
}
