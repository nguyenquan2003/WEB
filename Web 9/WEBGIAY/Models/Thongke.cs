using System;

namespace WEBGIAY.Models
{
    public class Thongke
    {
        public string Tennguoidung { get; set; }
        public string Dienthoai { get; set; }
        public int? Tongtien { get; set; }
        public int? Soluong { get; set; }
        public DateTime? NGAY_DAT { get; internal set; }
    }
}