using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class SanPhamModel
    {
        private string _mA_SP;
        private string _mA_NCC;
        private string _teN_SP;
        private string _ngaysx;
        private string _hsd;
        private string _soluong;
        private string _mA_LOAI;
        private string _gia;
        private string _ghichU_SP;
        private string _makho;
        private string _anh;
        public string mA_SP
        {
            get { return _mA_SP; }
            set { _mA_SP = value; }
        }

        public string mA_NCC
        {
            get { return _mA_NCC; }
            set { _mA_NCC = value; }
        }

        public string teN_SP
        {
            get { return _teN_SP; }
            set { _teN_SP = value; }
        }

        public string ngaysx
        {
            get { return _ngaysx; }
            set { _ngaysx = value; }
        }

        public string hsd
        {
            get { return _hsd; }
            set { _hsd = value; }
        }

        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        public string mA_LOAI
        {
            get { return _mA_LOAI; }
            set { _mA_LOAI = value; }
        }

        public string gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public string ghichU_SP
        {
            get { return _ghichU_SP; }
            set { _ghichU_SP = value; }
        }

        public string makho
        {
            get { return _makho; }
            set { _makho = value; }
        }

        public string anh
        {
            get { return _anh; }
            set { _anh = value; }
        }
    }
}
