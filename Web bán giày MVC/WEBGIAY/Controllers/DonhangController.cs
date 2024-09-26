using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Controllers
{
    public class DonhangController : Controller
    {
        private DbContextWebGiay db = new DbContextWebGiay();

        public ActionResult Index()
        {
            if (Session["use"] == null || Session["use"].ToString() == "")
            {
                return RedirectToAction("Dangnhap", "User");
            }
            nguoiDung kh = (nguoiDung)Session["use"];
            int maND = kh.maNguoiDung;
            var donhangs = db.donHangs.Include(d => d.nguoiDung).Where(d => d.maNguoiDung == maND);
            return View(donhangs.ToList());
        }

        public ActionResult Details(int? id)
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