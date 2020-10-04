﻿using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface ICottageDao
    {
        IEnumerable<Cottage> GetAll();
        Cottage Create(Cottage cottage);
        bool Delete(int idCottage);
        IEnumerable<Cottage> GetCottagesByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, string city, string street);
    }
}