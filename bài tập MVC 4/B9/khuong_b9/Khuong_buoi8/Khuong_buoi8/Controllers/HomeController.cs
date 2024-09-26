using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Khuong_buoi8.Models;
using System.IO;
namespace Khuong_buoi8.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DataClasses1DataContext data = new DataClasses1DataContext();

        public ActionResult Index()
        {
            List<Sach> ds = data.Saches.ToList();
            return View(ds);
        }
        //Them moi mot quyen sach
        public ActionResult ThemSachMoi()
        {
            ViewBag.MaChuDe = new SelectList(data.ChuDes.ToList().OrderBy(n => n.TenChuDe), "MaChuDe", "TenChuDe");
            ViewBag.MaNXB = new SelectList(data.NhaXuatBans.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
            return View();
        }
        [HttpPost]
        public ActionResult ThemSachMoi(Sach sach,HttpPostedFileBase fileupload)
        {
            if(fileupload == null)
            {
                ViewBag.ThongBao = "Vui lòng chọn ảnh bìa";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if(ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("/Hinh"), fileName);
                    fileupload.SaveAs(path);
                    sach.AnhBia = fileName;
                    data.Saches.InsertOnSubmit(sach);
                    data.SubmitChanges();
                }
            }
            ViewBag.MaChuDe = new SelectList(data.ChuDes.ToList().OrderBy(n => n.TenChuDe), "MaChuDe", "TenChuDe");
            ViewBag.MaNXB = new SelectList(data.NhaXuatBans.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
            return RedirectToAction("Index", "Home");
        }
        //chi tiết sản phẩm
        //public ActionResult ChiTietSanPham()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult ChiTietSanPham(int id)
        //{
        //    //Lấy ra đối tượng sách theo mã
        //    Sach sach = sach.SingleOrDefault(n => n.MaSach == id);
        //    ViewBag.MaSach = sach.MaSach;
        //    if(sach == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(sach);
        //}
    }
}
