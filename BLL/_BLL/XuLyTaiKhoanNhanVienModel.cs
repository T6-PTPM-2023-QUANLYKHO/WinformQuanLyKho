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
    public class XuLyTaiKhoanNhanVien
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
            string url = api.getByNhomNgDung;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listmanhom = JsonConvert.DeserializeObject<List<String>>(json);
            if (listmanhom != null) return listmanhom;
            return null;
        }
        public async Task<List<String>> GetNhanVien()
        {
            string url = api.getByNhanVien;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listmanv = JsonConvert.DeserializeObject<List<String>>(json);
            if (listmanv != null) return listmanv;
            return null;
        }
        public async Task<List<String>> GetTaiKhoan()
        {
            string url = api.getByTK;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<String> listTk = JsonConvert.DeserializeObject<List<String>>(json);
            if (listTk != null) return listTk;
            return null;
        }
        public async Task<List<TaiKhoanNVModel>> GetALlTK()
        {
            string url = api.getAllTK;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<TaiKhoanNVModel> listtk = JsonConvert.DeserializeObject<List<TaiKhoanNVModel>>(json);
            if (listtk != null) return listtk;
            return null;
        }
        public async Task<int> InsertTK(TaiKhoanNVModel tk)
        {
            string url = api.addTK;
            return await lib.insertData(tk, url);
        }
        public async Task<int> RepairTK(TaiKhoanNVModel tk)
        {
            string url = api.updateTK;
            return await lib.Update(tk, url);
        }
        public async Task<int> DeleteTK(string tk)
        {
            string url = api.removeTK;
            return await lib.deleteData(url, tk);
        }
    }
}
