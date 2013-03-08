using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class OrganizationMap : EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganizationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.Code)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Organization", "organization");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
        }
    }
}
