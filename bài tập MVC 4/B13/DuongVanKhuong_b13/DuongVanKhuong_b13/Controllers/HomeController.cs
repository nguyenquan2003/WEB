using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuongVanKhuong_b13.Models;
namespace DuongVanKhuong_b13.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DataClasses1DataContext data = new DataClasses1DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HoaDon()
        {
            List<tbl_HoaDon> dsHD = data.tbl_HoaDons.ToList();
            return View(dsHD);
        }
        public ActionResult CTHoaDon(int id)
        {
            List<tbl_ChiTiet> dsCTHD = data.tbl_ChiTiets.Where(t => t.MaHD == id).ToList();
            return View(dsCTHD);
        }
        public ActionResult XacNhanDon(int id)
        {
            tbl_HoaDon hd = data.tbl_HoaDons.FirstOrDefault(t => t.MaHoaDon == id);
            hd.NgayThanhToan = (DateTime)DateTime.Now;
            UpdateModel(hd);
            data.SubmitChanges();
            return RedirectToAction("HoaDon", "Home");
        }
    }
}
