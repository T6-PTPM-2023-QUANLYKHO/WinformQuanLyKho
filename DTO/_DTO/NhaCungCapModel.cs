using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class NhaCungCapModel
    {
        private static List<NhaCungCapModel> _listNCC;
        private string _ma_NCC;
        private string _ten_NCC;
        private string _diaChi_NCC;
        private string _sdt;
        public NhaCungCapModel()
        {
            this._ma_NCC = null;
            this._ten_NCC = null;
            this._diaChi_NCC = null;
            this._sdt = null;
        }
        public NhaCungCapModel(string MA_NCC, string TEN_NCC, string DIACHI_NCC, string sdt)
        {
            this._ma_NCC = MA_NCC;
            this._ten_NCC = TEN_NCC;
            this._diaChi_NCC = DIACHI_NCC;
            this._sdt = sdt;
        }
        public string ma_NCC
        {
            get { return _ma_NCC; }
            set { this._ma_NCC = value; }
        }
        public string ten_NCC
        {
            get { return _ten_NCC; }
            set { this._ten_NCC = value; }
        }
        public string diaChi_NCC
        {
            get { return _diaChi_NCC; }
            set { this._diaChi_NCC = value; }
        }
        public string sdt
        {
            get { return _sdt; }
            set { this._sdt = value; }
        }
    }
}
