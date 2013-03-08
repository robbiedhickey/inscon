using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class LookupGroupMap : EntityTypeConfiguration<LookupGroup>
    {
        public LookupGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.LookupGroupID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("LookupGroup", "common");
            this.Property(t => t.LookupGroupID).HasColumnName("LookupGroupID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OldID).HasColumnName("OldID");
        }
    }
}
