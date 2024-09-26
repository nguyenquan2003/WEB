using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongVanKhuong_B12.Models
{
    public class GioHang
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public int masach { get; set; }
        public string tensach { get; set; }
        public string hinh { get; set; }
        public int slmua { get; set; }
        public int gia { get; set; }
       
        public int thanhtien
        {
            get
            {
                return slmua * gia;
            }
        }
        //pt khoi tao
        public GioHang()
        {

        }
        public GioHang(int msach)
        {
            tbl_SanPham s = data.tbl_SanPhams.FirstOrDefault(t => t.MaSanPham == msach);
            masach = s.MaSanPham;
            tensach = s.TenSP;
            gia = (int)s.DonGia;
            hinh = s.HinhAnh;
            slmua = 1;
        }
    }
}