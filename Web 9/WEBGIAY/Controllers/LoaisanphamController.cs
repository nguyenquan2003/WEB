using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Controllers
{
    public class LoaisanphamController : Controller
    {
        public ActionResult BrandList()
        {
            DbContextWebGiay dt = new DbContextWebGiay();
            List<loaiSanPham> brs = dt.loaiSanPhams.ToList();
            return PartialView("BrandList", brs);
        }
        public ActionResult BrandProduct(int id, string sortBy, string search = "", int page = 1)
        {
            DbContextWebGiay ds = new DbContextWebGiay();

            List<sanPham> sp = ds.sanPhams.Where(row => row.maLoaiSP == id).ToList();
            sanPham selectedProduct = sp.FirstOrDefault(product => product.maSanPham == id);

            if (selectedProduct != null)
            {
                ViewBag.TenSanPham = selectedProduct.tenSanPham;
            }
            switch (sortBy)
            {
                case "Giá Bán tăng dần":
                    sp = sp.OrderBy(row => row.gia).ToList();
                    break;
                case "Giá Bán giảm dần":
                    sp = sp.OrderByDescending(row => row.gia).ToList();
                    break;
                case "Tên Sản Phẩm tăng dần":
                    sp = sp.OrderBy(row => row.tenSanPham).ToList();
                    break;
                case "Tên Sản Phẩm giảm dần":
                    sp = sp.OrderByDescending(row => row.tenSanPham).ToList();
                    break;
                default:
                    sp = sp.OrderBy(row => row.tenSanPham).ToList();
                    break;
            }
            ViewBag.Search = search;
            ViewBag.SortBy = sortBy;

            int NoOfRecordPage = 4;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(sp.Count) / Convert.ToDouble(NoOfRecordPage)));
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPage;
            ViewBag.Page = page;
            ViewBag.NoOfPage = NoOfPage;
            sp = sp.Skip(NoOfRecordToSkip).Take(NoOfRecordPage).ToList();
            return View(sp);
        }
        public ActionResult ChiTiet(int id)
        {
            DbContextWebGiay ds = new DbContextWebGiay();
            sanPham sp = ds.sanPhams.Where(row => row.maSanPham == id).FirstOrDefault();
            return View(sp);
        }
    }
}