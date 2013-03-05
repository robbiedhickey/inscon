using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Location
    {
        public int LocationID { get; set; }
        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int TypeID { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
