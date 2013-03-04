using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Address
    {
        public Address()
        {
            this.AddressUse_XREF = new List<AddressUse_XREF>();
        }

        public int AddressID { get; set; }
        public int ParentID { get; set; }
        public short EntityID { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public virtual AddressLocation AddressLocation { get; set; }
        public virtual ICollection<AddressUse_XREF> AddressUse_XREF { get; set; }
    }
}
