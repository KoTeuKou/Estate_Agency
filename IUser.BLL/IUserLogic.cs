using System.Collections.Generic;
using Entities;

namespace IUser.BLL
{
    public interface IUserLogic
    {
        List<User> SearchByName(string name);

        List<User> SearchBySurname(string surname);

        List<User> SearchByPhone(string phone);
        
        List<Award> GetAllAwardsOfUser(int id);

        User GetById(int id);

        string DeleteById(int id);

        User Edit(User user);

        User AddUser(User user);

        List<User> GetAllUsers();

        User AddAwardToUser(int idUser, int idAward);
        
    }
}