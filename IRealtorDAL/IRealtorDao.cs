using System.Collections.Generic;
using Entities;

namespace IRealtorDAL
{
    public interface IRealtorDao
    {
        IEnumerable<Realtor> GetAll();
        Realtor Create(Realtor realtor);
        string Delete(int idRealtor);
    }
}