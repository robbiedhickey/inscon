using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface IOrganizationRepository
    {
        IList<Organization> Get();
        IList<Organization> Get(int typeID);
        Organization GetByID(int id);
        void Insert(Organization organization);
        void Update(Organization organization);
        void Delete(Organization organization);
        void Save();
    }
}
