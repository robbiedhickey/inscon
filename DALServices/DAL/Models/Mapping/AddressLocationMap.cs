using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class AddressLocationMap : EntityTypeConfiguration<AddressLocation>
    {
        public AddressLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BuildingNumber)
                .HasMaxLength(20);

            this.Property(t => t.StreetName)
                .IsRequired()
                .HasMaxLength(60);

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
            this.ToTable("AddressLocation", "common");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.BuildingNumber).HasColumnName("BuildingNumber");
            this.Property(t => t.StreetName).HasColumnName("StreetName");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.GeoCode).HasColumnName("GeoCode");
            this.Property(t => t.Lattitude).HasColumnName("Lattitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");

            // Relationships
            this.HasRequired(t => t.Address)
                .WithOptional(t => t.AddressLocation);

        }
    }
}
