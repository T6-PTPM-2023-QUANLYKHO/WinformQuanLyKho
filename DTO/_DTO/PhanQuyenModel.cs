using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class PhanQuyenModel
    {
        public PhanQuyenModel(string MA_NHOM_NGUOI_DUNG, string MA_MAN_HINH, bool COQUYEN)
        {
            this.MA_NHOM_NGUOI_DUNG = MA_NHOM_NGUOI_DUNG;
            this.MA_MAN_HINH = MA_MAN_HINH;
            this.COQUYEN = COQUYEN;
        }
        public string MA_NHOM_NGUOI_DUNG { get; set; }
        public string MA_MAN_HINH { get; set; }
        public bool COQUYEN { get; set; }
    }

}
