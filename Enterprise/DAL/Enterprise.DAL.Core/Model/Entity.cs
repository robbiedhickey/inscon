// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 02-19-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 02-19-2013
// ***********************************************************************
// <copyright file="Entity.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Entity
    /// </summary>
    public class Entity : ModelBase<Entity>
    {
        /// <summary>
        /// The _entity
        /// </summary>
        private Int16 _entity;
        /// <summary>
        /// The _name
        /// </summary>
        private string _name;

        /// <summary>
        /// Gets or sets the entity ID.
        /// </summary>
        /// <value>The entity ID.</value>
        public Int16 EntityID
        {
            get { return _entity; }
            set {  SetProperty(ref _entity, value); }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get { return _name; }
            set {  SetProperty(ref _name, value); }
        }
    }
}