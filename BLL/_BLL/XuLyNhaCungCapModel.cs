using _DTO;
using Library;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _BLL
{
    public class XuLyNhaCungCapModel
    {
        NhaCungCapModel ncc = new NhaCungCapModel();
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        public async Task<int> ThemNCC(NhaCungCapModel ncc)
        {
            string url = api.insertNhaCungCap;
            int kq = await lib.insertData(ncc, url);
            return kq;
        }
        public async Task<List<NhaCungCapModel>> getAllDanhSach()
        {
            string url = api.getAllNhaCungCap;
            string json = await lib.getData(url);
            List<NhaCungCapModel> _listNCC = JsonConvert.DeserializeObject<List<NhaCungCapModel>>(json);
            return _listNCC;
        }
        public async Task<int> xoaNhaCungCap(string maNCC)
        {
            string url = api.deleteNhaCungCap;
            return await lib.deleteData(url, maNCC);
        }
        public async Task<int> CapNhatNCC(NhaCungCapModel ncc)
        {
            string url = api.updateNhaCungCap+"/"+ncc.ma_NCC;
            return await lib.Update(ncc, url);
        }
        public async Task<NhaCungCapModel> TimKiemNCCBySDT(string sdt)
        {
            string url = api.timKiemNhaCungCapSDT+"/"+sdt;
            string json = await lib.getData(url);
            NhaCungCapModel ncc = JsonConvert.DeserializeObject<NhaCungCapModel>(json);
            return ncc;
        }
        public async Task< bool> KT_MaNCCTonTaiSanPham(string maNCC) {
            string url = api.getAllSanPham;
            string json = await lib.getData(url);
            List<SanPhamModel> _litSanPham = JsonConvert.DeserializeObject<List<SanPhamModel>>(json);
            SanPhamModel sp= _litSanPham.Where(m => m.mA_NCC.Equals(maNCC)).FirstOrDefault();
            if (sp != null) { return true; }
            return false;//tồn tại
        }
    }
}
