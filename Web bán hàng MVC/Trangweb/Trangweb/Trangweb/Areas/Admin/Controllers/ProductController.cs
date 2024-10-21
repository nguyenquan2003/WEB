using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trangweb.Models;

namespace Trangweb.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
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
        public ActionResult Create()
        {
            myDbContext db = new myDbContext();
            //ViewBag.Departments = db.Departments.ToList();
            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product, HttpPostedFileBase imageFile)
        {
            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    // Kiểm tra kích thước
                    if (imageFile.ContentLength > 2000000)
                    {
                        ModelState.AddModelError("Image", "Kích thước file không được lớn hơn 2MB.");
                        return View();
                    }

                    // Kiểm tra loại file
                    var allowedExtensions = new[] { ".jpg", ".png" };
                    var fileEx = Path.GetExtension(imageFile.FileName).ToLower();
                    if (!allowedExtensions.Contains(fileEx))
                    {
                        ModelState.AddModelError("Image", "Chỉ chấp nhận hình ảnh dạng JPG hoặc PNG.");
                        return View();
                    }

                    // Lưu thông tin vào CSDL
                    product.Image = imageFile.FileName;
                    db.Products.Add(product);
                    db.SaveChanges();

                    // Lưu ảnh với tên gốc
                    var path = Path.Combine(Server.MapPath("~/Image/Product"), imageFile.FileName);
                    imageFile.SaveAs(path);
                }
                else
                {
                    // Lưu thông tin vào CSDL
                    product.Image = "";
                    db.Products.Add(product);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
       
                return View();
            }
        
    }
        private myDbContext db = new myDbContext();

        public ActionResult Edit(int? id)
        {
            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product product = db.Products.Find(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product, HttpPostedFileBase imageFile)
        {
            if (imageFile != null && imageFile.ContentLength > 0)
            {
                // Kiểm tra kích thước
                if (imageFile.ContentLength > 2000000)
                {
                    ModelState.AddModelError("Image", "Kích thước file không được lớn hơn 2MB.");
                }

                // Kiểm tra loại file
                var allowedExtensions = new[] { ".jpg", ".png" };
                var fileEx = Path.GetExtension(imageFile.FileName).ToLower();
                if (!allowedExtensions.Contains(fileEx))
                {
                    ModelState.AddModelError("Image", "Chỉ chấp nhận hình ảnh dạng JPG hoặc PNG.");
                }
            }

            if (ModelState.IsValid)
            {
                Product oldProduct = db.Products.Find(product.Id);

                if (oldProduct == null)
                {
                    return HttpNotFound();
                }
                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    var fileName = product.Id.ToString() + Path.GetExtension(imageFile.FileName).ToLower();
                    var path = Path.Combine(Server.MapPath("~/Image/Product"), fileName);
                    imageFile.SaveAs(path);

                    product.Image = fileName;
                }
                else
                {
                    // Nếu không có tệp hình ảnh mới, giữ nguyên hình ảnh cũ
                    product.Image = oldProduct.Image;
                }

                // Cập nhật thông tin sản phẩm
                db.Entry(oldProduct).CurrentValues.SetValues(product);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            myDbContext db = new myDbContext();
            Product product = db.Products.Find(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            myDbContext db = new myDbContext();
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index","Product");
        }
    }
}