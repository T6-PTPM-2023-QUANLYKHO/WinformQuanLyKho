using _DTO;
using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BLL
{
    public class XuLyChiTietPhieuXuatModel
    {
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        public async Task<int> ThemCTPhieuXuat(CTPhieuXuatModel ct)
        {
            string url = api.insertCTXuatHang;
            return await lib.insertData(ct, url);
        }
        public async Task< int> xoaChiTietPhieuXuatByMaPX(string maphieu)
        {
            string url = api.deleteCTPhieuXuatMaPh;
            return await lib.deleteData(url, maphieu);
        }
        public async Task< List<CTPhieuXuatModel> >getCTPhieuXuatByMaPhieu(string maPh)
        {
            string url = api.getCTPhieuXuatByMaPhieu+maPh;
            string json = await lib.getData(url);
            List<CTPhieuXuatModel> lst = JsonConvert.DeserializeObject<List<CTPhieuXuatModel>>(json);
            return lst;
        }
    }
}
