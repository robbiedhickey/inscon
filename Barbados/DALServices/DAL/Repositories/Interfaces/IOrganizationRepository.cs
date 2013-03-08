using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface IOrganizationRepository : IBaseCrudRepository<Organization>
    {
        IList<Organization> GetBy(int typeID);
    }
}
