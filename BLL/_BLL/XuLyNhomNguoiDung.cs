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
    public class XuLyNhomNguoiDung
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
        public async Task<List<NhomNguoiDungModel>> GetALlNND()
        {
            string url = api.getAllNND;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<NhomNguoiDungModel> nnd = JsonConvert.DeserializeObject<List<NhomNguoiDungModel>>(json);
            if (nnd != null) return nnd;
            return null;
        }
        public async Task<int> InsertNND(NhomNguoiDungModel nd)
        {
            string url = api.addNND;
            return await lib.insertData(nd, url);
        }
        public async Task<int> RepairNND(NhomNguoiDungModel nd)
        {
            string url = api.updateNDD;
            return await lib.Update(nd, url);
        }
        public async Task<int> DeleteNND(string nd)
        {
            string url = api.removeNND;
            return await lib.deleteData(url, nd);
        }
    }
}
