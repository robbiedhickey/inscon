using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.LookupGroupService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class LookupGroupRepository : ILookupGroupRepository
    {
        public List<LookupGroup> GetAllLookupGroups()
        {
            return new dbSvc().GetAllLookupGroups();
        }

        public LookupGroup GetLookupGroupById(int id)
        {
            return new dbSvc().GetLookupGroupById(id);
        }

        public void DeleteRecord(LookupGroup lookupGroup)
        {
            new dbSvc().DeleteRecord(lookupGroup);
        }

        public int SaveRecord(LookupGroup lookupGroup)
        {
            return new dbSvc().SaveRecord(lookupGroup);
        }
    }
}