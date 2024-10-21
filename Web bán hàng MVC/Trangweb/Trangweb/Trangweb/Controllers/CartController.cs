using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangweb.Models;

namespace Trangweb.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index(int? id, string search = "")
        {
            myDbContext db = new myDbContext();
            List<Cart> carts = db.Cart.ToList();
            List<Category> loai = db.Categories.ToList();
            ViewBag.Loai = loai;
            ViewBag.Search = search;
            return View(carts);
        }
        // Trong CartController.cs
        public ActionResult Add(int id)
        {
            myDbContext db = new myDbContext();
            Product product = db.Products.Where(p => p.Id == id).FirstOrDefault();
            if (product != null)
            {
                Cart cartItem = db.Cart.Where(c => c.Id == id).FirstOrDefault();
                if (cartItem != null)
                {
                    // Nếu sản phẩm đã có trong giỏ hàng, tăng số lượng
                    cartItem.Quantity += 1;
                }
                else
                {
                    // Nếu sản phẩm chưa có trong giỏ hàng, thêm mới
                    Cart newCartItem = new Cart();
                    newCartItem.Id = product.Id;
                    newCartItem.Quantity = 1;
                    newCartItem.Product = product;
                    db.Cart.Add(newCartItem);
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        // Trong CartController.cs
        [HttpPost]
        public JsonResult UpdateQuantity(int quan = 0, int proid = 0)
        {
            myDbContext db = new myDbContext();
            if (quan > 0)
            {
                Cart cartItem = db.Cart.Where(cart => cart.Id == proid).FirstOrDefault();
                if (cartItem != null)
                {
                    cartItem.Quantity = quan;
                    db.SaveChanges();
                }
            }
            return Json(new { success = true });
        }
        public ActionResult Remove(int id)
        {
            myDbContext db = new myDbContext();
            Cart cartItem = db.Cart.Where(row => row.Id == id).FirstOrDefault();
            if (cartItem != null)
            {
                db.Cart.Remove(cartItem);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}