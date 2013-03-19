using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Core.ViewModelMapper
{
    using Enterprise.Core.ViewModels;
    using Enterprise.Core.ViewModels.Common;
    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;

    public class ReoPropertyInfoMapper
    {
        public REOPropertyInfo Map(int organizationID, string loanNumber)
        {
            REOPropertyInfo retValue = new REOPropertyInfo();
            retValue.PageTitle = "REO - Property Info Page";

            OrganizationRepository orgRep = new OrganizationRepository();
            AssetRepository astRep = new AssetRepository();

            Organization org = orgRep.GetByID(organizationID);
            Asset ast = astRep.GetBy(loanNumber);

            AssetInfo assetInfo = new AssetInfo();
            assetInfo.Client = org.Name;
            assetInfo.InVPRArea = false;
            assetInfo.LoanNumber = loanNumber;
            assetInfo.MultipleUnits = true;
            assetInfo.PropertyStatus = "Redemption";
            assetInfo.PropertyType = "Multi Family";
            assetInfo.UnitQuantity = 4;
            retValue.AssetInfo = assetInfo;

            Person brokerInfo = new Person();
            brokerInfo.Name = "Michael John";
            brokerInfo.Phone = "1234567890";
            brokerInfo.EMail = "MichaelJ@realty.com";
            retValue.BrokerInfo = brokerInfo;

            Person assetMgrInfo = new Person();
            assetMgrInfo.Name = "Toni Montana";
            assetMgrInfo.Phone = "7773210987";
            assetMgrInfo.EMail = "toni.montanta@chase.com";
            retValue.AssetMgrInfo = assetMgrInfo;

            AccessInfo accessInfo = new AccessInfo();
            accessInfo.KeyCode = "35241";
            accessInfo.LockboxCode = "NDA";
            retValue.AccessInfo = accessInfo;

            AdditionalPropertyInfo addlPropInfo = new AdditionalPropertyInfo();
            addlPropInfo.HOAInfo = "8122144456";
            addlPropInfo.Elevation = 2500;
            addlPropInfo.PlumbingSystem = "Dry";
            addlPropInfo.LotSize = 15000;
            addlPropInfo.LawnSize = 4000;
            addlPropInfo.DaysInInventory = 120;
            retValue.AddlPropInfo = addlPropInfo;

            InitialServices initialServices = new InitialServices();
            initialServices.Rekey = new DateTime(2012, 10, 11);
            initialServices.Trashout = new DateTime(2012, 10, 11);
            initialServices.SalesClean = new DateTime(2012, 12, 11);
            initialServices.Winterization = null;
            initialServices.InitialGrassCut = new DateTime(2012, 12, 11);
            retValue.InitialServices = initialServices;

            List<UtilityStatus> utilStatusList = new List<UtilityStatus>();
            utilStatusList.Add(new UtilityStatus() { UtilType = "Water", UtilStatus = true });
            utilStatusList.Add(new UtilityStatus() { UtilType = "Electric", UtilStatus = true });
            utilStatusList.Add(new UtilityStatus() { UtilType = "Gas", UtilStatus = false });
            retValue.UtilStatus = utilStatusList;

            List<PropertyHistoryItem> propertyHistoryList = new List<PropertyHistoryItem>();
            propertyHistoryList.Add(
                new PropertyHistoryItem()
                {
                    LoanNumber = loanNumber,
                    WorkOrderNumber = "WO1234",
                    WorkOrderType = "Initial Services",
                    OrderDate = new DateTime(2012, 1, 2),
                    JobCompletionDate = new DateTime(2012, 1, 5),
                    CompletionUploadDate = new DateTime(2012, 1, 5),
                    BidDate = null,
                    BillDate = new DateTime(2012, 1, 7),
                    BidNumber = string.Empty,
                    InvoiceNumber = "i1234",
                    ClientInvoiceAmount = 1500,
                    NumberOfPhotos = 200
                });

            propertyHistoryList.Add(
                new PropertyHistoryItem()
                {
                    LoanNumber = loanNumber,
                    WorkOrderNumber = "WO2314",
                    WorkOrderType = "Bid approval",
                    OrderDate = new DateTime(2012, 1, 4),
                    JobCompletionDate = new DateTime(2012, 1, 5),
                    CompletionUploadDate = new DateTime(2012, 1, 6),
                    BidDate = null,
                    BillDate = null,
                    BidNumber = string.Empty,
                    InvoiceNumber = "i2314",
                    ClientInvoiceAmount = 565,
                    NumberOfPhotos = 43
                });

            propertyHistoryList.Add(
                new PropertyHistoryItem()
                {
                    LoanNumber = loanNumber,
                    WorkOrderNumber = "WO3453",
                    WorkOrderType = "Grass recut",
                    OrderDate = new DateTime(2012, 2, 2),
                    JobCompletionDate = new DateTime(2012, 2, 3),
                    CompletionUploadDate = new DateTime(2012, 2, 3),
                    BidDate = new DateTime(2012, 2, 4),
                    BillDate = new DateTime(2012, 2, 5),
                    BidNumber = "B3453",
                    InvoiceNumber = "i3453",
                    ClientInvoiceAmount = 0,
                    NumberOfPhotos = 20
                });

            propertyHistoryList.Add(
                new PropertyHistoryItem()
                {
                    LoanNumber = loanNumber,
                    WorkOrderNumber = "WO6654",
                    WorkOrderType = "Recurring services",
                    OrderDate = new DateTime(2012, 2, 6),
                    JobCompletionDate = new DateTime(2012, 2, 7),
                    CompletionUploadDate = new DateTime(2012, 2, 8),
                    BidDate = new DateTime(2012, 2, 8),
                    BillDate = new DateTime(2012, 2, 9),
                    BidNumber = "B6654",
                    InvoiceNumber = "i6654",
                    ClientInvoiceAmount = 0,
                    NumberOfPhotos = 44
                });

            propertyHistoryList.Add(
                new PropertyHistoryItem()
                {
                    LoanNumber = loanNumber,
                    WorkOrderNumber = "WO4432",
                    WorkOrderType = "Grass recut",
                    OrderDate = new DateTime(2012, 3, 2),
                    JobCompletionDate = new DateTime(2012, 3, 3),
                    CompletionUploadDate = new DateTime(2012, 3, 3),
                    BidDate = null,
                    BillDate = new DateTime(2012, 3, 5),
                    BidNumber = string.Empty,
                    InvoiceNumber = "i4423",
                    ClientInvoiceAmount = 0,
                    NumberOfPhotos = 21
                });

            propertyHistoryList.Add(
                new PropertyHistoryItem()
                {
                    LoanNumber = loanNumber,
                    WorkOrderNumber = "WO4532",
                    WorkOrderType = "Bid approval",
                    OrderDate = new DateTime(2012, 4, 12),
                    JobCompletionDate = new DateTime(2012, 4, 13),
                    CompletionUploadDate = new DateTime(2012, 4, 13),
                    BidDate = null,
                    BillDate = new DateTime(2012, 4, 15),
                    BidNumber = string.Empty,
                    InvoiceNumber = "i4532",
                    ClientInvoiceAmount = 400,
                    NumberOfPhotos = 5
                });

            retValue.PropertyHistory = propertyHistoryList;
            
            return retValue;
        }

        public void UnMap(REOPropertyInfo item)
        {
            
        }
    }
}
