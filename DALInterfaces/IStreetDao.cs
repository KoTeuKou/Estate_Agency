using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface IStreetDao
    {
        IEnumerable<Street> GetAll();
    }
}