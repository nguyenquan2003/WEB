using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnCuoiKi.Models
{
    public class GioHang
    {
        DataClasses2DataContext data = new DataClasses2DataContext();
        public int masanpham { get; set; }
        public string tensanpham { get; set; }
        public int giaban { get; set; }
        public string hinh { get; set; }
        public int slmua { get; set; }
        public int thanhtien
        {
            get
            {
                return slmua * giaban;
            }
        }
        public GioHang()
        {

        }
        public GioHang(int msanpham)
        {
            SanPham s = data.SanPhams.FirstOrDefault(t => t.MaSanPham == msanpham);
            masanpham = s.MaSanPham;
            tensanpham = s.TenSanPham;
            giaban = (int)s.GiaBan;
            hinh = s.AnhBia;
            slmua = 1;
        }   
    }
}