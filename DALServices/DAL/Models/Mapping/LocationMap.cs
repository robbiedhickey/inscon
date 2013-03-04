using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.Code)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Location", "organization");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.TypeID).HasColumnName("TypeID");

            // Relationships
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.OrganizationID);

        }
    }
}
