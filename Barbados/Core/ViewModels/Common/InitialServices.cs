using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Core.ViewModels.Common
{
    public class InitialServices
    {
        public DateTime? Rekey { get; set; }
        public DateTime? Trashout { get; set; }
        public DateTime? SalesClean { get; set; }
        public DateTime? Winterization { get; set; }
        public DateTime? InitialGrassCut { get; set; }
    }
}
