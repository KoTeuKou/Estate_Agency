using System;
using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface IFlatLogic
    {
        List<Flat> GetFlatsByFilters(FlatFilter filter);
        List<Flat> GetAll();
        Flat Create(Flat flat);
        Boolean Delete(int idFlat);
        List<Flat> GetSortedBy(SortBy sortBy);
    }
}