using System.Web.Mvc;
using BLLInterfaces;
using Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FlatController : Controller
    {
        private IFlatLogic _flatLogic;

        public FlatController(IFlatLogic flatLogic)
        {
            _flatLogic = flatLogic;
        }

        public ViewResult Flats()
        {
            ViewBag.Title = "Flats";
            ViewData["Flats"] = _flatLogic.GetAll();;
            return View();
        }
        [HttpPost]
        public ActionResult Add(FlatModel flatModel)
        {
            ViewBag.Title = "Flats";
            
            if(ModelState.IsValid)
            {
                _flatLogic.Create(new Flat(flatModel.FlatNumber, flatModel.FloorNumber, flatModel.SquareOfFlat,
                    flatModel.NumOfRooms, flatModel.Price));
            }
            return RedirectToAction("Flats");
        }
        
        [HttpPost]
        public ActionResult Delete(int idFlat)
        {
            ViewBag.Title = "Flats";
            _flatLogic.Delete(idFlat);
            return RedirectToAction("Flats");
        }
        public ActionResult GetFlatsByFilters(FlatFilter filter)
        {
            ViewBag.Title = "Flats";
            _flatLogic.GetFlatsByFilters(int.Parse(filter.MinFloorNumber), int.Parse(filter.MaxFloorNumber),
                double.Parse(filter.MinSquareOfFlat), double.Parse(filter.MaxSquareOfFlat), int.Parse(filter.MinNumOfRooms),
                int.Parse(filter.MaxNumOfRooms), int.Parse(filter.MinPrice), int.Parse(filter.MaxPrice),
                int.Parse(filter.NumOfHouse), int.Parse(filter.NumOfHouse), filter.City, filter.Street);
            return RedirectToAction("Flats");
        }
        public ActionResult SortByField(SortBy sortBy)
        {
            ViewBag.Title = "Flats";
            _flatLogic.GetSortedBy(sortBy);
            return RedirectToAction("Flats");
        }
        public ActionResult Reload()
        {
            ViewBag.Title = "Flats";
            _flatLogic.GetAll();
            return RedirectToAction("Flats");
        }
    }
}