using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongVanKhuong_buoi3.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GT { get; set; }
        public string Hinh { get; set; }
        public NhanVien()
            {
                MaNV = "2001215886";
                TenNV = "Duong Van Khuong";
                GT = "Nam";
                Hinh = "/HinhAnh/HinhAnh.jpg";
            }
    }
    
}