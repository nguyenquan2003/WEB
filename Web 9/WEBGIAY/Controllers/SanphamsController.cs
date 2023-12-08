using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Controllers
{
    public class SanphamsController : Controller
{
        public ActionResult Index(string search = " ", string sortBy = "Giá Bán tăng dần", int page = 1)
        {
            DbContextWebGiay ds = new DbContextWebGiay();
            var products = ds.sanPhams.Where(row => row.tenSanPham.Contains(search));
            if (search == null)
            {
                return HttpNotFound();
            }
            switch (sortBy)
            {
                case "Giá Bán tăng dần":
                    products = products.OrderBy(row => row.gia);
                    break;
                case "Giá Bán giảm dần":
                    products = products.OrderByDescending(row => row.gia);
                    break;
                case "Tên Sản Phẩm tăng dần":
                    products = products.OrderBy(row => row.tenSanPham);
                    break;
                case "Tên Sản Phẩm giảm dần":
                    products = products.OrderByDescending(row => row.tenSanPham);
                    break;
            }

            ViewBag.Search = search;
            ViewBag.SortBy = sortBy;
            int pageSize = 9;
            int pageNumber = (page < 1) ? 1 : page;

            var pagedProducts = products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            int totalProducts = products.Count();
            int totalPages = (int)Math.Ceiling((double)totalProducts / pageSize);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;

            return View(pagedProducts);

        }

        public ActionResult ChiTiet(int id = 0)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            var chitiet = db.sanPhams.SingleOrDefault(n => n.maSanPham == id);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

        private DbContextWebGiay db = new DbContextWebGiay();

        public List<sanPham> LaySanPhamNgauNhien(int soLuong)
        {
            return db.sanPhams.OrderBy(r => Guid.NewGuid()).Take(soLuong).ToList();
        }

        public ActionResult SanPhamLienQuan()
        {
            var sanPhamNgauNhien = LaySanPhamNgauNhien(4);
            return View(sanPhamNgauNhien);
        }
    }
}