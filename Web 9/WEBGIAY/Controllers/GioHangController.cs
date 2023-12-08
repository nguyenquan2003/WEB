using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace DoAnCuoiKy.Controllers
{
    public class GiohangController : Controller
    {
        DbContextWebGiay db = new DbContextWebGiay();

        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }

        public ActionResult ThemGioHang(int iMasp, string strURL)
        {
            sanPham sp = db.sanPhams.SingleOrDefault(n => n.maSanPham == iMasp);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            List<GioHang> lstGioHang = LayGioHang();

            GioHang sanpham = lstGioHang.Find(n => n.iMasp == iMasp);
            if (sanpham == null)
            {
                sanpham = new GioHang(iMasp);
                lstGioHang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoLuong++;
                return Redirect(strURL);
            }
        }

        public ActionResult CapNhatGioHang(int iMaSP, int txtSoLuong)
        {
            sanPham sp = db.sanPhams.SingleOrDefault(n => n.maSanPham == iMaSP);

            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            List<GioHang> lstGioHang = LayGioHang();

            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.iMasp == iMaSP);

            if (sanpham != null)
            {
                sanpham.iSoLuong = txtSoLuong;
            }

            return RedirectToAction("GioHang");
        }


        public ActionResult XoaGioHang(int iMaSP)
        {
            sanPham sp = db.sanPhams.SingleOrDefault(n => n.maSanPham == iMaSP);

            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.iMasp == iMaSP);

            if (sanpham != null)
            {
                lstGioHang.RemoveAll(n => n.iMasp == iMaSP);

            }
            if (lstGioHang.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("GioHang");
        }

        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<GioHang> lstGioHang = LayGioHang();
            return View(lstGioHang);
        }

        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTongSoLuong = lstGioHang.Sum(n => n.iSoLuong);
            }
            return iTongSoLuong;
        }

        private double TongTien()
        {
            double dTongTien = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                dTongTien = lstGioHang.Sum(n => n.ThanhTien);
            }
            return dTongTien;
        }

        public ActionResult GioHangPartial()
        {
            if (TongSoLuong() == 0)
            {
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }

        #region

        [HttpPost]
        public ActionResult DatHang(FormCollection donhangForm)
        {
            if (Session["use"] == null || Session["use"].ToString() == "")
            {
                return RedirectToAction("Dangnhap", "User");
            }

            if (Session["GioHang"] == null)
            {
                RedirectToAction("Index", "Home");
            }
            Console.WriteLine(donhangForm);
            string diaChiNhanHang = donhangForm["diaChiNhanHang"];
            string thanhtoan = donhangForm["MaTT"].ToString();
            int ptthanhtoan = Int32.Parse(thanhtoan);

            donHang dh = new donHang();
            nguoiDung kh = (nguoiDung)Session["use"];
            List<GioHang> gh = LayGioHang();
            dh.maNguoiDung = kh.maNguoiDung;
            dh.ngayDat = DateTime.Now;
            dh.thanhToan = ptthanhtoan;
            dh.diaChiNhanHang = diaChiNhanHang;
            int tongtien = 0;
            foreach (var item in gh)
            {
                int thanhtien = item.iSoLuong * (int)item.dDonGia;
                tongtien += thanhtien;
            }
            dh.tongTien = (int)tongtien;
            db.donHangs.Add(dh);
            db.SaveChanges();

            foreach (var item in gh)
            {
                chiTietDonHang ctDH = new chiTietDonHang();
                decimal thanhtien = item.iSoLuong * (decimal)item.dDonGia;
                ctDH.maDon = dh.maDon;
                ctDH.maSanPham = item.iMasp;
                ctDH.soLuong = item.iSoLuong;
                ctDH.donGia = (int)item.dDonGia;
                ctDH.thanhTien = (int)thanhtien;
                ctDH.phuongThucThanhToan = 1;
                db.chiTietDonHangs.Add(ctDH);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Donhang");
        }
        #endregion

        public ActionResult ThanhToanDonHang()
        {

            ViewBag.MaTT = new SelectList(new[]
                {
                    new { MaTT = 1, TenPT="Thanh toán tiền mặt" },
                    new { MaTT = 2, TenPT="Thanh toán chuyển khoản" },
                }, "MaTT", "TenPT", 1);
            ViewBag.MaNguoiDung = new SelectList(db.nguoiDungs, "maNguoiDung", "tenNguoiDung");

            if (Session["use"] == null || Session["use"].ToString() == "")
            {
                return RedirectToAction("Dangnhap", "User");
            }

            if (Session["GioHang"] == null)
            {
                RedirectToAction("Index", "Home");
            }

            donHang dh = new donHang();
            nguoiDung kh = (nguoiDung)Session["use"];
            List<GioHang> gh = LayGioHang();
            decimal tongtien = 0;
            foreach (var item in gh)
            {
                decimal thanhtien = item.iSoLuong * (decimal)item.dDonGia;
                tongtien += thanhtien;
            }

            dh.maNguoiDung = kh.maNguoiDung;
            dh.ngayDat = DateTime.Now;
            chiTietDonHang ctDH = new chiTietDonHang();
            ViewBag.tongtien = tongtien;
            return View(dh);
        }
    }
}