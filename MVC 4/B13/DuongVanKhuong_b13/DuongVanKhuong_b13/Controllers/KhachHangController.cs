using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DuongVanKhuong_b13.Models;

namespace DuongVanKhuong_b13.Controllers
{
    public class KhachHangController : Controller
    {
        //
        // GET: /KhachHang/
        DataClasses1DataContext data = new DataClasses1DataContext();
        string strcon = ConfigurationManager.ConnectionStrings["QLDonHangSachConnectionString"].ConnectionString;
        public ActionResult Index()
        {
            List<tbl_SanPham> dsSP = data.tbl_SanPhams.ToList();
            return View(dsSP);
        }
        public ActionResult Insert_KhachHang(KhachHang a)
        {
            // ket noi lai sever
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            int rs = 0;
            //kiem tra trung ma neu trung nhau khong them vao duoc
            string sql1 = "Select count(*) from tbl_KhachHang where MaKhachHang ='" + a.MaKhachHang + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, cn);
            int kt = (int)cmd1.ExecuteScalar();
            if (kt == 0)
            {
                string sql = "Insert into tbl_KhachHang (MaKhachHang,TenKhachHang,SoDienThoai, MatKhau)";
                sql += "values (N'" + a.MaKhachHang + "',N'" + a.TenKH + "',N'" + a.SoDienThoai + "', " + a.MatKhau + ")";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                rs = cmd.ExecuteNonQuery();
            }
            cn.Close();
            return RedirectToAction("KhachHang", "KhachHang");
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string TenKH, string MatKhau)
        {
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            int rs = 0;
            string str = "select *from tbl_KhachHang where TenKH = N'" + TenKH + "' and MatKhau = '" + MatKhau + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, cn);
            //int rs = da.ExecuteNonQuery();
            return RedirectToAction("DangKy", "KhachHang");
        }
        public ActionResult DangKy()
        {
            return View();
        }
    }
}
