using System.Collections.Generic;
using Entities;

namespace DALInterfaces
{
    public interface IOwnerDao
    {
        IEnumerable<Owner> GetAll();
    }
}