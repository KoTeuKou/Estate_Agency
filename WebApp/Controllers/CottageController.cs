using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BLLInterfaces;
using Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CottageController : Controller
    {
        private ICottageLogic _cottageLogic;
        private readonly IMapper _mapper;

        public CottageController(ICottageLogic cottageLogic, IStreetLogic streetLogic,ICityLogic cityLogic, IOwnerLogic ownerLogic, IMapper mapper)
        {
            _cottageLogic = cottageLogic;
            _mapper = mapper;

            ViewData["Streets"] = _mapper.Map<IEnumerable<StreetVm>>(streetLogic.GetAll());
            ViewData["Cities"] = _mapper.Map<IEnumerable<CityVm>>(cityLogic.GetAll());
            ViewData["Owners"] = _mapper.Map<IEnumerable<OwnerVm>>(ownerLogic.GetAll());
        }

        public CottageController()
        {
        }

        public ViewResult Cottages()
        {
            ViewBag.Title = "Cottages";
            var cottages = _cottageLogic.GetAll();
            var cottagesVm = _mapper.Map<IEnumerable<CottageModelVm>>(cottages);
            return View(cottagesVm);
        }
        
        public ViewResult AddCottage()
        {
            return View(new CottageModelVm());
        }
        
        public ViewResult CottageFilter()
        {
            return View(new CottageFilterVm());
        }
        
        [HttpPost]
        public ActionResult Add(CottageModelVm cottageModel)
        {
            _cottageLogic.Create(_mapper.Map<CottageModelVm, Cottage>(cottageModel));
            return RedirectToAction("Cottages");
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Cottages";
            _cottageLogic.Delete(id);
            return RedirectToAction("Cottages");
        }
        
        [HttpPost]
        public ActionResult GetCottagesByFilters(CottageFilterVm filterVm)
        {
            ViewBag.Title = "Cottages";
            _cottageLogic.GetCottagesByFilters(_mapper.Map<CottageFilterVm, CottageFilter>(filterVm));
            return RedirectToAction("Cottages");
        }
        public ActionResult SortByField(SortBy sortBy)
        {
            ViewBag.Title = "Cottages";
            _cottageLogic.GetSortedBy(sortBy);
            return RedirectToAction("Cottages");
        }
        
    }
}