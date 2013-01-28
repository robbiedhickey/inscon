// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="RequestService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class RequestService
    /// </summary>
    public class RequestService : ServiceBase<Request>
    {
        /// <summary>
        /// Gets all requests.
        /// </summary>
        /// <returns>List{Request}.</returns>
        public List<Request> GetAllRequests()
        {
            return QueryAll(SqlDatabase, Procedure.Request_SelectAll, Request.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the request by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Request.</returns>
        public Request GetRequestById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Request> h = h2 => h2.RequestId == id;
                return GetAllRequests().Find(h) ?? new Request();
            }

            return Query(SqlDatabase, Procedure.Request_SelectById, Request.Build, id);
        }
    }
}