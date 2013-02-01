using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.LookupGroupService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class LookupGroupService : ILookupGroupService
    {
        public List<LookupGroup> GetAllLookupGroups()
        {
            throw new NotImplementedException();
        }

        public LookupGroup GetLookupGroupById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(LookupGroup lookupGroup)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(LookupGroup lookupGroup)
        {
            throw new NotImplementedException();
        }
    }
}
