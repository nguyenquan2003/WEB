using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Trangweb.Models;

namespace Trangweb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id, string search = "")
        {
            myDbContext db = new myDbContext();
            //List<Category> ca = db.Categories.ToList();
            //return View(ca);
            List<Product> products = db.Products.ToList();
            List<Category> loai = db.Categories.Where(c => c.Id_Category >= 1 && c.Id_Category <= 6).ToList();
            ViewBag.Loai = loai;



            List<Product> pro = db.Products.Where(b => b.Id >= 1 && b.Id <= 4).ToList();
            ViewBag.Pro = pro;



            if (id == null)
            {
                // Nếu không có id thương hiệu, tìm tất cả sản phẩm có tên chứa chuỗi tìm kiếm
                products = db.Products.Where(p => p.Name.Contains(search)).ToList();
            }
            else
            {
                // Nếu có id thương hiệu, tìm sản phẩm thuộc thương hiệu đó và có tên chứa chuỗi tìm kiếm
                products = db.Products.Where(p => p.Id_Category == id && p.Name.Contains(search)).ToList();
            }
            ViewBag.Search = search;

            return View(products);
        }
    }
}