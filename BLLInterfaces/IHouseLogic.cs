using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface IHouseLogic
    {
        List<House> GetAll();
    }
}