using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.LookupService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class LookupRepository : ILookupRepository
    {
        public List<Lookup> GetAllLookups()
        {
            return new dbSvc().GetAllLookups();
        }

        public Lookup GetLookupById(int id)
        {
            return new dbSvc().GetLookupById(id);
        }

        public List<Lookup> GetLookupValuesByGroupId(short groupId)
        {
            return new dbSvc().GetLookupValuesByGroupId(groupId);
        }

        public void DeleteRecord(Lookup lookup)
        {
            new dbSvc().DeleteRecord(lookup);
        }

        public int SaveRecord(Lookup lookup)
        {
            return new dbSvc().SaveRecord(lookup);
        }
    }
}