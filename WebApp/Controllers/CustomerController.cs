using System.Collections.Generic;
using System.Web.Mvc;
using CityBLL;
using CustomerBLL;
using Entities;


namespace WebApp.Controllers
{
    public class CustomerController : Controller
    {
        private static string _answer = "";
        private static List<City> _citiesList;
        private static List<Customer> _customersList;
        private CityLogic _cityLogic;
        private CustomerLogic _customerLogic;

        public CustomerController()
        {
            _cityLogic = new CityLogic();
            _customerLogic = new CustomerLogic();
        }

        public ViewResult RegistrationForm()
        {
            ViewBag.Title = "Customers";
            ViewData["Result"] = _answer;
            if (_customersList == null)
                _customersList = _customerLogic.GetAll();
            if (_citiesList == null)
                _citiesList = _cityLogic.GetAll();
            
            ViewData["Cities"] = _citiesList;
            ViewData["Customers"] = _customersList;
            return View();
        }
        [HttpPost]
        public ActionResult Registration(string surname, string name, string city)
        {
            ViewBag.Title = "Customers";
            string fullName = surname + " " + name;
            if (_customersList.Find(x => x.CustomerName == fullName) == null)
            {
                int idCity = _citiesList.Find(city1 => city1.CityName == city).IdCity;
                if (ModelState.IsValid)
                {
                    var customer = new Customer(idCity,fullName);
                    var customerFromDb = _customerLogic.Create(customer);
                    _customersList.Add(customerFromDb);
                    return RedirectToAction("RegistrationForm");
                }
            }

            return RedirectToAction("RegistrationForm");
        }
        [HttpPost]
        public ActionResult Login(string surname, string name)
        {
            ViewBag.Title = "Customers";
            string fullName = surname + " " + name;
            var user = _customersList.Find(x => x.CustomerName == fullName);
            if ( user!= null)
            {
            }
        
            return RedirectToAction("RegistrationForm");
        }
    }
}