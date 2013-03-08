namespace Enterprise.DALServices.DAL.Test.DataLoaders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    using Enterprise.DALServices.DAL.Models;


    /// <summary>
    /// Responsible for seeding the database with test data. Programmers can implement a new ITestDataLoader
    /// and this class will automatically pick up the new instance and register it for use.
    /// </summary>
    public static class TestInitializer
    {
        private static readonly List<ITestDataLoader> dataLoaders = new List<ITestDataLoader>();

        static TestInitializer()
        {
            //get all classes that implement ITestDataLoader
            var loaders = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(type => type.GetInterfaces().Contains(typeof(ITestDataLoader)))
                            .Select(type => Activator.CreateInstance(type) as ITestDataLoader);

            //add test data loaders to collection
            dataLoaders.AddRange(loaders);
        }

        /// <summary>
        /// Seeds the database with test data that unit tests will depend on.
        /// </summary>
        /// <param name="context">The context.</param>
        public static void SeedDatabase(EnterpriseDbContext context)
        {
            //disable check constraints, delete data, reseed identity columsn
            ClearDatabaseAndReseed(context);

            //run data loaders
            dataLoaders.ForEach(loader => loader.LoadData(context));

            //persist test data
            context.SaveChanges();

            ReEnableCheckConstraints(context);
        }

        /// <summary>
        /// Clears the database tables and reseeds identity columns.
        /// </summary>
        /// <param name="context">The context.</param>
        private static void ClearDatabaseAndReseed(EnterpriseDbContext context)
        {
            var query = new StringBuilder();

            // turn off constraints
            query.AppendLine("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'");

            // get table names and generate delete statements
            GetTableNames(context).ForEach(table => query.AppendLine(string.Format("DELETE FROM {0}", table)));

            // get tables with identity columns and generate reseed statements
            GetDbccCheckIdents(context).ForEach(check => query.AppendLine(check));

            // execute generated sql
            context.Database.ExecuteSqlCommand(query.ToString());
        }

        private static void ReEnableCheckConstraints(EnterpriseDbContext context)
        {
            context.Database.ExecuteSqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all'");
        }


        private static List<string> GetTableNames(EnterpriseDbContext context)
        {
            return context.Database.SqlQuery<string>("SELECT '['+TABLE_SCHEMA+'].['+TABLE_NAME+']' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME NOT LIKE '%Migration%'").ToList();
        }

        private static List<string> GetDbccCheckIdents(EnterpriseDbContext context)
        {

            return context.Database.SqlQuery<string>(@" SELECT 'DBCC CHECKIDENT('''+TABLE_SCHEMA+'.'+TABLE_NAME+''', RESEED, 0)'
                                                        FROM INFORMATION_SCHEMA.TABLES
                                                        WHERE OBJECTPROPERTY(OBJECT_ID(TABLE_SCHEMA+'.'+TABLE_NAME), 'TableHasIdentity') = 1
                                                        AND TABLE_TYPE = 'BASE TABLE'").ToList();
        }
    }
}
