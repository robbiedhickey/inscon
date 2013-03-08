using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class UserNotificationMap : EntityTypeConfiguration<UserNotification>
    {
        public UserNotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.UserNotificationID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserNotification", "organization");
            this.Property(t => t.UserNotificationID).HasColumnName("UserNotificationID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DatePosted).HasColumnName("DatePosted");
            this.Property(t => t.DateRead).HasColumnName("DateRead");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserNotifications)
                .HasForeignKey(d => d.UserID);

        }
    }
}
