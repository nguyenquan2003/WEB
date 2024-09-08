using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuongVanKhuong_buoi3.Models;
namespace DuongVanKhuong_buoi3.Controllers
{
    public class bai1Controller : Controller
    {
        //
        // GET: /bai1/

        public ActionResult Index()
        {
            List<string> danhsach = new List<string>();
                danhsach.Add("Duong Van Khuong");
                danhsach.Add("Nguyen Thi Thu Thao");
                danhsach.Add("Trieu Nguyen Tu Hao");
                danhsach.Add("Huynh Thi Thao Nguyen");
                ViewBag.DuLieu = danhsach;
            return View();
        }
        public ActionResult Index2()
        {
             List<string> TraiCay = new List<string>();
            {
                TraiCay.Add("Cam");
                TraiCay.Add("Xoai");
                TraiCay.Add("Cam");
                ViewBag.TraiCay = TraiCay;
            };
            return View();
        }
        public ActionResult Index4()
        {
            NhanVien a = new NhanVien();
            return View(a);
        }

        public ActionResult Index5()
        {
            
            return View();
        }
    }
}
