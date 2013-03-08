using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
            this.Property(t => t.Street)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Suite)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(38);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Zip)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Address", "common");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Suite).HasColumnName("Suite");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
        }
    }
}
