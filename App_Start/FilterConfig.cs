﻿using System.Web;
using System.Web.Mvc;

namespace BenchMarkPartial4._8._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
