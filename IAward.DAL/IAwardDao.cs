using System.Collections.Generic;
using Entities;

namespace IAward.DAL
{
    public interface IAwardDao
    {
        IEnumerable<Award> GetAllAwards();

        string CreateAward(Award award);
        
        string DeleteAward(int idAward);
    }
}