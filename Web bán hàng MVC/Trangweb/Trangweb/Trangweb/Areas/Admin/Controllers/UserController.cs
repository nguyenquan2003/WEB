using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangweb.Identity;
using Trangweb.Models;

namespace Trangweb.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index(int? id, int page = 1, string search = "", string sortOption = "")
        {
            AppDbContext db = new AppDbContext();   
            List<AppUser> users = db.Users.ToList();
            myDbContext dbo = new myDbContext();

            List<Category> loai = dbo.Categories.ToList();
            ViewBag.Loai = loai;
          

            ViewBag.Search = search;

            return View(users);
        }
    }
}