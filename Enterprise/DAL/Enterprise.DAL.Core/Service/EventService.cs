// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="EventService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class EventService
    /// </summary>
    public class EventService : ServiceBase<Event>
    {

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Event.</returns>
        public static Event Build(ITypeReader reader)
        {
            var record = new Event
            {
                EventID = reader.GetInt32("EventID"),
                ParentID = reader.GetInt32("ParentID"),
                EntityID = reader.GetInt16("EntityID"),
                TypeID = reader.GetInt32("TypeID"),
                UserID = reader.GetInt32("UserID"),
                EventDate = reader.GetDate("EventDate")
            };

            return record;
        }

        /// <summary>
        /// Gets all events.
        /// </summary>
        /// <returns>List{Event}.</returns>
        public List<Event> GetAllEvents()
        {
            return QueryAll(SqlDatabase, Procedure.Event_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the event by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Event.</returns>
        public Event GetEventById(int id)
        {
            if (IsCached)
            {
                Predicate<Event> h = h2 => h2.EventID == id;
                return GetAllEvents().Find(h) ?? new Event();
            }

            return Query(SqlDatabase, Procedure.Event_SelectById, Build, id);
        }

        /// <summary>
        /// Gets the event by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>Event.</returns>
        public Event GetEventByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<Event> h = h2 => h2.ParentID == parentID && h2.EntityID == entityID;
                return GetAllEvents().Find(h) ?? new Event();
            }

            return Query(SqlDatabase, Procedure.Event_SelectByParentIdAndEntityId, Build, parentID, entityID);
        }
    }
}