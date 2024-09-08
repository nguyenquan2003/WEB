using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai2buoi2.Models;
namespace bai2buoi2.Controllers
{
    public class KhoaController : Controller
    {
        //
        // GET: /Khoa/

        public ActionResult Index()
        {
            //khai bao bien
            Khoa a = new Khoa();
            a.Mess = "Dang hoc code";
            return View(a);
        }

    }
}
