using Library;
using Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUCLibrary.Model
{
    public class XuLyPhieuXuatModel
    {
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        public async Task< List<PhieuXuatModel>> getAllPhieuXuat()
        {
            string url = api.getAllPhieuXuat;
            string json =await lib.getData(url);
            List<PhieuXuatModel> list = JsonConvert.DeserializeObject<List<PhieuXuatModel>>(json);
            return list;
        }
        public async Task< int> themPhieuXuat(PhieuXuatModel phieuXuat)
        {
            string url = api.addPhieuXuat;

            int kq =await lib.insertData(phieuXuat,url);
            return kq;
        }
        public async Task<Boolean> KT_TonTaiMaPhieuXuat(string maPhieu)
        {
            List<PhieuXuatModel> list = await getAllPhieuXuat();
            PhieuXuatModel p = list.Where(m => m.mapH_XH.Equals(maPhieu)).FirstOrDefault();
            if (p == null)
            {
                //không tồn tại
                return false;
            }
            //tồn tại
            return true;
        }
        public async Task<List<PhieuXuatModel>> getAllPhieuXuatByMaKH(string maKH)
        {
            string url = api.getAllPhieuXuat;
            string json = await lib.getData(url);
            List<PhieuXuatModel> listPhieuXuat = JsonConvert.DeserializeObject<List<PhieuXuatModel>>(json);
            List<PhieuXuatModel> resutl = listPhieuXuat.Where(m => m.makh.Trim().Equals(maKH.Trim())).ToList();
            return resutl;
        }
        public async Task<int> deletePhieuXuat(string maPhieuXuat)
        {
            string url = api.deletePhieuXuat;
            return await lib.deleteData(url, maPhieuXuat);
        }
    }
}
