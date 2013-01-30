// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="SqlDataRecord.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Class SqlDataRecord
    /// </summary>
    public abstract class SqlDataRecord : SqlDataExecutor, IDataRecord
    {
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
    }
}