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
    /// <summary>
    /// Handles access to the Request table.
    /// </summary>
    public class RequestService : IRequestService
    {
        /// <summary>
        /// Gets all requests.
        /// </summary>
        /// <returns>A list of request objects.</returns>
        public List<Request> GetAllRequests()
        {
            try
            {
                return new dbSvc().GetAllRequests();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the request by id.
        /// </summary>
        /// <param name="id">The id of the request.</param>
        /// <returns>the request object that matches the id.</returns>
        public Request GetRequestById(int id)
        {
            try
            {
                return new dbSvc().GetRequestById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the request record.
        /// </summary>
        /// <param name="request">The request to delete.</param>
        public void DeleteRecord(Request request)
        {
            try
            {
                new dbSvc().DeleteRecord(request);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the request record.
        /// </summary>
        /// <param name="request">The request to save.</param>
        /// <returns>The id of the saved request.</returns>
        public int SaveRecord(Request request)
        {
            try
            {
                return new dbSvc().SaveRecord(request);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
