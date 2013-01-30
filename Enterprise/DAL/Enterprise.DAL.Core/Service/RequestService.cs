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
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class RequestService
    /// </summary>
    public class RequestService : ServiceBase<Request>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Request.</returns>
        public static Request Build(ITypeReader reader)
        {
            var record = new Request
                {
                    RequestId = reader.GetInt32("RequestID"),
                    OrganizationId = reader.GetInt32("OrganizationID"),
                    DateInserted = reader.GetDate("DateInserted"),
                    CustomerRequestId = reader.GetString("CustomerRequestID")
                };
            return record;
        }

        /// <summary>
        /// Gets all requests.
        /// </summary>
        /// <returns>List{Request}.</returns>
        public List<Request> GetAllRequests()
        {
            return QueryAll(SqlDatabase, Procedure.Request_SelectAll, Build, CacheMinutesToExpire, IsCached);
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

            return Query(SqlDatabase, Procedure.Request_SelectById, Build, id);
        }
    }
}