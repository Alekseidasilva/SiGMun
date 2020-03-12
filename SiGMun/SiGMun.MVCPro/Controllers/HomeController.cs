using System.Web.Mvc;

namespace SiGMun.MVCPro.Controllers
{
   
    public class HomeController : Controller
    {

        // GET: Home
        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}