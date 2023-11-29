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
    public class XyLyKeKhuModel
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
        public async Task<List<String>> GetMaSP()
        {
            string url = api.getMaSP;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listmasp = JsonConvert.DeserializeObject<List<String>>(json);
            if (listmasp != null) return listmasp;
            return null;
        }
        public async Task<List<String>> GetMaKhu()
        {
            string url = api.getMaKHucombo;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listmasp = JsonConvert.DeserializeObject<List<String>>(json);
            if (listmasp != null) return listmasp;
            return null;
        }
        public async Task<List<KhuModel>> getAllKhu()
        {
            string url = api.getKhu;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<KhuModel> listkhu = JsonConvert.DeserializeObject<List<KhuModel>>(json);
            if (listkhu != null) return listkhu;
            return null;
        }
        public async Task<List<KeSPModel>> getAllKE()
        {
            string url = api.getKe;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<KeSPModel> listke = JsonConvert.DeserializeObject<List<KeSPModel>>(json);
            if (listke != null) return listke;
            return null;
        }
        public async Task<List<KeSPModel>> getAllKe(string makhu)
        {

            string url = "https://localhost:7202/api/ke/get-by-makhu/" + makhu;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<KeSPModel> listke = JsonConvert.DeserializeObject<List<KeSPModel>>(json);
            if (listke != null) return listke;
            return null;
        }
        public async Task<KhuModel> GetIDKhu(string Makhu)
        {
            string url = api.getKhuID + Makhu;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            KhuModel khu = JsonConvert.DeserializeObject<KhuModel>(json);
            if (khu != null) return khu;
            return null;
        }
        public async Task<KeSPModel> GetIDMaKe(string make)
        {
            string url = api.getKeID + make;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            KeSPModel ke = JsonConvert.DeserializeObject<KeSPModel>(json);
            if (ke != null) return ke;
            return null;
        }
        public async Task<int> DeleteKhu(string makhu)
        {
            string url = api.removeKhu;
            return await lib.deleteData(url, makhu);
        }
        public async Task<int> InsertKhu(KhuModel khu)
        {
            string url = api.addKhu;
            return await lib.insertData(khu, url);
        }
        public async Task<int> RepairKhu(KhuModel khu)
        {
            string url = api.updateKhu;
            return await lib.Update(khu, url);
        }
        public async Task<int> DeleteKe(string make)
        {
            string url = api.removeKe;
            return await lib.deleteData(url, make);
        }
        public async Task<int> InsertKe(KeSPModel ke)
        {
            string url = api.addKe;
            return await lib.insertData(ke, url);
        }
        public async Task<int> RepairKe(KeSPModel ke)
        {
            string url = api.updateKe;
            return await lib.Update(ke, url);
        }
    }
}
