using System.Collections.Generic;
using Entities;

namespace ICottageBLL
{
    public interface ICottageLogic
    {
        List<Cottage> GetAll();
        Cottage Create(Cottage cottage);
        string Delete(int idCottage);
    }
}