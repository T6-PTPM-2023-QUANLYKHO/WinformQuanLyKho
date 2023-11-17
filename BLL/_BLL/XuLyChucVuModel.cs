using _DTO;
using Library;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BLL
{
    public class XuLyChucVuModel
    {
        LibAPI lib = new LibAPI();
        storage_API.API_KhachHang api = new storage_API.API_KhachHang();
        private Boolean CheckJson(string json)
        {
            if (String.IsNullOrEmpty(json) || json == "" || json.Equals(""))
            {
                return false;
            }
            return true;
        }
        public async Task<string> layTenCVTheoMa(string maCV)
        {
            string url = api._GetCVbyID + maCV;
            string json = await lib.getData(url); // Lấy dữ liệu từ API
            if (CheckJson(json) == false) { return null; }
            dynamic myObject = JValue.Parse(json); // Chuyển dữ liệu về dạng Object
            return myObject.tenChucVu.ToString();
        }
        public async Task<List<ChucVuModel>> getAllChucVu()
        {
            List<ChucVuModel> listChucVu = new List<ChucVuModel>();
            string url = api._GetAllCV;
            string json = await lib.getData(url); // Lấy dữ liệu từ API
            if (CheckJson(json) == false) { return null; }
            dynamic myObject = JValue.Parse(json); // Chuyển dữ liệu về dạng Object
            foreach (dynamic questions in myObject)
            {
                // Truy xuất đến từng thuộc tính của obj để lấy dữ liệu
                ChucVuModel cv = new ChucVuModel();
                cv.MaChucVu = questions.maChucVu.ToString();
                cv.TenChucVu = questions.tenChucVu.ToString();
                listChucVu.Add(cv);
            }
            if (listChucVu != null) return listChucVu;
            return null;
        }
    }
}
