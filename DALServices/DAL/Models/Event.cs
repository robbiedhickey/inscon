using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Event
    {
        public int EventID { get; set; }
        public int ParentID { get; set; }
        public short EntityID { get; set; }
        public int TypeID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
    }
}
