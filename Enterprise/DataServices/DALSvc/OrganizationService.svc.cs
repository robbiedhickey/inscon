using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.OrganizationService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class OrganizationService : IOrganizationService
    {
        public List<Organization> GetAllOrganizations()
        {
            throw new NotImplementedException();
        }

        public Organization GetOrganizationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Organization> GetOrganizationsByTypeId(int? typeID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Organization organization)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Organization organization)
        {
            throw new NotImplementedException();
        }
    }
}
