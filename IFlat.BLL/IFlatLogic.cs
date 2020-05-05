using System.Collections.Generic;
using Entities;

namespace IFlat.BLL
{
    public interface IFlatLogic
    {
        List<Flat> GetFlatsByFilters(int flNumMin, int flNumMax, double sqMin, double sqMax, 
            int numOfRmsMin, int numOfRmsMax, int priceMin, int priceMax, int numOfHouseMin, int numOfHouseMax,
            string city, string street);
        List<Flat> GetAll();
        Flat Create(Flat flat);
        string Delete(int idFlat);
        List<Flat> GetSortedByPrice(List<Flat> flats);
        List<Flat> GetSortedByNumOfRooms(List<Flat> flats);
        List<Flat> GetSortedBySquare(List<Flat> flats);
        List<Flat> GetSortedByFloorNumber(List<Flat> flats);
        List<Flat> GetSortedByFlatNumber(List<Flat> flats);
    }
}