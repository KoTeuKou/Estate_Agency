using System.Collections.Generic;
using System.Web.Mvc;
using CustomerBLL;
using Entities;
using OwnerBLL;

namespace WebApp.Controllers
{
    public class AuthorizationController : Controller
    {
        private static List<Owner> _ownersList;
        private static List<Customer> _customersList;
        private OwnerLogic _ownerLogic;
        private CustomerLogic _customerLogic;

        public AuthorizationController()
        {
            _ownerLogic = new OwnerLogic();
            _customerLogic = new CustomerLogic();
            _ownersList = _ownerLogic.GetAll();
            _customersList = _customerLogic.GetAll();
        }

        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            return View();
        }
        

        
    }
}