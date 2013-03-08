namespace Enterprise.DALServices.DAL.Test.DataLoaders
{
    using System.Collections.Generic;

    using Enterprise.DALServices.DAL.Models;

    public class LocationLoader : ITestDataLoader
    {
        public void LoadData(EnterpriseDbContext context)
        {
            var locs = new List<Location>
                           {
                               new Location
                                   {
                                       OrganizationID = 1,
                                       Name = "Bank of the Outer Galactic Empire",
                                       Code = "BOGE01",
                                       TypeID = 11
                                   },
                               new Location
                                   {
                                       OrganizationID = 1,
                                       Name = "Greater Helium Branch",
                                       Code = "BOGE02",
                                       TypeID = 12
                                   },
                               new Location
                                   {
                                       OrganizationID = 1,
                                       Name = "Wastelands Branch",
                                       Code = "BOGE03",
                                       TypeID = 12
                                   },
                               new Location
                                   {
                                       OrganizationID = 2,
                                       Name = "Oort Cloud Savings and Loan",
                                       Code = "OCSL01",
                                       TypeID = 11
                                   },
                               new Location
                                   {
                                       OrganizationID = 2,
                                       Name = "Lower Hades Mercury Branch",
                                       Code = "BOGE02",
                                       TypeID = 12
                                   },
                               new Location
                                   {
                                       OrganizationID = 2,
                                       Name = "Rings of Saturn Branch",
                                       Code = "BOGE03",
                                       TypeID = 12
                                   },
                               new Location
                                   {
                                       OrganizationID = 3,
                                       Name = "Ronaks Thrify Mortgage Emporium",
                                       Code = "RTME01",
                                       TypeID = 11
                                   },
                               new Location
                                   {
                                       OrganizationID = 3,
                                       Name = "Arlen South Branch",
                                       Code = "BOGE02",
                                       TypeID = 12
                                   },
                               new Location
                                   {
                                       OrganizationID = 3,
                                       Name = "North Arlen Branch",
                                       Code = "BOGE03",
                                       TypeID = 12
                                   },
                           };

            locs.ForEach(loc => context.Locations.Add(loc));
        }
    }
}
