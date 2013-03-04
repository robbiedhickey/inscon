using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Enterprise.DALServices.DAL.Models.Mapping;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class EnterpriseDbContext : DbContext
    {
        static EnterpriseDbContext()
        {
            Database.SetInitializer<EnterpriseDbContext>(null);
        }

        public EnterpriseDbContext()
            : base("Name=EnterpriseDbContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressLocation> AddressLocations { get; set; }
        public DbSet<AddressUse_XREF> AddressUse_XREF { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Lookup> Lookups { get; set; }
        public DbSet<LookupGroup> LookupGroups { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Exterior> Exteriors { get; set; }
        public DbSet<ForSale> ForSales { get; set; }
        public DbSet<Interior> Interiors { get; set; }
        public DbSet<Loss> Losses { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<PropertyDamage> PropertyDamages { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAreaCoverage> UserAreaCoverages { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrderAssignment> WorkOrderAssignments { get; set; }
        public DbSet<WorkOrderItem> WorkOrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AddressLocationMap());
            modelBuilder.Configurations.Add(new AddressUse_XREFMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new EntityMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new FileMap());
            modelBuilder.Configurations.Add(new LookupMap());
            modelBuilder.Configurations.Add(new LookupGroupMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new ExteriorMap());
            modelBuilder.Configurations.Add(new ForSaleMap());
            modelBuilder.Configurations.Add(new InteriorMap());
            modelBuilder.Configurations.Add(new LossMap());
            modelBuilder.Configurations.Add(new MaintenanceMap());
            modelBuilder.Configurations.Add(new PropertyDamageMap());
            modelBuilder.Configurations.Add(new RenterMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new AssetMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserAreaCoverageMap());
            modelBuilder.Configurations.Add(new UserContactMap());
            modelBuilder.Configurations.Add(new UserNotificationMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new WorkOrderMap());
            modelBuilder.Configurations.Add(new WorkOrderAssignmentMap());
            modelBuilder.Configurations.Add(new WorkOrderItemMap());

            // If model is updated using the Reverse Engineer Tool this line 
            // must be replaced if Insert, Update and Delete mapping is to work.
            this.MapStoredProcs(modelBuilder);
        }
    }
}
