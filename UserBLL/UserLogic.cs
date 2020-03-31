using Entities;
using IUser.BLL;
using System.Collections.Generic;
using System.Linq;
using Cache.CacheUtil;
using IUser.DLL;
using UserDLL;


namespace UserBLL
{
    public class UserLogic : IUserLogic
    {
        private UserCache _userCache;
        private IUserDao _userDao;
        public UserLogic()
        {
            _userCache = new UserCache();
            _userDao = new UserDao();
        }
        
        public User Edit(User user)
        {
            var userFromDb = _userDao.Edit(user);
            _userCache.AddUser(userFromDb);
            return userFromDb;
        }

        public User AddUser(User user)
        {
            var userFromDb = _userDao.AddUser(user);
            _userCache.AddUser(userFromDb);
            return userFromDb;
        }

        public User AddAwardToUser(int idUser, int idAward)
        {
            var userFromDb = _userDao.AddAwardToUser(idUser, idAward);
            _userCache.AddUser(userFromDb);
            return userFromDb;
        }

        public string DeleteById(int id)
        {
            _userCache.DeleteUser(id);
            return _userDao.DeleteUser(id);
        }
        
        public User GetById(int id)
        {
            var userFromCache = _userCache.GetUser(id);
            return userFromCache ?? _userDao.GetById(id);
        }
        
        public List<User> SearchByName(string name)
        {
            return _userDao.SearchByName(name).ToList();
        }

        public List<User> SearchBySurname(string surname)
        {
            return _userDao.SearchBySurname(surname).ToList();;
        }
        
        public List<User> SearchByPatronymic(string patronymic)
        {
            return _userDao.SearchByPatronymic(patronymic).ToList();;
        }

        public List<User> SearchByPhone(string phone)
        {
            return _userDao.SearchByPhone(phone).ToList();;
        }
        
        public List<Award> GetAllAwardsOfUser(int id)
        {
            return _userDao.GetAllAwardsOfUser(id).ToList();
        }

        public List<User> GetAllUsers()
        {
            var usersFromCache = _userCache.GetListOfUsers();
            return usersFromCache ?? _userDao.GetAllUsers().ToList();
        }

        public List<User> GetSortedByDateOfBirth()
        {
            return _userDao.GetAllUsers().OrderBy(x => x.DateOfBirth).ToList();
        }

        public List<User> GetSortedByPatronymic()
        {
             return _userDao.GetAllUsers().OrderBy(x => x.Patronymic).ToList();
        }

        public List<User> GetSortedBySurname()
        {
            return _userDao.GetAllUsers().OrderBy(x => x.Surname).ToList();
        }

        public List<User> GetSortedByName()
        {
            return _userDao.GetAllUsers().OrderBy(x => x.Name).ToList();
        }
    }
}