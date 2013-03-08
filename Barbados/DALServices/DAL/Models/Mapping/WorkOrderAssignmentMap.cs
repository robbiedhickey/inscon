using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class WorkOrderAssignmentMap : EntityTypeConfiguration<WorkOrderAssignment>
    {
        public WorkOrderAssignmentMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderAssignmentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("WorkOrderAssignment", "request");
            this.Property(t => t.WorkOrderAssignmentID).HasColumnName("WorkOrderAssignmentID");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.StatusID).HasColumnName("StatusID");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderAssignments)
                .HasForeignKey(d => d.WorkOrderID);

        }
    }
}
