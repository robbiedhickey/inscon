using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Request : SqlDataRecord
    {
        private string _customerRequestId;
        private DateTime _dateInserted;
        private int _organizationId;
        private int _requestId;

        public Request()
        {
            EntityNumber = 2;
        }

        public Int32 RequestId
        {
            get { return _requestId; }
            set { _requestId = value; }
        }

        public Int32 OrganizationId
        {
            get { return _organizationId; }
            set { _organizationId = value; }
        }

        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { _dateInserted = value; }
        }

        public String CustomerRequestId
        {
            get { return _customerRequestId; }
            set { _customerRequestId = value; }
        }

        #region public methods

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
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_requestId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Request_Update
                                       , _requestId
                                       , _organizationId
                                       , _dateInserted
                                       , CustomerRequestId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _requestId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Request_Insert
                                                , _organizationId
                                                , _dateInserted
                                                , CustomerRequestId), Convert.ToInt32);
                CacheItem.Clear<Request>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Request_Delete, _requestId));
            CacheItem.Clear<Request>();
        }

        #endregion
    }
}