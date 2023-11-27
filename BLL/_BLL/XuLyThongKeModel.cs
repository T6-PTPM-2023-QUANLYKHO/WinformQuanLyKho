using _DTO;
using Library;
using Newtonsoft.Json;
using Syncfusion.CompoundFile.DocIO.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BLL
{
    public class XuLyThongKeModel
    {
        storage_API.thongke apiTK = new storage_API.thongke();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        LibAPI lib = new LibAPI();
        public async Task< List<TK_NhapHangModel>> getTK_NhapHang_TheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            string startDay =Helper.chuyenNgayThangSangUrl( ngayBD.Day+"/"+ngayBD.Month+"/"+ngayBD.Year);
            string endDay =Helper.chuyenNgayThangSangUrl( ngayKT.Day + "/" + ngayKT.Month + "/" + ngayKT.Year);
            string url = apiTK.thongKePhieuNhap+ startDay + "/"+ endDay;
            string json = await lib.getData(url);
            List<TK_NhapHangModel> list = JsonConvert.DeserializeObject<List<TK_NhapHangModel>>(json);
            return list;
        }
        public async Task<List<TK_XuatHangModel>> getTK_XuatHang_TheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            string startDay = Helper.chuyenNgayThangSangUrl(ngayBD.Day + "/" + ngayBD.Month + "/" + ngayBD.Year);
            string endDay = Helper.chuyenNgayThangSangUrl(ngayKT.Day + "/" + ngayKT.Month + "/" + ngayKT.Year);
            string url = apiTK.thongkePhieuXuat + startDay + "/" + endDay;
            string json = await lib.getData(url);
            List<TK_XuatHangModel> list = JsonConvert.DeserializeObject<List<TK_XuatHangModel>>(json);
            return list;
        }
        public async Task<List<PhieuNhap>> GetPhieuNhapSoNgayAsync(int soNgay)
        {
            string url = api.getPhieuNhapSoNgay + soNgay;
            string json = await lib.getData(url);
            List<PhieuNhap> list = JsonConvert.DeserializeObject<List<PhieuNhap>>(json);
            return list;
        }
        public List<PhieuNhap> getKyTruoc(List<PhieuNhap> lst)
        {
            try
            {
                int midindex = lst.Count / 2;
                List<PhieuNhap> result = new List<PhieuNhap>();
                for (int i = 0; i < midindex; i++)
                {
                    result.Add(lst[i]);
                }
                return result;
            }
            catch { return null; }

        }
        public List<PhieuNhap> getHienTai(List<PhieuNhap> lst)
        {
            try
            {
                int midindex = lst.Count / 2;
                List<PhieuNhap> result = new List<PhieuNhap>();
                for (int i = midindex; i < lst.Count; i++)
                {
                    result.Add(lst[i]);
                }
                return result;
            }
            catch { return null; }
        }
        public double TongDoanhThuNhapHang (List<TK_NhapHangModel> list)
        {
            double sum = 0;
            if(list != null)
            {
                foreach (TK_NhapHangModel item in list)
                {
                    sum += item.THANHTIEN;
                }
            }
            return sum; 
        }
        public double TongDoanhThuXuatHang(List<TK_XuatHangModel> list)
        {
            double sum = 0;
            if (list != null)
            {
                foreach (TK_XuatHangModel item in list)
                {
                    sum += item.THANHTIEN;
                }
            }
            return sum;
        }
    }
}
