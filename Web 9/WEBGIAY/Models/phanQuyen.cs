namespace WEBGIAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phanQuyen")]
    public partial class phanQuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phanQuyen()
        {
            nguoiDungs = new HashSet<nguoiDung>();
        }

        [Key]
        public int IdQuyen { get; set; }

        [StringLength(20)]
        public string tenQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nguoiDung> nguoiDungs { get; set; }
    }
}
