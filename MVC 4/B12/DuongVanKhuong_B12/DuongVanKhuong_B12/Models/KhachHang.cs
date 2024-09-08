using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongVanKhuong_B12.Models
{
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MatKhau { get; set; }
        public KhachHang()
        {

        }
    }
}