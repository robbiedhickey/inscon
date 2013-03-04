using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class ForSale
    {
        public int WorkOrderID { get; set; }
        public Nullable<int> PropertyForSaleByID { get; set; }
        public string RealtorName { get; set; }
        public string RealtorPhone { get; set; }
        public Nullable<int> ActiveListingID { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public Nullable<short> DaysOnMarket { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
