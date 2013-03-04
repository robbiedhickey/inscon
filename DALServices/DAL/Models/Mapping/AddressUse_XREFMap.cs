using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class AddressUse_XREFMap : EntityTypeConfiguration<AddressUse_XREF>
    {
        public AddressUse_XREFMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AddressID, t.TypeID });

            // Properties
            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AddressUse_XREF", "common");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");

            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.AddressUse_XREF)
                .HasForeignKey(d => d.AddressID);

        }
    }
}
