using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;
using WEBGIAY.Models;

namespace WEBGIAY.ApiControllers
{
    public class LoaiSanPhamController : ApiController
    {
        public List<loaiSanPham> GetLoaiSanPhams()
        {
            DbContextWebGiay db = new DbContextWebGiay();
            List<loaiSanPham> lsps = db.loaiSanPhams.ToList();
            return lsps;
        }

        public loaiSanPham GetmaLoaiSanPham(int ID)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            loaiSanPham lsp = db.loaiSanPhams.Where(row => row.maLoaiSP == ID).FirstOrDefault();
            return lsp;
        }

        public void PostLoaiSanPham(loaiSanPham newLoai)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            db.loaiSanPhams.Add(newLoai);
            db.SaveChanges();
        }

        public void PutLoaiSanPham(loaiSanPham loai)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            loaiSanPham oldLoai = db.loaiSanPhams.Where(r => r.maLoaiSP == loai.maLoaiSP).FirstOrDefault();
            oldLoai.tenLoaiSP = loai.tenLoaiSP;
            db.SaveChanges();
        }

        public void DeleteLoaiSanPham(int id)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            loaiSanPham oldLsp = db.loaiSanPhams.Where(r => r.maLoaiSP == id).FirstOrDefault();
            db.loaiSanPhams.Remove(oldLsp);
            db.SaveChanges();
        }
    }
}
