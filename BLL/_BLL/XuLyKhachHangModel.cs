using _DTO;
using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _BLL
{
    public class XuLyKhachHangModel
    {
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        private Boolean CheckJson(string json) {
            if (String.IsNullOrEmpty(json) || json == "" || json.Equals(""))
            {
                return false;
            }
            return true;
        }
        public async Task<List<KhachHangModel>> getAllKhachHang()
        {
            string url = api.getAllKH;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<KhachHangModel> listKhachHang = JsonConvert.DeserializeObject<List<KhachHangModel>>(json);
            if (listKhachHang != null) return listKhachHang;
            return null;
        }
        public async Task<KhachHangModel> getKhachHangBySDT(string sdt)
        {
            string url = api.getKHBySDT + sdt;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            KhachHangModel listKhachHang = JsonConvert.DeserializeObject<KhachHangModel>(json);
            if (listKhachHang != null) { return listKhachHang; }
            return null;
        }       
        public async Task<int> deleteKhachHang(string makH) 
        {
            string url = api.deleteKhachHang;
            return await lib.deleteData(url,makH);
        }
        public async Task<int> InsertKhachHang(KhachHangModel kh) 
        {
            string url = api.insertKhachHang;
            return await lib.insertData(kh,url);
        }
        public async Task<int> capNhatKH(KhachHangModel kh) 
        {
            string url = api.updateKhachHang;
            return await lib.Update(kh, url);
        }
    }
}
