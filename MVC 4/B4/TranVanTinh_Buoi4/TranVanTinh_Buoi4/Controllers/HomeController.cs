using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using TranVanTinh_Buoi4.Models;
using System.Configuration;
using System.Data;
namespace TranVanTinh_Buoi4.Controllers
{
    public class HomeController:Controller
    {
        //
        // GET: /Home/
        List<Employee> dsNhanSu = new List<Employee>();
        
        string strcon = ConfigurationManager.ConnectionStrings["strNhanSu"].ConnectionString;
        public ActionResult NhanSu()
        {

            //b1: connect voi Sql

            SqlConnection cn = new SqlConnection(strcon);// tao cho no 1 cai ket noi moi
            //tao cau truy van va xu ly
            string strsql = "Select * from tbl_Employee";
            SqlDataAdapter ds = new SqlDataAdapter(strsql, cn);
            // b3: do du lieu vao doi tuong luu tru
            DataTable dt = new DataTable();
            ds.Fill(dt);

            // b4: tao doi tuong bang phuong thuc cua doi tuong
            foreach(DataRow r in dt.Rows)
            {
                Employee n = new Employee();
                n.ID = (int)r["Id"];
                n.Name = r["Name"].ToString();
                n.Gender = r["Gender"].ToString();
                n.City = r["City"].ToString();
                n.Deptld = (int)r["DeptId"];
                dsNhanSu.Add(n);
            }

            return View(dsNhanSu);
        }
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert_Employee(Employee a)
        {
            // ket noi lai sever
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();

            int rs = 0;
            //kiem tra trung ten neu trung nhau khong them vao duoc
            string sql1 = "Select count(*) from tbl_Employee where Name ='" + a.Name + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, cn);
            int kt = (int)cmd1.ExecuteScalar();
            if(kt == 0)
            {
                string sql = "Insert into tbl_Employee (Name, Gender, City, DeptId)";
                sql += "values (N'" + a.Name + "',N'" + a.Gender + "',N'" + a.City + "', " + a.Deptld + ")";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                rs = cmd.ExecuteNonQuery(); 
            }
            cn.Close();
            return RedirectToAction("NhanSu", "Home");
        }
        public ActionResult PhongBan()
        {
            List<Deparment> dsPhong = new List<Deparment>();
            Deparment a = new Deparment();
            //ket noi lai voi sever
            SqlConnection cn = new SqlConnection(strcon);
            //tao cau truy van can xu ly
            string str = "Select * from tbl_Deparment";
            SqlDataAdapter ds = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            //tao phuong thuc tu doi tuong
            foreach(DataRow n in dt.Rows)
            {
                a.DeptId = (int)n["DeptId"];
                a.Name = n["Name"].ToString();
                dsPhong.Add(a);
            }
            return View(dsPhong);
        }
        public ActionResult ChiTiet(int Id)
        {
            int i = 0;
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            string sql1 = "Select * from tbl_Deparment where DeptId =" + Id;
            SqlDataAdapter adt = new SqlDataAdapter(sql1, cn);
            DataTable ds = new DataTable();
            adt.Fill(ds);
            string sql2 = "Select count(*) from tbl_Employee where DeptId = " + Id;
            SqlCommand td = new SqlCommand(sql2, cn);
            i = (int)td.ExecuteScalar();
            Deparment a = new Deparment();
            foreach(DataRow n in ds.Rows)
            {
                a.DeptId = (int)n["DeptId"];
                a.Name = n["Name"].ToString();
            }
            ViewBag.sl = i;
            return View(a);
        }
    }
}
