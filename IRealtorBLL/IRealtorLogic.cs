using System.Collections.Generic;
using Entities;

namespace IRealtorBLL
{
    public interface IRealtorLogic
    {
        List<Realtor> GetAll();
        Realtor Create(Realtor realtor);
        string Delete(int idRealtor);
    }
}