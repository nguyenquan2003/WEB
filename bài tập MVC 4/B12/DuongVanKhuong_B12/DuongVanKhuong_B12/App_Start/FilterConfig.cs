﻿using System.Web;
using System.Web.Mvc;

namespace DuongVanKhuong_B12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}