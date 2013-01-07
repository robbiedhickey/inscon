using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Summary description for SqlDataRecord.
    /// </summary>
    public abstract class SqlDataRecord : SqlDataExecutor, IDataRecord
    {
        private Dictionary<string, bool> _dirtyTable;
        private bool _trackChanges;

        /// <summary>
        /// Determines if any member of this listing has changed.
        /// </summary>
        /// <returns></returns>
        public bool IsChanged()
        {
            if (_dirtyTable != null)
            {
                return _dirtyTable.Any(kvp => kvp.Value);
            }

            return false;
        }

        public void IsDirty(string column)
        {
            _dirtyTable[column] = true;
        }

        public void SetChanged(string column)
        {
            if (_dirtyTable == null)
            {
                _dirtyTable = new Dictionary<string, bool>();
            }

            _dirtyTable[column] = true;
        }

        public bool IsChanged(string field)
        {
            return _dirtyTable != null && _dirtyTable.ContainsKey(field) && _dirtyTable[field];
        }

        public string[] DirtyFields()
        {
            var fields = new List<string>();

            if (_dirtyTable != null)
            {
                fields.AddRange(from kvp in _dirtyTable where kvp.Value select kvp.Key);
            }

            return fields.ToArray();
        }

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

        public void CommitChanges()
        {
            _dirtyTable.Clear();
        }

        protected void SetProperty<TValue>(ref TValue member, TValue newValue, IEqualityComparer<TValue> equalityComparer)
        {
            var changed = !equalityComparer.Equals(member, newValue);

            if (changed)
            {
                member = newValue;

                SetChanged(member.ToString());
            }
        }

        protected void SetProperty<TValue>(ref TValue member, TValue newValue)
        {
            SetProperty(ref member, newValue, EqualityComparer<TValue>.Default);
        }


    }
}

