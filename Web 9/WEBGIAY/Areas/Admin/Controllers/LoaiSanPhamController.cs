using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Areas.Admin.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        private DbContextWebGiay db = new DbContextWebGiay();


        public ActionResult Index()
        {
            return View(db.loaiSanPhams.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loaiSanPham loaisp = db.loaiSanPhams.Find(id);
            if (loaisp == null)
            {
                return HttpNotFound();
            }
            return View(loaisp);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maLoaiSP,tenLoaiSP")] loaiSanPham loaisp)
        {
            if (ModelState.IsValid)
            {
                db.loaiSanPhams.Add(loaisp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaisp);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loaiSanPham loaisp = db.loaiSanPhams.Find(id);
            if (loaisp == null)
            {
                return HttpNotFound();
            }
            return View(loaisp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maLoaiSP,tenLoaiSP")] loaiSanPham loaisp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaisp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaisp);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loaiSanPham loaisp = db.loaiSanPhams.Find(id);
            if (loaisp == null)
            {
                return HttpNotFound();
            }
            return View(loaisp);
        }

 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            loaiSanPham loaisp = db.loaiSanPhams.Find(id);
            db.loaiSanPhams.Remove(loaisp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
