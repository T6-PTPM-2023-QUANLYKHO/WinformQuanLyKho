using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class KhuModel
    {
        public KhuModel(string MA_KHU, string TEN_KHU)
        {
            this.MA_KHU = MA_KHU;
            this.TEN_KHU = TEN_KHU;
        }
        public string MA_KHU { get; set; }
        public string TEN_KHU { get; set; }
    }
}
