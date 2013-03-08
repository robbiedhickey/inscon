using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Maintenance
    {
        public int WorkOrderID { get; set; }
        public Nullable<bool> ChangeLocks { get; set; }
        public Nullable<bool> ReplaceGlass { get; set; }
        public Nullable<bool> BoardSecure { get; set; }
        public Nullable<bool> Winterize { get; set; }
        public Nullable<bool> CutGrass { get; set; }
        public Nullable<byte> GrassHeightInches { get; set; }
        public Nullable<bool> DrainPool { get; set; }
        public Nullable<bool> RemoveDebris { get; set; }
        public string RecommendedOther { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
