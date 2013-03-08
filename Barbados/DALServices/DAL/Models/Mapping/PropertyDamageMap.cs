using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class PropertyDamageMap : EntityTypeConfiguration<PropertyDamage>
    {
        public PropertyDamageMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PropertyDamage", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.Vandalized).HasColumnName("Vandalized");
            this.Property(t => t.FireDamage).HasColumnName("FireDamage");
            this.Property(t => t.LiabilityHazard).HasColumnName("LiabilityHazard");
            this.Property(t => t.StormDamage).HasColumnName("StormDamage");
            this.Property(t => t.FloodDamage).HasColumnName("FloodDamage");
            this.Property(t => t.FreezeDamage).HasColumnName("FreezeDamage");
            this.Property(t => t.RoofLeak).HasColumnName("RoofLeak");
            this.Property(t => t.Neglected).HasColumnName("Neglected");
            this.Property(t => t.EarthquakeDamage).HasColumnName("EarthquakeDamage");
            this.Property(t => t.CityViolation).HasColumnName("CityViolation");
            this.Property(t => t.Mold).HasColumnName("Mold");
            this.Property(t => t.BrokenWindows).HasColumnName("BrokenWindows");
            this.Property(t => t.BurstPipes).HasColumnName("BurstPipes");
            this.Property(t => t.StructuralDamage).HasColumnName("StructuralDamage");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.PropertyDamage);

        }
    }
}
