using Enterprise.DAL.Framework.Data;


namespace Enterprise.DAL.Core.Service
{
    public class GenericService: SqlDataRecord
    {
        public void RunProc(string database, string proc)
        {
            Execute(GetCommand(database, proc));
        }
    }
}
