using System.Linq;
using System.Web.Mvc;
using WEBGIAY.Models;
using System.Data.Entity;
using System.Web.Helpers;

namespace WEBGIAY.Areas.Admin.Controllers
{
    public class ThongkesController : Controller
    {
        private DbContextWebGiay db = new DbContextWebGiay();
        public ActionResult Index()
        {
            var dataThongke = (from s in db.donHangs
                               join x in db.nguoiDungs on s.maNguoiDung equals x.maNguoiDung
                               group s by s.maNguoiDung into g
                               select new Thongke
                               {
                                   Tennguoidung = g.FirstOrDefault().nguoiDung.tenNguoiDung,
                                   Tongtien = g.Sum(x => x.tongTien),
                                   Dienthoai = g.FirstOrDefault().nguoiDung.dienThoai,
                                   Soluong = g.Count(),
                                   NGAY_DAT = g.FirstOrDefault().ngayDat
                               })
                  .OrderByDescending(s => s.Tongtien)
                  .Take(5)
                  .ToList();

            dataThongke = dataThongke
                .OrderByDescending(t => t.NGAY_DAT)
                .ToList();

            return View(dataThongke);
        }

    }
}