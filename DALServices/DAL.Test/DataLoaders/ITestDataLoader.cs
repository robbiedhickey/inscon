namespace Enterprise.DALServices.DAL.Test.DataLoaders
{
    using Enterprise.DALServices.DAL.Models;

    public interface ITestDataLoader
    {
        void LoadData(EnterpriseDbContext context);
    }
}