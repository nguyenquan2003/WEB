namespace WEBGIAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nguoiDung")]
    public partial class nguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nguoiDung()
        {
            donHangs = new HashSet<donHang>();
        }

        [Key]
        public int maNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string tenNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string matKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string eMail { get; set; }

        [StringLength(10)]
        public string dienThoai { get; set; }

        public int? IdQuyen { get; set; }

        public string diaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donHang> donHangs { get; set; }

        public virtual phanQuyen phanQuyen { get; set; }
    }
}
