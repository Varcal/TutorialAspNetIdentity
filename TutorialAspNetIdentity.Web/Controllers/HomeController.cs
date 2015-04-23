using System.Web.Mvc;

namespace TutorialAspNetIdentity.Web.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult SignOut()
        {
            ViewBag.Message = "Sair";

            return View();
        }
    }
}
