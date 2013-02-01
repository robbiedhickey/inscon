using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.RequestService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class RequestService : IRequestService
    {
        public List<Request> GetAllRequests()
        {
            throw new NotImplementedException();
        }

        public Request GetRequestById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Request request)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
