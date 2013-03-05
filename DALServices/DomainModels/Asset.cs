using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Asset
    {
        public Asset()
        {
            this.WorkOrders = new List<WorkOrder>();
        }

        public int AssetID { get; set; }
        public int OrganizationID { get; set; }
        public int TypeID { get; set; }
        public string AssetNumber { get; set; }
        public string LoanNumber { get; set; }
        public Nullable<int> LoanTypeID { get; set; }
        public string MortgagorName { get; set; }
        public string MortgagorPhone { get; set; }
        public string HudCaseNumber { get; set; }
        public Nullable<System.DateTime> ConveyanceDate { get; set; }
        public Nullable<System.DateTime> FirstTimeVacantDate { get; set; }
        public Nullable<bool> InBankruptcyProtection { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
