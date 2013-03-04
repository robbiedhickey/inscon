using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class ForSaleMap : EntityTypeConfiguration<ForSale>
    {
        public ForSaleMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RealtorName)
                .HasMaxLength(30);

            this.Property(t => t.RealtorPhone)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ForSale", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.PropertyForSaleByID).HasColumnName("PropertyForSaleByID");
            this.Property(t => t.RealtorName).HasColumnName("RealtorName");
            this.Property(t => t.RealtorPhone).HasColumnName("RealtorPhone");
            this.Property(t => t.ActiveListingID).HasColumnName("ActiveListingID");
            this.Property(t => t.ListPrice).HasColumnName("ListPrice");
            this.Property(t => t.DaysOnMarket).HasColumnName("DaysOnMarket");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.ForSale);

        }
    }
}
