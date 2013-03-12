using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DALServices.ViewModels.Common
{
    public class AccessInfo
    {
        public string KeyCode { get; set; }
        public string LockboxCode { get; set; }

        public string KeyCodeLabel { get; set; }
        public string LockboxCodeLabel { get; set; }
    }
}
