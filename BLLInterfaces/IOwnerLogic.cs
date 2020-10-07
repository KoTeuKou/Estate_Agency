using System.Collections.Generic;
using Entities;

namespace BLLInterfaces
{
    public interface IOwnerLogic
    {
        List<Owner> GetAll();
    }
}