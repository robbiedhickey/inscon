using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class File
    {
        public int FileID { get; set; }
        public int ParentID { get; set; }
        public short EntityID { get; set; }
        public string ParentFolder { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Size { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string Caption { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
    }
}
