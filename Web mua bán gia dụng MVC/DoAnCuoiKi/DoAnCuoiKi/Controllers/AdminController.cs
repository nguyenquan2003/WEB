using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCuoiKi.Models;
using System.IO;
namespace DoAnCuoiKi.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        DataClasses2DataContext data = new DataClasses2DataContext();
        //TRANG CHỦ
        public ActionResult Index()
        {
            return View();
        }
        //TRANG DANH MỤC SẢN PHẨM
        public ActionResult DMSanPham()
        {
            List<SanPham> dsSP = data.SanPhams.ToList();
            return View(dsSP);
        }
        //TRANG DANH MỤC KHÁCH HÀNG
        public ActionResult DMKhachHang()
        {
            List<KhachHang> dsKH = data.KhachHangs.ToList();
            return View(dsKH);
        }
        //TRANG DANH MỤC ĐƠN HÀNG
        public ActionResult DMDonHang()
        {
            List<DonHang> dsDH = data.DonHangs.ToList();
            return View(dsDH);
        }
        //TRANG DANH MỤC LOẠI
        public ActionResult DMLoai()
        {
            List<LoaiHang> dsLH = data.LoaiHangs.ToList();
            return View(dsLH);
        }
        //NÚT XÁC NHẬN ĐƠN
        public ActionResult XacNhanDon(int id)
        {
            DonHang hd = data.DonHangs.FirstOrDefault(t => t.MaDonHang == id);
            hd.NgayGiao = (DateTime)DateTime.Now;
            hd.DaThanhToan = "Rồi";
            UpdateModel(hd);
            data.SubmitChanges();
            return RedirectToAction("DMDonHang", "Admin");
        }
        //THÊM LOẠI HÀNG
        public ActionResult ThemLoaiHang()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemLoaiHang(LoaiHang l)
        {
            data.LoaiHangs.InsertOnSubmit(l);
            data.SubmitChanges();
            return RedirectToAction("DMLoai", "Admin");
        }
        //THÊM MỘT SẢN PHẨM
        public ActionResult ThemSanPham()
        {
            ViewBag.MaLoai = new SelectList(data.LoaiHangs.ToList().OrderBy(n => n.TenLoai), "MaLoai", "TenLoai");
            ViewBag.MaNSX = new SelectList(data.NhaSanXuats.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            return View();
        }
        [HttpPost]
        public ActionResult ThemSanPham(SanPham s, HttpPostedFileBase fileupload)
        {
            if (fileupload == null)
            {
                ViewBag.thongbao = "Vui lòng chọn ảnh bìa.";
                return RedirectToAction("DMSanPham", "Admin");

            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("/HinhAnh"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.thongbao = "Hình đã tồn tại";

                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    s.AnhBia = fileName;
                    data.SanPhams.InsertOnSubmit(s);
                    data.SubmitChanges();
                }
            }
            //data.Saches.InsertOnSubmit(s);
            //data.SubmitChanges();
            ViewBag.MaLoai = new SelectList(data.LoaiHangs.ToList().OrderBy(n => n.TenLoai), "MaLoai", "TenLoai");
            ViewBag.MaNSX = new SelectList(data.NhaSanXuats.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            return RedirectToAction("DMSanPham", "Admin");
        }
        //HIỆU CHỈNH SẢN PHẨM
            public ActionResult HieuChinhSanPham(int? id)
        {
            SanPham s = data.SanPhams.FirstOrDefault(t => t.MaSanPham == id);
            return View(s);
        }
        [HttpPost]
        public ActionResult HieuChinhSanPham(SanPham pb)
        {
            SanPham s = data.SanPhams.FirstOrDefault(t => t.MaSanPham == pb.MaSanPham);
            s.TenSanPham = pb.TenSanPham;
            UpdateModel(data);
            data.SubmitChanges();
            return RedirectToAction("DMSanPham", "Admin");
        }
        //XÓA SẢN PHẨM
        public ActionResult XoaSanPham(int id)
        {
            SanPham s = data.SanPhams.FirstOrDefault(t => t.MaSanPham== id);
            if (s.ChiTietDonHangs.Count == 0)
            {
                data.SanPhams.DeleteOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("DMSanPham");
            }
            return View();
        }
        //XÓA LOẠI HÀNG
        //XÓA SẢN PHẨM
        public ActionResult XoaLoaiHang(string id)
        {
            LoaiHang s = data.LoaiHangs.FirstOrDefault(t => t.MaLoai == id);
            if (s.SanPhams.Count == 0)
            {
                data.LoaiHangs.DeleteOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("DMLoai");
            }
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection c)
        {
            using (var contx = new DataClasses2DataContext())
            {
                QuanLy kh = contx.QuanLies.SingleOrDefault(k => k.TaiKhoan == Request["taikhoan"] && k.MatKhau == int.Parse(Request["matkhau"]));
                if (kh != null)
                {
                    Session["admin"] = kh;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    return RedirectToAction("DangNhap", "");
            }
        }
        //
        //public ActionResult Delete(string id)
        //{
        //    LoaiHang l = data.LoaiHangs.FirstOrDefault(t => t.MaLoai == id);
        //    if (l.SanPhams.Count == 0) // 
        //    {
        //        data.LoaiHangs.DeleteOnSubmit(l);
        //        data.SubmitChanges();
        //        return RedirectToAction("DMLoai");

        //    }
        //    return View();
        //}
        //public ActionResult HieuChinh(int? id)
        //{
        //    tbl_Deparment phong = data.tbl_Deparments.FirstOrDefault(t => t.DeptId == id);
        //    return View(phong);
        //}
        //[HttpPost]
        //public ActionResult HieuChinh(tbl_Deparment pb)
        //{
        //    tbl_Deparment phong = data.tbl_Deparments.FirstOrDefault(t => t.DeptId == pb.DeptId);
        //    phong.Name = pb.Name;
        //    UpdateModel(data);
        //    data.SubmitChanges();
        //    return View(phong);
        //}
    }
}
