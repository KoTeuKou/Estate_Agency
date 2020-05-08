using System.Collections.Generic;
using System.Web.Mvc;
using CustomerBLL;
using Entities;
using OwnerBLL;

namespace WebApp.Controllers
{
    public class LogInLogOutController : Controller
    {
        public LogInLogOutController()
        {
        }
        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        

        [HttpGet]
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}