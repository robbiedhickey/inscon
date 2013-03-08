using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(28);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(28);

            this.Property(t => t.Title)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("User", "organization");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.AuthenticationID).HasColumnName("AuthenticationID");

            // Relationships
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.OrganizationID);

        }
    }
}
