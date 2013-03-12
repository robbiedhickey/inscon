using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DALServices.ViewModels.Common
{
    public class InitialServices
    {
        public DateTime? Rekey { get; set; }
        public DateTime? Trashout { get; set; }
        public DateTime? SalesClean { get; set; }
        public DateTime? Winterization { get; set; }
        public DateTime? InitialGrassCut { get; set; }

        public string RekeyLabel { get; set; }
        public string TrashoutLabel { get; set; }
        public string SalesCleanLabel { get; set; }
        public string WinterizationLabel { get; set; }
        public string InitialGrassCutLabel { get; set; }
    }
}
