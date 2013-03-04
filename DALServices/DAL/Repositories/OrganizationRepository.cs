using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.DALServices.DAL.Repositories.Interfaces;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class OrganizationRepository : IOrganizationRepository, IDisposable
    {
        public IList<Models.Organization> Get()
        {
            throw new NotImplementedException();
        }

        public IList<Models.Organization> Get(int typeID)
        {
            throw new NotImplementedException();
        }

        public Models.Organization GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Models.Organization organization)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.Organization organization)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Models.Organization organization)
        {
            throw new NotImplementedException();
        }
    }
}
