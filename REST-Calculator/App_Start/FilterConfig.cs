﻿using System.Web;
using System.Web.Mvc;

namespace REST_Calculator
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}