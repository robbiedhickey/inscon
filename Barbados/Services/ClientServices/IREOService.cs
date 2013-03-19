namespace Enterprise.ApplicationServices.ClientServices
{
    using System.ServiceModel;

    using Enterprise.Core.ViewModels;

    [ServiceContract]
    public interface IREOService
    {
        [OperationContract]
        REOPropertyInfo GetReoPropertyInfo(int organizationID, string loanNumber);
    }
}
