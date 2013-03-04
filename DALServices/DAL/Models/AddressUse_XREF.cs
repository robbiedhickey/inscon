using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class AddressUse_XREF
    {
        public int AddressID { get; set; }
        public int TypeID { get; set; }
        public virtual Address Address { get; set; }
    }
}
