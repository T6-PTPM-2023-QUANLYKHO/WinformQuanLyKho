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
    public class XuLyPhanQuyenModel
    {
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        LibAPI lib = new LibAPI();
        private Boolean CheckJson(string json)
        {
            if (String.IsNullOrEmpty(json) || json == "" || json.Equals(""))
            {
                return false;
            }
            return true;
        }
        public async Task<List<String>> GetMaNhom()
        {
            string url = api.getByMaNhom;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listmanhom = JsonConvert.DeserializeObject<List<String>>(json);
            if (listmanhom != null) return listmanhom;
            return null;
        }
        public async Task<List<String>> GetMaManHinh()
        {
            string url = api.getByMaManHinh;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listmamanhinh = JsonConvert.DeserializeObject<List<String>>(json);
            if (listmamanhinh != null) return listmamanhinh;
            return null;
        }
        public async Task<List<PhanQuyenModel>> GetALlPQ()
        {
            string url = api.getAllPQ;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<PhanQuyenModel> listmh = JsonConvert.DeserializeObject<List<PhanQuyenModel>>(json);
            if (listmh != null) return listmh;
            return null;
        }
        public async Task<int> InsertPQ(PhanQuyenModel mh)
        {
            string url = api.addPQ;
            return await lib.insertData(mh, url);
        }
        public async Task<int> RepairPQ(PhanQuyenModel mh)
        {
            string url = api.updatePQ;
            return await lib.Update(mh, url);
        }
        public async Task<int> DeletePQ(string mh)
        {
            string url = api.removePQ;
            return await lib.deleteData(url, mh);
        }
        public async Task<List<string>> LayDanhSachManHinhTuongUng(string maNhom)
        {
            List<string> danhSachManHinh = new List<string>();
            try
            {
                string url = api.getAllPQ;
                string json = await lib.getData(url);
                if (CheckJson(json) == false)
                {
                    return danhSachManHinh;
                }
                List<PhanQuyenModel> danhSachPhanQuyen = JsonConvert.DeserializeObject<List<PhanQuyenModel>>(json);
                var phanQuyenCuaNhom = danhSachPhanQuyen.Where(pq => pq.MA_NHOM_NGUOI_DUNG == maNhom);
                foreach (var phanQuyen in phanQuyenCuaNhom)
                {
                    danhSachManHinh.Add(phanQuyen.MA_MAN_HINH);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi truy xuất dữ liệu: {ex.Message}");
            }

            return danhSachManHinh;
        }
    }
}
