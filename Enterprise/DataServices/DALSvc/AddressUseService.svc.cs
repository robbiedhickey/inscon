using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.AddressUseService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class AddressUseService : IAddressUseService
    {
        public List<AddressUse> GetAllAddressUseRecords()
        {
            try
            {
                return new dbSvc().GetAllAddressUseRecords();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AddressUse GetAddressUseById(int id)
        {
            try
            {
                return new dbSvc().GetAddressUseById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<AddressUse> GetAddressUseByAddressId(int addressID)
        {
            try
            {
                return new dbSvc().GetAddressUseByAddressId(addressID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AddressUse GetAddressUseByAddressIdAndTypeId(int addressID, short typeID)
        {
            try
            {
                return new dbSvc().GetAddressUseByAddressIdAndTypeId(addressID, typeID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteRecord(AddressUse addressUse)
        {
            try
            {
                new dbSvc().DeleteRecord(addressUse);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int SaveRecord(AddressUse addressUse)
        {
            try
            {
                return new dbSvc().SaveRecord(addressUse);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
