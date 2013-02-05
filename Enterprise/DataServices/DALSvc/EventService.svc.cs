using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.EventService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Event table.
    /// </summary>
    public class EventService : IEventService
    {
        /// <summary>
        /// Gets all events.
        /// </summary>
        /// <returns>A list of all event objects.</returns>
        public List<Event> GetAllEvents()
        {
            try
            {
                return new dbSvc().GetAllEvents();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the event by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The event that matches the id.</returns>
        public Event GetEventById(int id)
        {
            try
            {
                return new dbSvc().GetEventById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the event by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>The event that matches the parameter list.</returns>
        public Event GetEventByParentIdAndEntityID(int parentID, short entityID)
        {
            try
            {
                return new dbSvc().GetEventByParentIdAndEntityID(parentID, entityID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the event record.
        /// </summary>
        /// <param name="dalEvent">The event to delete.</param>
        public void DeleteRecord(Event dalEvent)
        {
            try
            {
                new dbSvc().DeleteRecord(dalEvent);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the event record.
        /// </summary>
        /// <param name="dalEvent">The event to save.</param>
        /// <returns>The id of the saved record.</returns>
        public int SaveRecord(Event dalEvent)
        {
            try
            {
                return new dbSvc().SaveRecord(dalEvent);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
