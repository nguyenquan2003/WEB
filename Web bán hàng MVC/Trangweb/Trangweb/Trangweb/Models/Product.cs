using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Trangweb.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [RegularExpression(@"^[A-Za-z0-9À-ỹ\s]+$", ErrorMessage = "Tên chỉ được phép chứa chữ cái, số và khoảng trắng.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Vui lòng nhập số")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập miêu tả")]
        public string MieuTa { get; set; }
     
        public string Image { get; set; }


        [Required(ErrorMessage = "Vui lòng chọn phòng ban")]
        public int Id_Category { get; set; }

        public virtual Category Category { get; set; }
    }
}