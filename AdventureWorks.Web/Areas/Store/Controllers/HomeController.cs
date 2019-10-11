﻿using System.Web.Mvc;

namespace AdventureWorks.Web.Areas.Store.Controllers
{
    public class HomeController : Controller
    {
        // GET: Store/Home
        public ActionResult Index()
        {
            if (!ControllerContext.RouteData.DataTokens.ContainsKey("area"))
                ControllerContext.RouteData.DataTokens.Add("area", "Store");

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult DisplayTopMenu()
        {
            // TODO: model -> mark active

            return PartialView("_Partial_TopMenu");
        }

        [ChildActionOnly]
        public PartialViewResult DisplayMessagesMenu()
        {
            return PartialView("_Partial_MessagesMenu");
        }

        [ChildActionOnly]
        public PartialViewResult DisplayNotificationsMenu()
        {
            return PartialView("_Partial_NotificationsMenu");
        }

        [ChildActionOnly]
        public PartialViewResult DisplayTasksMenu()
        {
            return PartialView("_Partial_TasksMenu");
        }

        [ChildActionOnly]
        public PartialViewResult DisplayUserMenu()
        {
            return PartialView("_Partial_UserMenu");
        }

        // GET: Store/Home/Test
        public ActionResult Test()
        {
            return View();
        }
    }
}