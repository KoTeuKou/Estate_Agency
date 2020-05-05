using System.Collections.Generic;
using Entities;

namespace IOwnerBLL
{
    public interface IOwnerLogic
    {
        List<Owner> GetAll();
        Owner Create(Owner owner);
        string Delete(int idOwner);
    }
}