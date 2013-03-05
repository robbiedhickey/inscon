using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Comment
    {
        public int CommentID { get; set; }
        public int ParentID { get; set; }
        public short EntityID { get; set; }
        public Nullable<int> UserID { get; set; }
        public int TypeID { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
    }
}
