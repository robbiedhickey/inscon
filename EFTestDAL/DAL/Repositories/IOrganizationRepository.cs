namespace Enterprise.DAL.Repositories
{
    using System;
    using System.Collections.Generic;

    using Enterprise.DAL.Models;

    public interface IOrganizationRepository : IDisposable
    {
        IList<Organization> Get();

        IList<Organization> Get(int typeID);

        Organization GetByID(int id);

        void Insert(Organization organization);

        void Update(Organization organization);

        void Delete(int id);

        void Save();
    }
}
