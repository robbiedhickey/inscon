using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class MaintenanceMap : EntityTypeConfiguration<Maintenance>
    {
        public MaintenanceMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecommendedOther)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Maintenance", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.ChangeLocks).HasColumnName("ChangeLocks");
            this.Property(t => t.ReplaceGlass).HasColumnName("ReplaceGlass");
            this.Property(t => t.BoardSecure).HasColumnName("BoardSecure");
            this.Property(t => t.Winterize).HasColumnName("Winterize");
            this.Property(t => t.CutGrass).HasColumnName("CutGrass");
            this.Property(t => t.GrassHeightInches).HasColumnName("GrassHeightInches");
            this.Property(t => t.DrainPool).HasColumnName("DrainPool");
            this.Property(t => t.RemoveDebris).HasColumnName("RemoveDebris");
            this.Property(t => t.RecommendedOther).HasColumnName("RecommendedOther");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.Maintenance);

        }
    }
}
