using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserAreaCoverageService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class UserAreaCoverageService : IUserAreaCoverageService
    {
        public List<UserAreaCoverage> GetAllUserAreaCoverages()
        {
            throw new NotImplementedException();
        }

        public UserAreaCoverage GetAddressByParentId(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(int userId, int serviceId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(UserAreaCoverage userAreaCoverage)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(UserAreaCoverage userAreaCoverage)
        {
            throw new NotImplementedException();
        }
    }
}
