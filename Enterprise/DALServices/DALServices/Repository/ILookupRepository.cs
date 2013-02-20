using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface ILookupRepository
    {
        List<Lookup> GetAllLookups();
        Lookup GetLookupById(Int32 id);
        List<Lookup> GetLookupValuesByGroupId(Int16 groupId);
        bool DeleteRecord(Lookup lookup);
        int SaveRecord(Lookup lookup);
    }
}
