using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface ICityDao
    {
        IEnumerable<City> GetAll();
    }
}