using System.Collections.Generic;
using Entities;

namespace ICityDAL
{
    public interface ICityDao
    {
        IEnumerable<City> GetAll();
        City Create(City city);
        string Delete(int idCity);
    }
}