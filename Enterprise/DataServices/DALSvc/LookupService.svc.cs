using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.LookupService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class LookupService : ILookupService
    {
        public List<Lookup> GetAllLookups()
        {
            throw new NotImplementedException();
        }

        public Lookup GetLookupById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Lookup> GetLookupValuesByGroupId(short groupID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Lookup lookup)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Lookup lookup)
        {
            throw new NotImplementedException();
        }
    }
}
