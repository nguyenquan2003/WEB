using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Areas.Admin.Controllers
{
    public class PhanQuyensController : Controller
    {
        private DbContextWebGiay db = new DbContextWebGiay();

        public ActionResult Index()
        {
            return View(db.phanQuyens.ToList());
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
