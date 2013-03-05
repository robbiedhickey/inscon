using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            this.WorkOrderAssignments = new List<WorkOrderAssignment>();
            this.WorkOrderItems = new List<WorkOrderItem>();
        }

        public int WorkOrderID { get; set; }
        public int RequestID { get; set; }
        public int AssetID { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
        public virtual Exterior Exterior { get; set; }
        public virtual ForSale ForSale { get; set; }
        public virtual Interior Interior { get; set; }
        public virtual Loss Loss { get; set; }
        public virtual Maintenance Maintenance { get; set; }
        public virtual PropertyDamage PropertyDamage { get; set; }
        public virtual Renter Renter { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual Request Request { get; set; }
        public virtual ICollection<WorkOrderAssignment> WorkOrderAssignments { get; set; }
        public virtual ICollection<WorkOrderItem> WorkOrderItems { get; set; }
    }
}
