using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AwardBLL;
using Entities;
using UserBLL;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private UserLogic _userLogic;
        private AwardLogic _awardLogic;
        private static string _answer = "";
        private static List<User> _userList;
        private static List<Award> _awardsList;
        public UserController()
        {
            
            _userLogic = new UserLogic();
            _awardLogic = new AwardLogic();
        }
        
        public ViewResult List()
        {
            ViewBag.Title = "Users";
            ViewData["Result"] = _answer;
            if (_userList == null)
                _userList = _userLogic.GetAllUsers();
            ViewData["Users"] = _userList;
            ViewBag.Title = "Awards";
            ViewData["Result"] = _answer;
            if (_awardsList == null)
                _awardsList = _awardLogic.GetAllAwards();
            ViewData["Awards"] = _awardsList;
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, string name, string patronymic,
            string phoneNumber, string dateOfBirth)
        {
            ViewBag.Title = "Users";
            const string errorMessage = "Пустое поле";
                if (string.IsNullOrEmpty(surname))
                {
                    ModelState.AddModelError("Surname", errorMessage);
                }
                if (string.IsNullOrEmpty(name))
                {
                    ModelState.AddModelError("Name", errorMessage);
                }
                if (string.IsNullOrEmpty(patronymic))
                {
                    ModelState.AddModelError("Patronymic", errorMessage);
                }
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    ModelState.AddModelError("PhoneNumber", errorMessage);
                }
                if (string.IsNullOrEmpty(dateOfBirth))
                {
                    ModelState.AddModelError("DateOfBirth", errorMessage);
                }
                if(ModelState.IsValid)
                {
                    var user = new User(int.MaxValue, surname, name, patronymic,
                            phoneNumber, DateTime.Parse(dateOfBirth), new List<Award>());
                    var userFromDb = _userLogic.AddUser(user);
                    _userList.Add(userFromDb);
                }
                return RedirectToAction("List");
        }

        
        [HttpPost]
        public ActionResult AddAward(int idAward, int idUser)
        {
            ViewBag.Title = "Users";
            var userFromDb = _userLogic.AddAwardToUser(idUser, idAward);
            _userList.Remove(_userList.First(id => id.IdUser == idUser));
            _userList.Add(userFromDb);
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Edit(int idUser, string surname, string name, string patronymic,
            string phoneNumber, string dateOfBirth, List<Award> awards)
        {
            var user = new User(idUser, surname, name, patronymic,
                phoneNumber, DateTime.Parse(dateOfBirth), awards);
            ViewBag.Title = "Users";
            var userFromDb = _userLogic.Edit(user);
            _userList.Remove(_userList.First(id => id.IdUser == idUser));
            _userList.Add(userFromDb);
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult Delete(int idUser)
        {
            ViewBag.Title = "Users";
            _userList.Remove(_userList.First(id => id.IdUser == idUser));
            _answer = _userLogic.DeleteById(idUser);
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult SortByIdUser()
        {
            ViewBag.Title = "Users";
            _userList.Sort((user1, user2) =>
                user1.IdUser.CompareTo(user2.IdUser));
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult SortByName()
        {
            ViewBag.Title = "Users";
            _userList = _userLogic.GetSortedByName();
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult SortBySurname()
        {
            ViewBag.Title = "Users";
            _userList = _userLogic.GetSortedBySurname();
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult SortByPatronymic()
        {
            ViewBag.Title = "Users";
            _userList = _userLogic.GetSortedByPatronymic();
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult SortByDateOfBirth()
        {
            ViewBag.Title = "Users";
            _userList = _userLogic.GetSortedByDateOfBirth();
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult SearchByName(string name)
        {
            ViewBag.Title = "Users";
            _userList = name == "" ? _userLogic.GetAllUsers() : _userLogic.SearchByName(name);
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult SearchBySurname(string surname)
        {
            ViewBag.Title = "Users";
            _userList = surname == "" ? _userLogic.GetAllUsers() : _userLogic.SearchBySurname(surname);
            return RedirectToAction("List");
        }
        
        [HttpPost]
        public ActionResult SearchByPatronymic(string patronymic)
        {
            ViewBag.Title = "Users";
            _userList = patronymic == "" ? _userLogic.GetAllUsers() : _userLogic.SearchByPatronymic(patronymic);
            return RedirectToAction("List");
        }
    }
}