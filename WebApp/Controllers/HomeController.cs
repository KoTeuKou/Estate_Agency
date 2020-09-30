using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {}
        
        public ActionResult Index()
        {
            return View();
        }
    }
}