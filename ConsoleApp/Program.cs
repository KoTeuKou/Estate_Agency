using System;
using UserBLL;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userLogic = new UserLogic();
            var user = userLogic.GetById(1);
            var awardsOfUser = userLogic.GetAllAwardsOfUser(user.IdUser);
            foreach (var elem in awardsOfUser)
            {
                Console.Write(elem.Tittle + " ");
            }
        }
    }
}