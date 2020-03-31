using System.Collections.Generic;
using System.Linq;
using AwardDAL;
using Cache.CacheUtil;
using Entities;
using IAward.BLL;
using IAwardDAL;

namespace AwardBLL
{
    public class AwardLogic : IAwardLogic
    {
        private AwardCache _awardCache;
        private IAwardDao _awardDao;
        public AwardLogic()
        {
            _awardCache = new AwardCache();
            _awardDao = new AwardDao();
        }
        
        public List<Award> GetAllAwards()
        {
            var awardsFromCache = _awardCache.GetListOfAwards();
            return awardsFromCache ?? _awardDao.GetAllAwards().ToList();
        }

        public Award CreateAward(Award award)
        {
            var awardFromDb = _awardDao.CreateAward(award);
            _awardCache.AddAward(awardFromDb);
            return awardFromDb;
        }

        public Award GetAwardById(int id)
        {
            var awardFromCache = _awardCache.GetAward(id);
            return awardFromCache ?? _awardDao.GetAwardById(id);
        }
        
        public string DeleteAward(int idAward)
        {
            _awardCache.DeleteAward(idAward);
            return _awardDao.DeleteAward(idAward);
        }
    }
}