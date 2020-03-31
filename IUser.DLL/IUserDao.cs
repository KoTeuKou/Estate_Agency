using System.Collections.Generic;
using Entities;

namespace IUser.DLL
{
    public interface IUserDao
    {
        IEnumerable<User> SearchByName(string name);

        IEnumerable<User> SearchBySurname(string surname);

        IEnumerable<User> SearchByPhone(string phone);
        
        IEnumerable<Award> GetAllAwardsOfUser(int id);
        
        IEnumerable<User> SearchByPatronymic(string patronymic);
        
        User GetById(int id);
        
        string DeleteUser(int id);

        User Edit(User user);

        User AddUser(User user);

        IEnumerable<User> GetAllUsers();

        User AddAwardToUser(int idUser, int idAward);
        
    }
}
