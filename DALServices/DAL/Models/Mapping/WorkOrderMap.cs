using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class WorkOrderMap : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            // Table & Column Mappings
            this.ToTable("WorkOrder", "request");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.AssetID).HasColumnName("AssetID");
            this.Property(t => t.DateInserted).HasColumnName("DateInserted");

            // Relationships
            this.HasRequired(t => t.Asset)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.AssetID);
            this.HasRequired(t => t.Request)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.RequestID);

        }
    }
}
