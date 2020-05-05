using System.Collections.Generic;
using Entities;

namespace ICityBLL
{
    public interface ICityLogic
    {
        List<City> GetAll();
        City Create(City city);
        string Delete(int idCity);
    }
}