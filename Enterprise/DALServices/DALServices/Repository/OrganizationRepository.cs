using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.OrganizationService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class OrganizationRepository : IOrganizationRepository
    {
        public List<Organization> GetAllOrganizations()
        {
            return new dbSvc().GetAllOrganizations();
        }

        public Organization GetOrganizationById(int id)
        {
            return new dbSvc().GetOrganizationById(id);
        }

        public List<Organization> GetOrganizationsByTypeId(int? typeId)
        {
            return new dbSvc().GetOrganizationsByTypeId(typeId);
        }

        public bool DeleteRecord(Organization organization)
        {
            return new dbSvc().DeleteRecord(organization);
        }

        public int SaveRecord(Organization organization)
        {
            return new dbSvc().SaveRecord(organization);
        }
    }
}