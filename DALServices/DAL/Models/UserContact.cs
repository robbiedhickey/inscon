using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class UserContact
    {
        public int UserContactID { get; set; }
        public int UserID { get; set; }
        public string Value { get; set; }
        public int TypeID { get; set; }
        public bool IsPrimary { get; set; }
        public virtual User User { get; set; }
    }
}
