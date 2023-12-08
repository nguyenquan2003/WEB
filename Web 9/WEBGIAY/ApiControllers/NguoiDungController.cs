using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WEBGIAY.Models;

namespace WEBGIAY.ApiControllers
{
    public class NguoiDungController : ApiController
    {
        public List<nguoiDung> GetNguoiDungs()
        {
            DbContextWebGiay db = new DbContextWebGiay();
            List<nguoiDung> nguoiDungs = db.nguoiDungs.ToList();
            return nguoiDungs;
        }

        public nguoiDung GetNguoiDung(int ID)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            nguoiDung nguoiDung = db.nguoiDungs.Where(row => row.maNguoiDung == ID).FirstOrDefault();
            return nguoiDung;
        }

        public void PostNguoiDung(nguoiDung newNguoiDung)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            db.nguoiDungs.Add(newNguoiDung);
            db.SaveChanges();
        }

        public void PutNguoiDung(nguoiDung nguoiDung)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            nguoiDung oldNguoiDung = db.nguoiDungs.Where(r => r.maNguoiDung == nguoiDung.maNguoiDung).FirstOrDefault();

            if (oldNguoiDung != null)
            {
                oldNguoiDung.tenNguoiDung = nguoiDung.tenNguoiDung;
                oldNguoiDung.matKhau = nguoiDung.matKhau;
                oldNguoiDung.eMail = nguoiDung.eMail;
                oldNguoiDung.dienThoai = nguoiDung.dienThoai;
                oldNguoiDung.IdQuyen = nguoiDung.IdQuyen;
                oldNguoiDung.diaChi = nguoiDung.diaChi;

                db.SaveChanges();
            }
        }

        public void DeleteNguoiDung(int id)
        {
            DbContextWebGiay db = new DbContextWebGiay();
            nguoiDung oldNguoiDung = db.nguoiDungs.Where(r => r.maNguoiDung == id).FirstOrDefault();

            if (oldNguoiDung != null)
            {
                db.nguoiDungs.Remove(oldNguoiDung);
                db.SaveChanges();
            }
        }
    }
}