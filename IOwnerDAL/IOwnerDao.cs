using System.Collections.Generic;
using Entities;

namespace IOwnerDAL
{
    public interface IOwnerDao
    {
        IEnumerable<Owner> GetAll();
        Owner Create(Owner owner);
        string Delete(int idOwner);
    }
}