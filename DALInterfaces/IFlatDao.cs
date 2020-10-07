﻿using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface IFlatDao
    {
        IEnumerable<Flat> GetAll();
        IEnumerable<Flat> GetFlatsByFilters(FlatFilter filter);
        
        Flat Create(Flat flat);
        bool Delete(int idFlat);
    }
    
}