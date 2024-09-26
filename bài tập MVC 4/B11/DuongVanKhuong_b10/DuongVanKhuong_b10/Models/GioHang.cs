using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DuongVanKhuong_b10.Models;

namespace DuongVanKhuong_b10.Models
{

    public class GioHang //Mot san pham chon mua
    {
        ModelsDataContext data = new ModelsDataContext();
        public int masach { get; set; }
        public string tensach { get; set; }
        public int gia { get; set; }
        public string hinh { get; set; }
        public int slmua { get; set; }
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
            Sach s = data.Saches.FirstOrDefault(t => t.MaSach == msach);
            masach = s.MaSach;
            tensach = s.TenSach;
            gia = (int)s.GiaBan;
            hinh = s.AnhBia;
            slmua = 1;
        }
    }
}