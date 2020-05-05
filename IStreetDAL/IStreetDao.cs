using System.Collections.Generic;
using Entities;

namespace IStreetDAL
{
    public interface IStreetDao
    {
        IEnumerable<Street> GetAll();
        Street Create(Street street);
        string Delete(int idStreet);
    }
}