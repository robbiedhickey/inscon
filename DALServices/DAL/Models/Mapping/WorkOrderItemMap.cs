using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class WorkOrderItemMap : EntityTypeConfiguration<WorkOrderItem>
    {
        public WorkOrderItemMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderItemID);

            // Properties
            // Table & Column Mappings
            this.ToTable("WorkOrderItem", "request");
            this.Property(t => t.WorkOrderItemID).HasColumnName("WorkOrderItemID");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.DateInserted).HasColumnName("DateInserted");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderItems)
                .HasForeignKey(d => d.WorkOrderID);

        }
    }
}
