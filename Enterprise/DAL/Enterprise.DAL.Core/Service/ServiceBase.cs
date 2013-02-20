// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ServiceBase.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class ServiceBase
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ServiceBase<T> : SqlDataAccessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBase{T}"/> class.
        /// </summary>
        public ServiceBase()
        {
            var type = typeof (T);

            EntityName = type.Name;
            CacheMinutesToExpire = 30;
            SqlDatabase = Database.EnterpriseDb;
            IsCached = false;
        }

        /// <summary>
        /// Gets or sets the cache minutes to expire.
        /// </summary>
        /// <value>The cache minutes to expire.</value>
        public Int16 CacheMinutesToExpire { get; set; }

        /// <summary>
        /// Gets or sets the SQL database.
        /// </summary>
        /// <value>The SQL database.</value>
        public String SqlDatabase { get; set; }

        /// <summary>
        /// Gets or sets the is cached.
        /// </summary>
        /// <value>The is cached.</value>
        public Boolean IsCached { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        public String EntityName { get; set; }

        /// <summary>
        /// Saves the record.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Int32.</returns>
        public Int32 SaveRecord(T model)
        {
            var record = new DataRecordTask<T>
            {
                Model = model
            };

            return record.SaveRecord();
        }

        /// <summary>
        /// Deletes the record.
        /// </summary>
        /// <param name="model">The model.</param>
        public bool DeleteRecord(T model)
        {
            var record = new DataRecordTask<T>
                {
                    Model = model
                };
            return record.DeleteRecord();
        }
    
}

}