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
    public class WorkOrderItemController : ApiController
    {
        private readonly IWorkOrderItemRepository _repository = new WorkOrderItemRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            return _repository.GetAllWorkOrderItems();
        }

        public WorkOrderItem GetWorkOrderItemById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the work order item must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetWorkOrderItemById(id);
        }

        public List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(Int32 workOrderId)
        {
            if (workOrderId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Work Order ID for the work order item must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetWorkOrderItemsByWorkOrderId(workOrderId);
        }

        public void DeleteRecord(WorkOrderItem workOrderItem)
        {
            if (workOrderItem == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The work order item must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(workOrderItem);
        }

        public int SaveRecord(WorkOrderItem workOrderItem)
        {
            if (workOrderItem == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The work order item must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(workOrderItem);
        }
    }
}
