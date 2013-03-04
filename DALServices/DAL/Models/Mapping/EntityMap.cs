using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            // Primary Key
            this.HasKey(t => t.EntityID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Entity", "common");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
