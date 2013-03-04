using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class WorkOrderAssignment
    {
        public int WorkOrderAssignmentID { get; set; }
        public int WorkOrderID { get; set; }
        public int UserID { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public int StatusID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
