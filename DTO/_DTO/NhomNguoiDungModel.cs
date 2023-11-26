using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class NhomNguoiDungModel
    {
        public NhomNguoiDungModel(string MA_NHOM, string TEN_NHOM, string GHI_CHU )
        {
            this.MA_NHOM = MA_NHOM;
            this.TEN_NHOM = TEN_NHOM;
            this.GHI_CHU = GHI_CHU;
        }
        public string MA_NHOM { get; set; }
        public string TEN_NHOM { get; set; }
        public string GHI_CHU { get; set; }

    }
}
