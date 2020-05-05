using System.Collections.Generic;
using Entities;

namespace IStreetBLL
{
    public interface IStreetLogic
    {
        List<Street> GetAll();
        Street Create(Street street);
        string Delete(int idStreet);
    }
}