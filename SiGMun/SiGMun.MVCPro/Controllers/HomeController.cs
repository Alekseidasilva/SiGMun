﻿using System.Web.Mvc;

namespace SiGMun.MVCPro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}