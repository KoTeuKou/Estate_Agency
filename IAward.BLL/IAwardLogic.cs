using System.Collections.Generic;
using Entities;

namespace IAward.BLL
{
    public interface IAwardLogic
    {
        List<Award> GetAllAwards();
        Award GetAwardById(int id);
        Award CreateAward(Award award);
        string DeleteAward(int idAward);
    }
}