using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class RenterMap : EntityTypeConfiguration<Renter>
    {
        public RenterMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RenterName)
                .HasMaxLength(50);

            this.Property(t => t.RenterPhone)
                .HasMaxLength(10);

            this.Property(t => t.RentPaidTo)
                .HasMaxLength(30);

            this.Property(t => t.RentPaidToAddress)
                .HasMaxLength(65);

            // Table & Column Mappings
            this.ToTable("Renter", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.RenterName).HasColumnName("RenterName");
            this.Property(t => t.RenterPhone).HasColumnName("RenterPhone");
            this.Property(t => t.RentPaidTo).HasColumnName("RentPaidTo");
            this.Property(t => t.RentPaidToAddress).HasColumnName("RentPaidToAddress");
            this.Property(t => t.RentCurrent).HasColumnName("RentCurrent");
            this.Property(t => t.RentAmountMonthly).HasColumnName("RentAmountMonthly");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.Renter);

        }
    }
}
