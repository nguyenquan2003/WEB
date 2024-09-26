using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai2buoi2.Models
{
    public class Khoa
    {
        public string TenKhoa { get; set; }
        public int NamThanhLap { get; set; }
        public string Mess { get; set; }
        public Khoa()
        {
            TenKhoa = "Cong Nghe Thong Tin";
            NamThanhLap = 2003;
            Mess = "Code mai mai";
        }
    }
}