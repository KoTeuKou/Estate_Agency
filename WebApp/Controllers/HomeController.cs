using System.Collections.Generic;
using System.Web.Mvc;
using CustomerBLL;
using Entities;
using OwnerBLL;

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
        public ActionResult IndexLogged()
        {
            return View();
        }
        
        public ActionResult IndexLoggedAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string login)
        {
            if (login == "admin")
                return RedirectToAction("IndexLoggedAdmin");
            if (login == "user")
                return RedirectToAction("IndexLogged");
            return RedirectToAction("Index");
        }
        
    }
}