using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DAL.Models
{
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class EnterpriseDbContext : DbContext
    {
        public EnterpriseDbContext()
            : base()
        {
            Database.SetInitializer<EnterpriseDbContext>(null);
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Organization>().ToTable("Organization", schemaName: "organization");
            modelBuilder.Entity<Asset>().ToTable("Asset", schemaName: "organization");
            modelBuilder.Entity<Location>().ToTable("Location", schemaName: "organization");
        }
    }
}
