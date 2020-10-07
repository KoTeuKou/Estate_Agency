using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BLLInterfaces;
using Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FlatController : Controller
    {
        private IFlatLogic _flatLogic;
        private readonly IMapper _mapper;

        public FlatController(IFlatLogic flatLogic, IStreetLogic streetLogic,ICityLogic cityLogic, IOwnerLogic ownerLogic, IHouseLogic houseLogic, IMapper mapper)
        {
            _flatLogic = flatLogic;
            _mapper = mapper;
            
            ViewData["Streets"] = _mapper.Map<IEnumerable<StreetVm>>(streetLogic.GetAll());
            ViewData["Cities"] = _mapper.Map<IEnumerable<CityVm>>(cityLogic.GetAll());
            ViewData["Owners"] = _mapper.Map<IEnumerable<OwnerVm>>(ownerLogic.GetAll());
            ViewData["Houses"] = _mapper.Map<IEnumerable<HouseVm>>(houseLogic.GetAll());
        }

        public FlatController()
        {
        }

        public ViewResult Flats()
        {
            ViewBag.Title = "Flats";
            var flats = _flatLogic.GetAll();
            var flatsVm = _mapper.Map<IEnumerable<FlatModelVm>>(flats);
            return View(flatsVm);
        }

        public ViewResult AddFlat()
        {
            return View(new FlatModelVm());
        }

        public ViewResult FlatFilter()
        {
            return View(new FlatFilterVm());
        }

        [HttpPost]
        public ActionResult Add(FlatModelVm flatModel)
        {
            _flatLogic.Create(_mapper.Map<FlatModelVm, Flat>(flatModel));
            return RedirectToAction("Flats");
        }

        [HttpPost]
        public ActionResult Delete(int idFlat)
        {
            ViewBag.Title = "Flats";
            _flatLogic.Delete(idFlat);
            return RedirectToAction("Flats");
        }

        [HttpPost]
        public ActionResult GetFlatsByFilters(FlatFilterVm filterVm)
        {
            ViewBag.Title = "Flats";
            _flatLogic.GetFlatsByFilters(_mapper.Map<FlatFilterVm, FlatFilter>(filterVm));
            return RedirectToAction("Flats");
        }

        public ActionResult SortByField(SortBy sortBy)
        {
            ViewBag.Title = "Flats";
            _flatLogic.GetSortedBy(sortBy);
            return RedirectToAction("Flats");
        }
    }
}