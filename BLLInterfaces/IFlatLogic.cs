﻿using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface IFlatLogic
    {
        List<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street);
        List<Flat> GetAll();
        void Create(Flat flat);
        void Delete(int idFlat);
        List<Flat> GetSortedBy(SortBy sortBy);
    }
}