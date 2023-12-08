namespace WEBGIAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanPham")]
    public partial class sanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanPham()
        {
            chiTietDonHangs = new HashSet<chiTietDonHang>();
        }

        [Key]
        public int maSanPham { get; set; }

        [StringLength(100)]
        public string tenSanPham { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaySanXuat { get; set; }

        public int? soLuongSanPham { get; set; }

        public int? maLoaiSP { get; set; }

        public double? gia { get; set; }

        public string chuThichSanPham { get; set; }

        public string hinhAnh { get; set; }

        public string hinh1 { get; set; }

        public string hinh2 { get; set; }

        public string hinh3 { get; set; }

        public string hinh4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chiTietDonHang> chiTietDonHangs { get; set; }

        public virtual loaiSanPham loaiSanPham { get; set; }
    }
}
