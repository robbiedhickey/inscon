using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class UserContactMap : EntityTypeConfiguration<UserContact>
    {
        public UserContactMap()
        {
            // Primary Key
            this.HasKey(t => t.UserContactID);

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserContact", "organization");
            this.Property(t => t.UserContactID).HasColumnName("UserContactID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.IsPrimary).HasColumnName("IsPrimary");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserContacts)
                .HasForeignKey(d => d.UserID);

        }
    }
}
