using System.Linq;
using System;
using System.Web.Mvc;
using WEBGIAY.Models;
using PagedList;
using System.IO;
using System.Web.UI.WebControls;
using System.Web;
using System.Data.Entity;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace WEBGIAY.Areas.Admin.Controllers
{
    public class HomeController : Controller
        
    {
        DbContextWebGiay db = new DbContextWebGiay();

        //public ActionResult Index(int? page, string sortColumn, string sortOrder, string search = " ")
        //{
        //    var products = db.sanPhams.Where(row => row.tenSanPham.Contains(search));
        //    if (search == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    if (page == null) page = 1;

        //    var sp = db.sanPhams.AsQueryable();

        //    switch (sortColumn)
        //    {
        //        case "tenSanPham":
        //            sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.tenSanPham) : sp.OrderBy(x => x.tenSanPham);
        //            break;
        //        case "tenLoaiSP":
        //            sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.loaiSanPham.tenLoaiSP) : sp.OrderBy(x => x.loaiSanPham.tenLoaiSP);
        //            break;
        //        case "gia":
        //            sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.gia) : sp.OrderBy(x => x.gia);
        //            break;
        //        case "soLuongSanPham":
        //            sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.soLuongSanPham) : sp.OrderBy(x => x.soLuongSanPham);
        //            break;
        //        default:
        //            sp = sp.OrderBy(x => x.maSanPham);
        //            break;
        //    }


        //    ViewBag.Search = search;
        //    int pageSize = 5;
        //    int pageNumber = (page ?? 1);

        //    ViewBag.SortColumn = sortColumn;
        //    ViewBag.SortOrder = sortOrder;

        //    return View(sp.ToPagedList(pageNumber, pageSize));
        //}

        public ActionResult Index(int? page, string sortColumn, string sortOrder, string search = " ")
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                var sp = db.sanPhams.AsQueryable();

                switch (sortColumn)
                {
                    case "tenSanPham":
                        sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.tenSanPham) : sp.OrderBy(x => x.tenSanPham);
                        break;
                    case "tenLoaiSP":
                        sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.loaiSanPham.tenLoaiSP) : sp.OrderBy(x => x.loaiSanPham.tenLoaiSP);
                        break;
                    case "gia":
                        sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.gia) : sp.OrderBy(x => x.gia);
                        break;
                    case "soLuongSanPham":
                        sp = (sortOrder == "desc") ? sp.OrderByDescending(x => x.soLuongSanPham) : sp.OrderBy(x => x.soLuongSanPham);
                        break;
                    default:
                        sp = sp.OrderBy(x => x.maSanPham);
                        break;
                }

                int outerPageSize = 5;
                int pageNumber = (page ?? 1);

                ViewBag.SortColumn = sortColumn;
                ViewBag.SortOrder = sortOrder;

                return View(sp.ToPagedList(pageNumber, outerPageSize));
            }

            var products = db.sanPhams.Where(row => row.tenSanPham.Contains(search));

            if (!products.Any())
            {
                return View();
            }

            switch (sortColumn)
            {
                case "tenSanPham":
                    products = (sortOrder == "desc") ? products.OrderByDescending(x => x.tenSanPham) : products.OrderBy(x => x.tenSanPham);
                    break;
                case "tenLoaiSP":
                    products = (sortOrder == "desc") ? products.OrderByDescending(x => x.loaiSanPham.tenLoaiSP) : products.OrderBy(x => x.loaiSanPham.tenLoaiSP);
                    break;
                case "gia":
                    products = (sortOrder == "desc") ? products.OrderByDescending(x => x.gia) : products.OrderBy(x => x.gia);
                    break;
                case "soLuongSanPham":
                    products = (sortOrder == "desc") ? products.OrderByDescending(x => x.soLuongSanPham) : products.OrderBy(x => x.soLuongSanPham);
                    break;
                default:
                    products = products.OrderBy(x => x.maSanPham);
                    break;
            }

            int innerPageSize = 5;
            int innerPageNumber = (page ?? 1);

            ViewBag.Search = search;
            ViewBag.SortColumn = sortColumn;
            ViewBag.SortOrder = sortOrder;

            return View(products.ToPagedList(innerPageNumber, innerPageSize));
        }



        public ActionResult Details(int id)
        {
            var dt = db.sanPhams.Find(id);
            return View(dt);
        }

        public ActionResult Create()
        {
            ViewBag.MaLoaiSp = db.loaiSanPhams.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(sanPham product, List<HttpPostedFileBase> imageFiles)
        {
            if (!ModelState.IsValid)
            {
                // If ModelState is not valid, return the view with validation errors
                return View();
            }

            using (DbContextWebGiay db = new DbContextWebGiay())
            {
                ViewBag.MaLoaiSp = db.loaiSanPhams.ToList();

                try
                {
                    db.sanPhams.Add(product);
                    db.SaveChanges();

                    sanPham pro = db.sanPhams.OrderByDescending(x => x.maSanPham).FirstOrDefault();

                    if (pro != null)
                    {
                        for (int i = 0; i < (imageFiles != null ? Math.Min(imageFiles.Count, 5) : 0); i++)
                        {
                            HttpPostedFileBase imageFile = imageFiles[i];

                            if (imageFile != null && imageFile.ContentLength > 0)
                            {
                                var fileName = SaveImage(imageFile, pro.maSanPham, i);

                                switch (i)
                                {
                                    case 0:
                                        pro.hinhAnh = fileName;
                                        break;
                                    case 1:
                                        pro.hinh1 = fileName;
                                        break;
                                    case 2:
                                        pro.hinh2 = fileName;
                                        break;
                                    case 3:
                                        pro.hinh3 = fileName;
                                        break;
                                    case 4:
                                        pro.hinh4 = fileName;
                                        break;
                                }
                            }
                        }

                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(null, "There are no records in the database.");
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    Console.WriteLine($"StackTrace: {ex.StackTrace}");
                    ModelState.AddModelError(null, "An error occurred while saving to the database.");
                    return View();
                }
            }
        }

        private string SaveImage(HttpPostedFileBase imageFile, int productId, int index)
        {
            if (imageFile.ContentLength > 5000000)
            {
                ModelState.AddModelError("Image", "Kích thước file không được lớn hơn 5MB.");
                return null;
            }

            var allowExs = new[] { ".jpg", ".png" };
            var fileEx = Path.GetExtension(imageFile.FileName).ToLower();

            if (!allowExs.Contains(fileEx))
            {
                ModelState.AddModelError("Image", "Phần mở rộng file không hỗ trợ.");
                return null;
            }

            var fileName = $"{productId}_image{index}{fileEx}";
            var path = Path.Combine(Server.MapPath("~/Asset/images"), fileName);

            imageFile.SaveAs(path);

            return fileName;
        }

        public ActionResult DeleteImage(int id)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            sanPham product = db.sanPhams.Where(row => row.maSanPham == id).FirstOrDefault();
            if (product != null)
            {
                if (product.hinhAnh == "")
                {
                    return RedirectToAction("Index");
                }

                string imagePath = Server.MapPath("~/Images/" + product.hinhAnh);

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
                product.hinhAnh = "";
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var dt = db.sanPhams.Find(id);
            var hangselected = new SelectList(db.loaiSanPhams, "maLoaiSP", "tenLoaiSP", dt.maLoaiSP);
            ViewBag.Mahang = hangselected;

            return View(dt);
        }

        [HttpPost]
        public ActionResult Edit(sanPham sanpham)
        {
            try
            {
                var oldItem = db.sanPhams.Find(sanpham.maSanPham);
                oldItem.tenSanPham = sanpham.tenSanPham;
                oldItem.ngaySanXuat = sanpham.ngaySanXuat;

                oldItem.soLuongSanPham = sanpham.soLuongSanPham;
                oldItem.maLoaiSP = sanpham.maLoaiSP;

                oldItem.gia = sanpham.gia;
                oldItem.chuThichSanPham = sanpham.chuThichSanPham;
              
                oldItem.hinhAnh = sanpham.hinhAnh;
                oldItem.hinh1 = sanpham.hinh1;
                oldItem.hinh2 = sanpham.hinh2;
                oldItem.hinh3 = sanpham.hinh3;
                oldItem.hinh4 = sanpham.hinh4;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var dt = db.sanPhams.Find(id);
            return View(dt);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var dt = db.sanPhams.Find(id);

                db.sanPhams.Remove(dt);

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
