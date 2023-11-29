using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class ChucVuModel
    {
<<<<<<< HEAD
        public ChucVuModel() { }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
=======
        public ChucVuModel(string MaChucVu, string TenChucVu)
        {
            this.MaChucVu = MaChucVu;
            this.TenChucVu = TenChucVu;
        }
        public string MaChucVu { get; set; }
        public string TenChucVu { set; get; }
>>>>>>> tuan
    }
}
