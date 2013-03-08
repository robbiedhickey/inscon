namespace Enterprise.DALServices.DAL.Test.DataLoaders
{
    using System.Collections.Generic;

    using Enterprise.DALServices.DAL.Models;

    public class OrganizationLoader : ITestDataLoader
    {
        public void LoadData(EnterpriseDbContext context)
        {
            var orgs = new List<Organization>
                           {
                               new Organization
                                   {
                                       Name = "Bank of the Outer Galactic Empire",
                                       Code = "BOGE",
                                       TypeID = 3,
                                       StatusID = 1
                                   },
                               new Organization
                                   {
                                       Name = "Oort Cloud Savings and Loan",
                                       Code = "OCSL",
                                       TypeID = 3,
                                       StatusID = 1
                                   },
                               new Organization
                                   {
                                       Name = "Ronaks Thrifty Mortgage Emporium",
                                       Code = "RTME",
                                       TypeID = 3,
                                       StatusID = 1
                                   },
                           };

            orgs.ForEach(org => context.Organizations.Add(org));
        }
    }
}