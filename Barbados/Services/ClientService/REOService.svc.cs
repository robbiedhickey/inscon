namespace Enterprise.ApplicationServices.ClientService
{
    using System;

    using Enterprise.Core.ViewModelMapper;
    using Enterprise.Core.ViewModels;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change 
    //       the class name "REOService" in code, svc and config file together.

    // NOTE: In order to launch WCF Test Client for testing this service, 
    //       please select REOService.svc or REOService.svc.cs at the Solution 
    //       Explorer and start debugging.
    public class REOService : IREOService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public REOPropertyInfo GetReoPropertyInfo(int organizationID, string loanNumber)
        {
            ReoPropertyInfoMapper mapper = new ReoPropertyInfoMapper();
            REOPropertyInfo reoPropertyInfo = mapper.Map(organizationID, loanNumber);

            return reoPropertyInfo;
        }
    }
}
