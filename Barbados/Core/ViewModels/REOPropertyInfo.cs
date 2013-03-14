namespace Enterprise.Core.ViewModels
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using Enterprise.Core.ViewModels.Common;

    [DataContract]
    public class REOPropertyInfo
    {
        public REOPropertyInfo()
        {
            UtilStatus = new List<UtilityStatus>();
            PropertyHistory = new List<PropertyHistoryItem>();
        }

        [DataMember]
        public string PageTitle { get; set; }

        [DataMember]
        public AssetInfo AssetInfo { get; set; }
        
        [DataMember]
        public Person BrokerInfo { get; set; }
        
        [DataMember]
        public Person AssetMgrInfo { get; set; }
        
        [DataMember]
        public AccessInfo AccessInfo { get; set; }
        
        [DataMember]
        public AdditionalPropertyInfo AddlPropInfo { get; set; }
        
        [DataMember]
        public ICollection<UtilityStatus> UtilStatus { get; set; }
        
        [DataMember]
        public InitialServices InitialServices { get; set; }
        
        [DataMember]
        public ICollection<PropertyHistoryItem> PropertyHistory { get; set; }
    }
}
