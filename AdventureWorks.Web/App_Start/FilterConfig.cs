﻿using System.Web.Mvc;
using AdventureWorks.Web.Helpers.Attributes;

namespace AdventureWorks.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleAntiforgeryTokenErrorAttribute { ExceptionType = typeof(HttpAntiForgeryException) });
        }
    }
}
