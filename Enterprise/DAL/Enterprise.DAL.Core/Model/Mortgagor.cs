using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Mortgagor : ModelBase
    {
        private int _loanId;
        private int _mortgagorId;
        private string _name;
        private string _phoneNumber;
        private int _typeId;

        public Mortgagor()
        {
            EntityNumber = (short) Entities.Mortgagor;
        }

        public Int32 MortgagorId
        {
            get { return _mortgagorId; }
            set { SetProperty(ref _mortgagorId, value); }
        }

        public Int32 LoanId
        {
            get { return _loanId; }
            set { SetProperty(ref _loanId, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }


        #region public methods
        public static Mortgagor Build(ITypeReader reader)
        {
            var record = new Mortgagor
                {
                    MortgagorId = reader.GetInt32("MortgagorID"),
                    LoanId = reader.GetInt32("LoanID"),
                    Name = reader.GetString("Name"),
                    TypeId = reader.GetInt32("TypeID"),
                    PhoneNumber = reader.GetString("Phone")
                };

            return record;
        }

        
        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_mortgagorId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Mortgagor_Update
                                       , _mortgagorId
                                       , _loanId
                                       , _name
                                       , _typeId
                                       , _phoneNumber));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _mortgagorId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Mortgagor_Insert
                                       , _loanId
                                       , _name
                                       , _typeId
                                       , _phoneNumber), Convert.ToInt32);
                CacheItem.Clear<Mortgagor>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Mortgagor_Delete, _mortgagorId));
            CacheItem.Clear<Mortgagor>();
        }

        #endregion
    }
}