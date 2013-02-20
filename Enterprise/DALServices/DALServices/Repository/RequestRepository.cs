using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.RequestService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class RequestRepository : IRequestRepository
    {
        public List<Request> GetAllRequests()
        {
            return new dbSvc().GetAllRequests();
        }

        public Request GetRequestById(int id)
        {
            return new dbSvc().GetRequestById(id);
        }

        public bool DeleteRecord(Request request)
        {
            return new dbSvc().DeleteRecord(request);
        }

        public int SaveRecord(Request request)
        {
            return new dbSvc().SaveRecord(request);
        }
    }
}