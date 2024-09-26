namespace WEBGIAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("donHang")]
    public partial class donHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public donHang()
        {
            chiTietDonHangs = new HashSet<chiTietDonHang>();
        }

        [Key]
        public int maDon { get; set; }

        public DateTime? ngayDat { get; set; }

        public int? tinhTrang { get; set; }

        public int? maNguoiDung { get; set; }

        public double? thanhToan { get; set; }

        public string diaChiNhanHang { get; set; }

        public int? tongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chiTietDonHang> chiTietDonHangs { get; set; }

        public virtual nguoiDung nguoiDung { get; set; }
    }
}
