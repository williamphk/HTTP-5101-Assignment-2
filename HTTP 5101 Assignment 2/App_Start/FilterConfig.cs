﻿using System.Web;
using System.Web.Mvc;

namespace HTTP_5101_Assignment_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
