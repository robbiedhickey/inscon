using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Renter
    {
        public int WorkOrderID { get; set; }
        public string RenterName { get; set; }
        public string RenterPhone { get; set; }
        public string RentPaidTo { get; set; }
        public string RentPaidToAddress { get; set; }
        public Nullable<bool> RentCurrent { get; set; }
        public Nullable<decimal> RentAmountMonthly { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
