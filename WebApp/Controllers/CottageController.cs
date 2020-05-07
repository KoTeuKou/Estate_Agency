using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CityBLL;
using Entities;
using CottageBLL;
using HouseBLL;
using Microsoft.Ajax.Utilities;
using OwnerBLL;
using RealtorBLL;
using StreetBLL;

namespace WebApp.Controllers
{
    public class CottageController : Controller
    {
        private static string _answer = "";
        private static List<Cottage> _cottagesList;
        private static List<House> _housesList;
        private static List<Street> _streetsList;
        private static List<City> _citiesList;
        private static List<Owner> _ownersList;
        private static List<Realtor> _realtorsList;
        private CottageLogic _cottageLogic;
        private HouseLogic _houseLogic;
        private StreetLogic _streetLogic;
        private CityLogic _cityLogic;
        private OwnerLogic _ownerLogic;
        private RealtorLogic _realtorLogic;


        public CottageController()
        {
            _cottageLogic = new CottageLogic();
            _houseLogic = new HouseLogic();
            _streetLogic = new StreetLogic();
            _cityLogic = new CityLogic();
            _ownerLogic = new OwnerLogic();
            _realtorLogic = new RealtorLogic();
        }

        public ViewResult Cottages()
        {
            ViewBag.Title = "Cottages";
            ViewData["Result"] = _answer;
            if (_cottagesList == null)
                _cottagesList = _cottageLogic.GetAll();
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
            if (_realtorsList == null)
                _realtorsList = _realtorLogic.GetAll();
            
            ViewData["Cottages"] = _cottagesList;
            ViewData["Houses"] = _housesList;
            ViewData["Streets"] = _streetsList;
            ViewData["Cities"] = _citiesList;
            ViewData["Owners"] = _ownersList;
            ViewData["Realtors"] = _realtorsList;
            return View();
        }
        [HttpPost]
        public ActionResult Add(int cottageNumber, int floorNumber, double squareOfCottage, int numOfRooms, int price, string owner, string citySelection, string addStreetSelection)
        {
            ViewBag.Title = "Cottages";
            int idOwner = _ownersList.Find(x => x.OwnerName == owner).IdOwner;
            int idStreet = _streetsList.Find(x => x.StreetName == addStreetSelection && x.CityName == citySelection).IdStreet;
            if(ModelState.IsValid)
            {
                var  cottage = new Cottage(cottageNumber, floorNumber, squareOfCottage, numOfRooms, price, idOwner, idStreet);
                var cottageFromDb = _cottageLogic.Create(cottage);
                _cottagesList.Add(cottageFromDb);
            }
            return RedirectToAction("Cottages");
        }
        
        [HttpPost]
        public ActionResult Delete(int idCottage)
        {
            ViewBag.Title = "Cottages";
            _cottagesList.Remove(_cottagesList.First(id => id.IdCottage == idCottage));
            _answer = _cottageLogic.Delete(idCottage);
            return RedirectToAction("Cottages");
        }
        public ActionResult GetCottagesByFilters(string flNumMin, string flNumMax, string sqMin, string sqMax, 
            string numOfRmsMin, string numOfRmsMax, string priceMin, string priceMax,
            string citySelection, string streetSelection, string houseNumSelection)
        {
            ViewBag.Title = "Cottages";
            if (flNumMin.Equals(""))
            {
                flNumMin = "1";
            }
            if (flNumMax.Equals(""))
            {
                flNumMax = "100000";
            }
            if (sqMin.Equals(""))
            {
                sqMin = "1";
            }
            if (sqMax.Equals(""))
            {
                sqMax = "1000";
            }
            if (numOfRmsMin.Equals(""))
            {
                numOfRmsMin = "1";
            }
            if (numOfRmsMax.Equals(""))
            {
                numOfRmsMax = "50";
            }
            if (priceMin.Equals(""))
            {
                priceMin = "0";
            }
            if (priceMax.Equals(""))
            {
                priceMax = "9999000";
            }
            if (citySelection.IsNullOrWhiteSpace())
            {
                citySelection = "";
            }
            if (streetSelection.IsNullOrWhiteSpace())
            {
                streetSelection = "";
            }
            int numOfHouseMin = 0;
            int numOfHouseMax = 100000;
            if (!houseNumSelection.IsNullOrWhiteSpace())
            {
                numOfHouseMin = int.Parse(houseNumSelection);
                numOfHouseMax = int.Parse(houseNumSelection);
            }
            _cottagesList = _cottageLogic.GetCottagesByFilters(int.Parse(flNumMin), int.Parse(flNumMax), 
                double.Parse(sqMin), double.Parse(sqMax), int.Parse(numOfRmsMin),
                int.Parse(numOfRmsMax), int.Parse(priceMin), int.Parse(priceMax),
                numOfHouseMin, numOfHouseMax,
                citySelection, streetSelection);
            return RedirectToAction("Cottages");
        }
        public ActionResult SortByCottageNumber()
        {
            ViewBag.Title = "Cottages";
            _cottagesList = _cottageLogic.GetSortedByCottageNumber(_cottagesList);
            return RedirectToAction("Cottages");
        }
        public ActionResult SortByFloorNumber()
        {
            ViewBag.Title = "Cottages";
            _cottagesList = _cottageLogic.GetSortedByFloorNumber(_cottagesList);
            return RedirectToAction("Cottages");
        }
        public ActionResult SortBySquare()
        {
            ViewBag.Title = "Cottages";
            _cottagesList = _cottageLogic.GetSortedBySquare(_cottagesList);
            return RedirectToAction("Cottages");
        }
        public ActionResult SortByNumOfRooms()
        {
            ViewBag.Title = "Cottages";
            _cottagesList = _cottageLogic.GetSortedByNumOfRooms(_cottagesList);
            return RedirectToAction("Cottages");
        }
        public ActionResult SortByPrice()
        {
            ViewBag.Title = "Cottages";
            _cottagesList = _cottageLogic.GetSortedByPrice(_cottagesList);
            return RedirectToAction("Cottages");
        }
        public ActionResult Reload()
        {
            ViewBag.Title = "Cottages";
            _cottagesList = _cottageLogic.GetAll();
            return RedirectToAction("Cottages");
        }
        public ActionResult MakeContract(int id_building, string realtorName, int id_customer, string saleOrRent)
        {
            ViewBag.Title = "Cottages";
            Realtor realtor = _realtorsList.Find(realtor1 => realtor1.RealtorName == realtorName);
            int id_realtor = realtor.IdRealtor;
            _cottageLogic.MakeContract(id_building, id_realtor, id_customer, saleOrRent);
            _cottagesList = _cottageLogic.GetAll();
            return RedirectToAction("Cottages");
        }
    }
}