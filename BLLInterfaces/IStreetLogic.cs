using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface IStreetLogic
    {
        List<Street> GetAll();
    }
}