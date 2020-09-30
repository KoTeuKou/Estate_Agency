using System.Collections.Generic;
using System.Web.Mvc;
using BLLInterfaces;
using Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CottageController : Controller
    {
        private ICottageLogic _cottageLogic;

        public CottageController(ICottageLogic cottageLogic)
        {
            _cottageLogic = cottageLogic;
        }

        public CottageController()
        {
        }

        public ViewResult Cottages()
        {
            ViewBag.Title = "Cottages";
            ViewData["Cottages"] = _cottageLogic.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Add(CottageModel model)
        {
            ViewBag.Title = "Cottages";
            if(ModelState.IsValid)
            {
                _cottageLogic.Create(new Cottage(model.CottageNumber, model.NumOfFloors, model.SquareOfCottage, model.NumOfRooms, model.Price));
            }
            return RedirectToAction("Cottages");
        }
        
        [HttpPost]
        public ActionResult Delete(int idCottage)
        {
            ViewBag.Title = "Cottages";
            _cottageLogic.Delete(idCottage);
            return RedirectToAction("Cottages");
        }
        
        [HttpPost]
        public ActionResult GetCottagesByFilters(CottageFilter filter)
        {
            ViewBag.Title = "Cottages";
          
            _cottageLogic.GetCottagesByFilters(int.Parse(filter.MaxFloorNumber), int.Parse(filter.MaxFloorNumber), 
                double.Parse(filter.MinSquareOfFlat), double.Parse(filter.MaxSquareOfFlat), int.Parse(filter.MinNumOfRooms),
                int.Parse(filter.MaxNumOfRooms), int.Parse(filter.MinPrice), int.Parse(filter.MaxPrice),
                filter.City, filter.Street);
            return RedirectToAction("Cottages");
        }
        public ActionResult SortByField(SortBy sortBy)
        {
            ViewBag.Title = "Cottages";
            _cottageLogic.GetSortedBy(sortBy);
            return RedirectToAction("Cottages");
        }
      
        public ActionResult Reload()
        {
            ViewBag.Title = "Cottages";
            _cottageLogic.GetAll();
            return RedirectToAction("Cottages");
        }
    }
}