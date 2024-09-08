using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ON.Models
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSP { get; set; }
        public int MaL { get; set; }
        public int MaSX { get; set; }
        public double Gia { get; set; }
        public string GhiChu { get; set; }
        public string Hinh { get; set; }
        public SanPham()
        {

        }
    }
}