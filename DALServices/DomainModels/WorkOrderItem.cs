using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class WorkOrderItem
    {
        public int WorkOrderItemID { get; set; }
        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
