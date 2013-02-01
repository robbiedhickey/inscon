using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.GenericService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class GenericService : IGenericService
    {
        public void RunProc(string database, string procedure)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable GetDataTable(string Database, string StoredProcedure, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetDataSet(string Database, string StoredProcedure, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public System.Data.IDataReader GetDataReader(string Database, string StoredProcedure, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
