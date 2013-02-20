using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IRequestRepository
    {
        List<Request> GetAllRequests();
        Request GetRequestById(Int32 id);
        bool DeleteRecord(Request request);
        int SaveRecord(Request request);
    }
}
