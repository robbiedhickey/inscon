using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Lookup
    {
        public int LookupID { get; set; }
        public int LookupGroupID { get; set; }
        public string Value { get; set; }
        public Nullable<int> OldID { get; set; }
        public virtual LookupGroup LookupGroup { get; set; }
    }
}
