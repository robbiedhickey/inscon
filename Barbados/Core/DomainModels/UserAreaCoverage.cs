using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class UserAreaCoverage
    {
        public int UserAreaCoverageID { get; set; }
        public int UserID { get; set; }
        public string ZipCode { get; set; }
        public int ServiceID { get; set; }
        public virtual User User { get; set; }
    }
}
