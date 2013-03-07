namespace Enterprise.DALServices.DAL.Test
{
    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;
    using Enterprise.DALServices.DAL.Test.DataLoaders;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestBase
    {
        protected EfUnitOfWork UnitOfWork { get; set; }

        public TestBase()
        {
            this.UnitOfWork = new EfUnitOfWork();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            //force context to rebuild
            this.UnitOfWork.Dispose();
            this.UnitOfWork = new EfUnitOfWork();
        }

        [AssemblyInitialize()]
        public static void Initializer(TestContext ctx)
        {
            TestInitializer.SeedDatabase(new EnterpriseDbContext());
        }
    }
}