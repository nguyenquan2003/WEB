using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DoAnCuoiKi.Models;

namespace DoAnCuoiKi.Controllers
{
    public class KhachHangController : Controller
    {
        //
        // GET: /KhachHang/
        DataClasses2DataContext data = new DataClasses2DataContext();
        string strcon = ConfigurationManager.ConnectionStrings["QL_DGDConnectionString"].ConnectionString;
        public ActionResult Index(string search = "")
        {
            List<SanPham> dsSanPham = data.SanPhams.Where(row => row.TenSanPham.Contains(search)).ToList();
            ViewBag.Search = search;
            //List<SanPham> dsSanPham = data.SanPhams.ToList();
            return View(dsSanPham);
        }

        public ActionResult Index2(string id)
        {
            List<SanPham> dsSanPham = data.SanPhams.Where(row => row.MaLoai == id).ToList();
            //List<SanPham> dsSanPham = data.SanPhams.ToList();
            return View(dsSanPham);
        }

        public ActionResult DMLoaiHang()
        {
            List<LoaiHang> dsLoaiHang = data.LoaiHangs.ToList();
            return View(dsLoaiHang);
        }
        public ActionResult XemChiTiet(int id)
        {
            SanPham S = data.SanPhams.FirstOrDefault(t => t.MaSanPham == id);
            return View(S);
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
                GioHang sach = gio.FirstOrDefault(t => t.masanpham == id);
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
            ViewBag.tbgio = "";
            ViewBag.sum = gio.Sum(g => g.giaban * g.slmua);
            ViewBag.amount = gio.Sum(g => g.slmua);
            return View(gio);//modelView
        }
        public ActionResult XoaGioHang(int id)
        {
            List<GioHang> gio = (List<GioHang>)Session["gh"];
            gio.RemoveAll(s => s.masanpham == id);
            Session["gh"] = gio;
            return RedirectToAction("XemGioHang");
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection c)
        {
            using (var contx = new DataClasses2DataContext())
            {
                KhachHang kh = contx.KhachHangs.SingleOrDefault(k => k.TaiKhoan == Request["taikhoan"] && k.MatKhau == Request["matkhau"]);
                if (kh != null)
                {
                    Session["user"] = kh;
                    return RedirectToAction("Index", "KhachHang");
                }
                else
                    return RedirectToAction("DangNhap", "KhachHang");
            }
        }
        //ĐĂNG KÝ
        public ActionResult DangKy()
        {
            ViewBag.MaKhachHang = new SelectList(data.KhachHangs.ToList().OrderBy(n => n.HoTen), "MaKhachHang", "HoTen");
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(KhachHang l)
        {
            data.KhachHangs.InsertOnSubmit(l);
            data.SubmitChanges();
            ViewBag.MaKhachHang = new SelectList(data.KhachHangs.ToList().OrderBy(n => n.HoTen), "MaKhachHang", "HoTen");
            return RedirectToAction("DangNhap", "KhachHang");
        }
        
    }
}
