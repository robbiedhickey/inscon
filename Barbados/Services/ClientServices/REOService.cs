namespace Enterprise.ApplicationServices.ClientServices
{
    using System;

    using Enterprise.Core.ViewModels;
    using Enterprise.Core.ViewModelMapper;

    public class REOService : IREOService
    {
        public REOPropertyInfo GetReoPropertyInfo(int organizationID, string loanNumber)
        {
            REOPropertyInfo reoPropertyInfo = new REOPropertyInfo();
            ReoPropertyInfoMapper mapper = new ReoPropertyInfoMapper();

            reoPropertyInfo = mapper.Map(organizationID, loanNumber);

            return reoPropertyInfo;
        }
    }
}
