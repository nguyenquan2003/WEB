using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ON.Models;

namespace ON.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        List<SanPham> dsSanPham = new List<SanPham>();

        string strcon = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
        public ActionResult SanPham()
        {

            //b1: connect voi Sql

            SqlConnection cn = new SqlConnection(strcon);// tao cho no 1 cai ket noi moi
            //tao cau truy van va xu ly
            string strsql = "Select * from tbl_SanPham";
            SqlDataAdapter ds = new SqlDataAdapter(strsql, cn);
            // b3: do du lieu vao doi tuong luu tru
            DataTable dt = new DataTable();
            ds.Fill(dt);

            // b4: tao doi tuong bang phuong thuc cua doi tuong
            foreach (DataRow r in dt.Rows)
            {
                SanPham n = new SanPham();
                n.TenSP = r["TenSP"].ToString();
                n.Gia = (double)r["Gia"];
                dsSanPham.Add(n);
            }

            return View(dsSanPham);
        }



        List<KhachHang> dsKhachHang = new List<KhachHang>();
        public ActionResult KhachHang()
        {

            //b1: connect voi Sql

            SqlConnection cn = new SqlConnection(strcon);// tao cho no 1 cai ket noi moi
            //tao cau truy van va xu ly
            string strsql = "Select * from tbl_KhachHang";
            SqlDataAdapter ds = new SqlDataAdapter(strsql, cn);
            // b3: do du lieu vao doi tuong luu tru
            DataTable dt = new DataTable();
            ds.Fill(dt);

            // b4: tao doi tuong bang phuong thuc cua doi tuong
            foreach (DataRow r in dt.Rows)
            {
                KhachHang n = new KhachHang();
                n.MaKhachHang = (int)r["MaKhachHang"];
                n.TenKhachHang = r["TenKhachHang"].ToString();
                n.SoDienThoai = r["SoDienThoai"].ToString();
                n.MatKhau = r["MatKhau"].ToString();
                dsKhachHang.Add(n);
            }

            return View(dsKhachHang);
        }



        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
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
                sql += "values (N'" + a.MaKhachHang + "',N'" + a.TenKhachHang + "',N'" + a.SoDienThoai + "', " + a.MatKhau + ")";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                rs = cmd.ExecuteNonQuery();
            }
            cn.Close();
            return RedirectToAction("KhachHang", "Home");
        }



        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string TenKhachHang, string MatKhau)
        {

            // khai baos vaf connect sql
            
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();//
            //cau lenh truy van 
            string str = "select *from tbl_KhachHang where TenKhachHang = N'" + TenKhachHang + "' and MatKhau = '" + MatKhau + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                KhachHang a = new KhachHang();
                a.TenKhachHang = r["TenKhachHang"].ToString();
                a.MatKhau = r["MatKhau"].ToString();
                Session["KhachHang"] = a;
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult ChiTiet(int Id)
        {
            int i = 0;
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string sql1 = "Select * from tbl_SanPham where DeptId =" + Id;
            SqlDataAdapter adt = new SqlDataAdapter(sql1, cn);
            DataTable ds = new DataTable();
            adt.Fill(ds);
            string sql2 = "Select count(*) from tbl_Employee where DeptId = " + Id;
            SqlCommand td = new SqlCommand(sql2, cn);
            i = (int)td.ExecuteScalar();
            SanPham a = new SanPham();
            foreach (DataRow n in ds.Rows)
            {
                a.MaSanPham = n["MaSanPham"].ToString();
                a.TenSP = n["TenSP"].ToString();
                a.MaL = (int)n["MaL"];
                a.MaSX = (int)n["MaSX"];
                a.GhiChu = n["GhiChu"].ToString();
            }
            ViewBag.sl = i;
            return View(a);
        }
        /*string strcon = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
        public ActionResult SanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            SanPham a = new SanPham();
            //ket noi lai voi sever
            SqlConnection cn = new SqlConnection(strcon);
            //tao cau truy van can xu ly
            string str = "Select * from tbl_SanPham";
            SqlDataAdapter ds = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            //tao phuong thuc tu doi tuong
            foreach (DataRow n in dt.Rows)
            {
                a.TenSP = n["TenSP"].ToString();
                a.Gia = (double)n["Gia"];
                
                dsSanPham.Add(a);
            }
            return View(dsSanPham);
        }*/
        /*string str = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
        public ActionResult SanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            //kết nối SQL
            SqlConnection cn = new SqlConnection(str);
            //Tạo câu truy vấn
            string strcon = "select * from tbl_SanPham";
            SqlDataAdapter dt = new SqlDataAdapter(strcon, cn);
            //Đổ dữ liệu nào nơi lưu trữ
            DataTable ds = new DataTable();
            dt.Fill(ds);
            foreach(DataRow a in ds.Rows)
            {
                SanPham b = new SanPham();
                b.TenSP = a["TenSP"].ToString();
                b.Gia = (double)a["Gia"];
                dsSanPham.Add(b);
            }
            cn.Close();
            return View(dsSanPham);
        }*/
        /*[HttpPost]
        public ActionResult DangNhap(string TenKhachHang, string MatKhau)
        {
            string strsql = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
            SqlConnection cn = new SqlConnection(strsql);
            cn.Open();
            string str = "select *from tbl_KhachHang where TenKhachHang = N'" + TenKhachHang + "' and MatKhau = '" + MatKhau + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                KhachHang a = new KhachHang();
                a.TenKhachHang = r["TenKhachHang"].ToString();
                a.MatKhau = r["MatKhau"].ToString();
                Session["KhachHang"] = a;
            }

            return RedirectToAction("Index", "Home");
        }*/
    }
}
