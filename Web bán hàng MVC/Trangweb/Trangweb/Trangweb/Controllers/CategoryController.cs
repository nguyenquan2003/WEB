using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangweb.Models;

namespace Trangweb.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(int? id, int page = 1, string search = "", string sortOption = "")
        {
            myDbContext db = new myDbContext();

            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;

            List<Product> products = db.Products.ToList();

            switch (sortOption)
            {
                case "tang":
                    products = products.OrderBy(e => e.Price).ToList();
                    break;
                case "giam":
                    products = products.OrderByDescending(e => e.Price).ToList();
                    break;
                default:
                    products = db.Products.ToList();
                    break;
            }

            if (id != null)
            {
                ViewBag.Id = id; // Thiết lập ViewBag.Id tại đây
                products = products.Where(p => p.Id_Category == id).ToList();
            }

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search)).ToList();
            }

            ViewBag.Search = search;
            ViewBag.SortOption = sortOption; // Thêm dòng này

            int NoOfRecordPerPage = 4;

            int NoOfPages = (int)Math.Ceiling((double)products.Count / NoOfRecordPerPage);
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPerPage;

            ViewBag.Page = page;
            ViewBag.NoOfPages = NoOfPages;
            if (NoOfPages > 0)
            {
                products = products.Skip(NoOfRecordToSkip).Take(NoOfRecordPerPage).ToList();
            }


            return View(products);
        }
    }
}