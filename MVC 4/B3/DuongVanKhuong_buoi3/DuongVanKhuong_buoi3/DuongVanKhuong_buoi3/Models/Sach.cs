using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongVanKhuong_buoi3.Models
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal Gia { get; set; }
        public string Hinh { get; set; }
        public Sach()
        {
            MaSach = "01";
            TenSach = "Nao";
            Gia = 90000;
            Hinh ="/HinhAnh/HinhAnh.ipg";
        }
        public Sach(string s,string t,decimal g,string ha)
        {
            MaSach = s;
            TenSach = t;
            Gia = g;
            Hinh = ha;
        }
    }
    
}