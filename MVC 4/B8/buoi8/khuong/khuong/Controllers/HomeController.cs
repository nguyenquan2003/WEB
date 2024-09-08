using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using khuong.Models;
namespace khuong.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DataClasses1DataContext data = new DataClasses1DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HienThiTrang()
        {
            List<tbl_Deparment> dsPB = data.tbl_Deparments.ToList();
            return View(dsPB);
        }
        public ActionResult ThemPhongBan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemPhongBan(tbl_Deparment pb)
        {
            data.tbl_Deparments.InsertOnSubmit(pb);
            data.SubmitChanges();
            return RedirectToAction("HienThiTrang", "Home");
        }
        public ActionResult HieuChinh(int? id)
        {
            tbl_Deparment phong = data.tbl_Deparments.FirstOrDefault(t => t.DeptId == id);
            return View(phong);
        }
        [HttpPost]
        public ActionResult HieuChinh(tbl_Deparment pb)
        {
            tbl_Deparment phong = data.tbl_Deparments.FirstOrDefault(t => t.DeptId == pb.DeptId);
            phong.Name = pb.Name;
            UpdateModel(data);
            data.SubmitChanges();
            return View(phong);
        }

        // Xoa 
        public ActionResult Delete(int id)
        {
            tbl_Deparment phong = data.tbl_Deparments.FirstOrDefault(t => t.DeptId == id);
            //kiem tra co nhan vien hay khong
            if(phong.tbl_Employees.Count == 0) // khong co nhan vien
            {
                data.tbl_Deparments.DeleteOnSubmit(phong);
                data.SubmitChanges();
                return RedirectToAction("HienThiTrang");
               
            }
            return View();
        }
    }
}
