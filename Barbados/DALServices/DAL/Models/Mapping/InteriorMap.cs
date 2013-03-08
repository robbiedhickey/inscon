using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class InteriorMap : EntityTypeConfiguration<Interior>
    {
        public InteriorMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ContactName)
                .HasMaxLength(50);

            this.Property(t => t.ContactNumber)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Interior", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.InteriorStatusID).HasColumnName("InteriorStatusID");
            this.Property(t => t.HeatSourceID).HasColumnName("HeatSourceID");
            this.Property(t => t.PropaneVolumeID).HasColumnName("PropaneVolumeID");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactNumber).HasColumnName("ContactNumber");
            this.Property(t => t.MaintainedID).HasColumnName("MaintainedID");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.Interior);

        }
    }
}
