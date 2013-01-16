using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Loan : SqlDataRecord
    {
        private string _hudCaseNumber;
        private int _loanID;
        private string _loanNumber;
        private int _organizationID;
        private int _typeID;

        private Organization _organization;

        #region private variables

        #endregion

        #region public properties

        public Int32 LoanID
        {
            get { return _loanID; }
            set { SetProperty(ref _loanID, value); }
        }

        public Int32 OrganizationID
        {
            get { return _organizationID; }
            set { SetProperty(ref _organizationID, value); }
        }

        public Int32 TypeID
        {
            get { return _typeID; }
            set { SetProperty(ref _typeID, value); }
        }

        public String LoanNumber
        {
            get { return _loanNumber; }
            set { SetProperty(ref _loanNumber, value); }
        }

        public String HudCaseNumber
        {
            get { return _hudCaseNumber; }
            set { SetProperty(ref _hudCaseNumber, value); }
        }

        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeID).Value; }
        }

        public Organization Organization
        {
            get
            {
                if (_organization != null)
                {
                    return _organization;
                }
                _organization = new OrganizationService().GetOrganizationById(_organizationID);
                return _organization;
            }
        }

        #endregion

        #region public methods

        // Constructor
        public Loan()
        {
            EntityNumber = 12;
        }

        public static Loan Build(ITypeReader reader)
        {
            var record = new Loan
                {
                    LoanID = reader.GetInt32("LoanID"),
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    TypeID = reader.GetInt32("TypeID"),
                    LoanNumber = reader.GetString("LoanNumber"),
                    HudCaseNumber = reader.GetString("HudCaseNumber")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_loanID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Loan_Update
                                       , _loanID
                                       , _organizationID
                                       , _typeID
                                       , _loanNumber
                                       , _hudCaseNumber));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _loanID = Execute(GetCommand(Database.EnterpriseDb, Procedure.Loan_Insert
                                             , _organizationID
                                             , _typeID
                                             , _loanNumber
                                             , _hudCaseNumber), Convert.ToInt32);
                CacheItem.Clear<Lookup>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Loan_Delete, _loanID));
            CacheItem.Clear<Lookup>();
        }

        #endregion
    }
}