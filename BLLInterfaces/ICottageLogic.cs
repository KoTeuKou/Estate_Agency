using System;
using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface ICottageLogic
    {
        List<Cottage> GetAll();
        Cottage Create(Cottage cottage);
        Boolean Delete(int idCottage);
        List<Cottage> GetCottagesByFilters(CottageFilter filter);
        List<Cottage> GetSortedBy(SortBy sortBy);
    }
}