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
           
            return View();
        }
        public ActionResult DMChuDe()
        {
            List<ChuDe> dsCD = data.ChuDes.ToList();
            return View(dsCD);
        }
        public ActionResult NhaXuatBan()
        {
            List<NhaXuatBan> NXB = data.NhaXuatBans.ToList();
            return View(NXB);
        }
        public ActionResult DSSach()
        {
            List<Sach> dsSach = data.Saches.Take(16).ToList();
            return View(dsSach);
        }
        public ActionResult XemChiTiet(int id)
        {
            Sach S = data.Saches.FirstOrDefault(t => t.MaSach == id);
            return View(S);
        }
    }
}
