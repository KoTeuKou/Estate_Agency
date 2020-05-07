﻿using System.Collections.Generic;
using System.Web.Mvc;
using CustomerBLL;
using Entities;
using OwnerBLL;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<Owner> _ownersList;
        private static List<Customer> _customersList;
        private OwnerLogic _ownerLogic;
        private CustomerLogic _customerLogic;
        public HomeController()
        {
            _ownerLogic = new OwnerLogic();
            _customerLogic = new CustomerLogic();
            _ownersList = _ownerLogic.GetAll();
            _customersList = _customerLogic.GetAll();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexLogged()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Login)
        {
            bool exist = _customersList.Find(x => x.CustomerName == Login) != null || 
                         _ownersList.Find(x => x.OwnerName == Login) != null;
            ViewBag.LogIn = exist;
            return RedirectToAction("IndexLogged");
        }
    }
}