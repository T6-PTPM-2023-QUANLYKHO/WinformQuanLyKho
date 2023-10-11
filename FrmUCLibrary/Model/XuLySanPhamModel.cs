using Library;
using Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmUCLibrary.Model
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
    }
}
