using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Request
    {
        public Request()
        {
            this.WorkOrders = new List<WorkOrder>();
        }

        public int RequestID { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
        public string CustomerRequestID { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
