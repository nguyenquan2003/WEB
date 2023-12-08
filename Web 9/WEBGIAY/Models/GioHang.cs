using System.Linq;

namespace WEBGIAY.Models
{
    public class GioHang
    {
        DbContextWebGiay db = new DbContextWebGiay();
        public int iMasp { get; set; }
        public string sTensp { get; set; }
        public string sAnhBia { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double ThanhTien
        {
            get { return iSoLuong * dDonGia; }
        }

        public GioHang(int Masp)
        {
            iMasp = Masp;
            sanPham sp = db.sanPhams.Single(n => n.maSanPham == iMasp);
            sTensp = sp.tenSanPham;
            sAnhBia = sp.hinhAnh;
            dDonGia = double.Parse(sp.gia.ToString());
            iSoLuong = 1;
        }

    }
}