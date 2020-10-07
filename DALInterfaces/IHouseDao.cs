using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface IHouseDao
    {
        IEnumerable<House> GetAll();
    }
}