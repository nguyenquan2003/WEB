using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Areas.Admin.Controllers
{
    public class DonhangsController : Controller
    {
        private DbContextWebGiay db = new DbContextWebGiay();

        public ActionResult Index()
        {
            var donhangs = db.donHangs.Include(d => d.nguoiDung);
            return View(donhangs.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donHang donhang = db.donHangs.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }

        public ActionResult xemThongTinDonHang(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donHang donhang = db.donHangs.Find(id);
            var chitiet = db.chiTietDonHangs.Include(d => d.sanPham).Where(d => d.maDon == id).ToList();
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }

        public ActionResult Xacnhan(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var donHang = db.donHangs.Find(id);
            if (donHang != null)
            {
                var chiTietDonHangs = donHang.chiTietDonHangs;

                foreach (var chiTiet in chiTietDonHangs)
                {
                    var sanPham = db.sanPhams.Find(chiTiet.maSanPham);

                    if (sanPham != null)
                    {
                        sanPham.soLuongSanPham -= chiTiet.soLuong;

                        db.Entry(sanPham).State = EntityState.Modified;
                    }
                }

                donHang.tinhTrang = 1;

                db.Entry(donHang).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maDon,ngayDat,tinhTrang,maNguoiDung,thanhToan,diaChiNhanHang")] donHang donhang)
        {
            if (ModelState.IsValid)
            {

                db.donHangs.Add(donhang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNguoidung = new SelectList(db.nguoiDungs, "maNguoiDung", (System.Collections.IEnumerable)donhang.nguoiDung);
            return View(donhang);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donHang donhang = db.donHangs.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNguoidung = new SelectList(db.nguoiDungs, "maNguoiDung", "Anhdaidien", donhang.maNguoiDung);
            return View(donhang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maDon,ngayDat,tinhTrang,maNguoiDung,thanhToan,diaChiNhanHang")] donHang donhang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donhang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNguoidung = new SelectList(db.nguoiDungs, "maNguoiDung", "Anhdaidien", donhang.maNguoiDung);
            return View(donhang);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donHang donhang = db.donHangs.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            donHang donhang = db.donHangs.Find(id);
            db.donHangs.Remove(donhang);
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
