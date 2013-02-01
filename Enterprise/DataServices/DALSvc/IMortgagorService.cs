using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IMortgagorService
    {
        [OperationContract]
        List<Mortgagor> GetAllMortgagors();

        [OperationContract]
        Mortgagor GetMortgagorById(int id);

        [OperationContract]
        List<Mortgagor> GetMortgagorsByLoanId(Int32 loanId);

        [OperationContract]
        Mortgagor GetMortgagorsByLoanIdAndTypeId(Int32 loanId, Int32 typeId);

        [OperationContract]
        void DeleteRecord(Mortgagor mortgagor);

        [OperationContract]
        int SaveRecord(Mortgagor mortgagor);
    }
}
