using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.DALServices.DAL.Repositories.Interfaces;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class AssetRepository : IAssetRepository, IDisposable
    {
        public IList<Models.Asset> Get()
        {
            throw new NotImplementedException();
        }

        public IList<Models.Asset> Get(int organizationID)
        {
            throw new NotImplementedException();
        }

        public Models.Asset GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Models.Asset asset)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.Asset asset)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Models.Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
