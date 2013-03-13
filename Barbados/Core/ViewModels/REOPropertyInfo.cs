using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Core.ViewModels
{
    using Enterprise.Core.ViewModels.Common;

    public class REOPropertyInfo
    {
        public REOPropertyInfo()
        {
            UtilStatus = new List<UtilityStatus>();
            PropertyHistory = new List<PropertyHistoryItem>();
        }

        public string PageTitle { get; set; }
        public AssetInfo AssetInfo { get; set; }
        public Person BrokerInfo { get; set; }
        public Person AssetMgrInfo { get; set; }
        public AccessInfo AccessInfo { get; set; }
        public AdditionalPropertyInfo AddlPropInfo { get; set; }
        public ICollection<UtilityStatus> UtilStatus { get; set; }
        public InitialServices InitialServices { get; set; }
        public ICollection<PropertyHistoryItem> PropertyHistory { get; set; }
    }
}
