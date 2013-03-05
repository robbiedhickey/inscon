using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Interior
    {
        public int WorkOrderID { get; set; }
        public Nullable<int> InteriorStatusID { get; set; }
        public Nullable<int> HeatSourceID { get; set; }
        public Nullable<int> PropaneVolumeID { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public Nullable<int> MaintainedID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
