using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangweb.Models;

namespace Trangweb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(int? id, int page = 1, string search = "")
        {
            myDbContext db = new myDbContext();

            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;

            List<Product> products = db.Products.ToList();

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

            int NoOfRecordPerPage = 4;
            int NoOfPages = (int)Math.Ceiling((double)products.Count / NoOfRecordPerPage);
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.NoOfPages = NoOfPages;

            products = products.Skip(NoOfRecordToSkip).Take(NoOfRecordPerPage).ToList();


            return View(products);
        }
        public ActionResult Detail(int id, string search = "")
        {
            myDbContext db = new myDbContext();
            Product product = db.Products.Where(p => p.Id == id).FirstOrDefault();
            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;
            ViewBag.Search = search;
            return View(product);


        }
        //public ActionResult Create()
        //{
        //    myDbContext db = new myDbContext();
        //    //ViewBag.Departments = db.Departments.ToList();
        //    List<Category> loai = db.Categories.ToList();
        //    ViewBag.Loai = loai;
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Create(Product product, HttpPostedFileBase imageFile)
        //{
        //    myDbContext db = new myDbContext();
        //    if (ModelState.IsValid)
        //    {


        //        if (imageFile != null && imageFile.ContentLength > 0)
        //        {
        //            // Kiểm tra kích thước
        //            if (imageFile.ContentLength > 2000000)
        //            {
        //                ModelState.AddModelError("Image", "Kích thước file không được lớn hơn 2MB.");
        //                return View();
        //            }

        //            // Kiểm tra loại file
        //            var allowedExtensions = new[] { ".jpg", ".png" };
        //            var fileEx = Path.GetExtension(imageFile.FileName).ToLower();
        //            if (!allowedExtensions.Contains(fileEx))
        //            {
        //                ModelState.AddModelError("Image", "Chỉ chấp nhận hình ảnh dạng JPG hoặc PNG.");
        //                return View();
        //            }

        //            // Lưu thông tin vào CSDL
        //            product.Image = "";
        //            db.Products.Add(product);
        //            db.SaveChanges();

        //            // Truy vấn lại và đổi tên ảnh
        //            Product pro = db.Products.ToList().Last();
        //            var fileName = pro.Id.ToString() + fileEx;
        //            var path = Path.Combine(Server.MapPath("~/Images"), fileName);
        //            imageFile.SaveAs(path);

        //            pro.Image = fileName;
        //            db.SaveChanges();
        //        }
        //        else
        //        {
        //            // Lưu thông tin vào CSDL
        //            product.Image = "";
        //            db.Products.Add(product);
        //            db.SaveChanges();
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        List<Category> loai = db.Categories.ToList();
        //        ViewBag.Loai = loai;
        //        return View();
        //    }
        //}
        //public ActionResult Delete()
        //{

        //}
    }
}
