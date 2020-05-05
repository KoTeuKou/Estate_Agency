using System.Collections.Generic;
using Entities;

namespace IHouseDAL
{
    public interface IHouseDao
    {
        IEnumerable<House> GetAll();
        House Create(House house);
        string Delete(int idHouse);
    }
}