using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class LossMap : EntityTypeConfiguration<Loss>
    {
        public LossMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LossType)
                .HasMaxLength(68);

            // Table & Column Mappings
            this.ToTable("Loss", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.LossType).HasColumnName("LossType");
            this.Property(t => t.PercentageCompleted).HasColumnName("PercentageCompleted");
            this.Property(t => t.OwnerSatisfactionID).HasColumnName("OwnerSatisfactionID");
            this.Property(t => t.OwnerSatisfactionNotes).HasColumnName("OwnerSatisfactionNotes");
            this.Property(t => t.AdditionalRepairsNeeded).HasColumnName("AdditionalRepairsNeeded");
            this.Property(t => t.EstimatedCompletionDate).HasColumnName("EstimatedCompletionDate");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.Loss);

        }
    }
}
