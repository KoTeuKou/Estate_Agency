using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CityBLL;
using Entities;
using FlatBLL;
using HouseBLL;
using Microsoft.Ajax.Utilities;
using OwnerBLL;
using RealtorBLL;
using StreetBLL;

namespace WebApp.Controllers
{
    public class FlatController : Controller
    {
        private static string _answer = "";
        private static List<Flat> _flatsList;
        private static List<House> _housesList;
        private static List<Street> _streetsList;
        private static List<City> _citiesList;
        private static List<Owner> _ownersList;
        private static List<Realtor> _realtorsList;
        private FlatLogic _flatLogic;
        private HouseLogic _houseLogic;
        private StreetLogic _streetLogic;
        private CityLogic _cityLogic;
        private OwnerLogic _ownerLogic;
        private RealtorLogic _realtorLogic;


        public FlatController()
        {
            _flatLogic = new FlatLogic();
            _houseLogic = new HouseLogic();
            _streetLogic = new StreetLogic();
            _cityLogic = new CityLogic();
            _ownerLogic = new OwnerLogic();
            _realtorLogic = new RealtorLogic();
        }

        public ViewResult Flats()
        {
            ViewBag.Title = "Flats";
            ViewData["Result"] = _answer;
            if (_flatsList == null)
                _flatsList = _flatLogic.GetAll();
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
            
            ViewData["Flats"] = _flatsList;
            ViewData["Houses"] = _housesList;
            ViewData["Streets"] = _streetsList;
            ViewData["Cities"] = _citiesList;
            ViewData["Owners"] = _ownersList;
            ViewData["Realtors"] = _realtorsList;
            return View();
        }
        [HttpPost]
        public ActionResult Add(int flatNumber, int floorNumber, double squareOfFlat, int numOfRooms, int price, string owner, string addStreetSelection, int addHouseNumSelection)
        {
            ViewBag.Title = "Flats";
            int idOwner = _ownersList.Find(x => x.OwnerName == owner).IdOwner;
            int idHouse = _housesList.Find(x => x.HouseNum == addHouseNumSelection && x.StreetName == addStreetSelection).IdHouse;
            if(ModelState.IsValid)
            {
                var  flat = new Flat(flatNumber, floorNumber, squareOfFlat, numOfRooms, price, idOwner, idHouse);
                var flatFromDb = _flatLogic.Create(flat);
                _flatsList.Add(flatFromDb);
            }
            return RedirectToAction("Flats");
        }
        
        [HttpPost]
        public ActionResult Delete(int idFlat)
        {
            ViewBag.Title = "Flats";
            _flatsList.Remove(_flatsList.First(id => id.IdFlat == idFlat));
            _answer = _flatLogic.Delete(idFlat);
            return RedirectToAction("Flats");
        }
        public ActionResult GetFlatsByFilters(string flNumMin, string flNumMax, string sqMin, string sqMax, 
            string numOfRmsMin, string numOfRmsMax, string priceMin, string priceMax,
            string citySelection, string streetSelection, string houseNumSelection)
        {
            ViewBag.Title = "Flats";
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
            _flatsList = _flatLogic.GetFlatsByFilters(int.Parse(flNumMin), int.Parse(flNumMax), 
                double.Parse(sqMin), double.Parse(sqMax), int.Parse(numOfRmsMin),
                int.Parse(numOfRmsMax), int.Parse(priceMin), int.Parse(priceMax),
                numOfHouseMin, numOfHouseMax,
                citySelection, streetSelection);
            return RedirectToAction("Flats");
        }
        public ActionResult SortByFlatNumber()
        {
            ViewBag.Title = "Flats";
            _flatsList = _flatLogic.GetSortedByFlatNumber(_flatsList);
            return RedirectToAction("Flats");
        }
        public ActionResult SortByFloorNumber()
        {
            ViewBag.Title = "Flats";
            _flatsList = _flatLogic.GetSortedByFloorNumber(_flatsList);
            return RedirectToAction("Flats");
        }
        public ActionResult SortBySquare()
        {
            ViewBag.Title = "Flats";
            _flatsList = _flatLogic.GetSortedBySquare(_flatsList);
            return RedirectToAction("Flats");
        }
        public ActionResult SortByNumOfRooms()
        {
            ViewBag.Title = "Flats";
            _flatsList = _flatLogic.GetSortedByNumOfRooms(_flatsList);
            return RedirectToAction("Flats");
        }
        public ActionResult SortByPrice()
        {
            ViewBag.Title = "Flats";
            _flatsList = _flatLogic.GetSortedByPrice(_flatsList);
            return RedirectToAction("Flats");
        }
        public ActionResult Reload()
        {
            ViewBag.Title = "Flats";
            _flatsList = _flatLogic.GetAll();
            return RedirectToAction("Flats");
        }
        public ActionResult MakeContract(int id_building, string realtorName, int id_customer, string saleOrRent)
        {
            ViewBag.Title = "Flats";
            Realtor realtor = _realtorsList.Find(realtor1 => realtor1.RealtorName == realtorName);
            int id_realtor = realtor.IdRealtor;
            _flatLogic.MakeContract(id_building, id_realtor, id_customer, saleOrRent);
            _flatsList = _flatLogic.GetAll();
            return RedirectToAction("Flats");
        }
    }
}