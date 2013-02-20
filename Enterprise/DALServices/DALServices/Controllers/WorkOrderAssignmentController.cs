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
    public class WorkOrderAssignmentController : ApiController
    {
        private readonly IWorkOrderAssignmentRepository _repository = new WorkOrderAssignmentRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            return _repository.GetAllWorkOrderAssignments();
        }

        [HttpGet]
        public WorkOrderAssignment GetWorkOrderAssignmentById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the work order assignment must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetWorkOrderAssignmentById(id);
        }

        [HttpGet]
        public List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(Int32 workOrderId)
        {
            if (workOrderId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the work order assignment must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAllWorkOrderAssignmentsByWorkOrderId(workOrderId);
        }

        [HttpDelete]
        public void DeleteRecord(WorkOrderAssignment workOrderAssignment)
        {
            if (workOrderAssignment == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The work order assignment must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(workOrderAssignment);
        }

        [HttpPost]
        public int SaveRecord(WorkOrderAssignment workOrderAssignment)
        {
            if (workOrderAssignment == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The work order assignment must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(workOrderAssignment);
        }
    }
}
