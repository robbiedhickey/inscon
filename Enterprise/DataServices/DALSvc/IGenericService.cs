using System.Data;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IGenericService
    {
        [OperationContract]
        void RunProc(string database, string procedure);

        [OperationContract]
        DataTable GetDataTable(string Database, string StoredProcedure, params object[] parameters);

        [OperationContract]
        DataSet GetDataSet(string Database, string StoredProcedure, params object[] parameters);

        [OperationContract]
        IDataReader GetDataReader(string Database, string StoredProcedure, params object[] parameters);
    }
}
