using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CityBLL;
using CottageBLL;
using CustomerBLL;
using Entities;
using FlatBLL;
using RealtorBLL;
using HouseBLL;
using OwnerBLL;
using StreetBLL;

namespace WebApp.Controllers
{
    public class AdministrationPanelController : Controller
    {
        private static string _answer = "";
        private static List<Realtor> _realtorsList;
        private static List<House> _housesList;
        private static List<Street> _streetsList;
        private static List<City> _citiesList;
        private static List<Owner> _ownersList;
        private static List<Cottage> _cottagesList;
        private static List<Flat> _flatsList;
        private static List<Customer> _customersList;
        private RealtorLogic _realtorLogic;
        private HouseLogic _houseLogic;
        private StreetLogic _streetLogic;
        private CityLogic _cityLogic;
        private OwnerLogic _ownerLogic;
        private CottageLogic _cottageLogic;
        private FlatLogic _flatLogic;
        private CustomerLogic _customerLogic;

        public AdministrationPanelController()
        {
            _houseLogic = new HouseLogic();
            _streetLogic = new StreetLogic();
            _cityLogic = new CityLogic();
            _ownerLogic = new OwnerLogic();
            _realtorLogic = new RealtorLogic();
            _cottageLogic = new CottageLogic();
            _flatLogic = new FlatLogic();
            _customerLogic = new CustomerLogic();
        }

        public ViewResult AdministrationPanel()
        {
            ViewBag.Title = "AdministrationPanel";
            ViewData["Result"] = _answer;
            if (_realtorsList == null)
                _realtorsList = _realtorLogic.GetAll();
            if (_housesList == null)
                _housesList = _houseLogic.GetAll();
            if (_streetsList == null)
                _streetsList = _streetLogic.GetAll();
            if (_citiesList == null)
                _citiesList = _cityLogic.GetAll();
            if (_citiesList == null)
                _citiesList = _cityLogic.GetAll();
            if (_ownersList == null)
                _ownersList = _ownerLogic.GetAll();
            if (_cottagesList == null)
                _cottagesList = _cottageLogic.GetAll();
            if (_flatsList == null)
                _flatsList = _flatLogic.GetAll();
            if (_customersList == null)
                _customersList = _customerLogic.GetAll();
            
            ViewData["Flats"] = _flatsList;
            ViewData["Cottages"] = _cottagesList;
            ViewData["Realtors"] = _realtorsList;
            ViewData["Houses"] = _housesList;
            ViewData["Streets"] = _streetsList;
            ViewData["Cities"] = _citiesList;
            ViewData["Owners"] = _ownersList;
            ViewData["Customers"] = _customersList;
            return View();
        }
        [HttpPost]
        public ActionResult AddRealtor(string realtorName)
        {
            ViewBag.Title = "AdministrationPanel";
            if(ModelState.IsValid)
            {
                var realtor = new Realtor(realtorName);
                var realtorFromDb = _realtorLogic.Create(realtor);
                _realtorsList.Add(realtorFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteRealtor(int idRealtor)
        {
            ViewBag.Title = "AdministrationPanel";
            _realtorsList.Remove(_realtorsList.First(x => x.IdRealtor == idRealtor));
            _answer = _realtorLogic.Delete(idRealtor);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddCottage(int cottageNumber, int floorNumber, double squareOfCottage, int numOfRooms, int price, string owner, string citySelection, string addStreetSelection)
        {
            ViewBag.Title = "AdministrationPanel";
            int idOwner = _ownersList.Find(owner1 => owner1.OwnerName == owner).IdOwner;
            int idStreet = _streetsList.Find(x => x.StreetName == addStreetSelection && x.CityName == citySelection).IdStreet;
            if(ModelState.IsValid)
            {
                var  cottage = new Cottage(cottageNumber, floorNumber, squareOfCottage, numOfRooms, price, idOwner, idStreet);
                var cottageFromDb = _cottageLogic.Create(cottage);
                _cottagesList.Add(cottageFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteCottage(int idCottage)
        {
            ViewBag.Title = "AdministrationPanel";
            _cottagesList.Remove(_cottagesList.First(x => x.IdCottage == idCottage));
            _answer = _cottageLogic.Delete(idCottage);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddFlat(int flatNumber, int floorNumber, double squareOfFlat, int numOfRooms, int price, string owner, string addStreetSelection, int addHouseNumSelection)
        {
            ViewBag.Title = "AdministrationPanel";
            int idOwner = _ownersList.Find(x => x.OwnerName == owner).IdOwner;
            int idHouse = _housesList.Find(x => x.HouseNum == addHouseNumSelection && x.StreetName == addStreetSelection).IdHouse;
            if(ModelState.IsValid)
            {
                var  flat = new Flat(flatNumber, floorNumber, squareOfFlat, numOfRooms, price, idOwner, idHouse);
                var flatFromDb = _flatLogic.Create(flat);
                _flatsList.Add(flatFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteFlat(int idFlat)
        {
            ViewBag.Title = "AdministrationPanel";
            _flatsList.Remove(_flatsList.First(x => x.IdFlat == idFlat));
            _answer = _flatLogic.Delete(idFlat);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddCity(string cityName)
        {
            ViewBag.Title = "AdministrationPanel";
            if(ModelState.IsValid)
            {
                var city = new City(cityName);
                var cityFromDb = _cityLogic.Create(city);
                _citiesList.Add(cityFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteCity(int idCity)
        {
            ViewBag.Title = "AdministrationPanel";
            _citiesList.Remove(_citiesList.First(x => x.IdCity == idCity));
            _answer = _cityLogic.Delete(idCity);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddStreet(string streetName, string cityName)
        {
            ViewBag.Title = "AdministrationPanel";
            if(ModelState.IsValid)
            {
                int idCity = _citiesList.Find(x => x.CityName == cityName).IdCity;
                var street = new Street(idCity, streetName);
                var streetFromDb = _streetLogic.Create(street);
                _streetsList.Add(streetFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteStreet(int idStreet)
        {
            ViewBag.Title = "AdministrationPanel";
            _streetsList.Remove(_streetsList.First(x => x.IdStreet == idStreet));
            _answer = _streetLogic.Delete(idStreet);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddHouse(int numOfHouse, int numOfFloors, string citySelectionHouse, string addStreetSelectionHouse)
        {
            ViewBag.Title = "AdministrationPanel";
            if(ModelState.IsValid)
            {
                int idStreet = _streetsList.Find(x => x.StreetName == addStreetSelectionHouse && x.CityName == citySelectionHouse).IdStreet;
                var house = new House(numOfHouse, numOfFloors, idStreet);
                var houseFromDb = _houseLogic.Create(house);
                _housesList.Add(houseFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteHouse(int idHouse)
        {
            ViewBag.Title = "AdministrationPanel";
            _housesList.Remove(_housesList.First(x => x.IdHouse == idHouse));
            _answer = _houseLogic.Delete(idHouse);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddCustomer(string surname, string name, string cityName)
        {
            ViewBag.Title = "AdministrationPanel";
            if(ModelState.IsValid)
            {
                string fullname = surname + " " + name;
                int idCity = _citiesList.Find(x => x.CityName == cityName).IdCity;
                var customer = new Customer(idCity, fullname);
                var customerFromDb = _customerLogic.Create(customer);
                _customersList.Add(customerFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteCustomer(int idCustomer)
        {
            ViewBag.Title = "AdministrationPanel";
            _customersList.Remove(_customersList.First(x => x.IdCustomer == idCustomer));
            _answer = _customerLogic.Delete(idCustomer);
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult AddOwner(string surname, string name)
        {
            ViewBag.Title = "AdministrationPanel";
            if(ModelState.IsValid)
            {
                string fullname = surname + " " + name;
                var owner = new Owner(fullname);
                var ownerFromDb = _ownerLogic.Create(owner);
                _ownersList.Add(ownerFromDb);
            }
            return RedirectToAction("AdministrationPanel");
        }
        
        [HttpPost]
        public ActionResult DeleteOwner(int idOwner)
        {
            ViewBag.Title = "AdministrationPanel";
            _ownersList.Remove(_ownersList.First(x => x.IdOwner == idOwner));
            _answer = _ownerLogic.Delete(idOwner);
            return RedirectToAction("AdministrationPanel");
        }
    }
}