using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IUserAreaCoverageRepository
    {
        List<UserAreaCoverage> GetAllUserAreaCoverages();
        UserAreaCoverage GetUserAreaCoverageByParentId(int id);
        List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(Int32 userId, Int32 serviceId);
        bool DeleteRecord(UserAreaCoverage userAreaCoverage);
        int SaveRecord(UserAreaCoverage userAreaCoverage);
    }
}
