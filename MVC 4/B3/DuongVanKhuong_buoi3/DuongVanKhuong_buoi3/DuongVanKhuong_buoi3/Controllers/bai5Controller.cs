using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuongVanKhuong_buoi3.Models;

namespace DuongVanKhuong_buoi3.Controllers
{
    public class bai5Controller : Controller
    {
        //
        // GET: /bai5/

        public ActionResult HienThiSach()
        {
            List<Sach> dsSach = new List<Sach>();
            Sach s1 = new Sach("S1", "Dat ", 90000, "/HinhAnh/HinhAnh.ipg");
            dsSach.Add(s1);

            Sach s2 = new Sach("S1", "Nao", 90000, "/HinhAnh/HinhAnh.ipg");
            dsSach.Add(s2);

            Sach s3 = new Sach("S1", "Nao", 90000, "/HinhAnh/HinhAnh.ipg");
            dsSach.Add(s3);

            return View(dsSach);
        }

    }
}
