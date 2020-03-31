using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AwardBLL;
using Entities;

namespace WebApp.Controllers
{
    public class AwardController : Controller
    {
        private static string _answer = "";
        private static List<Award> _awardsList;
        private AwardLogic _awardLogic;

        public AwardController()
        {
            _awardLogic = new AwardLogic();
        }

        public ViewResult Awards()
        {
            ViewBag.Title = "Awards";
            ViewData["Result"] = _answer;
            if (_awardsList == null)
                _awardsList = _awardLogic.GetAllAwards();
            ViewData["Awards"] = _awardsList;
            return View();
        }
        [HttpPost]
        public ActionResult Add(string tittle)
        {
            ViewBag.Title = "Awards";

            if (string.IsNullOrEmpty(tittle))
            {
                    ModelState.AddModelError("Titte", "Пустое поле");
            }
            
            if(ModelState.IsValid)
            {
                    var  award = new Award(int.MaxValue, tittle);
                    var awardFromDb = _awardLogic.CreateAward(award);
                    _awardsList.Add(awardFromDb);
                    return RedirectToAction("Awards");
            }
            return RedirectToAction("Awards");
        }
        
        [HttpPost]
        public ActionResult Delete(int idAward)
        {
            ViewBag.Title = "Awards";
            _awardsList.Remove(_awardsList.First(id => id.IdAward == idAward));
            _answer = _awardLogic.DeleteAward(idAward);
            return RedirectToAction("Awards");
        }

    }
}