using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Areas.Admin.Controllers
{
    public class NguoidungsController : Controller
    {
        private DbContextWebGiay db = new DbContextWebGiay();

        public ActionResult Index()
        {
            var nguoidungs = db.nguoiDungs.Include(n => n.phanQuyen);
            return View(nguoidungs.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nguoiDung nguoidung = db.nguoiDungs.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nguoiDung nguoidung = db.nguoiDungs.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdQuyen = new SelectList(db.phanQuyens, "IdQuyen", "tenQuyen", nguoidung.IdQuyen);
            return View(nguoidung);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maNguoiDung, tenNguoiDung, matKhau, eMail, dienThoai, IdQuyen, diaChi")] nguoiDung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguoidung).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Details", new { id = nguoidung.maNguoiDung });

            }
            ViewBag.IDQuyen = new SelectList(db.phanQuyens, "IdQuyen", "tenQuyen", nguoidung.IdQuyen);
            return View(nguoidung);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nguoiDung nguoidung = db.nguoiDungs.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nguoiDung nguoidung = db.nguoiDungs.Find(id);
            db.nguoiDungs.Remove(nguoidung);
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
