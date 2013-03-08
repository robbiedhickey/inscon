using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Event", "common");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
        }
    }
}
