using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DuongVanKhuong_B6.Models;
namespace DuongVanKhuong_B6.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string TenKhachHang, string MatKhau)
        {
            
            // khai baos vaf connect sql
            string strsql = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
            SqlConnection cn = new SqlConnection(strsql);
            cn.Open();//
            //cau lenh truy van 
            string str = "select *from tbl_KhachHang where TenKhachHang = N'"+TenKhachHang+"' and MatKhau = '"+MatKhau+"'";
            SqlDataAdapter da = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow r in dt.Rows)
            {
                KhachHang a = new KhachHang();
                a.TenKhachHang = r["TenKhachHang"].ToString();
                a.MatKhau = r["MatKhau"].ToString();
                Session["KhachHang"] = a;
            }

            return RedirectToAction("Trang Chu","Home");
        }
        public ActionResult TrangChu()
        {
            return View();
        }

    }
}
