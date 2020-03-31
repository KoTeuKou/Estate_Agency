using System.Collections.Generic;
using Entities;

namespace IAwardDAL
{
    public interface IAwardDao
    {
        IEnumerable<Award> GetAllAwards();

        Award CreateAward(Award award);
        
        string DeleteAward(int idAward);
        Award GetAwardById(int id);
    }
}