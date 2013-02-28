using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DAL.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public int TypeID { get; set; }
        public string AssetNumber { get; set; }
        public string LoanNumber { get; set; }
        public int? LoanTypeID { get; set; }
        public string MortgagorName { get; set; }
        public string MortgagorPhone { get; set; }
        public string HudCaseNumber { get; set; }
        public DateTime? ConveyanceDate { get; set; }
        public DateTime? FirstTimeVacantDate { get; set; }
        public bool? InBankruptcyProtection { get; set; }

        public int OrganizationID { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
