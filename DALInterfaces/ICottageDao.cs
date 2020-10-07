using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface ICottageDao
    {
        IEnumerable<Cottage> GetAll();
        Cottage Create(Cottage cottage);
        bool Delete(int idCottage);
        IEnumerable<Cottage> GetCottagesByFilters(CottageFilter filter);
    }
}