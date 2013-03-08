using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class LookupMap : EntityTypeConfiguration<Lookup>
    {
        public LookupMap()
        {
            // Primary Key
            this.HasKey(t => t.LookupID);

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Lookup", "common");
            this.Property(t => t.LookupID).HasColumnName("LookupID");
            this.Property(t => t.LookupGroupID).HasColumnName("LookupGroupID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.OldID).HasColumnName("OldID");

            // Relationships
            this.HasRequired(t => t.LookupGroup)
                .WithMany(t => t.Lookups)
                .HasForeignKey(d => d.LookupGroupID);

        }
    }
}
