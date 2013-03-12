using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DALServices.ViewModels.Common
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

        public string ClientLabel { get; set; }
        public string LoanNumberLabel { get; set; }
        public string PropertyStatusLabel { get; set; }
        public string PropertyTypeLabel { get; set; }
        public string MultipleUnitsLabel { get; set; }
        public string UnitQuantityLabel { get; set; }
        public string InVPRAreaLabel { get; set; }
    }
}
