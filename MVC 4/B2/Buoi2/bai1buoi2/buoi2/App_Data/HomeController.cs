using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace buoi2.App_Data
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Index(int id,string name)
        {
            ViewBag.ma = id;
            ViewBag.ten = name;
            return View();
        }

    }
}
