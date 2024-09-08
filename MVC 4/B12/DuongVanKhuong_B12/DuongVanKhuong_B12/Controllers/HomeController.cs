using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DuongVanKhuong_B12.Models;
namespace DuongVanKhuong_B12.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DataClasses1DataContext data = new DataClasses1DataContext();
        string strcon = ConfigurationManager.ConnectionStrings["QLDonHangSachConnectionString"].ConnectionString;
        public ActionResult Index()
        {
            List<tbl_SanPham> dsSanPham = data.tbl_SanPhams.ToList();
            return View(dsSanPham);
        }
        //lay gio hang
        public List<GioHang> LayGioHang()
        {
            List<GioHang> gio = Session["gh"] as List<GioHang>;
            if (gio == null)
            {
                gio = new List<GioHang>();
                Session["gh"] = gio;
            }
            return gio;
        }

        //Them gio hang
        public ActionResult ThemGioHang(int id)
        {
            List<GioHang> gio = LayGioHang();
            //neu gio hang rong
            if (gio == null || gio.Count == 0)
            {
                GioHang sp = new GioHang(id);
                gio = new List<GioHang>();
                gio.Add(sp);
            }
            else//co gio roi
            {
                //kiemtra xem co trong gio chua
                GioHang sach = gio.FirstOrDefault(t => t.masach == id);
                if (sach == null) // cuon sach duoc chon chua co trong gio
                {
                    sach = new GioHang(id);
                    gio.Add(sach);
                }
                else//cuon sach da chon
                {
                    sach.slmua++;
                }
            }

            Session["gh"] = gio;
            return RedirectToAction("Index");
        }
        //xem gio hang
        public ActionResult XemGioHang()
        {
            List<GioHang> gio = (List<GioHang>)Session["gh"];
            return View(gio);//modelView
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult XuLyDangNhap(FormCollection c)
        {
            string tk = c["txtTen"];
            string mk = c["txtMK"];
            tbl_KhachHang kh = data.tbl_KhachHangs.SingleOrDefault(t => t.TenKH == tk && t.MatKhau == mk);
            if (kh == null)
                return RedirectToAction("DangNhap");
            Session["KhachHang"] = kh;
            return RedirectToAction("Index", "Home");
        }
    }
}
