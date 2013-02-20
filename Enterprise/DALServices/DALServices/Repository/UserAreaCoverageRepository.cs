using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.UserAreaCoverageService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class UserAreaCoverageRepository : IUserAreaCoverageRepository
    {
        public List<UserAreaCoverage> GetAllUserAreaCoverages()
        {
            return new dbSvc().GetAllUserAreaCoverages();
        }

        public UserAreaCoverage GetUserAreaCoverageByParentId(int id)
        {
            return new dbSvc().GetUserAreaCoverageByParentId(id);
        }

        public List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(int userId, int serviceId)
        {
            return new dbSvc().GetUserAreaCoverageByUserIdandServiceId(userId, serviceId);
        }

        public bool DeleteRecord(UserAreaCoverage userAreaCoverage)
        {
            return new dbSvc().DeleteRecord(userAreaCoverage);
        }

        public int SaveRecord(UserAreaCoverage userAreaCoverage)
        {
            return new dbSvc().SaveRecord(userAreaCoverage);
        }
    }
}