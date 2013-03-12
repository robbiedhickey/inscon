using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DALServices.ViewModels.Common
{
    public class AdditionalPropertyInfo
    {
        public string HOAInfo { get; set; }
        public int Elevation { get; set; }
        public string PlumbingSystem { get; set; }
        public int LotSize { get; set; }
        public int LawnSize { get; set; }
        public int DaysInInventory { get; set; }

        public string HOAInfoLabel { get; set; }
        public string ElevationLabel { get; set; }
        public string PlumbingSystemLabel { get; set; }
        public string LotSizeLabel { get; set; }
        public string LawnSizeLabel { get; set; }
        public string DaysInInventoryLabel { get; set; }
    }
}
