using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiGMun.MVCPro.Controllers
{
    public class ContaController : Controller
    {
        // GET: Conta
        public ActionResult Login()
        {
            return View();
        }
    }
}