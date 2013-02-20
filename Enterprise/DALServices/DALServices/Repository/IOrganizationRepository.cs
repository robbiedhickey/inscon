using Enterprise.DAL.Core.Model;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IOrganizationRepository
    {
        List<Organization> GetAllOrganizations();
        Organization GetOrganizationById(int id);
        List<Organization> GetOrganizationsByTypeId(int? typeId);
        bool DeleteRecord(Organization organization);
        int SaveRecord(Organization organization);
    }
}
