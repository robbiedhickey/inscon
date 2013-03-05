using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Organization
    {
        public Organization()
        {
            this.Assets = new List<Asset>();
            this.Locations = new List<Location>();
            this.Users = new List<User>();
        }

        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int TypeID { get; set; }
        public int StatusID { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
