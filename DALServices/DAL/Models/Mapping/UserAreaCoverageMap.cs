using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class UserAreaCoverageMap : EntityTypeConfiguration<UserAreaCoverage>
    {
        public UserAreaCoverageMap()
        {
            // Primary Key
            this.HasKey(t => t.UserAreaCoverageID);

            // Properties
            this.Property(t => t.ZipCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("UserAreaCoverage", "organization");
            this.Property(t => t.UserAreaCoverageID).HasColumnName("UserAreaCoverageID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.ServiceID).HasColumnName("ServiceID");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserAreaCoverages)
                .HasForeignKey(d => d.UserID);

        }
    }
}
