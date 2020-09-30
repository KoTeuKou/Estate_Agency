﻿using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface IFlatDao
    {
        IEnumerable<Flat> GetAll();
        IEnumerable<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street);
        
        Flat Create(Flat flat);
        string Delete(int idFlat);
        string MakeContract(int idBuilding, int idRealtor, int idCustomer, string saleOrRent);
    }
    
}