using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class LookupGroup
    {
        public LookupGroup()
        {
            this.Lookups = new List<Lookup>();
        }

        public int LookupGroupID { get; set; }
        public string Name { get; set; }
        public Nullable<int> OldID { get; set; }
        public virtual ICollection<Lookup> Lookups { get; set; }
    }
}
