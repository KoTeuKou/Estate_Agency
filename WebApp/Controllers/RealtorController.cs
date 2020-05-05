using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CityBLL;
using Entities;
using RealtorBLL;
using HouseBLL;
using OwnerBLL;
using RealtorBLL;
using StreetBLL;

namespace WebApp.Controllers
{
    public class RealtorController : Controller
    {
        private static string _answer = "";
        private static List<Realtor> _realtorsList;
        private static List<House> _housesList;
        private static List<Street> _streetsList;
        private static List<City> _citiesList;
        private static List<Owner> _ownersList;
        private RealtorLogic _realtorLogic;
        private HouseLogic _houseLogic;
        private StreetLogic _streetLogic;
        private CityLogic _cityLogic;
        private OwnerLogic _ownerLogic;


        public RealtorController()
        {
            _houseLogic = new HouseLogic();
            _streetLogic = new StreetLogic();
            _cityLogic = new CityLogic();
            _ownerLogic = new OwnerLogic();
            _realtorLogic = new RealtorLogic();
        }

        public ViewResult Realtors()
        {
            ViewBag.Title = "Realtors";
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

            ViewData["Realtors"] = _realtorsList;
            ViewData["Houses"] = _housesList;
            ViewData["Streets"] = _streetsList;
            ViewData["Cities"] = _citiesList;
            ViewData["Owners"] = _ownersList;
            return View();
        }
        [HttpPost]
        public ActionResult Add(string realtorName)
        {
            ViewBag.Title = "Realtors";
            if(ModelState.IsValid)
            {
                var  realtor = new Realtor(realtorName);
                var realtorFromDb = _realtorLogic.Create(realtor);
                _realtorsList.Add(realtorFromDb);
                return RedirectToAction("Realtors");
            }
            return RedirectToAction("Realtors");
        }
        
        [HttpPost]
        public ActionResult Delete(int idRealtor)
        {
            ViewBag.Title = "Realtors";
            _realtorsList.Remove(_realtorsList.First(id => id.IdRealtor == idRealtor));
            _answer = _realtorLogic.Delete(idRealtor);
            return RedirectToAction("Realtors");
        }
       
        public ActionResult SortByRealtorName()
        {
            ViewBag.Title = "Realtors";
            _realtorsList = _realtorLogic.GetSortedByRealtorName(_realtorsList);
            return RedirectToAction("Realtors");
        }
        public ActionResult SortByExperience()
        {
            ViewBag.Title = "Realtors";
            _realtorsList = _realtorLogic.GetSortedByNumOfContracts(_realtorsList);
            return RedirectToAction("Realtors");
        }
    }
}