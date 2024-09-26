namespace WEBGIAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chiTietDonHang")]
    public partial class chiTietDonHang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maSanPham { get; set; }

        public int? soLuong { get; set; }

        public double? donGia { get; set; }

        public double? thanhTien { get; set; }

        public int? phuongThucThanhToan { get; set; }

        public virtual donHang donHang { get; set; }

        public virtual sanPham sanPham { get; set; }
    }
}
