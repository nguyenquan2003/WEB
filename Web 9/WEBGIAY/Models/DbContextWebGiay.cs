using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WEBGIAY.Models
{
    public partial class DbContextWebGiay : DbContext
    {
        public DbContextWebGiay()
            : base("name=DbContextWebGiay")
        {
        }

        public virtual DbSet<chiTietDonHang> chiTietDonHangs { get; set; }
        public virtual DbSet<donHang> donHangs { get; set; }
        public virtual DbSet<loaiSanPham> loaiSanPhams { get; set; }
        public virtual DbSet<nguoiDung> nguoiDungs { get; set; }
        public virtual DbSet<phanQuyen> phanQuyens { get; set; }
        public virtual DbSet<sanPham> sanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<donHang>()
                .HasMany(e => e.chiTietDonHangs)
                .WithRequired(e => e.donHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nguoiDung>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<nguoiDung>()
                .Property(e => e.dienThoai)
                .IsFixedLength();

            modelBuilder.Entity<sanPham>()
                .HasMany(e => e.chiTietDonHangs)
                .WithRequired(e => e.sanPham)
                .WillCascadeOnDelete(false);
        }
    }
}
