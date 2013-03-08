
namespace Enterprise.DALServices.DAL.Test.DataLoaders
{
    using System;
    using System.Collections.Generic;

    using Enterprise.DALServices.DAL.Models;

    public class AssetLoader : ITestDataLoader
    {
        public void LoadData(EnterpriseDbContext context)
        {
            var assets = new List<Asset>
                             {
                                 new Asset
                                     {
                                         OrganizationID = 1,
                                         TypeID = 30,
                                         AssetNumber = "000001",
                                         LoanNumber = "123456",
                                         LoanTypeID = 18,
                                         MortgagorName = "Amy Wong",
                                         MortgagorPhone = "2143453001",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 1,
                                         TypeID = 30,
                                         AssetNumber = "000002",
                                         LoanNumber = "234567",
                                         LoanTypeID = 18,
                                         MortgagorName = "Hubert Farnsworth",
                                         MortgagorPhone = "2143453002",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 1,
                                         TypeID = 30,
                                         AssetNumber = "000003",
                                         LoanNumber = "345678",
                                         LoanTypeID = 18,
                                         MortgagorName = "Joe Melman",
                                         MortgagorPhone = "2143453003",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 2,
                                         TypeID = 30,
                                         AssetNumber = "000004",
                                         LoanNumber = "456789",
                                         LoanTypeID = 18,
                                         MortgagorName = "Barbados Slim",
                                         MortgagorPhone = "2143453004",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 2,
                                         TypeID = 30,
                                         AssetNumber = "000005",
                                         LoanNumber = "567890",
                                         LoanTypeID = 18,
                                         MortgagorName = "Jettro Heller",
                                         MortgagorPhone = "2143453005",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 2,
                                         TypeID = 30,
                                         AssetNumber = "000006",
                                         LoanNumber = "678901",
                                         LoanTypeID = 18,
                                         MortgagorName = "Pepper Potts",
                                         MortgagorPhone = "2143453006",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 3,
                                         TypeID = 30,
                                         AssetNumber = "000007",
                                         LoanNumber = "789012",
                                         LoanTypeID = 18,
                                         MortgagorName = "Leo Wong",
                                         MortgagorPhone = "2143453007",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 3,
                                         TypeID = 30,
                                         AssetNumber = "000008",
                                         LoanNumber = "890123",
                                         LoanTypeID = 18,
                                         MortgagorName = "Inez Wong",
                                         MortgagorPhone = "2143453008",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                                 new Asset
                                     {
                                         OrganizationID = 3,
                                         TypeID = 30,
                                         AssetNumber = "000009",
                                         LoanNumber = "901234",
                                         LoanTypeID = 18,
                                         MortgagorName = "Zapp Brannigan",
                                         MortgagorPhone = "2143453009",
                                         HudCaseNumber = null,
                                         ConveyanceDate = null,
                                         FirstTimeVacantDate = null 
                                     },
                             };

            assets.ForEach(asset => context.Assets.Add(asset));
        }
    }
}
