﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ON.Models
{
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string MatKhau { get; set; }
        public KhachHang()
        {

        }
    }
}