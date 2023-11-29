﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DTO
{
    public class ThongKeSpModel
    {

        public SanPhamModel2 SanPham { get; set; } // Thông tin sản phẩm
        public int SoLuong { get; set; } // Số lượng

        public ThongKeSpModel(SanPhamModel2 sanPham, int soLuong)
        {
            // Sao chép thông tin từ SanPhamModel
            this.SanPham = new SanPhamModel2
            {
                mA_SP = sanPham.mA_SP,
                mA_NCC = sanPham.mA_NCC,
                teN_SP = sanPham.teN_SP,
                ngaysx = sanPham.ngaysx,
                hsd = sanPham.hsd,
                soluong = sanPham.soluong,
                mA_LOAI = sanPham.mA_LOAI,
                gia = sanPham.gia,
                ghichU_SP = sanPham.ghichU_SP,
                makho = sanPham.makho,
                anh = sanPham.anh
            };

            // Thiết lập giá trị SoLuong
            this.SoLuong = soLuong;
        }


    }
}
