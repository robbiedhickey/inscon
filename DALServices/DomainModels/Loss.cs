using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Loss
    {
        public int WorkOrderID { get; set; }
        public string LossType { get; set; }
        public Nullable<decimal> PercentageCompleted { get; set; }
        public Nullable<int> OwnerSatisfactionID { get; set; }
        public string OwnerSatisfactionNotes { get; set; }
        public string AdditionalRepairsNeeded { get; set; }
        public Nullable<System.DateTime> EstimatedCompletionDate { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
