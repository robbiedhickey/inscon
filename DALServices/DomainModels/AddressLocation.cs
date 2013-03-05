using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class AddressLocation
    {
        public int AddressID { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public System.Data.Entity.Spatial.DbGeography GeoCode { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
        public virtual Address Address { get; set; }
    }
}
