using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Enterprise.DAL.Core.Model;

namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class WorkOrderController : ApiController
    {
        private readonly IWorkOrderRepository _repository = new WorkOrderRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<WorkOrder> GetAllWorkOrders()
        {
            return _repository.GetAllWorkOrders();
        }

        [HttpGet]
        public WorkOrder GetWorkOrderById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the work order must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetWorkOrderById(id);
        }

        [HttpGet]
        public List<WorkOrder> GetWorkOrdersByRequestId(Int32 requestId)
        {
            if (requestId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the work order must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetWorkOrdersByRequestId(requestId);
        }

        [HttpGet]
        public List<WorkOrder> GetWorkOrdersByAssetId(Int32 assetId)
        {
            if (assetId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the work order must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetWorkOrdersByAssetId(assetId);
        }

        [HttpDelete]
        public bool DeleteRecord(WorkOrder workOrder)
        {
            if (workOrder == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The work order must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.DeleteRecord(workOrder);
        }

        [HttpPost]
        public int SaveRecord(WorkOrder workOrder)
        {
            if (workOrder == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The work order must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(workOrder);
        }
    }
}
