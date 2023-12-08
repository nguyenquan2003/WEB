using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WEBGIAY.Models;

namespace WEBGIAY.Controllers
{
    public class UserController : Controller
    {
        DbContextWebGiay db = new DbContextWebGiay();
        public ActionResult Dangky()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dangky(nguoiDung nguoidung)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.nguoiDungs.Add(nguoidung);
                    db.SaveChanges();
                    ViewBag.RegOk = "Đăng kí thành công. Đăng nhập ngay";
                    ViewBag.isReg = true;
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Có lỗi xảy ra khi đăng ký: " + ex.Message);
                }
            }
            return View(nguoidung);
        }

        public ActionResult Dangnhap()
        {
            return View();

        }


        [HttpPost]
        public ActionResult Dangnhap(FormCollection userlog)
        {
            string userMail = userlog["userMail"].ToString();
            string password = userlog["password"].ToString();
            var islogin = db.nguoiDungs.SingleOrDefault(x => x.eMail.Equals(userMail) && x.matKhau.Equals(password));

            if (islogin != null)
            {
                if (userMail == "Admin@gmail.com")
                {
                    Session["use"] = islogin;
                    return RedirectToAction("Index", "Admin/Home");
                }
                else
                {
                    Session["use"] = islogin;
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.Fail = "Tài khoản hoặc mật khẩu không chính xác.";
                return View("Dangnhap");
            }

        }
        public ActionResult DangXuat()
        {
            Session["use"] = null;
            return RedirectToAction("Index", "Home");

        }

        public ActionResult Profile(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nguoiDung nguoiDung = db.nguoiDungs.Find(id);
            if (nguoiDung == null)
            {
                return HttpNotFound();
            }
            return View(nguoiDung);
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

                return RedirectToAction("Profile", new { id = nguoidung.maNguoiDung });

            }
            ViewBag.IDQuyen = new SelectList(db.phanQuyens, "IdQuyen", "tenQuyen", nguoidung.IdQuyen);
            return View(nguoidung);
        }
        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }
    }
}