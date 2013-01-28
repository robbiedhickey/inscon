// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ModelBase.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class ModelBase
    /// </summary>
    public class ModelBase : SqlDataExecutor, IDataRecord, IDisposable
    {
        #region entityId's

        /// <summary>
        /// The address_ entity id
        /// </summary>
        public const Int16 Address_EntityId = 6;

        /// <summary>
        /// The address location_ entity id
        /// </summary>
        public const Int16 AddressLocation_EntityId = 22;

        /// <summary>
        /// The address use_ entity id
        /// </summary>
        public const Int16 AddressUse_EntityId = 20;

        /// <summary>
        /// The comment_ entity id
        /// </summary>
        public const Int16 Comment_EntityId = 7;

        /// <summary>
        /// The entity_ entity id
        /// </summary>
        public const Int16 Entity_EntityId = 5;

        /// <summary>
        /// The event_ entity id
        /// </summary>
        public const Int16 Event_EntityId = 9;

        /// <summary>
        /// The file_ entity id
        /// </summary>
        public const Int16 File_EntityId = 10;

        /// <summary>
        /// The loan_ entity id
        /// </summary>
        public const Int16 Loan_EntityId = 12;

        /// <summary>
        /// The location_ entity id
        /// </summary>
        public const Int16 Location_EntityId = 11;

        /// <summary>
        /// The lookup_ entity id
        /// </summary>
        public const Int16 Lookup_EntityId = 8;

        /// <summary>
        /// The lookup group_ entity id
        /// </summary>
        public const Int16 LookupGroup_EntityId = 4;

        /// <summary>
        /// The mortgagor_ entity id
        /// </summary>
        public const Int16 Mortgagor_EntityId = 13;

        /// <summary>
        /// The organization_ entity id
        /// </summary>
        public const Int16 Organization_EntityId = 14;

        /// <summary>
        /// The product_ entity id
        /// </summary>
        public const Int16 Product_EntityId = 3;

        /// <summary>
        /// The product category_ entity id
        /// </summary>
        public const Int16 ProductCategory_EntityId = 1;

        /// <summary>
        /// The request_ entity id
        /// </summary>
        public const Int16 Request_EntityId = 2;

        /// <summary>
        /// The user_ entity id
        /// </summary>
        public const Int16 User_EntityId = 15;

        /// <summary>
        /// The user area coverage_ entity id
        /// </summary>
        public const Int16 UserAreaCoverage_EntityId = 17;

        /// <summary>
        /// The user contact_ entity id
        /// </summary>
        public const Int16 UserContact_EntityId = 18;

        /// <summary>
        /// The user notification_ entity id
        /// </summary>
        public const Int16 UserNotification_EntityId = 16;

        /// <summary>
        /// The work order_ entity id
        /// </summary>
        public const Int16 WorkOrder_EntityId = 21;

        /// <summary>
        /// The work order assignment_ entity id
        /// </summary>
        public const Int16 WorkOrderAssignment_EntityId = 19;

        /// <summary>
        /// The work order item_ entity id
        /// </summary>
        public const Int16 WorkOrderItem_EntityId = 23;

        #endregion

        /// <summary>
        /// The _dirty table
        /// </summary>
        private Dictionary<string, bool> _dirtyTable;

        /// <summary>
        /// The _track changes
        /// </summary>
        private bool _trackChanges;


        /// <summary>
        /// Gets or sets the entity number.
        /// </summary>
        /// <value>The entity number.</value>
        public short EntityNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [track changes].
        /// </summary>
        /// <value><c>true</c> if [track changes]; otherwise, <c>false</c>.</value>
        public bool TrackChanges
        {
            get { return _trackChanges; }
            set
            {
                if (!_trackChanges && value)
                {
                    _dirtyTable = new Dictionary<string, bool>();
                }

                _trackChanges = value;
            }
        }


        /// <summary>
        /// Determines whether this instance is changed.
        /// </summary>
        /// <returns><c>true</c> if this instance is changed; otherwise, <c>false</c>.</returns>
        public bool IsChanged()
        {
            if (_dirtyTable != null)
            {
                return _dirtyTable.Any(kvp => kvp.Value);
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified column is dirty.
        /// </summary>
        /// <param name="column">The column.</param>
        public void IsDirty(string column)
        {
            _dirtyTable[column] = true;
        }

        /// <summary>
        /// Sets the changed.
        /// </summary>
        /// <param name="column">The column.</param>
        public void SetChanged(string column)
        {
            if (_dirtyTable == null)
            {
                _dirtyTable = new Dictionary<string, bool>();
            }

            _dirtyTable[column] = true;
        }

        /// <summary>
        /// Determines whether the specified field is changed.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <returns><c>true</c> if the specified field is changed; otherwise, <c>false</c>.</returns>
        public bool IsChanged(string field)
        {
            return _dirtyTable != null && _dirtyTable.ContainsKey(field) && _dirtyTable[field];
        }

        /// <summary>
        /// Dirties the fields.
        /// </summary>
        /// <returns>System.String[][].</returns>
        public string[] DirtyFields()
        {
            var fields = new List<string>();

            if (_dirtyTable != null)
            {
                fields.AddRange(from kvp in _dirtyTable where kvp.Value select kvp.Key);
            }

            return fields.ToArray();
        }

        /// <summary>
        /// Commits the changes.
        /// </summary>
        public void CommitChanges()
        {
            _dirtyTable.Clear();
        }

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <typeparam name="TValue">The type of the T value.</typeparam>
        /// <param name="member">The member.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="equalityComparer">The equality comparer.</param>
        protected void SetProperty<TValue>(ref TValue member, TValue newValue,
                                           IEqualityComparer<TValue> equalityComparer)
        {
            bool changed = !equalityComparer.Equals(member, newValue);

            if (changed)
            {
                member = newValue;

                SetChanged(member.ToString());
            }
        }

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <typeparam name="TValue">The type of the T value.</typeparam>
        /// <param name="member">The member.</param>
        /// <param name="newValue">The new value.</param>
        protected void SetProperty<TValue>(ref TValue member, TValue newValue)
        {
            SetProperty(ref member, newValue, EqualityComparer<TValue>.Default);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}