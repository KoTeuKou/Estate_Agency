using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface ICottageLogic
    {
        List<Cottage> GetAll();
        void Create(Cottage cottage);
        void Delete(int idCottage);
        List<Cottage> GetCottagesByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax,
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax,
            string city, string street);
        List<Cottage> GetSortedBy(SortBy sortBy);
    }
}