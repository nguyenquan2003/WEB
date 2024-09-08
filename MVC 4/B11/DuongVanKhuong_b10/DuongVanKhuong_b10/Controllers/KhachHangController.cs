using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuongVanKhuong_b10.Models;
namespace DuongVanKhuong_b10.Controllers
{
    public class KhachHangController : Controller
    {
        //
        // GET: /KhachHang/
        ModelsDataContext data = new ModelsDataContext();
        public ActionResult Index()
        {
            List<Sach> dsSach = data.Saches.Take(16).ToList();
            return View(dsSach);
        }
        
        public ActionResult DMChuDe()
        {
            List<ChuDe> dsCD = data.ChuDes.ToList();
            return View(dsCD);
        }
        //lay gio hang
        public List<GioHang>LayGioHang()
        {
            List<GioHang> gio = Session["gh"] as List<GioHang>;
            if(gio == null)
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
            if(gio == null || gio.Count == 0)
            {
                GioHang sp = new GioHang(id);
                gio = new List<GioHang>();
                gio.Add(sp);
            }
            else//co gio roi
            {
                //kiemtra xem co trong gio chua
                GioHang sach = gio.FirstOrDefault(t => t.masach == id);
                if(sach == null) // cuon sach duoc chon chua co trong gio
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
        public ActionResult NhaXuatBan()
        {
            List<NhaXuatBan> NXB = data.NhaXuatBans.ToList();
            return View(NXB);
        }
      
        public ActionResult XemChiTiet(int id)
        {
            Sach S = data.Saches.FirstOrDefault(t => t.MaSach == id);
            return View(S);
        }
    }
}
