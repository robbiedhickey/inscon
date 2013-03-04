using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface IOrganizationRepository
    {
        IList<Organization> Get();
        IList<Organization> Get(int typeID);
        Organization GetByID(int id);
        bool Insert(Organization organization);
        bool Update(Organization organization);
        bool Delete(Organization organization);
    }
}
