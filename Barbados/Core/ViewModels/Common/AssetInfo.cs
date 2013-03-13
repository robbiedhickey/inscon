using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Core.ViewModels.Common
{
    public class AssetInfo
    {
        public string Client { get; set; }
        public string LoanNumber { get; set; }
        public string PropertyStatus { get; set; }
        public string PropertyType { get; set; }
        public bool MultipleUnits { get; set; }
        public int UnitQuantity { get; set; }
        public bool InVPRArea { get; set; }
    }
}
