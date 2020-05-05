using System.Collections.Generic;
using Entities;

namespace IHouseBLL
{
    public interface IHouseLogic
    {
        List<House> GetAll();
        House Create(House house);
        string Delete(int idHouse);
    }
}