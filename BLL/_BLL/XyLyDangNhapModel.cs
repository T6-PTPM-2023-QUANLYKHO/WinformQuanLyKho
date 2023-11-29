using _DTO;
using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _BLL
{
    public class XyLyDangNhapModel
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
        public async Task<List<DangNhapModel>> GetALlDangNhap()
        {
            string url = api.getallDN;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            List<DangNhapModel> listdn = JsonConvert.DeserializeObject<List<DangNhapModel>>(json);
            if (listdn != null) return listdn;
            return null;
        }
        public async Task<DangNhapModel> getbytk(string taikhoan, string matkhau)
       {
            string url = "https://localhost:44327/api/tai-khoan-dn/get-by-tkmk/" + taikhoan + "/" + matkhau;
            string json = await lib.getData(url);
            DangNhapModel tk = JsonConvert.DeserializeObject<DangNhapModel>(json);
            return tk;
        }
        public async Task<int> PostTKMK(DangNhapModel tk)
        {
            string url = api.puttkmk;
            return await lib.insertData(tk, url);
        }
        public async Task<int> InsertDN(DangNhapModel tk)
        {
            string url = api.puttkmk;
            return await lib.insertData(tk, url);
        }
        public async Task<int> RepairDN(DangNhapModel tk)
        {
            string url = api.repairDN;
            return await lib.Update(tk, url);
        }
        public async Task<int> DeleteDN(string tk)
        {
            string url = api.removeDN;
            return await lib.deleteData(url, tk);
        }
        public async Task<DangNhapModel> getTKDN(string tk)
        {
            string url = "https://localhost:44327/api/tai-khoan-dn/get-by-id/" + tk;
            string json = await lib.getData(url);
            if (CheckJson(json) == false) { return null; }
            DangNhapModel thongtintk = JsonConvert.DeserializeObject<DangNhapModel>(json);
            if (thongtintk != null) { return thongtintk; }
            return null;
        }
    }
}
