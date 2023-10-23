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
    public class XuLyLoaiSanPhamModel
    {
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        public async Task<List<LoaiSanPhamModel>> getAllLoaiSP()
        {
            string url = api.getAllLoaiSP;
            string json = await lib.getData(url);
            List<LoaiSanPhamModel> list = JsonConvert.DeserializeObject<List<LoaiSanPhamModel>>(json);
            return list;
        }
    }
}
