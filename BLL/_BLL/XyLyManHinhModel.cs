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
    public class XyLyManHinhModel
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
        public async Task<List<ManHinhModel>> GetMaHinh(string taikhoan)
        {
            string url = api.getManHinh + taikhoan;
            string json = await lib.getData(url);
            List<ManHinhModel> manHinhList = JsonConvert.DeserializeObject<List<ManHinhModel>>(json);
            return manHinhList;
        }
        public async Task<List<ManHinhModel>> GetALlMH()
        {
            string url = api.getAllMH;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<ManHinhModel> listmh = JsonConvert.DeserializeObject<List<ManHinhModel>>(json);
            if (listmh != null) return listmh;
            return null;
        }
        public async Task<int> InsertMH(ManHinhModel mh)
        {
            string url = api.addMH;
            return await lib.insertData(mh, url);
        }
        public async Task<int> RepairMH(ManHinhModel mh)
        {
            string url = api.updateMH;
            return await lib.Update(mh, url);
        }
        public async Task<int> DeleteMH(string mh)
        {
            string url = api.removeMH;
            return await lib.deleteData(url, mh);
        }

    }
}
