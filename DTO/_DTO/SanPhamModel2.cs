using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class  SanPhamModel2
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
        private byte[] _anh;
        public string mA_SP { get; set; }
        public string mA_NCC { get; set; }
        public string teN_SP { get; set; }
        public DateTime ngaysx { get; set; }
        public DateTime hsd { get; set; }
        public int soluong { get; set; }
        public string mA_LOAI { get; set; }
        public double gia { get; set; }
        public string ghichU_SP { get; set; }
        public string makho { get; set; }
        public byte[] anh { get; set; }
    }
}
